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
        DataServices.Service dataServeces = new DataServices.Service();
        private List<BonLivraison> br = new List<BonLivraison>();
        private List<BonLivraisonLigne> brl = new List<BonLivraisonLigne>();
        private bool check = false;
        private GridCheckMarksSelection MarkSelection;
        private string SuplayName = string.Empty;
        //private Items item = new Items();
        private List<BonLivraisonLigne> lignesSelected;
        private string idBonReception = null;


        /// <summary>
        /// bending receptions
        /// </summary>
        private bool BendingRecetionTreeList() {
            try
            {
                receptionListBindingSource.DataSource = br = dataServeces.getBonReception();
                return true;
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool BendingListReceptionlinebById()
        {
            try
            {
                idBonReception = listReceptiongridView.GetRowCellValue(listReceptiongridView.FocusedRowHandle, "id").ToString();
                SuplayName = Util.GetSyplayName(listReceptiongridView.GetRowCellValue(listReceptiongridView.FocusedRowHandle, "NomClient").ToString());
                receptionLineListBindingSource.DataSource = brl = dataServeces.getLigneBonReceptionById(idBonReception);
                if (!check)
                {
                    MarkSelection = new GridCheckMarksSelection(receptionGridView);
                    MarkSelection.View.OptionsBehavior.Editable = false;
                    check = true;
                }

                EnableInput(true);

                return true;
            }
            catch (Exception ex)
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIReception));
            this.receptionListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.listReceptionGridControl = new DevExpress.XtraGrid.GridControl();
            this.listReceptiongridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.scanSButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.validationSButton = new DevExpress.XtraEditors.SimpleButton();
            this.teDLC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.teNLot = new DevExpress.XtraEditors.TextEdit();
            this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.teCode = new DevExpress.XtraEditors.TextEdit();
            this.receptionGridControl = new DevExpress.XtraGrid.GridControl();
            this.receptionLineListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receptionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Designation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.dxReceptionErrorProvider = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.receptionListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listReceptionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listReceptiongridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teDLC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNLot.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionLineListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxReceptionErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 741);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerControl1.Location = new System.Drawing.Point(3, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.listReceptionGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1359, 716);
            this.splitContainerControl1.SplitterPosition = 371;
            this.splitContainerControl1.TabIndex = 3;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // listReceptionGridControl
            // 
            this.listReceptionGridControl.DataSource = this.receptionListBindingSource;
            this.listReceptionGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listReceptionGridControl.Location = new System.Drawing.Point(0, 0);
            this.listReceptionGridControl.MainView = this.listReceptiongridView;
            this.listReceptionGridControl.Name = "listReceptionGridControl";
            this.listReceptionGridControl.Size = new System.Drawing.Size(371, 716);
            this.listReceptionGridControl.TabIndex = 1;
            this.listReceptionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.listReceptiongridView});
            // 
            // listReceptiongridView
            // 
            this.listReceptiongridView.GridControl = this.listReceptionGridControl;
            this.listReceptiongridView.Name = "listReceptiongridView";
            this.listReceptiongridView.OptionsPrint.EnableAppearanceEvenRow = true;
            this.listReceptiongridView.OptionsPrint.EnableAppearanceOddRow = true;
            this.listReceptiongridView.OptionsPrint.PrintDetails = true;
            this.listReceptiongridView.OptionsPrint.PrintFilterInfo = true;
            this.listReceptiongridView.OptionsPrint.PrintPreview = true;
            this.listReceptiongridView.OptionsPrint.PrintSelectedRowsOnly = true;
            this.listReceptiongridView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.listReceptiongridView_RowClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.AutoScrollMinSize = new System.Drawing.Size(42, 64);
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.splitContainer1.Panel1.Controls.Add(this.scanSButton);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.validationSButton);
            this.splitContainer1.Panel1.Controls.Add(this.teDLC);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.teNLot);
            this.splitContainer1.Panel1.Controls.Add(this.codeTextEdit);
            this.splitContainer1.Panel1.Controls.Add(this.teCode);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.receptionGridControl);
            this.splitContainer1.Size = new System.Drawing.Size(979, 712);
            this.splitContainer1.SplitterDistance = 67;
            this.splitContainer1.TabIndex = 1;
            // 
            // scanSButton
            // 
            this.scanSButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scanSButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.scanSButton.Enabled = false;
            this.scanSButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("scanSButton.ImageOptions.Image")));
            this.scanSButton.Location = new System.Drawing.Point(879, 10);
            this.scanSButton.Name = "scanSButton";
            this.scanSButton.Size = new System.Drawing.Size(42, 45);
            this.scanSButton.TabIndex = 8;
            this.scanSButton.Click += new System.EventHandler(this.scanSButton_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Location = new System.Drawing.Point(783, 13);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "DLC :";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl3.Location = new System.Drawing.Point(662, 13);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "N Lot :";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(553, 13);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Code :";
            // 
            // validationSButton
            // 
            this.validationSButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.validationSButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.validationSButton.Enabled = false;
            this.validationSButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("validationSButton.ImageOptions.Image")));
            this.validationSButton.Location = new System.Drawing.Point(927, 14);
            this.validationSButton.Name = "validationSButton";
            this.validationSButton.Size = new System.Drawing.Size(42, 38);
            this.validationSButton.TabIndex = 4;
            this.validationSButton.Click += new System.EventHandler(this.validationSButton_Click);
            // 
            // teDLC
            // 
            this.teDLC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teDLC.EditValue = "";
            this.teDLC.Enabled = false;
            this.teDLC.Location = new System.Drawing.Point(751, 28);
            this.teDLC.Name = "teDLC";
            this.teDLC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.teDLC.Size = new System.Drawing.Size(100, 20);
            this.teDLC.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(114, 10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(30, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Scan :";
            // 
            // teNLot
            // 
            this.teNLot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teNLot.EditValue = "";
            this.teNLot.Enabled = false;
            this.teNLot.Location = new System.Drawing.Point(619, 28);
            this.teNLot.Name = "teNLot";
            this.teNLot.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.teNLot.Size = new System.Drawing.Size(126, 20);
            this.teNLot.TabIndex = 2;
            // 
            // codeTextEdit
            // 
            this.codeTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.codeTextEdit.EditValue = "";
            this.codeTextEdit.Enabled = false;
            this.codeTextEdit.Location = new System.Drawing.Point(149, 28);
            this.codeTextEdit.Name = "codeTextEdit";
            this.codeTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.codeTextEdit.Size = new System.Drawing.Size(349, 20);
            this.codeTextEdit.TabIndex = 0;
            this.codeTextEdit.Validated += new System.EventHandler(this.codeTextEdit_Validated);
            // 
            // teCode
            // 
            this.teCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teCode.EditValue = "";
            this.teCode.Enabled = false;
            this.teCode.Location = new System.Drawing.Point(513, 28);
            this.teCode.Name = "teCode";
            this.teCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.teCode.Size = new System.Drawing.Size(100, 20);
            this.teCode.TabIndex = 1;
            // 
            // receptionGridControl
            // 
            this.receptionGridControl.DataSource = this.receptionLineListBindingSource;
            this.receptionGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receptionGridControl.Location = new System.Drawing.Point(0, 0);
            this.receptionGridControl.MainView = this.receptionGridView;
            this.receptionGridControl.Name = "receptionGridControl";
            this.receptionGridControl.Size = new System.Drawing.Size(979, 641);
            this.receptionGridControl.TabIndex = 2;
            this.receptionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.receptionGridView});
            // 
            // receptionGridView
            // 
            this.receptionGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.Designation,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11});
            this.receptionGridView.GridControl = this.receptionGridControl;
            this.receptionGridView.Name = "receptionGridView";
            this.receptionGridView.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.receptionGridView_RowStyle);
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "id";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 56;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "Code";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 79;
            // 
            // Designation
            // 
            this.Designation.Caption = "Designation";
            this.Designation.FieldName = "Designation";
            this.Designation.Name = "Designation";
            this.Designation.Visible = true;
            this.Designation.VisibleIndex = 2;
            this.Designation.Width = 459;
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "NLot";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            this.gridColumn8.Width = 131;
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "DatePeremption";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 211;
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "Qte";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            this.gridColumn10.Width = 65;
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "QteScannee";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 6;
            this.gridColumn11.Width = 67;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 719);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1359, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
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
            // UIReception
            // 
            this.AcceptButton = this.scanSButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UIReception";
            this.Text = "UIReception";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UIReception_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.receptionListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listReceptionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listReceptiongridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teDLC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNLot.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionLineListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receptionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dxReceptionErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource receptionListBindingSource;
        private Splitter splitter1;
        private SplitContainerControl splitContainerControl1;
        private SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl listReceptionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView listReceptiongridView;
        private StatusStrip statusStrip1;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private LabelControl labelControl1;
        private TextEdit codeTextEdit;
        private BindingSource receptionLineListBindingSource;
        private DevExpress.XtraGrid.GridControl receptionGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView receptionGridView;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxReceptionErrorProvider;
        private TextEdit teDLC;
        private TextEdit teNLot;
        private TextEdit teCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private LabelControl labelControl4;
        private LabelControl labelControl3;
        private LabelControl labelControl2;
        private SimpleButton validationSButton;
        private SimpleButton scanSButton;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn Designation;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
    }
}