namespace AlmedStockManagement
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.livraisonbarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.receptionbarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.vracbarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.connexionBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.livraisonbarButtonItem,
            this.receptionbarButtonItem,
            this.vracbarButtonItem,
            this.connexionBarButtonItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.livraisonbarButtonItem);
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.receptionbarButtonItem);
            this.ribbonControl1.QuickToolbarItemLinks.Add(this.vracbarButtonItem);
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1009, 143);
            // 
            // livraisonbarButtonItem
            // 
            this.livraisonbarButtonItem.Caption = "Livraison";
            this.livraisonbarButtonItem.Id = 1;
            this.livraisonbarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("livraisonbarButtonItem.ImageOptions.Image")));
            this.livraisonbarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("livraisonbarButtonItem.ImageOptions.LargeImage")));
            this.livraisonbarButtonItem.Name = "livraisonbarButtonItem";
            this.livraisonbarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LivraisonbarButtonItem_ItemClick);
            // 
            // receptionbarButtonItem
            // 
            this.receptionbarButtonItem.Caption = "Reception";
            this.receptionbarButtonItem.Id = 2;
            this.receptionbarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("receptionbarButtonItem.ImageOptions.Image")));
            this.receptionbarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("receptionbarButtonItem.ImageOptions.LargeImage")));
            this.receptionbarButtonItem.Name = "receptionbarButtonItem";
            this.receptionbarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ReceptionbarButtonItem_ItemClick);
            // 
            // vracbarButtonItem
            // 
            this.vracbarButtonItem.Caption = "Vrac";
            this.vracbarButtonItem.Id = 3;
            this.vracbarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("vracbarButtonItem.ImageOptions.Image")));
            this.vracbarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("vracbarButtonItem.ImageOptions.LargeImage")));
            this.vracbarButtonItem.Name = "vracbarButtonItem";
            this.vracbarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.VracbarButtonItem_ItemClick);
            // 
            // connexionBarButtonItem
            // 
            this.connexionBarButtonItem.Caption = "Data";
            this.connexionBarButtonItem.Id = 4;
            this.connexionBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("connexionBarButtonItem.ImageOptions.Image")));
            this.connexionBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("connexionBarButtonItem.ImageOptions.LargeImage")));
            this.connexionBarButtonItem.Name = "connexionBarButtonItem";
            this.connexionBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ConnexionBarButtonItem_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "BuckUp";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem1_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Stock";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Glyph = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup1.Glyph")));
            this.ribbonPageGroup1.ItemLinks.Add(this.receptionbarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.livraisonbarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.vracbarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Mouvements Stock";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Seting";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Glyph = ((System.Drawing.Image)(resources.GetObject("ribbonPageGroup2.Glyph")));
            this.ribbonPageGroup2.ItemLinks.Add(this.connexionBarButtonItem);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Database connexion";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Login/Logout";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Login";
            this.barButtonItem4.Id = 8;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItem4_ItemClick);
            // 
            // MainForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 576);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Almed stock manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem livraisonbarButtonItem;
        private DevExpress.XtraBars.BarButtonItem receptionbarButtonItem;
        private DevExpress.XtraBars.BarButtonItem vracbarButtonItem;
        private DevExpress.XtraBars.BarButtonItem connexionBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
    }
}

