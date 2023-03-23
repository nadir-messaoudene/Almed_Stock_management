using AlmedFramework;
using AlmedFramework.Utils;
using DC;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlmedStockManagement
{
    public partial class UILivraison : DevExpress.XtraEditors.XtraForm, IObserver
    {
        public UILivraison()
        {
            InitializeComponent();
            BendingLivraisonTreeList();
        }


        private void InputControl(bool ctr)
        {
            codeTextEdit.Enabled = ctr;
            EnableManualyInput(false);
        }

        private void EnableManualyInput(bool ctr)
        {
            teDLC.Enabled = ctr;
            teCode.Enabled = ctr;
            teNLot.Enabled = ctr;
        }

        private void LivraisonGridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                int quantite_cmd = int.Parse(View.GetRowCellDisplayText(e.RowHandle, View.Columns["QteScannee"]));
                int quantite = int.Parse(View.GetRowCellDisplayText(e.RowHandle, View.Columns["Qte"]));

                if (quantite_cmd == 0)
                {
                    e.Appearance.BackColor = Color.LightCoral;
                    e.Appearance.BackColor2 = Color.MediumOrchid;
                }
                else if (quantite_cmd < quantite)
                {
                    e.Appearance.BackColor = Color.LightCyan;
                    e.Appearance.BackColor2 = Color.Cyan;
                }
                else if (quantite_cmd == quantite)
                {
                    e.Appearance.BackColor = Color.Green;
                    e.Appearance.BackColor2 = Color.MediumSeaGreen;
                }
            }
        }

        private void ScanSimpleButton_Click(object sender, EventArgs e)
        {
            item = new Items()
            {
                DLC = teDLC.Text,
                LN = teCode.Text,
                NLot = teNLot.Text,
                Qte = "0",
                SuplayName = "",
                BRN = "",
                DateCreated = "",
                Movement = "",
                IdReception = ""
            };
            Scan();
        }

        private void Scan()
        {
            try
            {

                if (codeTextEdit.Text.Equals(string.Empty))
                {
                    dxLivraisonErrorProvider.SetError(codeTextEdit, "Code manquant !");
                    Find();
                    return;
                }
                dxLivraisonErrorProvider.ClearErrors();


                if (codeTextEdit.Text.Contains("$"))
                {
                    item = QRCodeHelper.GetItemsByAlmedCode(codeTextEdit.Text);
                }
                else
                {
                    try
                    {
                        item = QRCodeHelper.GetItemsBySuplayName("Abbott", codeTextEdit.Text);
                    }
                    catch
                    {
                        try
                        {
                            item = QRCodeHelper.GetItemsBySuplayName("Oxoid", codeTextEdit.Text);
                            if(item.LN == "")
                                try
                                {
                                    item = QRCodeHelper.GetItemsBySuplayName("Sebia", codeTextEdit.Text);
                                }
                                catch
                                {
                                    Console.Beep(3000, 1000);
                                    XtraMessageBox.Show(
                                        "Erreur Code",
                                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                        }
                        catch
                        {
                            Console.Beep(3000, 1000);
                            XtraMessageBox.Show(
                                "Erreur Code",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }

                teDLC.Text = item.DLC;
                teCode.Text = item.LN;
                teNLot.Text = item.NLot;

                if (!Find())
                {
                    Console.Beep(3000, 1000);
                    XtraMessageBox.Show(
                        "Le produit Ref : " + item.LN + " non trouve",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(
                    ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                codeTextEdit.Text = "";
                codeTextEdit.Focus();
            }
        }
        private bool Find()
        {
            try
            {
                find = false;
                for (int i = 0; i < livraisonGridView.RowCount; i++)
                {
                    var row = (BonLivraisonLigne)livraisonGridView.GetRow(i);
                    if (row.DatePeremption != null)
                    {
                        if (Util.RemouveSparators(row.Code.ToLower()) == Util.RemouveSparators(item.LN.ToLower()) &&
                        Util.RemouveSparators(row.NLot.ToLower()) == Util.RemouveSparators(item.NLot.ToLower()) &&
                        Util.IsDateEqual(row.DatePeremption, item.DLC) &&
                        !MarkSelection.IsRowSelected(i))
                        {
                            find = true;                            
                        }
                    }
                    else
                    if (Util.RemouveSparators(row.Code.ToLower()) == Util.RemouveSparators(item.LN.ToLower()) &&
                        Util.RemouveSparators(row.NLot.ToLower()) == Util.RemouveSparators(item.NLot.ToLower()) &&
                        !MarkSelection.IsRowSelected(i))
                    {
                        find = true;
                    }

                    if (find)
                    {
                        if (row.Qte > row.QteScannee)
                        {
                            Console.Beep(1000, 1000);
                            row.QteScannee++;
                            livraisonGridView.RefreshData();
                        }
                        if (row.Qte == row.QteScannee)
                        {
                            Console.Beep(2000, 1000);
                            MarkSelection.SelectRow(i, true);
                            XtraMessageBox.Show("Le produit Ref : " + item.LN + " avec date : " + item.DLC + " est entierement scanné",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        livraisonGridView.FocusedRowHandle = i;
                        livraisonGridView.RefreshData();

                        //record item in local data base
                        item.SuplayName = cleintName;
                        item.Qte = row.QteScannee.ToString();
                        item.BRN = nbl;
                        item.DateCreated = DateTime.Today.ToShortDateString();
                        item.Movement = "Livraison";
                        item.IdReception = idBonLivraison;
                        item.IdItem = row.id;

                        dataServeces.RecordeItem(item);
                        break;
                    }                    
                }

                Validation();
                livraisonGridControl.RefreshDataSource();
                codeTextEdit.Text = "";
                codeTextEdit.Focus();

                return find;
            }
            catch (Exception ex)
            {
                Console.Beep(3000, 1000);
                XtraMessageBox.Show(
                    ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                codeTextEdit.Text = "";
                codeTextEdit.Focus();

                return find;
            }
        }

        private void Validation()
        {
            for (int i = 0; i < livraisonGridView.RowCount; i++)
            {
                if (!MarkSelection.IsRowSelected(i))
                {
                    validationSButton.Enabled = false;
                    return;
                }
            }
                validationSButton.Enabled = true;
        }

        private void RefrechSimpleButton_Click(object sender, EventArgs e)
        {
            BendingLivraisonTreeList();

            listLivraisongridView.RefreshData();
            livraisonGridControl.Refresh();
        }

        private void ListLivraisongridView_RowClick(object sender, RowClickEventArgs e)
        {
            BendingListLivraisonlinebById();
        }
        private void ValidationSButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataServeces.UpdateLivraison(idBonLivraison);

                InputControl(false);
                validationSButton.Enabled = false;
                //refreshing
                BendingLivraisonTreeList();
                livraisonGridControl.DataSource = null;
                Console.Beep(1000, 1000);
                XtraMessageBox.Show("BL enregistré avec succés !!",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
            catch (Exception ex)
            {
                Console.Beep(3000, 1000);
                XtraMessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                codeTextEdit.Text = "";
                codeTextEdit.Focus();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            BendingLivraisonTreeList();

            listLivraisongridView.RefreshData();
            livraisonGridControl.Refresh();
        }

        private void ListLivraisongridView_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            BendingListLivraisonlinebById();
        }

        public void Update(bool ctr)
        {
            EnableManualyInput(ctr);
        }

        private void UILivraison_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
