using AlmedFramework;
using DC;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlmedStockManagement
{
    partial class UIReception
    {
        private Items item;

        private DataServices.Service dataServeces = new DataServices.Service();
        private List<BonLivraison> br = new List<BonLivraison>();
        private List<BonLivraisonLigne> brl = new List<BonLivraisonLigne>();
        private bool check = false;
        private GridCheckMarksSelection MarkSelection;
        private string SuplayName = string.Empty;
        private List<BonLivraisonLigne> lignesSelected;
        private string idBonReception = "";
        private string brn = "";


        /// <summary>
        /// bending receptions list
        /// </summary>

        private void BindingRecetionTreeList()
        {
            try
            {
                receptionSplashScreenManager.ShowWaitForm();

                listReceptionGridControl.DataSource = br = dataServeces.GetBonReception();

                receptionSplashScreenManager.CloseWaitForm();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                receptionSplashScreenManager.CloseWaitForm();
            }
        }

        /// <summary>
        /// bending receptions
        /// </summary>

        private bool BindingListReceptionlinebById()
        {
            try
            {
                receptionSplashScreenManager.ShowWaitForm();

                idBonReception = listReceptiongridView.GetRowCellValue(listReceptiongridView.FocusedRowHandle, "id").ToString();
                brn = listReceptiongridView.GetRowCellValue(listReceptiongridView.FocusedRowHandle, "NBL").ToString();
                SuplayName = Util.GetSyplayName(listReceptiongridView.GetRowCellValue(listReceptiongridView.FocusedRowHandle, "NomClient").ToString());
                receptionGridControl.DataSource = brl = dataServeces.GetLigneBonReceptionById(idBonReception);
                if (!check)
                {
                    MarkSelection = new GridCheckMarksSelection(receptionGridView);
                    MarkSelection.View.OptionsBehavior.Editable = false;
                    check = true;
                }

                InputCotrol(true);


                for (int i = 0; i < receptionGridView.RowCount; i++)
                {
                    var row = (BonLivraisonLigne)receptionGridView.GetRow(i);
                    int QteScannee = int.Parse(dataServeces.GetQteByIdItemAndIdReception(row.id, idBonReception));
                    if (QteScannee > 0)
                        row.QteScannee = QteScannee;
                    if (QteScannee == row.Qte)
                        MarkSelection.SelectRow(i, true);
                    receptionGridView.RefreshData();
                }

                PrintCheckBox.Checked = SuplayName == "Abbott" ? false : true;

                Validation();
                receptionSplashScreenManager.CloseWaitForm();
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                receptionSplashScreenManager.CloseWaitForm();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIReception));
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PrintCheckBox = new System.Windows.Forms.CheckBox();
            this.connexionCheckBox = new System.Windows.Forms.CheckBox();
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
            this.receptionGridControl = new DevExpress.XtraGrid.GridControl();
            this.receptionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Designation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Numero_lot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Qte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.receptionsDockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.listReceptionDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.refrechSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.listReceptionGridControl = new DevExpress.XtraGrid.GridControl();
            this.listReceptiongridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NBL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Qte_Scan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receptionSplashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::AlmedStockManagement.LivraisonWaitForm), true, true);
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxReceptionErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNLot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDLC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionsDockManager)).BeginInit();
            this.listReceptionDockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listReceptionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listReceptiongridView)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.PrintCheckBox);
            this.splitContainer1.Panel1.Controls.Add(this.connexionCheckBox);
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
            this.splitContainer1.Panel2.Controls.Add(this.receptionGridControl);
            this.splitContainer1.Size = new System.Drawing.Size(1004, 733);
            this.splitContainer1.SplitterDistance = 61;
            this.splitContainer1.TabIndex = 31;
            // 
            // PrintCheckBox
            // 
            this.PrintCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintCheckBox.AutoSize = true;
            this.PrintCheckBox.Location = new System.Drawing.Point(69, 33);
            this.PrintCheckBox.Name = "PrintCheckBox";
            this.PrintCheckBox.Size = new System.Drawing.Size(88, 17);
            this.PrintCheckBox.TabIndex = 33;
            this.PrintCheckBox.Text = "Printing code";
            this.PrintCheckBox.UseVisualStyleBackColor = true;
            // 
            // connexionCheckBox
            // 
            this.connexionCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connexionCheckBox.AutoSize = true;
            this.connexionCheckBox.Checked = true;
            this.connexionCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.connexionCheckBox.Location = new System.Drawing.Point(69, 12);
            this.connexionCheckBox.Name = "connexionCheckBox";
            this.connexionCheckBox.Size = new System.Drawing.Size(78, 17);
            this.connexionCheckBox.TabIndex = 32;
            this.connexionCheckBox.Text = "Connected";
            this.connexionCheckBox.UseVisualStyleBackColor = true;
            // 
            // validationSButton
            // 
            this.validationSButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.validationSButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.validationSButton.Enabled = false;
            this.validationSButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("validationSButton.ImageOptions.Image")));
            this.validationSButton.Location = new System.Drawing.Point(958, 12);
            this.validationSButton.Name = "validationSButton";
            this.validationSButton.Size = new System.Drawing.Size(42, 38);
            this.validationSButton.TabIndex = 26;
            this.validationSButton.Click += new System.EventHandler(this.ValidationSButton_Click);
            // 
            // scanSButton
            // 
            this.scanSButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scanSButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.scanSButton.Enabled = false;
            this.scanSButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("scanSButton.ImageOptions.Image")));
            this.scanSButton.Location = new System.Drawing.Point(910, 12);
            this.scanSButton.Name = "scanSButton";
            this.scanSButton.Size = new System.Drawing.Size(42, 38);
            this.scanSButton.TabIndex = 30;
            this.scanSButton.Click += new System.EventHandler(this.ScanSButton_Click);
            // 
            // teCode
            // 
            this.teCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teCode.EditValue = "";
            this.teCode.Enabled = false;
            this.teCode.Location = new System.Drawing.Point(566, 21);
            this.teCode.Name = "teCode";
            this.teCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.teCode.Size = new System.Drawing.Size(100, 20);
            this.teCode.TabIndex = 23;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(837, 2);
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
            this.codeTextEdit.Location = new System.Drawing.Point(194, 21);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.codeTextEdit.Size = new System.Drawing.Size(349, 20);
            this.codeTextEdit.TabIndex = 21;
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(711, 2);
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
            this.teNLot.Location = new System.Drawing.Point(672, 21);
            this.teNLot.Name = "teNLot";
            this.teNLot.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.teNLot.Size = new System.Drawing.Size(126, 20);
            this.teNLot.TabIndex = 24;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(607, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Code :";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(329, 2);
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
            this.teDLC.Location = new System.Drawing.Point(804, 21);
            this.teDLC.Name = "teDLC";
            this.teDLC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.teDLC.Size = new System.Drawing.Size(100, 20);
            this.teDLC.TabIndex = 25;
            // 
            // receptionGridControl
            // 
            this.receptionGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receptionGridControl.Location = new System.Drawing.Point(0, 0);
            this.receptionGridControl.MainView = this.receptionGridView;
            this.receptionGridControl.Name = "receptionGridControl";
            this.receptionGridControl.Size = new System.Drawing.Size(1004, 668);
            this.receptionGridControl.TabIndex = 21;
            this.receptionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.receptionGridView,
            this.gridView1});
            // 
            // receptionGridView
            // 
            this.receptionGridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.receptionGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Code,
            this.Designation,
            this.Numero_lot,
            this.DLC,
            this.Qte,
            this.gridColumn5});
            this.receptionGridView.GridControl = this.receptionGridControl;
            this.receptionGridView.Name = "receptionGridView";
            this.receptionGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.receptionGridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.receptionGridView.OptionsSelection.EnableAppearanceHideSelection = false;
            this.receptionGridView.OptionsView.ShowGroupPanel = false;
            this.receptionGridView.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.ReceptionGridView_RowStyle);
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
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "QteScannee";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.OptionsColumn.AllowMove = false;
            this.gridColumn5.OptionsColumn.AllowSize = false;
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 67;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.receptionGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // receptionsDockManager
            // 
            this.receptionsDockManager.DockingOptions.ShowCloseButton = false;
            this.receptionsDockManager.Form = this;
            this.receptionsDockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.listReceptionDockPanel});
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
            // listReceptionDockPanel
            // 
            this.listReceptionDockPanel.Controls.Add(this.dockPanel1_Container);
            this.listReceptionDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.listReceptionDockPanel.ID = new System.Guid("8fd31b9f-54d2-4a39-ba04-6c87fb21bad5");
            this.listReceptionDockPanel.Location = new System.Drawing.Point(0, 0);
            this.listReceptionDockPanel.Name = "listReceptionDockPanel";
            this.listReceptionDockPanel.OriginalSize = new System.Drawing.Size(350, 200);
            this.listReceptionDockPanel.Size = new System.Drawing.Size(350, 733);
            this.listReceptionDockPanel.Text = "Liste Reception";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.refrechSimpleButton);
            this.dockPanel1_Container.Controls.Add(this.listReceptionGridControl);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(341, 706);
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
            this.refrechSimpleButton.Location = new System.Drawing.Point(256, 0);
            this.refrechSimpleButton.Name = "refrechSimpleButton";
            this.refrechSimpleButton.Size = new System.Drawing.Size(85, 33);
            this.refrechSimpleButton.TabIndex = 44;
            this.refrechSimpleButton.Text = "Refresh";
            // 
            // listReceptionGridControl
            // 
            this.listReceptionGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listReceptionGridControl.Location = new System.Drawing.Point(0, 0);
            this.listReceptionGridControl.MainView = this.listReceptiongridView;
            this.listReceptionGridControl.Name = "listReceptionGridControl";
            this.listReceptionGridControl.Size = new System.Drawing.Size(341, 706);
            this.listReceptionGridControl.TabIndex = 33;
            this.listReceptionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.listReceptiongridView});
            // 
            // listReceptiongridView
            // 
            this.listReceptiongridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.listReceptiongridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.NBL,
            this.gridColumn7,
            this.date});
            this.listReceptiongridView.GridControl = this.listReceptionGridControl;
            this.listReceptiongridView.Name = "listReceptiongridView";
            this.listReceptiongridView.OptionsCustomization.AllowColumnResizing = false;
            this.listReceptiongridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.ListReceptiongridView_RowClick);
            this.listReceptiongridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.ListReceptiongridView_RowCellClick);
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "Code";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Width = 54;
            // 
            // NBL
            // 
            this.NBL.FieldName = "NBL";
            this.NBL.Name = "NBL";
            this.NBL.OptionsColumn.AllowEdit = false;
            this.NBL.Visible = true;
            this.NBL.VisibleIndex = 0;
            this.NBL.Width = 102;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "NomClient";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 117;
            // 
            // date
            // 
            this.date.FieldName = "Date";
            this.date.Name = "date";
            this.date.OptionsColumn.AllowEdit = false;
            this.date.Visible = true;
            this.date.VisibleIndex = 2;
            this.date.Width = 106;
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
            // receptionSplashScreenManager
            // 
            this.receptionSplashScreenManager.ClosingDelay = 500;
            // 
            // timer
            // 
            this.timer.Interval = 200000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // UIReception
            // 
            this.AcceptButton = this.scanSButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.listReceptionDockPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "UIReception";
            this.Text = "Reception";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UIReception_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxReceptionErrorProvider)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNLot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDLC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionsDockManager)).EndInit();
            this.listReceptionDockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listReceptionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listReceptiongridView)).EndInit();
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
        private DevExpress.XtraGrid.GridControl receptionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView receptionGridView;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Code;
        private DevExpress.XtraGrid.Columns.GridColumn Designation;
        private DevExpress.XtraGrid.Columns.GridColumn Numero_lot;
        private DevExpress.XtraGrid.Columns.GridColumn DLC;
        private DevExpress.XtraGrid.Columns.GridColumn Qte;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Docking.DockManager receptionsDockManager;
        private DevExpress.XtraBars.Docking.DockPanel listReceptionDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraGrid.GridControl listReceptionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView listReceptiongridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn NBL;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn date;
        private CheckBox connexionCheckBox;
        private CheckBox PrintCheckBox;
        private DevExpress.XtraGrid.Columns.GridColumn Qte_Scan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraSplashScreen.SplashScreenManager receptionSplashScreenManager;
        private Timer timer;
        private SimpleButton refrechSimpleButton;
    }
}