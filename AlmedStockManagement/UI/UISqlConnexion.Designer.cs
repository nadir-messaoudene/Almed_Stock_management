namespace AlmedStockManagement
{
    partial class UISqlConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UISqlConnexion));
            this.SqlTestDefaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.testConnexioSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.cuncelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.connexionStringTextEditor = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.serverTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.passwordTextEditor = new System.Windows.Forms.TextBox();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.dataBaseComboBox = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.providerTextEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl4.Location = new System.Drawing.Point(9, 116);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Server name :";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl1.Location = new System.Drawing.Point(9, 218);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Password :";
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loginTextEdit.EditValue = "";
            this.loginTextEdit.Location = new System.Drawing.Point(115, 181);
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.loginTextEdit.Size = new System.Drawing.Size(151, 20);
            this.loginTextEdit.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl2.Location = new System.Drawing.Point(9, 146);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Data base :";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl3.Location = new System.Drawing.Point(9, 184);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Login :";
            // 
            // testConnexioSimpleButton
            // 
            this.testConnexioSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.testConnexioSimpleButton.Location = new System.Drawing.Point(141, 407);
            this.testConnexioSimpleButton.Name = "testConnexioSimpleButton";
            this.testConnexioSimpleButton.Size = new System.Drawing.Size(101, 35);
            this.testConnexioSimpleButton.TabIndex = 7;
            this.testConnexioSimpleButton.Text = "Test Connexion";
            this.testConnexioSimpleButton.Click += new System.EventHandler(this.TestConnexioSimpleButton_Click);
            // 
            // SaveSimpleButton
            // 
            this.SaveSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveSimpleButton.Enabled = false;
            this.SaveSimpleButton.Location = new System.Drawing.Point(248, 407);
            this.SaveSimpleButton.Name = "SaveSimpleButton";
            this.SaveSimpleButton.Size = new System.Drawing.Size(61, 35);
            this.SaveSimpleButton.TabIndex = 8;
            this.SaveSimpleButton.Text = "Save";
            this.SaveSimpleButton.Click += new System.EventHandler(this.SaveSimpleButton_Click);
            // 
            // cuncelSimpleButton
            // 
            this.cuncelSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cuncelSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cuncelSimpleButton.Location = new System.Drawing.Point(315, 407);
            this.cuncelSimpleButton.Name = "cuncelSimpleButton";
            this.cuncelSimpleButton.Size = new System.Drawing.Size(61, 35);
            this.cuncelSimpleButton.TabIndex = 9;
            this.cuncelSimpleButton.Text = "cancel";
            this.cuncelSimpleButton.Click += new System.EventHandler(this.CuncelSimpleButton_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl5.Location = new System.Drawing.Point(9, 301);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(82, 13);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Connexion String";
            // 
            // connexionStringTextEditor
            // 
            this.connexionStringTextEditor.Location = new System.Drawing.Point(115, 264);
            this.connexionStringTextEditor.Multiline = true;
            this.connexionStringTextEditor.Name = "connexionStringTextEditor";
            this.connexionStringTextEditor.Size = new System.Drawing.Size(261, 104);
            this.connexionStringTextEditor.TabIndex = 6;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelControl6.Location = new System.Drawing.Point(9, 82);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(47, 13);
            this.labelControl6.TabIndex = 25;
            this.labelControl6.Text = "Provider :";
            // 
            // serverTextEdit
            // 
            this.serverTextEdit.Location = new System.Drawing.Point(115, 113);
            this.serverTextEdit.Name = "serverTextEdit";
            this.serverTextEdit.Size = new System.Drawing.Size(210, 20);
            this.serverTextEdit.TabIndex = 2;
            // 
            // passwordTextEditor
            // 
            this.passwordTextEditor.Location = new System.Drawing.Point(115, 210);
            this.passwordTextEditor.Name = "passwordTextEditor";
            this.passwordTextEditor.PasswordChar = '*';
            this.passwordTextEditor.Size = new System.Drawing.Size(151, 21);
            this.passwordTextEditor.TabIndex = 5;
            this.passwordTextEditor.Text = "1234";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(13, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Properties.ZoomPercent = 120D;
            this.pictureEdit1.Size = new System.Drawing.Size(74, 72);
            this.pictureEdit1.TabIndex = 27;
            // 
            // dataBaseComboBox
            // 
            this.dataBaseComboBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dataBaseComboBox.EditValue = "";
            this.dataBaseComboBox.Location = new System.Drawing.Point(115, 143);
            this.dataBaseComboBox.Name = "dataBaseComboBox";
            this.dataBaseComboBox.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.dataBaseComboBox.Size = new System.Drawing.Size(151, 20);
            this.dataBaseComboBox.TabIndex = 3;
            // 
            // providerTextEdit
            // 
            this.providerTextEdit.Location = new System.Drawing.Point(115, 79);
            this.providerTextEdit.Name = "providerTextEdit";
            this.providerTextEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.providerTextEdit.Properties.Items.AddRange(new object[] {
            "Microsoft SQL Server (SqlClient)",
            "Microsoft Access Database File (OLE DB)"});
            this.providerTextEdit.Size = new System.Drawing.Size(261, 20);
            this.providerTextEdit.TabIndex = 1;
            // 
            // UISqlConnexion
            // 
            this.AcceptButton = this.testConnexioSimpleButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.cuncelSimpleButton;
            this.ClientSize = new System.Drawing.Size(384, 454);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.passwordTextEditor);
            this.Controls.Add(this.serverTextEdit);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.connexionStringTextEditor);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.cuncelSimpleButton);
            this.Controls.Add(this.SaveSimpleButton);
            this.Controls.Add(this.testConnexioSimpleButton);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.loginTextEdit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.dataBaseComboBox);
            this.Controls.Add(this.providerTextEdit);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UISqlConnexion";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowMdiChildCaptionInParentTitle = true;
            this.Text = "SQL Connexion";
            this.Load += new System.EventHandler(this.UISqlConnexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serverTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel SqlTestDefaultLookAndFeel;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit loginTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton testConnexioSimpleButton;
        private DevExpress.XtraEditors.SimpleButton SaveSimpleButton;
        private DevExpress.XtraEditors.SimpleButton cuncelSimpleButton;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox connexionStringTextEditor;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit serverTextEdit;
        private System.Windows.Forms.TextBox passwordTextEditor;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit dataBaseComboBox;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.ComboBoxEdit providerTextEdit;
    }
}