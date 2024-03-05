﻿
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.linkLabelCreateAccount = new System.Windows.Forms.LinkLabel();
            this.linkLabelForgetPassword = new System.Windows.Forms.LinkLabel();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelRoadPassword = new System.Windows.Forms.Panel();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.panelRoadAccount = new System.Windows.Forms.Panel();
            this.pictureBoxAccount = new System.Windows.Forms.PictureBox();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonComback = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccount)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.linkLabelCreateAccount);
            this.panelLogin.Controls.Add(this.linkLabelForgetPassword);
            this.panelLogin.Controls.Add(this.pictureBoxIcon);
            this.panelLogin.Controls.Add(this.panelPassword);
            this.panelLogin.Controls.Add(this.panelAccount);
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(475, 165);
            this.panelLogin.TabIndex = 0;
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.Location = new System.Drawing.Point(270, 112);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(88, 27);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLoginClick);
            // 
            // linkLabelCreateAccount
            // 
            this.linkLabelCreateAccount.AutoSize = true;
            this.linkLabelCreateAccount.Location = new System.Drawing.Point(364, 142);
            this.linkLabelCreateAccount.Name = "linkLabelCreateAccount";
            this.linkLabelCreateAccount.Size = new System.Drawing.Size(95, 17);
            this.linkLabelCreateAccount.TabIndex = 4;
            this.linkLabelCreateAccount.TabStop = true;
            this.linkLabelCreateAccount.Text = "Tạo tài khoản";
            this.linkLabelCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelCreateAccountLinkClicked);
            // 
            // linkLabelForgetPassword
            // 
            this.linkLabelForgetPassword.AutoSize = true;
            this.linkLabelForgetPassword.Location = new System.Drawing.Point(241, 142);
            this.linkLabelForgetPassword.Name = "linkLabelForgetPassword";
            this.linkLabelForgetPassword.Size = new System.Drawing.Size(117, 17);
            this.linkLabelForgetPassword.TabIndex = 3;
            this.linkLabelForgetPassword.TabStop = true;
            this.linkLabelForgetPassword.Text = "Quên mật khẩu ?";
            this.linkLabelForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelForgetPasswordLinkClicked);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 3;
            this.pictureBoxIcon.TabStop = false;
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.textBoxPassword);
            this.panelPassword.Controls.Add(this.panelRoadPassword);
            this.panelPassword.Controls.Add(this.pictureBoxPassword);
            this.panelPassword.Location = new System.Drawing.Point(159, 56);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(314, 50);
            this.panelPassword.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(59, 8);
            this.textBoxPassword.MaxLength = 16;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(234, 27);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPasswordKeyPress);
            // 
            // panelRoadPassword
            // 
            this.panelRoadPassword.BackColor = System.Drawing.Color.Aqua;
            this.panelRoadPassword.Location = new System.Drawing.Point(19, 38);
            this.panelRoadPassword.Name = "panelRoadPassword";
            this.panelRoadPassword.Size = new System.Drawing.Size(274, 3);
            this.panelRoadPassword.TabIndex = 4;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPassword.Image")));
            this.pictureBoxPassword.Location = new System.Drawing.Point(18, 8);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 3;
            this.pictureBoxPassword.TabStop = false;
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.panelRoadAccount);
            this.panelAccount.Controls.Add(this.pictureBoxAccount);
            this.panelAccount.Controls.Add(this.textBoxAccount);
            this.panelAccount.Location = new System.Drawing.Point(159, 3);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(314, 50);
            this.panelAccount.TabIndex = 0;
            // 
            // panelRoadAccount
            // 
            this.panelRoadAccount.BackColor = System.Drawing.Color.Aqua;
            this.panelRoadAccount.Location = new System.Drawing.Point(19, 38);
            this.panelRoadAccount.Name = "panelRoadAccount";
            this.panelRoadAccount.Size = new System.Drawing.Size(274, 3);
            this.panelRoadAccount.TabIndex = 3;
            // 
            // pictureBoxAccount
            // 
            this.pictureBoxAccount.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAccount.Image")));
            this.pictureBoxAccount.Location = new System.Drawing.Point(19, 8);
            this.pictureBoxAccount.Name = "pictureBoxAccount";
            this.pictureBoxAccount.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAccount.TabIndex = 2;
            this.pictureBoxAccount.TabStop = false;
            // 
            // textBoxAccount
            // 
            this.textBoxAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAccount.Location = new System.Drawing.Point(59, 8);
            this.textBoxAccount.MaxLength = 11;
            this.textBoxAccount.Multiline = true;
            this.textBoxAccount.Name = "textBoxAccount";
            this.textBoxAccount.Size = new System.Drawing.Size(234, 30);
            this.textBoxAccount.TabIndex = 1;
            this.textBoxAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAccountKeyPress);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMain.Controls.Add(this.panelLogin);
            this.panelMain.Location = new System.Drawing.Point(0, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(475, 205);
            this.panelMain.TabIndex = 0;
            // 
            // buttonComback
            // 
            this.buttonComback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonComback.BackgroundImage")));
            this.buttonComback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonComback.Location = new System.Drawing.Point(410, 5);
            this.buttonComback.Name = "buttonComback";
            this.buttonComback.Size = new System.Drawing.Size(45, 30);
            this.buttonComback.TabIndex = 1;
            this.buttonComback.UseVisualStyleBackColor = true;
            this.buttonComback.Visible = false;
            this.buttonComback.Click += new System.EventHandler(this.ButtonCombackClick);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1211, 626);
            this.Controls.Add(this.buttonComback);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLogin";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccount)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.LinkLabel linkLabelCreateAccount;
        private System.Windows.Forms.LinkLabel linkLabelForgetPassword;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.Panel panelRoadAccount;
        private System.Windows.Forms.PictureBox pictureBoxAccount;
        private System.Windows.Forms.Panel panelRoadPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonComback;
    }
}