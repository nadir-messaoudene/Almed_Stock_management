using AlmedFramework;
using AlmedFramework.DO;
using DC;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlmedStockManagement
{
    public partial class UIReception : Form
    {
        private Items item;

        public UIReception()
        {
            InitializeComponent();
            BendingRecetionTreeList();
        }

        private void listReceptiongridView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
                BendingListReceptionlinebById();
        }

        private void Scan()
        {
            if (codeTextEdit.Text.Equals(string.Empty))
            {
                dxReceptionErrorProvider.SetError(codeTextEdit, "Code manquant !");
                return;
            }
            dxReceptionErrorProvider.ClearErrors();

            teDLC.Text = Util.GetLNLotInCodeByGamme(SuplayName, codeTextEdit.Text).DLC;
            teCode.Text = Util.GetLNLotInCodeByGamme(SuplayName, codeTextEdit.Text).LN;
            teNLot.Text = Util.GetLNLotInCodeByGamme(SuplayName, codeTextEdit.Text).NLot;

            item = new Items(SuplayName, teDLC.Text, teCode.Text, teNLot.Text, "");
            Search();
            codeTextEdit.Focus();
        }
        private void Search()
        {
            item = new Items(SuplayName, teDLC.Text, teCode.Text, teNLot.Text, "");
            bool find = false;
            for (int i = 0; i < receptionGridView.RowCount; i++)
            {
                var row = (BonLivraisonLigne)receptionGridView.GetRow(i);
                if (!row.DatePeremption.Equals(string.Empty))
                {
                    if (row.Code.ToLower() == item.LN.ToLower() && Util.IsDateEqual(row.DatePeremption, item.DLC))
                    {
                        MarkSelection.SelectRow(i, true);
                        row.NLot = item.NLot;
                        receptionGridControl.RefreshDataSource();
                        find = true;
                        MarkSelection.SelectRow(i, true);

                        if (item.NLot.Equals(string.Empty))
                        {
                            XtraMessageBox.Show(
                                "NLot Manquant.",
                                "Erreur",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else
                        {
                            XtraQRCode barcode = new XtraQRCode(row.Code, row.NLot, Convert.ToDateTime(row.DatePeremption).ToShortDateString());
                            for (int j = 0; j < int.Parse(row.Qte.ToString()); j++)
                            {
                                barcode.Print();
                            }

                            try
                            {
                                //Update BonReception line
                                dataServeces.UpdateBonLivraisonLigneBy(row.id, row.NLot);
                            }
                            catch (Exception ex)
                            {
                                XtraMessageBox.Show(
                                         ex.Message,
                                         "Erreur",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
                                return;
                            }                         

                        }

                    }
                }
            }
            if (!find)
                XtraMessageBox.Show(
                    " Item : " + item.ToString() + " not found",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void codeTextEdit_Validated(object sender, System.EventArgs e)
        {
            Scan();
        }

        private void receptionGridView_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                e.Appearance.BackColor = Color.LightGreen;
                e.Appearance.BackColor2 = Color.MediumAquamarine;
            }
        }
        private void validationSButton_Click(object sender, System.EventArgs e)
        {
            {
                try
                {
                    lignesSelected = new List<BonLivraisonLigne>();
                    foreach (object instance in MarkSelection.GetSelectedRows())
                    {
                        lignesSelected.Add((BonLivraisonLigne)instance);
                    }

                    if (MarkSelection.SelectedCount == receptionGridView.RowCount)
                    {
                        dataServeces.PieceDiversSolded(idBonReception);

                        receptionGridView.RefreshData();
                        XtraMessageBox.Show(
                            "Impression terminé. BRP Enregistré avec succès.",
                            "Information", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        receptionGridControl.DataSource = null;
                        lignesSelected = null;
                        MarkSelection.ClearSelection();
                    }
                    else
                        XtraMessageBox.Show(
                            "Produit manquant.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message,
                        "Erreur",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void UIReception_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                Search();
        }
        private void EnableInput(bool ctr)
        {
            codeTextEdit.Enabled = ctr;
            teDLC.Enabled = ctr;
            teCode.Enabled = ctr;
            teNLot.Enabled = ctr;
            scanSButton.Enabled = ctr;
        }

        private void scanSButton_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
