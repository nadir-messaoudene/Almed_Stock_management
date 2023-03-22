namespace AlmedStockManagement
{
    partial class UILivraison
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.livraisonTreeList = new DevExpress.XtraTreeList.TreeList();
            this.livraisonGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livraisonTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livraisonGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.livraisonTreeList);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.splitContainerControl1.Panel2.Controls.Add(this.livraisonGridControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(979, 499);
            this.splitContainerControl1.SplitterPosition = 408;
            this.splitContainerControl1.TabIndex = 4;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // livraisonTreeList
            // 
            this.livraisonTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.livraisonTreeList.Location = new System.Drawing.Point(0, 0);
            this.livraisonTreeList.Name = "livraisonTreeList";
            this.livraisonTreeList.Size = new System.Drawing.Size(408, 499);
            this.livraisonTreeList.TabIndex = 1;
            // 
            // livraisonGridControl
            // 
            this.livraisonGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.livraisonGridControl.Location = new System.Drawing.Point(0, 0);
            this.livraisonGridControl.MainView = this.gridView1;
            this.livraisonGridControl.Name = "livraisonGridControl";
            this.livraisonGridControl.Size = new System.Drawing.Size(562, 495);
            this.livraisonGridControl.TabIndex = 0;
            this.livraisonGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.livraisonGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // UILivraison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 499);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "UILivraison";
            this.Text = "UILivraison";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.livraisonTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livraisonGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTreeList.TreeList livraisonTreeList;
        private DevExpress.XtraGrid.GridControl livraisonGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}