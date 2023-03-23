using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmedStockManagement
{
    public partial class UISqlConnexion : DevExpress.XtraEditors.XtraForm
    {
        DataServices.Service dataServeces = new DataServices.Service();
        public UISqlConnexion()
        {
            InitializeComponent();
        }

        private void CuncelSimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TestConnexioSimpleButton_Click(object sender, EventArgs e)
        {
            string result = dataServeces.SqlTestConnexion(providerTextEdit.Text, serverTextEdit.Text, dataBaseComboBox.Text, loginTextEdit.Text, passwordTextEditor.Text).ToString();
            switch (result)
            {
                case "ok":
                    XtraMessageBox.Show("Connexion succes", "information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    connexionStringTextEditor.Text = "Server = " + serverTextEdit.Text + "; Database = " + dataBaseComboBox.Text + "; User Id = " + loginTextEdit.Text + "; Password = ***";
                    SaveSimpleButton.Enabled = true;
                    break;
                default:
                    XtraMessageBox.Show(result, "information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    SaveSimpleButton.Enabled = false;
                    break;
            }
        }

        private void SaveSimpleButton_Click(object sender, EventArgs e)
        {
                XtraMessageBox.Show(dataServeces.SaveConnexionString(serverTextEdit.Text, dataBaseComboBox.Text, loginTextEdit.Text, passwordTextEditor.Text), "SQL Connexion Informations");
            connexionStringTextEditor.Text = "Server = " + serverTextEdit.Text + "; Database = " + dataBaseComboBox.Text + "; User Id = " + loginTextEdit.Text + "; Password = ***";
            SaveSimpleButton.Enabled = false;
        }

        private void UISqlConnexion_Load(object sender, EventArgs e)
        {
            serverTextEdit.Text = dataServeces.GetCurentSqlServerName();
            dataBaseComboBox.Text = dataServeces.GetCurentSqlDataBase();
            loginTextEdit.Text = dataServeces.GetCurentLoginname();
        }
    }
}

