
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.buttonCreateAccount.Location = new System.Drawing.Point(262, 171);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(105, 27);
            this.buttonCreateAccount.TabIndex = 3;
            this.buttonCreateAccount.Text = "Tạo tài khoản";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.ButtonCreateAccountClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(178, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nhập lại mật khẩu mới";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(7, 4);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 3;
            this.pictureBoxIcon.TabStop = false;
            // 
            // userControlTextBoxNewPassword
            // 
            this.userControlTextBoxNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxNewPassword.Location = new System.Drawing.Point(162, 119);
            this.userControlTextBoxNewPassword.Name = "userControlTextBoxNewPassword";
            this.userControlTextBoxNewPassword.Size = new System.Drawing.Size(314, 49);
            this.userControlTextBoxNewPassword.TabIndex = 2;
            this.userControlTextBoxNewPassword.TextBoxText = "";
            // 
            // userControlTextBoxPassword
            // 
            this.userControlTextBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxPassword.Location = new System.Drawing.Point(162, 55);
            this.userControlTextBoxPassword.Name = "userControlTextBoxPassword";
            this.userControlTextBoxPassword.Size = new System.Drawing.Size(314, 50);
            this.userControlTextBoxPassword.TabIndex = 1;
            this.userControlTextBoxPassword.TextBoxText = "";
            // 
            // userControlTextBoxAccount
            // 
            this.userControlTextBoxAccount.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxAccount.Location = new System.Drawing.Point(162, -1);
            this.userControlTextBoxAccount.Name = "userControlTextBoxAccount";
            this.userControlTextBoxAccount.Size = new System.Drawing.Size(314, 50);
            this.userControlTextBoxAccount.TabIndex = 0;
            this.userControlTextBoxAccount.TextBoxText = "";
            // 
            // FCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 208);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userControlTextBoxNewPassword);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.userControlTextBoxPassword);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.userControlTextBoxAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCreateAccount";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label label1;
        private UserControls.UserControlTextBoxPassword userControlTextBoxNewPassword;
        private UserControls.UserControlTextBoxPassword userControlTextBoxPassword;
        private UserControls.UserControlTextBoxAccount userControlTextBoxAccount;
    }
}