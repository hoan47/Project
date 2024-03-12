
namespace Project
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.linkLabelCreateAccount = new System.Windows.Forms.LinkLabel();
            this.linkLabelForgetPassword = new System.Windows.Forms.LinkLabel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.userControlTextBoxPassword = new Project.UserControls.UserControlTextBoxPassword();
            this.userControlTextBoxAccount = new Project.UserControls.UserControlTextBoxAccount();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelCreateAccount
            // 
            this.linkLabelCreateAccount.AutoSize = true;
            this.linkLabelCreateAccount.Location = new System.Drawing.Point(292, 145);
            this.linkLabelCreateAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelCreateAccount.Name = "linkLabelCreateAccount";
            this.linkLabelCreateAccount.Size = new System.Drawing.Size(73, 13);
            this.linkLabelCreateAccount.TabIndex = 5;
            this.linkLabelCreateAccount.TabStop = true;
            this.linkLabelCreateAccount.Text = "Tạo tài khoản";
            this.linkLabelCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelCreateAccountLinkClicked);
            // 
            // linkLabelForgetPassword
            // 
            this.linkLabelForgetPassword.AutoSize = true;
            this.linkLabelForgetPassword.Location = new System.Drawing.Point(213, 145);
            this.linkLabelForgetPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabelForgetPassword.Name = "linkLabelForgetPassword";
            this.linkLabelForgetPassword.Size = new System.Drawing.Size(80, 13);
            this.linkLabelForgetPassword.TabIndex = 4;
            this.linkLabelForgetPassword.TabStop = true;
            this.linkLabelForgetPassword.Text = "Quên mật khẩu";
            this.linkLabelForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelForgetPasswordLinkClicked);
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.Location = new System.Drawing.Point(229, 120);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(70, 23);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLoginClick);
            // 
            // userControlTextBoxPassword
            // 
            this.userControlTextBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxPassword.LableText = "Mật khẩu";
            this.userControlTextBoxPassword.Location = new System.Drawing.Point(138, 78);
            this.userControlTextBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlTextBoxPassword.Name = "userControlTextBoxPassword";
            this.userControlTextBoxPassword.Size = new System.Drawing.Size(236, 38);
            this.userControlTextBoxPassword.TabIndex = 2;
            this.userControlTextBoxPassword.TextBoxText = "";
            // 
            // userControlTextBoxAccount
            // 
            this.userControlTextBoxAccount.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxAccount.Location = new System.Drawing.Point(138, 38);
            this.userControlTextBoxAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlTextBoxAccount.Name = "userControlTextBoxAccount";
            this.userControlTextBoxAccount.Size = new System.Drawing.Size(236, 41);
            this.userControlTextBoxAccount.TabIndex = 1;
            this.userControlTextBoxAccount.TextBoxText = "";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(23, 34);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(112, 122);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 3;
            this.pictureBoxIcon.TabStop = false;
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.userControlTextBoxPassword);
            this.Controls.Add(this.userControlTextBoxAccount);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.linkLabelCreateAccount);
            this.Controls.Add(this.linkLabelForgetPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLogin";
            this.Load += new System.EventHandler(this.FLoginLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelCreateAccount;
        private System.Windows.Forms.LinkLabel linkLabelForgetPassword;
        private System.Windows.Forms.Button buttonLogin;
        private UserControls.UserControlTextBoxAccount userControlTextBoxAccount;
        private UserControls.UserControlTextBoxPassword userControlTextBoxPassword;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
    }
}