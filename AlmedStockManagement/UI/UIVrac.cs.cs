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
    public partial class UIVrac : DevExpress.XtraEditors.XtraForm, IObserver
    {

        public UIVrac()
        {
            InitializeComponent();
            BindingVracTreeList();
        }

        private void ListReceptiongridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
                BindingListVraclinebById();
        }

        private void Scan()
        {
            vracSplashScreenManager.ShowWaitForm();
            if (codeTextEdit.Text.Equals(string.Empty))
            {
                dxReceptionErrorProvider.SetError(codeTextEdit, "Code manquant !");
                Find();
                return;
            }
            else if (codeTextEdit.Text.Contains("$"))
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
                        if (item.LN == "")
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
            dxReceptionErrorProvider.ClearErrors();

            item.LN += "-N";

            if (!Find())
            {
                Console.Beep(3000, 1000);
                XtraMessageBox.Show(
                    " Item : " + item.ToString() + " not found",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            codeTextEdit.Text = "";
            codeTextEdit.Focus();
            vracSplashScreenManager.CloseWaitForm();

        }
        private bool Find()
        {
            bool find = false;

            try
            {

                for (int i = 0; i < listVracGridView.RowCount; i++)
                {
                    var row = (PieceDiversLigne)listVracGridView.GetRow(i);
                    if (!row.Equals(string.Empty))
                    {
                        if (Util.RemouveSparators(row.LN.ToLower()) == Util.RemouveSparators(item.LN.ToLower()) &&
                            Util.IsDateEqual(row.PLDFEFOPEREMPTION, item.DLC) &&
                            !MarkSelection.IsRowSelected(i))
                        {
                            Console.Beep(3000, 1000);
                            MarkSelection.SelectRow(i, true);
                            find = true;
                            XtraQRCode barcode = new XtraQRCode(row.LN, row.PLDNUMLOT, row.PLDFEFOPEREMPTION);
                            for (int j = 0; j < int.Parse(row.Qte.ToString()); j++)
                            {
                                barcode.Print();
                            }

                            #region RECORD ITEM
                            item.SuplayName = row.PLDDESIGNATION;
                            item.Qte = row.Qte.ToString();
                            item.BRN = PCDNUM;
                            item.DateCreated = DateTime.Today.ToShortDateString();
                            item.Movement = "Vrac";
                            item.IdReception = idVrac;
                            item.IdItem = row.PLDID;

                            dataServeces.RecordeItem(item);

                            Console.Beep(2000, 1000);
                            #endregion RECORD ITEM
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Beep(3000, 1000);
                XtraMessageBox.Show(
                         ex.Message,
                         "Erreur",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                return find;
            }
            if (MarkSelection.SelectedCount == listVracGridView.RowCount)
                validationSButton.Enabled = true;

            return find;
            }
        private void EnableInput(bool ctr)
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

        private void RefrechSimpleButton_Click(object sender, EventArgs e)
        {
            listVracGridControl.Refresh();
        }
        private void ScanSButton_Click_1(object sender, EventArgs e)
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

        private void Timer_Tick(object sender, EventArgs e)
        {
            BindingVracTreeList();
        }

        private void RefrechSimpleButton_Click_1(object sender, EventArgs e)
        {
            BindingVracTreeList();
        }

        private void ValidationSButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                //Update 
                dataServeces.PieceDiversSolded(idVrac);

                validationSButton.Enabled = false;
                //refreshing
                BindingVracTreeList();
                listVracGridControl.DataSource = null;
                EnableInput(false);

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

        private void ListVracGridView_RowStyle_1(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            #region Row style
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if (MarkSelection.IsRowSelected(e.RowHandle))
                {
                    e.Appearance.BackColor = Color.Green;
                    e.Appearance.BackColor2 = Color.MediumSeaGreen;
                }
                else
                {
                    e.Appearance.BackColor = Color.LightCoral;
                    e.Appearance.BackColor2 = Color.MediumOrchid;
                }
            }
            #endregion Row style
        }

        public void Update(bool ctr)
        {
            EnableManualyInput(ctr);
        }
    }
}
