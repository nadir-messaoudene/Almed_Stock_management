using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlmedStockManagement
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void livraisonbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
            livraisonForm.MdiParent = this;
            livraisonForm.WindowState = FormWindowState.Maximized;
            livraisonForm.Show();
        }

        private void receptionbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
            receptionForm.MdiParent = this;
            receptionForm.WindowState = FormWindowState.Maximized;
            receptionForm.Show();
        }

        private void vracbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
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
            UIVrac receptionForm = new UIVrac();
            receptionForm.MdiParent = this;
            receptionForm.WindowState = FormWindowState.Maximized;
            receptionForm.Show();
        }
    }
}
