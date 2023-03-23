using DC;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AlmedStockManagement
{
    partial class UILivraison
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Items item;
        private bool find;
        DataServices.Service dataServeces = new DataServices.Service();

        private List<BonLivraison> bl = new List<BonLivraison>();
        private List<BonLivraisonLigne> bll = new List<BonLivraisonLigne>();
        private GridCheckMarksSelection MarkSelection;
        private string idBonLivraison;
        private string cleintName;
        private string nbl;

        private bool BendingListLivraisonlinebById()
        {
            try
            {
                livraisonSplashScreenManager.ShowWaitForm();

                idBonLivraison = listLivraisongridView.GetRowCellValue(listLivraisongridView.FocusedRowHandle, "id").ToString();
                nbl = listLivraisongridView.GetRowCellValue(listLivraisongridView.FocusedRowHandle, "NBL").ToString();
                cleintName = listLivraisongridView.GetRowCellValue(listLivraisongridView.FocusedRowHandle, "NomClient").ToString();
                livraisonGridControl.DataSource = bll = dataServeces.GetBonLivraisonLigneById(idBonLivraison);

                if (!check)
                {
                    MarkSelection = new GridCheckMarksSelection(livraisonGridView);
                    MarkSelection.View.OptionsBehavior.Editable = false;
                    check = true;
                }
                
                InputControl(true);

                for (int i = 0; i < livraisonGridView.RowCount; i++)
                {
                    var row = (BonLivraisonLigne)livraisonGridView.GetRow(i);
                    int QteScannee = int.Parse(dataServeces.GetQteByIdItemAndIdReception(row.id, idBonLivraison));
                    if (QteScannee > 0)
                        row.QteScannee = QteScannee;
                    if (QteScannee == row.Qte)
                        MarkSelection.SelectRow(i, true);
                    livraisonGridView.RefreshData();
                }
                Validation();

                livraisonSplashScreenManager.CloseWaitForm();
                return true;

            }
            catch (Exception e)
            {
                if (e.GetType() == typeof(SqlException))
                {
                    XtraMessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                livraisonSplashScreenManager.CloseWaitForm();
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// 
        private void BendingLivraisonTreeList()
        {
            try
            {
                livraisonSplashScreenManager.ShowWaitForm();

                listLivraisonGridControl.DataSource = bl = dataServeces.GetBonLivraisons();

                livraisonSplashScreenManager.CloseWaitForm();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(
                         e.Message,
                         "Erreur",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                livraisonSplashScreenManager.CloseWaitForm();
                return;
            }
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UILivraison));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.scanSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.validationSButton = new DevExpress.XtraEditors.SimpleButton();
            this.teCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.teNLot = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teDLC = new DevExpress.XtraEditors.TextEdit();
            this.livraisonGridControl = new DevExpress.XtraGrid.GridControl();
            this.livraisonGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Designation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Numero_lot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Qte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Qte_Scan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.refrechSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.livraisonsDockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.listLivraisonDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.listLivraisonGridControl = new DevExpress.XtraGrid.GridControl();
            this.listLivraisongridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idReceprionList = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NomClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NBL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.dxLivraisonErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.livraisonSplashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::AlmedStockManagement.LivraisonWaitForm), true, true);
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNLot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDLC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livraisonGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livraisonGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livraisonsDockManager)).BeginInit();
            this.listLivraisonDockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listLivraisonGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listLivraisongridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxLivraisonErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(350, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.scanSimpleButton);
            this.splitContainer1.Panel1.Controls.Add(this.validationSButton);
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
            this.splitContainer1.Panel2.Controls.Add(this.livraisonGridControl);
            this.splitContainer1.Size = new System.Drawing.Size(1004, 499);
            this.splitContainer1.SplitterDistance = 46;
            this.splitContainer1.TabIndex = 33;
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(783, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(26, 13);
            this.labelControl5.TabIndex = 46;
            this.labelControl5.Text = "DLC :";
            // 
            // scanSimpleButton
            // 
            this.scanSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scanSimpleButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.scanSimpleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scanSimpleButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("scanSimpleButton.ImageOptions.Image")));
            this.scanSimpleButton.Location = new System.Drawing.Point(865, 5);
            this.scanSimpleButton.Name = "scanSimpleButton";
            this.scanSimpleButton.Size = new System.Drawing.Size(42, 38);
            this.scanSimpleButton.TabIndex = 45;
            this.scanSimpleButton.Click += new System.EventHandler(this.ScanSimpleButton_Click);
            // 
            // validationSButton
            // 
            this.validationSButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.validationSButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.validationSButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.validationSButton.Enabled = false;
            this.validationSButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("validationSButton.ImageOptions.Image")));
            this.validationSButton.Location = new System.Drawing.Point(913, 6);
            this.validationSButton.Name = "validationSButton";
            this.validationSButton.Size = new System.Drawing.Size(42, 38);
            this.validationSButton.TabIndex = 38;
            this.validationSButton.Click += new System.EventHandler(this.ValidationSButton_Click);
            // 
            // teCode
            // 
            this.teCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teCode.EditValue = "";
            this.teCode.Enabled = false;
            this.teCode.Location = new System.Drawing.Point(514, 21);
            this.teCode.Name = "teCode";
            this.teCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.teCode.Size = new System.Drawing.Size(100, 20);
            this.teCode.TabIndex = 35;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(1135, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 13);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "DLC :";
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTextEdit.EditValue = "";
            this.codeTextEdit.Enabled = false;
            this.codeTextEdit.Location = new System.Drawing.Point(142, 21);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.codeTextEdit.Size = new System.Drawing.Size(349, 20);
            this.codeTextEdit.TabIndex = 33;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(659, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "N Lot :";
            // 
            // teNLot
            // 
            this.teNLot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teNLot.EditValue = "";
            this.teNLot.Enabled = false;
            this.teNLot.Location = new System.Drawing.Point(620, 21);
            this.teNLot.Name = "teNLot";
            this.teNLot.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.teNLot.Size = new System.Drawing.Size(126, 20);
            this.teNLot.TabIndex = 36;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(555, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 39;
            this.labelControl2.Text = "Code :";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(277, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 34;
            this.labelControl1.Text = "Scan :";
            // 
            // teDLC
            // 
            this.teDLC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teDLC.EditValue = "";
            this.teDLC.Enabled = false;
            this.teDLC.Location = new System.Drawing.Point(752, 21);
            this.teDLC.Name = "teDLC";
            this.teDLC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.teDLC.Size = new System.Drawing.Size(100, 20);
            this.teDLC.TabIndex = 37;
            // 
            // livraisonGridControl
            // 
            this.livraisonGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.livraisonGridControl.Location = new System.Drawing.Point(0, 0);
            this.livraisonGridControl.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.livraisonGridControl.MainView = this.livraisonGridView;
            this.livraisonGridControl.Name = "livraisonGridControl";
            this.livraisonGridControl.Size = new System.Drawing.Size(1004, 449);
            this.livraisonGridControl.TabIndex = 22;
            this.livraisonGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.livraisonGridView,
            this.gridView1});
            // 
            // livraisonGridView
            // 
            this.livraisonGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.livraisonGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Code,
            this.Designation,
            this.Numero_lot,
            this.DLC,
            this.Qte,
            this.Qte_Scan});
            this.livraisonGridView.GridControl = this.livraisonGridControl;
            this.livraisonGridView.Name = "livraisonGridView";
            this.livraisonGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.livraisonGridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.livraisonGridView.OptionsSelection.EnableAppearanceHideSelection = false;
            this.livraisonGridView.OptionsView.ShowGroupPanel = false;
            this.livraisonGridView.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.LivraisonGridView_RowStyle);
            // 
            // ID
            // 
            this.ID.FieldName = "id";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowMove = false;
            this.ID.OptionsColumn.AllowSize = false;
            this.ID.OptionsColumn.ReadOnly = true;
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            this.ID.Width = 56;
            // 
            // Code
            // 
            this.Code.FieldName = "Code";
            this.Code.Name = "Code";
            this.Code.OptionsColumn.AllowEdit = false;
            this.Code.OptionsColumn.AllowMove = false;
            this.Code.OptionsColumn.AllowSize = false;
            this.Code.OptionsColumn.ReadOnly = true;
            this.Code.Visible = true;
            this.Code.VisibleIndex = 1;
            this.Code.Width = 79;
            // 
            // Designation
            // 
            this.Designation.Caption = "Designation";
            this.Designation.FieldName = "Designation";
            this.Designation.Name = "Designation";
            this.Designation.OptionsColumn.AllowEdit = false;
            this.Designation.OptionsColumn.AllowMove = false;
            this.Designation.OptionsColumn.AllowSize = false;
            this.Designation.OptionsColumn.ReadOnly = true;
            this.Designation.Visible = true;
            this.Designation.VisibleIndex = 2;
            this.Designation.Width = 459;
            // 
            // Numero_lot
            // 
            this.Numero_lot.FieldName = "NLot";
            this.Numero_lot.Name = "Numero_lot";
            this.Numero_lot.OptionsColumn.AllowEdit = false;
            this.Numero_lot.OptionsColumn.AllowMove = false;
            this.Numero_lot.OptionsColumn.AllowSize = false;
            this.Numero_lot.OptionsColumn.ReadOnly = true;
            this.Numero_lot.Visible = true;
            this.Numero_lot.VisibleIndex = 3;
            this.Numero_lot.Width = 131;
            // 
            // DLC
            // 
            this.DLC.FieldName = "DatePeremption";
            this.DLC.Name = "DLC";
            this.DLC.OptionsColumn.AllowEdit = false;
            this.DLC.OptionsColumn.AllowMove = false;
            this.DLC.OptionsColumn.AllowSize = false;
            this.DLC.OptionsColumn.ReadOnly = true;
            this.DLC.Visible = true;
            this.DLC.VisibleIndex = 4;
            this.DLC.Width = 211;
            // 
            // Qte
            // 
            this.Qte.FieldName = "Qte";
            this.Qte.Name = "Qte";
            this.Qte.OptionsColumn.AllowEdit = false;
            this.Qte.OptionsColumn.AllowMove = false;
            this.Qte.OptionsColumn.AllowSize = false;
            this.Qte.OptionsColumn.ReadOnly = true;
            this.Qte.Visible = true;
            this.Qte.VisibleIndex = 5;
            this.Qte.Width = 65;
            // 
            // Qte_Scan
            // 
            this.Qte_Scan.FieldName = "QteScannee";
            this.Qte_Scan.Name = "Qte_Scan";
            this.Qte_Scan.OptionsColumn.AllowEdit = false;
            this.Qte_Scan.OptionsColumn.AllowMove = false;
            this.Qte_Scan.OptionsColumn.AllowSize = false;
            this.Qte_Scan.OptionsColumn.ReadOnly = true;
            this.Qte_Scan.Visible = true;
            this.Qte_Scan.VisibleIndex = 6;
            this.Qte_Scan.Width = 67;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.livraisonGridControl;
            this.gridView1.Name = "gridView1";
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
            this.refrechSimpleButton.Location = new System.Drawing.Point(255, 0);
            this.refrechSimpleButton.Name = "refrechSimpleButton";
            this.refrechSimpleButton.Size = new System.Drawing.Size(85, 33);
            this.refrechSimpleButton.TabIndex = 43;
            this.refrechSimpleButton.Text = "Refresh";
            this.refrechSimpleButton.Click += new System.EventHandler(this.RefrechSimpleButton_Click);
            // 
            // livraisonsDockManager
            // 
            this.livraisonsDockManager.Form = this;
            this.livraisonsDockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.listLivraisonDockPanel});
            this.livraisonsDockManager.TopZIndexControls.AddRange(new string[] {
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
            // listLivraisonDockPanel
            // 
            this.listLivraisonDockPanel.Controls.Add(this.dockPanel1_Container);
            this.listLivraisonDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.listLivraisonDockPanel.ID = new System.Guid("a92b0c6b-0294-4267-b46e-77e2b2fa63de");
            this.listLivraisonDockPanel.Location = new System.Drawing.Point(0, 0);
            this.listLivraisonDockPanel.Name = "listLivraisonDockPanel";
            this.listLivraisonDockPanel.OriginalSize = new System.Drawing.Size(350, 200);
            this.listLivraisonDockPanel.Size = new System.Drawing.Size(350, 499);
            this.listLivraisonDockPanel.Text = "List Livraisons";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.refrechSimpleButton);
            this.dockPanel1_Container.Controls.Add(this.listLivraisonGridControl);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(341, 472);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // listLivraisonGridControl
            // 
            this.listLivraisonGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLivraisonGridControl.Location = new System.Drawing.Point(0, 0);
            this.listLivraisonGridControl.MainView = this.listLivraisongridView;
            this.listLivraisonGridControl.Name = "listLivraisonGridControl";
            this.listLivraisonGridControl.Size = new System.Drawing.Size(341, 472);
            this.listLivraisonGridControl.TabIndex = 35;
            this.listLivraisonGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.listLivraisongridView});
            // 
            // listLivraisongridView
            // 
            this.listLivraisongridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.listLivraisongridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idReceprionList,
            this.NomClient,
            this.date,
            this.NBL});
            this.listLivraisongridView.GridControl = this.listLivraisonGridControl;
            this.listLivraisongridView.Name = "listLivraisongridView";
            this.listLivraisongridView.OptionsCustomization.AllowColumnResizing = false;
            this.listLivraisongridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.ListLivraisongridView_RowClick);
            this.listLivraisongridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.ListLivraisongridView_RowCellClick);
            // 
            // idReceprionList
            // 
            this.idReceprionList.FieldName = "id";
            this.idReceprionList.Name = "idReceprionList";
            this.idReceprionList.OptionsColumn.AllowEdit = false;
            this.idReceprionList.Width = 48;
            // 
            // NomClient
            // 
            this.NomClient.FieldName = "NomClient";
            this.NomClient.Name = "NomClient";
            this.NomClient.OptionsColumn.AllowEdit = false;
            this.NomClient.Visible = true;
            this.NomClient.VisibleIndex = 1;
            this.NomClient.Width = 171;
            // 
            // date
            // 
            this.date.FieldName = "Date";
            this.date.Name = "date";
            this.date.OptionsColumn.AllowEdit = false;
            this.date.Visible = true;
            this.date.VisibleIndex = 2;
            this.date.Width = 72;
            // 
            // NBL
            // 
            this.NBL.Caption = "NBL";
            this.NBL.FieldName = "NBL";
            this.NBL.Name = "NBL";
            this.NBL.OptionsColumn.AllowEdit = false;
            this.NBL.Visible = true;
            this.NBL.VisibleIndex = 0;
            this.NBL.Width = 82;
            // 
            // dxLivraisonErrorProvider
            // 
            this.dxLivraisonErrorProvider.ContainerControl = this;
            // 
            // livraisonSplashScreenManager
            // 
            this.livraisonSplashScreenManager.ClosingDelay = 500;
            // 
            // timer
            // 
            this.timer.Interval = 200000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // UILivraison
            // 
            this.AcceptButton = this.scanSimpleButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 499);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.listLivraisonDockPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UILivraison";
            this.Text = "Livraison";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UILivraison_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNLot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDLC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livraisonGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livraisonGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livraisonsDockManager)).EndInit();
            this.listLivraisonDockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listLivraisonGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listLivraisongridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxLivraisonErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl livraisonGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView livraisonGridView;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn Designation;
        private DevExpress.XtraGrid.Columns.GridColumn Numero_lot;
        private DevExpress.XtraGrid.Columns.GridColumn DLC;
        private DevExpress.XtraGrid.Columns.GridColumn Qte;
        private DevExpress.XtraGrid.Columns.GridColumn Qte_Scan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton refrechSimpleButton;
        private DevExpress.XtraEditors.SimpleButton validationSButton;
        private DevExpress.XtraEditors.TextEdit teCode;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit codeTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit teNLot;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teDLC;
        private DevExpress.XtraBars.Docking.DockManager livraisonsDockManager;
        private DevExpress.XtraBars.Docking.DockPanel listLivraisonDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.GridControl listLivraisonGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView listLivraisongridView;
        private DevExpress.XtraGrid.Columns.GridColumn idReceprionList;
        private DevExpress.XtraGrid.Columns.GridColumn NomClient;
        private DevExpress.XtraGrid.Columns.GridColumn date;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private SimpleButton scanSimpleButton;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxLivraisonErrorProvider;
        private bool check;
        private DevExpress.XtraGrid.Columns.GridColumn NBL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraSplashScreen.SplashScreenManager livraisonSplashScreenManager;
        private Timer timer;
        private LabelControl labelControl5;
    }
}