using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace AlmedStockManagement
{

    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        DataServices.Service dataServeces = new DataServices.Service();
        UILoginForm loginForm = new UILoginForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void LivraisonbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                dataServeces.TestCurrentConnexionString();

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is UILivraison)
                    {
                        if (frm.WindowState == FormWindowState.Minimized)
                            frm.WindowState = FormWindowState.Maximized;
                        frm.Focus();
                        return;
                    }
                }
                UILivraison livraisonForm = new UILivraison();
                loginForm.Subscribe(livraisonForm);
                livraisonForm.MdiParent = this;
                WindowState = FormWindowState.Maximized;
                livraisonForm.Show();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ReceptionbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                dataServeces.TestCurrentConnexionString();

                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is UIReception)
                    {
                        if (frm.WindowState == FormWindowState.Minimized)
                            frm.WindowState = FormWindowState.Maximized;
                        frm.Focus();
                        return;
                    }
                }
                UIReception receptionForm = new UIReception();
                loginForm.Subscribe(receptionForm);
                receptionForm.MdiParent = this;
                WindowState = FormWindowState.Maximized;
                receptionForm.Show();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void VracbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                dataServeces.TestCurrentConnexionString();
                foreach (Form frm in this.MdiChildren)
                {
                    if (frm is UIVrac)
                    {
                        if (frm.WindowState == FormWindowState.Minimized)
                            frm.WindowState = FormWindowState.Maximized;
                        frm.Focus();
                        return;
                    }
                }
                UIVrac vracForm = new UIVrac();
                loginForm.Subscribe(vracForm);
                vracForm.MdiParent = this;
                WindowState = FormWindowState.Maximized;

                vracForm.Show();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ConnexionBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => new UISqlConnexion().ShowDialog();

        private void BarButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => new UIBackUpAccess().ShowDialog();

        private void BarButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => loginForm.ShowDialog();
    }
}
