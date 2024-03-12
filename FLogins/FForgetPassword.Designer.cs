﻿
namespace Project
{
    partial class FForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FForgetPassword));
            this.buttonFindAccount = new System.Windows.Forms.Button();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.buttonUpdatePassword = new System.Windows.Forms.Button();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.userControlTextBoxPassword = new Project.UserControls.UserControlTextBoxPassword();
            this.userControlTextBoxAccount = new Project.UserControls.UserControlTextBoxAccount();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelPassword.SuspendLayout();
            this.panelAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFindAccount
            // 
            this.buttonFindAccount.AutoSize = true;
            this.buttonFindAccount.Location = new System.Drawing.Point(100, 51);
            this.buttonFindAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFindAccount.Name = "buttonFindAccount";
            this.buttonFindAccount.Size = new System.Drawing.Size(137, 30);
            this.buttonFindAccount.TabIndex = 1;
            this.buttonFindAccount.Text = "Tìm tài khoản";
            this.buttonFindAccount.UseVisualStyleBackColor = true;
            this.buttonFindAccount.Click += new System.EventHandler(this.ButtonFindAccountClick);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(12, 30);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(170, 170);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 3;
            this.pictureBoxIcon.TabStop = false;
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.userControlTextBoxPassword);
            this.panelPassword.Controls.Add(this.buttonUpdatePassword);
            this.panelPassword.Location = new System.Drawing.Point(185, 128);
            this.panelPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(315, 85);
            this.panelPassword.TabIndex = 2;
            this.panelPassword.TabStop = true;
            this.panelPassword.Visible = false;
            // 
            // buttonUpdatePassword
            // 
            this.buttonUpdatePassword.AutoSize = true;
            this.buttonUpdatePassword.Location = new System.Drawing.Point(118, 51);
            this.buttonUpdatePassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdatePassword.Name = "buttonUpdatePassword";
            this.buttonUpdatePassword.Size = new System.Drawing.Size(105, 30);
            this.buttonUpdatePassword.TabIndex = 1;
            this.buttonUpdatePassword.Text = "Cập nhật";
            this.buttonUpdatePassword.UseVisualStyleBackColor = true;
            this.buttonUpdatePassword.Click += new System.EventHandler(this.ButtonUpdatePasswordClick);
            // 
            // panelAccount
            // 
            this.panelAccount.Controls.Add(this.userControlTextBoxAccount);
            this.panelAccount.Controls.Add(this.buttonFindAccount);
            this.panelAccount.Location = new System.Drawing.Point(187, 43);
            this.panelAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(315, 85);
            this.panelAccount.TabIndex = 1;
            this.panelAccount.TabStop = true;
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.Location = new System.Drawing.Point(456, 22);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(35, 27);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.Back);
            // 
            // userControlTextBoxPassword
            // 
            this.userControlTextBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxPassword.LableText = "Mật khẩu mới";
            this.userControlTextBoxPassword.Location = new System.Drawing.Point(0, 0);
            this.userControlTextBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlTextBoxPassword.Name = "userControlTextBoxPassword";
            this.userControlTextBoxPassword.Size = new System.Drawing.Size(315, 50);
            this.userControlTextBoxPassword.TabIndex = 0;
            this.userControlTextBoxPassword.TextBoxText = "";
            // 
            // userControlTextBoxAccount
            // 
            this.userControlTextBoxAccount.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxAccount.Location = new System.Drawing.Point(0, 0);
            this.userControlTextBoxAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userControlTextBoxAccount.Name = "userControlTextBoxAccount";
            this.userControlTextBoxAccount.Size = new System.Drawing.Size(315, 50);
            this.userControlTextBoxAccount.TabIndex = 0;
            this.userControlTextBoxAccount.TextBoxText = "";
            // 
            // FForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 246);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panelAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FForgotPassword";
            this.Load += new System.EventHandler(this.FForgetPasswordLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFindAccount;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Button buttonUpdatePassword;
        private UserControls.UserControlTextBoxAccount userControlTextBoxAccount;
        private System.Windows.Forms.Button buttonBack;
        private UserControls.UserControlTextBoxPassword userControlTextBoxPassword;
    }
}