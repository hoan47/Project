
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
            this.pictureAccount = new System.Windows.Forms.PictureBox();
            this.textBoxAccount = new System.Windows.Forms.TextBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelNewPassword = new System.Windows.Forms.Panel();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.panelRoadNewPasswoed = new System.Windows.Forms.Panel();
            this.pictureBoxNewPassword = new System.Windows.Forms.PictureBox();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelRoadPassword = new System.Windows.Forms.Panel();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.panelAccount = new System.Windows.Forms.Panel();
            this.panelRoadAccount = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAccount)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelNewPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            this.panelAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.AutoSize = true;
            this.buttonCreateAccount.Location = new System.Drawing.Point(258, 175);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(105, 27);
            this.buttonCreateAccount.TabIndex = 3;
            this.buttonCreateAccount.Text = "Tạo tài khoản";
            this.buttonCreateAccount.UseVisualStyleBackColor = true;
            this.buttonCreateAccount.Click += new System.EventHandler(this.ButtonCreateAccountClick);
            // 
            // pictureAccount
            // 
            this.pictureAccount.Image = ((System.Drawing.Image)(resources.GetObject("pictureAccount.Image")));
            this.pictureAccount.Location = new System.Drawing.Point(19, 8);
            this.pictureAccount.Name = "pictureAccount";
            this.pictureAccount.Size = new System.Drawing.Size(30, 30);
            this.pictureAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAccount.TabIndex = 2;
            this.pictureAccount.TabStop = false;
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
            this.panelMain.Controls.Add(this.panelNewPassword);
            this.panelMain.Controls.Add(this.buttonCreateAccount);
            this.panelMain.Controls.Add(this.pictureBoxIcon);
            this.panelMain.Controls.Add(this.panelPassword);
            this.panelMain.Controls.Add(this.panelAccount);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(475, 205);
            this.panelMain.TabIndex = 3;
            // 
            // panelNewPassword
            // 
            this.panelNewPassword.Controls.Add(this.labelNewPassword);
            this.panelNewPassword.Controls.Add(this.textBoxNewPassword);
            this.panelNewPassword.Controls.Add(this.panelRoadNewPasswoed);
            this.panelNewPassword.Controls.Add(this.pictureBoxNewPassword);
            this.panelNewPassword.Location = new System.Drawing.Point(159, 112);
            this.panelNewPassword.Name = "panelNewPassword";
            this.panelNewPassword.Size = new System.Drawing.Size(314, 60);
            this.panelNewPassword.TabIndex = 5;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(16, 4);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(148, 17);
            this.labelNewPassword.TabIndex = 5;
            this.labelNewPassword.Text = "Nhập lại mật khẩu mới";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.Location = new System.Drawing.Point(59, 24);
            this.textBoxNewPassword.MaxLength = 16;
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(234, 27);
            this.textBoxNewPassword.TabIndex = 2;
            this.textBoxNewPassword.UseSystemPasswordChar = true;
            this.textBoxNewPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNewPasswordKeyPress);
            // 
            // panelRoadNewPasswoed
            // 
            this.panelRoadNewPasswoed.BackColor = System.Drawing.Color.Aqua;
            this.panelRoadNewPasswoed.Location = new System.Drawing.Point(19, 54);
            this.panelRoadNewPasswoed.Name = "panelRoadNewPasswoed";
            this.panelRoadNewPasswoed.Size = new System.Drawing.Size(274, 3);
            this.panelRoadNewPasswoed.TabIndex = 4;
            // 
            // pictureBoxNewPassword
            // 
            this.pictureBoxNewPassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNewPassword.Image")));
            this.pictureBoxNewPassword.Location = new System.Drawing.Point(18, 24);
            this.pictureBoxNewPassword.Name = "pictureBoxNewPassword";
            this.pictureBoxNewPassword.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNewPassword.TabIndex = 3;
            this.pictureBoxNewPassword.TabStop = false;
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
            this.panelPassword.TabIndex = 2;
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
            this.panelAccount.Controls.Add(this.pictureAccount);
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
            // FCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 208);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCreateAccount";
            ((System.ComponentModel.ISupportInitialize)(this.pictureAccount)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelNewPassword.ResumeLayout(false);
            this.panelNewPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.PictureBox pictureAccount;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panelRoadPassword;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.Panel panelAccount;
        private System.Windows.Forms.Panel panelRoadAccount;
        private System.Windows.Forms.Panel panelNewPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Panel panelRoadNewPasswoed;
        private System.Windows.Forms.PictureBox pictureBoxNewPassword;
    }
}