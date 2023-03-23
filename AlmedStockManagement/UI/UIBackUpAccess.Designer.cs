namespace AlmedStockManagement
{
    partial class UIBackUpAccess
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
            this.backUpDefaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.serverTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cuncelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.BackUpSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.connexionStringTextEditor = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.GetSourceDirectorySimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.GetBukupDirectorySimpleButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.serverTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl6.Location = new System.Drawing.Point(15, 83);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(87, 13);
            this.labelControl6.TabIndex = 27;
            this.labelControl6.Text = "Source Directory :";
            // 
            // serverTextEdit
            // 
            this.serverTextEdit.Location = new System.Drawing.Point(139, 80);
            this.serverTextEdit.Name = "serverTextEdit";
            this.serverTextEdit.Size = new System.Drawing.Size(210, 20);
            this.serverTextEdit.TabIndex = 28;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(139, 106);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(210, 20);
            this.textEdit1.TabIndex = 30;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Location = new System.Drawing.Point(15, 109);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 13);
            this.labelControl1.TabIndex = 29;
            this.labelControl1.Text = "Backup Directory :";
            // 
            // cuncelSimpleButton
            // 
            this.cuncelSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cuncelSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cuncelSimpleButton.Location = new System.Drawing.Point(317, 381);
            this.cuncelSimpleButton.Name = "cuncelSimpleButton";
            this.cuncelSimpleButton.Size = new System.Drawing.Size(61, 35);
            this.cuncelSimpleButton.TabIndex = 33;
            this.cuncelSimpleButton.Text = "cancel";
            this.cuncelSimpleButton.Click += new System.EventHandler(this.CuncelSimpleButton_Click);
            // 
            // BackUpSimpleButton
            // 
            this.BackUpSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BackUpSimpleButton.Enabled = false;
            this.BackUpSimpleButton.Location = new System.Drawing.Point(248, 381);
            this.BackUpSimpleButton.Name = "BackUpSimpleButton";
            this.BackUpSimpleButton.Size = new System.Drawing.Size(61, 35);
            this.BackUpSimpleButton.TabIndex = 32;
            this.BackUpSimpleButton.Text = "Back up";
            this.BackUpSimpleButton.Click += new System.EventHandler(this.BackUpSimpleButton_Click);
            // 
            // connexionStringTextEditor
            // 
            this.connexionStringTextEditor.Location = new System.Drawing.Point(90, 200);
            this.connexionStringTextEditor.Multiline = true;
            this.connexionStringTextEditor.Name = "connexionStringTextEditor";
            this.connexionStringTextEditor.Size = new System.Drawing.Size(303, 130);
            this.connexionStringTextEditor.TabIndex = 34;
            this.connexionStringTextEditor.Text = "Xcopy  D:\\Data \\\\192.168.1.6\\Volume_1\\Buckup  /M /E /G /H /Y";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Location = new System.Drawing.Point(15, 241);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 13);
            this.labelControl5.TabIndex = 35;
            this.labelControl5.Text = "Backup.bat :";
            // 
            // GetSourceDirectorySimpleButton
            // 
            this.GetSourceDirectorySimpleButton.Location = new System.Drawing.Point(355, 78);
            this.GetSourceDirectorySimpleButton.Name = "GetSourceDirectorySimpleButton";
            this.GetSourceDirectorySimpleButton.Size = new System.Drawing.Size(23, 26);
            this.GetSourceDirectorySimpleButton.TabIndex = 38;
            this.GetSourceDirectorySimpleButton.Text = "...";
            this.GetSourceDirectorySimpleButton.Click += new System.EventHandler(this.GetDirectorySimpleButton_Click);
            // 
            // GetBukupDirectorySimpleButton
            // 
            this.GetBukupDirectorySimpleButton.Location = new System.Drawing.Point(355, 103);
            this.GetBukupDirectorySimpleButton.Name = "GetBukupDirectorySimpleButton";
            this.GetBukupDirectorySimpleButton.Size = new System.Drawing.Size(23, 26);
            this.GetBukupDirectorySimpleButton.TabIndex = 39;
            this.GetBukupDirectorySimpleButton.Text = "...";
            this.GetBukupDirectorySimpleButton.Click += new System.EventHandler(this.GetBukupDirectorySimpleButton_Click);
            // 
            // UIBackUpAccess
            // 
            this.AcceptButton = this.BackUpSimpleButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cuncelSimpleButton;
            this.ClientSize = new System.Drawing.Size(405, 440);
            this.Controls.Add(this.GetBukupDirectorySimpleButton);
            this.Controls.Add(this.GetSourceDirectorySimpleButton);
            this.Controls.Add(this.connexionStringTextEditor);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cuncelSimpleButton);
            this.Controls.Add(this.BackUpSimpleButton);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.serverTextEdit);
            this.Controls.Add(this.labelControl6);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UIBackUpAccess";
            this.Text = "UIBackUpAccess";
            ((System.ComponentModel.ISupportInitialize)(this.serverTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel backUpDefaultLookAndFeel;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit serverTextEdit;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton cuncelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton BackUpSimpleButton;
        private System.Windows.Forms.TextBox connexionStringTextEditor;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton GetSourceDirectorySimpleButton;
        private DevExpress.XtraEditors.SimpleButton GetBukupDirectorySimpleButton;
    }
}