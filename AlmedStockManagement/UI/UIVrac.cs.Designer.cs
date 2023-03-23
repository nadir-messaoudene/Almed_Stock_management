using DC;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlmedStockManagement
{
    partial class UIVrac
    {
        private Items item;

        DataServices.Service dataServeces = new DataServices.Service();

        private bool check = false;
        private GridCheckMarksSelection MarkSelection;
        private string idVrac = null;

        private List<PieceDivers> pd;
        private List<PieceDiversLigne> pdl;

        private string PCDNUM;

        private void BindingVracTreeList()
        {
            try
            {
                vracSplashScreenManager.ShowWaitForm();
                vracGridControl.DataSource = pd = dataServeces.GetPieceDivers();
                vracSplashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                vracSplashScreenManager.CloseWaitForm();
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// bending receptions
        /// </summary>

        private bool BindingListVraclinebById()
        {
            try
            {
                vracSplashScreenManager.ShowWaitForm();
                idVrac = vracGridView.GetRowCellValue(vracGridView.FocusedRowHandle, "PCDID").ToString();
                listVracGridControl.DataSource = pdl = dataServeces.GetPieceDiversLigneByID(idVrac);

                PCDNUM = vracGridView.GetRowCellValue(vracGridView.FocusedRowHandle, "PCDNUM").ToString();

                if (!check)
                {
                    MarkSelection = new GridCheckMarksSelection(listVracGridView);
                    MarkSelection.View.OptionsBehavior.Editable = false;
                    check = true;
                }

                EnableInput(true);
                vracSplashScreenManager.CloseWaitForm();
                return true;
            }
            catch (Exception ex)
            {
                vracSplashScreenManager.CloseWaitForm();
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIVrac));
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.dxReceptionErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabFormContentContainer2 = new DevExpress.XtraBars.TabFormContentContainer();
            this.tabFormPage2 = new DevExpress.XtraBars.TabFormPage();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.receptionsDockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.controlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
            this.listReceptionsDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.refrechSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.vracGridControl = new DevExpress.XtraGrid.GridControl();
            this.vracGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.document1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.validationSButton = new DevExpress.XtraEditors.SimpleButton();
            this.scanSButton = new DevExpress.XtraEditors.SimpleButton();
            this.teCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.teNLot = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teDLC = new DevExpress.XtraEditors.TextEdit();
            this.listVracGridControl = new DevExpress.XtraGrid.GridControl();
            this.listVracGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PLDID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PLDDESIGNATION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PLDNUMLOT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PLDFEFOPEREMPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Qte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn16 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn19 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn20 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vracSplashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::AlmedStockManagement.LivraisonWaitForm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxReceptionErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionsDockManager)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.listReceptionsDockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vracGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vracGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).BeginInit();
            this.dockPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNLot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDLC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listVracGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listVracGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = null;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Size = new System.Drawing.Size(408, 716);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // dxReceptionErrorProvider
            // 
            this.dxReceptionErrorProvider.ContainerControl = this;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Designation";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 459;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Designation";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 459;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "Designation";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 459;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Designation";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 459;
            // 
            // gridColumn12
            // 
            this.gridColumn12.FieldName = "Designation";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 2;
            this.gridColumn12.Width = 459;
            // 
            // gridColumn13
            // 
            this.gridColumn13.FieldName = "Designation";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 2;
            this.gridColumn13.Width = 459;
            // 
            // gridColumn14
            // 
            this.gridColumn14.FieldName = "Designation";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 2;
            this.gridColumn14.Width = 459;
            // 
            // tabFormContentContainer2
            // 
            this.tabFormContentContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFormContentContainer2.Location = new System.Drawing.Point(0, 0);
            this.tabFormContentContainer2.Name = "tabFormContentContainer2";
            this.tabFormContentContainer2.Size = new System.Drawing.Size(0, 0);
            this.tabFormContentContainer2.TabIndex = 0;
            // 
            // tabFormPage2
            // 
            this.tabFormPage2.ContentContainer = this.tabFormContentContainer2;
            this.tabFormPage2.Name = "tabFormPage2";
            this.tabFormPage2.Text = "Page 1";
            // 
            // receptionsDockManager
            // 
            this.receptionsDockManager.Form = this;
            this.receptionsDockManager.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.receptionsDockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.listReceptionsDockPanel});
            this.receptionsDockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.controlContainer1);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanel1.FloatLocation = new System.Drawing.Point(823, 473);
            this.dockPanel1.FloatVertical = true;
            this.dockPanel1.ID = new System.Guid("7aabb4a2-93a8-411c-9462-b65f57ba321f");
            this.dockPanel1.Location = new System.Drawing.Point(-32768, -32768);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.SavedIndex = 1;
            this.dockPanel1.Size = new System.Drawing.Size(200, 200);
            this.dockPanel1.Text = "dockPanel1";
            this.dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // controlContainer1
            // 
            this.controlContainer1.Location = new System.Drawing.Point(4, 24);
            this.controlContainer1.Name = "controlContainer1";
            this.controlContainer1.Size = new System.Drawing.Size(192, 172);
            this.controlContainer1.TabIndex = 0;
            // 
            // listReceptionsDockPanel
            // 
            this.listReceptionsDockPanel.Controls.Add(this.dockPanel1_Container);
            this.listReceptionsDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.listReceptionsDockPanel.ID = new System.Guid("8fd31b9f-54d2-4a39-ba04-6c87fb21bad5");
            this.listReceptionsDockPanel.Location = new System.Drawing.Point(0, 0);
            this.listReceptionsDockPanel.Name = "listReceptionsDockPanel";
            this.listReceptionsDockPanel.Options.ShowCloseButton = false;
            this.listReceptionsDockPanel.OriginalSize = new System.Drawing.Size(341, 200);
            this.listReceptionsDockPanel.Size = new System.Drawing.Size(341, 733);
            this.listReceptionsDockPanel.Text = "Liste Vrac";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.refrechSimpleButton);
            this.dockPanel1_Container.Controls.Add(this.vracGridControl);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(332, 706);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // refrechSimpleButton
            // 
            this.refrechSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refrechSimpleButton.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.refrechSimpleButton.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.refrechSimpleButton.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.refrechSimpleButton.Appearance.Options.UseBackColor = true;
            this.refrechSimpleButton.Appearance.Options.UseBorderColor = true;
            this.refrechSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.refrechSimpleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refrechSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("refrechSimpleButton.ImageOptions.Image")));
            this.refrechSimpleButton.Location = new System.Drawing.Point(247, 0);
            this.refrechSimpleButton.Name = "refrechSimpleButton";
            this.refrechSimpleButton.Size = new System.Drawing.Size(85, 33);
            this.refrechSimpleButton.TabIndex = 45;
            this.refrechSimpleButton.Text = "Refresh";
            this.refrechSimpleButton.Click += new System.EventHandler(this.RefrechSimpleButton_Click_1);
            // 
            // vracGridControl
            // 
            this.vracGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vracGridControl.Location = new System.Drawing.Point(0, 0);
            this.vracGridControl.MainView = this.vracGridView;
            this.vracGridControl.Name = "vracGridControl";
            this.vracGridControl.Size = new System.Drawing.Size(332, 706);
            this.vracGridControl.TabIndex = 33;
            this.vracGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.vracGridView,
            this.gridView2});
            // 
            // vracGridView
            // 
            this.vracGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.vracGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.vracGridView.GridControl = this.vracGridControl;
            this.vracGridView.Name = "vracGridView";
            this.vracGridView.OptionsCustomization.AllowColumnResizing = false;
            this.vracGridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.ListReceptiongridView_RowClick);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "PCDID";
            this.gridColumn5.FieldName = "PCDID";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 67;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "PCDNUM";
            this.gridColumn6.FieldName = "PCDNUM";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 119;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "PCDATECREATED";
            this.gridColumn7.FieldName = "PCDATECREATED";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            this.gridColumn7.Width = 130;
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.vracGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "PCDID";
            this.gridColumn18.FieldName = "PCDID";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 0;
            this.gridColumn18.Width = 77;
            // 
            // document1
            // 
            this.document1.Caption = "dockPanel2";
            this.document1.ControlName = "dockPanel2";
            this.document1.FloatLocation = new System.Drawing.Point(0, 0);
            this.document1.FloatSize = new System.Drawing.Size(200, 200);
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(1015, 713);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float;
            this.dockPanel2.DockedAsTabbedDocument = true;
            this.dockPanel2.ID = new System.Guid("d77b69fd-203b-4cf6-848e-6db1f7ffdc32");
            this.dockPanel2.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel2.Size = new System.Drawing.Size(1017, 737);
            this.dockPanel2.Text = "dockPanel2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(341, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.validationSButton);
            this.splitContainer1.Panel1.Controls.Add(this.scanSButton);
            this.splitContainer1.Panel1.Controls.Add(this.teCode);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.codeTextEdit);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.teNLot);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.teDLC);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listVracGridControl);
            this.splitContainer1.Size = new System.Drawing.Size(1013, 733);
            this.splitContainer1.SplitterDistance = 61;
            this.splitContainer1.TabIndex = 33;
            // 
            // validationSButton
            // 
            this.validationSButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.validationSButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.validationSButton.Enabled = false;
            this.validationSButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("validationSButton.ImageOptions.Image")));
            this.validationSButton.Location = new System.Drawing.Point(968, 12);
            this.validationSButton.Name = "validationSButton";
            this.validationSButton.Size = new System.Drawing.Size(42, 38);
            this.validationSButton.TabIndex = 26;
            this.validationSButton.Click += new System.EventHandler(this.ValidationSButton_Click_1);
            // 
            // scanSButton
            // 
            this.scanSButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scanSButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.scanSButton.Enabled = false;
            this.scanSButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("scanSButton.ImageOptions.Image")));
            this.scanSButton.Location = new System.Drawing.Point(920, 12);
            this.scanSButton.Name = "scanSButton";
            this.scanSButton.Size = new System.Drawing.Size(42, 38);
            this.scanSButton.TabIndex = 30;
            this.scanSButton.Click += new System.EventHandler(this.ScanSButton_Click_1);
            // 
            // teCode
            // 
            this.teCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teCode.EditValue = "";
            this.teCode.Enabled = false;
            this.teCode.Location = new System.Drawing.Point(576, 21);
            this.teCode.Name = "teCode";
            this.teCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.teCode.Size = new System.Drawing.Size(100, 20);
            this.teCode.TabIndex = 23;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(847, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 13);
            this.labelControl4.TabIndex = 29;
            this.labelControl4.Text = "DLC :";
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTextEdit.EditValue = "";
            this.codeTextEdit.Enabled = false;
            this.codeTextEdit.Location = new System.Drawing.Point(204, 21);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.codeTextEdit.Size = new System.Drawing.Size(349, 20);
            this.codeTextEdit.TabIndex = 21;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(721, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "N Lot :";
            // 
            // teNLot
            // 
            this.teNLot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teNLot.EditValue = "";
            this.teNLot.Enabled = false;
            this.teNLot.Location = new System.Drawing.Point(682, 21);
            this.teNLot.Name = "teNLot";
            this.teNLot.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.teNLot.Size = new System.Drawing.Size(126, 20);
            this.teNLot.TabIndex = 24;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(617, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Code :";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(339, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Scan :";
            // 
            // teDLC
            // 
            this.teDLC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teDLC.EditValue = "";
            this.teDLC.Enabled = false;
            this.teDLC.Location = new System.Drawing.Point(814, 21);
            this.teDLC.Name = "teDLC";
            this.teDLC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.teDLC.Size = new System.Drawing.Size(100, 20);
            this.teDLC.TabIndex = 25;
            // 
            // listVracGridControl
            // 
            this.listVracGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVracGridControl.Location = new System.Drawing.Point(0, 0);
            this.listVracGridControl.MainView = this.listVracGridView;
            this.listVracGridControl.Name = "listVracGridControl";
            this.listVracGridControl.Size = new System.Drawing.Size(1013, 668);
            this.listVracGridControl.TabIndex = 21;
            this.listVracGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.listVracGridView});
            // 
            // listVracGridView
            // 
            this.listVracGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PLDID,
            this.LN,
            this.PLDDESIGNATION,
            this.PLDNUMLOT,
            this.PLDFEFOPEREMPTION,
            this.Qte});
            this.listVracGridView.GridControl = this.listVracGridControl;
            this.listVracGridView.Name = "listVracGridView";
            this.listVracGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.listVracGridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.listVracGridView.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.ListVracGridView_RowStyle_1);
            // 
            // PLDID
            // 
            this.PLDID.Caption = "PLDID";
            this.PLDID.FieldName = "PLDID";
            this.PLDID.Name = "PLDID";
            this.PLDID.OptionsColumn.AllowEdit = false;
            this.PLDID.Visible = true;
            this.PLDID.VisibleIndex = 0;
            this.PLDID.Width = 77;
            // 
            // LN
            // 
            this.LN.Caption = "LN";
            this.LN.FieldName = "LN";
            this.LN.Name = "LN";
            this.LN.OptionsColumn.AllowEdit = false;
            this.LN.Visible = true;
            this.LN.VisibleIndex = 1;
            this.LN.Width = 85;
            // 
            // PLDDESIGNATION
            // 
            this.PLDDESIGNATION.Caption = "PLDDESIGNATION";
            this.PLDDESIGNATION.FieldName = "PLDDESIGNATION";
            this.PLDDESIGNATION.Name = "PLDDESIGNATION";
            this.PLDDESIGNATION.OptionsColumn.AllowEdit = false;
            this.PLDDESIGNATION.Visible = true;
            this.PLDDESIGNATION.VisibleIndex = 2;
            this.PLDDESIGNATION.Width = 418;
            // 
            // PLDNUMLOT
            // 
            this.PLDNUMLOT.Caption = "PLDNUMLOT";
            this.PLDNUMLOT.FieldName = "PLDNUMLOT";
            this.PLDNUMLOT.Name = "PLDNUMLOT";
            this.PLDNUMLOT.OptionsColumn.AllowEdit = false;
            this.PLDNUMLOT.Visible = true;
            this.PLDNUMLOT.VisibleIndex = 3;
            this.PLDNUMLOT.Width = 131;
            // 
            // PLDFEFOPEREMPTION
            // 
            this.PLDFEFOPEREMPTION.Caption = "PLDFEFOPEREMPTION";
            this.PLDFEFOPEREMPTION.FieldName = "PLDFEFOPEREMPTION";
            this.PLDFEFOPEREMPTION.Name = "PLDFEFOPEREMPTION";
            this.PLDFEFOPEREMPTION.OptionsColumn.AllowEdit = false;
            this.PLDFEFOPEREMPTION.Visible = true;
            this.PLDFEFOPEREMPTION.VisibleIndex = 4;
            this.PLDFEFOPEREMPTION.Width = 214;
            // 
            // Qte
            // 
            this.Qte.FieldName = "Qte";
            this.Qte.Name = "Qte";
            this.Qte.OptionsColumn.AllowEdit = false;
            this.Qte.Visible = true;
            this.Qte.VisibleIndex = 5;
            this.Qte.Width = 64;
            // 
            // timer
            // 
            this.timer.Interval = 200000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "DatePeremption";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            this.gridColumn8.Width = 214;
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "DatePeremption";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 214;
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "DatePeremption";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 4;
            this.gridColumn10.Width = 214;
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "DatePeremption";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 4;
            this.gridColumn11.Width = 214;
            // 
            // gridColumn15
            // 
            this.gridColumn15.FieldName = "DatePeremption";
            this.gridColumn15.Name = "gridColumn15";
            this.gridColumn15.OptionsColumn.AllowEdit = false;
            this.gridColumn15.Visible = true;
            this.gridColumn15.VisibleIndex = 4;
            this.gridColumn15.Width = 214;
            // 
            // gridColumn16
            // 
            this.gridColumn16.FieldName = "DatePeremption";
            this.gridColumn16.Name = "gridColumn16";
            this.gridColumn16.OptionsColumn.AllowEdit = false;
            this.gridColumn16.Visible = true;
            this.gridColumn16.VisibleIndex = 4;
            this.gridColumn16.Width = 214;
            // 
            // gridColumn17
            // 
            this.gridColumn17.FieldName = "DatePeremption";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.OptionsColumn.AllowEdit = false;
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 4;
            this.gridColumn17.Width = 214;
            // 
            // gridColumn19
            // 
            this.gridColumn19.Caption = "PCDNUM";
            this.gridColumn19.FieldName = "PCDNUM";
            this.gridColumn19.Name = "gridColumn19";
            this.gridColumn19.OptionsColumn.AllowEdit = false;
            this.gridColumn19.Visible = true;
            this.gridColumn19.VisibleIndex = 1;
            this.gridColumn19.Width = 119;
            // 
            // gridColumn20
            // 
            this.gridColumn20.Caption = "PCDNUM";
            this.gridColumn20.FieldName = "PCDNUM";
            this.gridColumn20.Name = "gridColumn20";
            this.gridColumn20.OptionsColumn.AllowEdit = false;
            this.gridColumn20.Visible = true;
            this.gridColumn20.VisibleIndex = 1;
            this.gridColumn20.Width = 119;
            // 
            // vracSplashScreenManager
            // 
            this.vracSplashScreenManager.ClosingDelay = 500;
            // 
            // UIVrac
            // 
            this.AcceptButton = this.scanSButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.listReceptionsDockPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "UIVrac";
            this.Text = "Vrac";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxReceptionErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionsDockManager)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.listReceptionsDockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vracGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vracGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.document1)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNLot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDLC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listVracGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listVracGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxReceptionErrorProvider;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
        private DevExpress.XtraBars.TabFormContentContainer tabFormContentContainer2;
        private DevExpress.XtraBars.TabFormPage tabFormPage2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraBars.Docking.DockManager receptionsDockManager;
        private DevExpress.XtraBars.Docking.DockPanel listReceptionsDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.GridControl vracGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView vracGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private SplitContainer splitContainer1;
        private SimpleButton validationSButton;
        private SimpleButton scanSButton;
        private TextEdit teCode;
        private LabelControl labelControl4;
        private TextEdit codeTextEdit;
        private LabelControl labelControl3;
        private TextEdit teNLot;
        private LabelControl labelControl2;
        private LabelControl labelControl1;
        private TextEdit teDLC;
        private DevExpress.XtraGrid.GridControl listVracGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView listVracGridView;
        private DevExpress.XtraGrid.Columns.GridColumn PLDID;
        private DevExpress.XtraGrid.Columns.GridColumn PLDDESIGNATION;
        private DevExpress.XtraGrid.Columns.GridColumn PLDNUMLOT;
        private DevExpress.XtraGrid.Columns.GridColumn PLDFEFOPEREMPTION;
        private DevExpress.XtraGrid.Columns.GridColumn Qte;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer controlContainer1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document document1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private SimpleButton refrechSimpleButton;
        private Timer timer;
        private DevExpress.XtraGrid.Columns.GridColumn LN;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn16;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn19;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn20;
        private DevExpress.XtraSplashScreen.SplashScreenManager vracSplashScreenManager;
    }
}