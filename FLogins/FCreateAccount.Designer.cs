
namespace Project
{
    partial class FCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCreateAccount));
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.userControlTextBoxNewPassword = new Project.UserControls.UserControlTextBoxPassword();
            this.userControlTextBoxPassword = new Project.UserControls.UserControlTextBoxPassword();
            this.userControlTextBoxAccount = new Project.UserControls.UserControlTextBoxAccount();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.AutoSize = true;
            this.buttonCreateAccount.Location = new System.Drawing.Point(225, 210);
            this.buttonCreateAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(83, 23);
            this.buttonCreateAccount.TabIndex = 4;
            this.buttonCreateAccount.Text = "Tạo tài khoản";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.ButtonCreateAccountClick);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.Location = new System.Drawing.Point(350, 64);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(26, 22);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.Back);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(10, 62);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 3;
            this.pictureBoxIcon.TabStop = false;
            // 
            // userControlTextBoxNewPassword
            // 
            this.userControlTextBoxNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxNewPassword.Location = new System.Drawing.Point(149, 170);
            this.userControlTextBoxNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlTextBoxNewPassword.Name = "userControlTextBoxNewPassword";
            this.userControlTextBoxNewPassword.Size = new System.Drawing.Size(236, 40);
            this.userControlTextBoxNewPassword.TabIndex = 3;
            this.userControlTextBoxNewPassword.TextBoxText = "";
            // 
            // userControlTextBoxPassword
            // 
            this.userControlTextBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxPassword.Location = new System.Drawing.Point(149, 125);
            this.userControlTextBoxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlTextBoxPassword.Name = "userControlTextBoxPassword";
            this.userControlTextBoxPassword.Size = new System.Drawing.Size(236, 41);
            this.userControlTextBoxPassword.TabIndex = 2;
            this.userControlTextBoxPassword.TextBoxText = "";
            // 
            // userControlTextBoxAccount
            // 
            this.userControlTextBoxAccount.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxAccount.Location = new System.Drawing.Point(149, 79);
            this.userControlTextBoxAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlTextBoxAccount.Name = "userControlTextBoxAccount";
            this.userControlTextBoxAccount.Size = new System.Drawing.Size(236, 41);
            this.userControlTextBoxAccount.TabIndex = 1;
            this.userControlTextBoxAccount.TextBoxText = "";
            // 
            // FCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(405, 292);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.userControlTextBoxNewPassword);
            this.Controls.Add(this.userControlTextBoxPassword);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.userControlTextBoxAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCreateAccount";
            this.Load += new System.EventHandler(this.FCreateAccountLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private UserControls.UserControlTextBoxPassword userControlTextBoxNewPassword;
        private UserControls.UserControlTextBoxPassword userControlTextBoxPassword;
        private UserControls.UserControlTextBoxAccount userControlTextBoxAccount;
        private System.Windows.Forms.Button buttonBack;
    }
}