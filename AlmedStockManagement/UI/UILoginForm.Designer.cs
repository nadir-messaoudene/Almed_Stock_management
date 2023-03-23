namespace AlmedStockManagement
{
    partial class UILoginForm
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
            System.Windows.Forms.TextBox passwordTextEditor;
            this.cuncelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.testConnexioSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.loginTextEdit = new DevExpress.XtraEditors.TextEdit();
            passwordTextEditor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // passwordTextEditor
            // 
            passwordTextEditor.Location = new System.Drawing.Point(236, 75);
            passwordTextEditor.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            passwordTextEditor.Name = "passwordTextEditor";
            passwordTextEditor.PasswordChar = '*';
            passwordTextEditor.Size = new System.Drawing.Size(298, 31);
            passwordTextEditor.TabIndex = 15;
            passwordTextEditor.Text = "0000000000";
            // 
            // cuncelSimpleButton
            // 
            this.cuncelSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cuncelSimpleButton.Location = new System.Drawing.Point(418, 148);
            this.cuncelSimpleButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cuncelSimpleButton.Name = "cuncelSimpleButton";
            this.cuncelSimpleButton.Size = new System.Drawing.Size(122, 67);
            this.cuncelSimpleButton.TabIndex = 17;
            this.cuncelSimpleButton.Text = "cancel";
            this.cuncelSimpleButton.Click += new System.EventHandler(this.CuncelSimpleButton_Click);
            // 
            // testConnexioSimpleButton
            // 
            this.testConnexioSimpleButton.Location = new System.Drawing.Point(262, 148);
            this.testConnexioSimpleButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.testConnexioSimpleButton.Name = "testConnexioSimpleButton";
            this.testConnexioSimpleButton.Size = new System.Drawing.Size(122, 67);
            this.testConnexioSimpleButton.TabIndex = 16;
            this.testConnexioSimpleButton.Text = "Login";
            this.testConnexioSimpleButton.Click += new System.EventHandler(this.TestConnexioSimpleButton_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(62, 23);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 25);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Login :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(62, 88);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(102, 25);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Password :";
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.EditValue = "";
            this.loginTextEdit.Location = new System.Drawing.Point(236, 17);
            this.loginTextEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loginTextEdit.Name = "loginTextEdit";
            // 
            // 
            // 
            this.loginTextEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.loginTextEdit.Size = new System.Drawing.Size(302, 34);
            this.loginTextEdit.TabIndex = 14;
            // 
            // UILoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 256);
            this.Controls.Add(passwordTextEditor);
            this.Controls.Add(this.cuncelSimpleButton);
            this.Controls.Add(this.testConnexioSimpleButton);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.loginTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "UILoginForm";
            this.Text = "UILoginForm";
            this.Load += new System.EventHandler(this.UILoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cuncelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton testConnexioSimpleButton;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit loginTextEdit;
    }
}