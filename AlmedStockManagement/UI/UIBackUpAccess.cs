using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmedStockManagement
{
    public partial class UIBackUpAccess : DevExpress.XtraEditors.XtraForm
    {
        public UIBackUpAccess()
        {
            InitializeComponent();
        }

        private void CuncelSimpleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetDirectorySimpleButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {

                }
            }
        }

        private void BackUpSimpleButton_Click(object sender, EventArgs e)
        {

        }

        private void GetBukupDirectorySimpleButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {

                }
            }
        }
    }
}
