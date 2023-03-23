using AlmedFramework;
using AlmedFramework.Utils;
using DC;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlmedStockManagement
{
    public partial class UIReception : DevExpress.XtraEditors.XtraForm, IObserver
    {
        public UIReception()
        {
            InitializeComponent();
            BindingRecetionTreeList();
        }

        private void ListReceptiongridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
                BindingListReceptionlinebById();
        }

        private void Scan()
        {
            #region Scanning item
            try
            {
                if (codeTextEdit.Text.Equals(string.Empty))
                {
                    dxReceptionErrorProvider.SetError(codeTextEdit, "Code manquant !");
                    Search();
                    return;
                }
                dxReceptionErrorProvider.ClearErrors();

                item = QRCodeHelper.GetItemsBySuplayName(SuplayName, codeTextEdit.Text);
                teDLC.Text = item.DLC;
                teCode.Text = item.LN;
                teNLot.Text = item.NLot;
                Search();
                Validation();
            }
            catch (Exception ex)
            {
                Console.Beep(3000, 1000);
                XtraMessageBox.Show(
                    ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                codeTextEdit.Text = "";
                codeTextEdit.Focus();
            }
            finally
            {
                codeTextEdit.Text = "";
                codeTextEdit.Focus();
            }
            #endregion Scanning item
        }
        private void Search()
        {
            bool find = false;

            #region Search item
            for (int i = 0; i < receptionGridView.RowCount; i++)
            {
                var row = (BonLivraisonLigne)receptionGridView.GetRow(i);

                if (Util.RemouveSparators(row.Code.ToLower()) == Util.RemouveSparators(item.LN.ToLower()) &&
                    Util.IsDateEqual(row.DatePeremption, item.DLC) &&
                    !MarkSelection.IsRowSelected(i))
                {
                    if (item.NLot.Equals(string.Empty))
                    {
                        Console.Beep(3000, 1000);
                        if (XtraMessageBox.Show(
                             "Voullez vous continuer sans le NLot !!! pour Ne pas introduire le NLot tappez OK",
                             "Warning-NLot Manquant-",
                             MessageBoxButtons.OKCancel,
                             MessageBoxIcon.Warning) == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                    try
                    {
                        row.NLot = item.NLot;
                        XtraQRCode barcode = new XtraQRCode(row.Code, row.NLot, row.DatePeremption);
                        if (PrintCheckBox.Checked)
                        {
                            for (int j = 0; j < int.Parse(row.Qte.ToString()); j++)
                            {
                                barcode.Print();
                                row.QteScannee++;
                            }
                        }
                        if (connexionCheckBox.Checked)
                        {
                            //Update BonReception line
                            dataServeces.UpdateBonReceptionLigneBy(row.id, row.NLot);
                        }
                        if (row.Qte > row.QteScannee)
                        {
                            row.QteScannee++;
                            receptionGridView.FocusedRowHandle = i;
                            receptionGridControl.RefreshDataSource();
                            Console.Beep(1000, 1000);
                        }
                        if (row.Qte <= row.QteScannee)
                        {
                            Console.Beep(2000, 1000);
                            MarkSelection.SelectRow(i, true);
                            XtraMessageBox.Show("Le produit Ref : " + item.LN + " avec date : " + item.DLC + " est entierement scanné",
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        #region record item in local data base
                        //record item in local data base

                        item.SuplayName = SuplayName;
                        item.Qte = row.QteScannee.ToString();
                        item.BRN = brn;
                        item.DateCreated = DateTime.Today.ToShortDateString();
                        item.Movement = "Reception";
                        item.IdReception = idBonReception;
                        item.IdItem = row.id;

                        dataServeces.RecordeItem(item);
                        #endregion record item in local data base
                        find = true;
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.Beep(3000, 1000);
                        XtraMessageBox.Show(
                                 ex.Message,
                                 "Erreur",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            #endregion Search item
            if (!find)
            {
                Console.Beep(3000, 1000);
                XtraMessageBox.Show(
                    " Item : " + item.ToString() + " not found",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void ReceptionGridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            #region Row style
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
            #endregion Row style
        }
        private void ValidationSButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                dataServeces.PieceAchatRecu(idBonReception);
                InputCotrol(false);
                validationSButton.Enabled = false;
                //refreshing
                BindingRecetionTreeList();
                receptionGridControl.DataSource = null;

                Console.Beep(1000, 1000);
                    XtraMessageBox.Show(
                        "Impression terminé. BRP Enregistré avec succès.",
                        "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.Beep(3000, 1000);
                XtraMessageBox.Show(ex.Message,
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                codeTextEdit.Text = "";
                codeTextEdit.Focus();
            }
        }

        private void UIReception_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                return;
                
        }
        private void InputCotrol(bool ctr)
        {
            codeTextEdit.Enabled = ctr;
            EnableManualyInput(false);
            scanSButton.Enabled = ctr;
        }

        private void EnableManualyInput(bool ctr)
        {
            teDLC.Enabled = ctr;
            teCode.Enabled = ctr;
            teNLot.Enabled = ctr;
        }

        private void ScanSButton_Click(object sender, EventArgs e)
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

        private void RefrechSimpleButton_Click(object sender, EventArgs e)
        {
            BindingRecetionTreeList();

            listReceptiongridView.RefreshData();
            receptionGridControl.Refresh();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            BindingRecetionTreeList();

            listReceptiongridView.RefreshData();
            receptionGridControl.Refresh();
        }
        private void Validation()
        {
            for (int i = 0; i < receptionGridView.RowCount; i++)
            {
                if (!MarkSelection.IsRowSelected(i))
                {
                    validationSButton.Enabled = false;
                    return;
                }
            }
            validationSButton.Enabled = true;
        }
        private void ListReceptiongridView_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            BindingListReceptionlinebById();
        }
        public void Update(bool ctr)
        {
            EnableManualyInput(ctr);
        }
    }
}
