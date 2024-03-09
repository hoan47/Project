namespace Project
{
    partial class FUpdateInfo
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
            System.Windows.Forms.Button buttonChangeImage;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUpdateInfo));
            System.Windows.Forms.Button buttonDeleteImage;
            this.panelInfo = new System.Windows.Forms.Panel();
            this.userControlTextBoxEditPhone = new Project.UserControlTextBoxEdit();
            this.userControlRadioButtonEditGender = new Project.UserControlRadioButtonEdit();
            this.userControlTextBoxEditEmail = new Project.UserControlTextBoxEdit();
            this.userControlTextBoxEditIdCard = new Project.UserControlTextBoxEdit();
            this.userControlTextBoxEditAddress = new Project.UserControlTextBoxEdit();
            this.userControlDateTimePackerEditDateOfBirth = new Project.UserControlDateTimePackerEdit();
            this.userControlTextBoxEditName = new Project.UserControlTextBoxEdit();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            buttonChangeImage = new System.Windows.Forms.Button();
            buttonDeleteImage = new System.Windows.Forms.Button();
            this.panelInfo.SuspendLayout();
            this.panelImage.SuspendLayout();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonChangeImage
            // 
            buttonChangeImage.AutoSize = true;
            buttonChangeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            buttonChangeImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChangeImage.BackgroundImage")));
            buttonChangeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonChangeImage.Location = new System.Drawing.Point(95, 284);
            buttonChangeImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            buttonChangeImage.Name = "buttonChangeImage";
            buttonChangeImage.Size = new System.Drawing.Size(50, 50);
            buttonChangeImage.TabIndex = 1;
            buttonChangeImage.UseVisualStyleBackColor = false;
            buttonChangeImage.Click += new System.EventHandler(this.ButtonChangeImageClick);
            // 
            // buttonDeleteImage
            // 
            buttonDeleteImage.AutoSize = true;
            buttonDeleteImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            buttonDeleteImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteImage.BackgroundImage")));
            buttonDeleteImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonDeleteImage.Location = new System.Drawing.Point(164, 284);
            buttonDeleteImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            buttonDeleteImage.Name = "buttonDeleteImage";
            buttonDeleteImage.Size = new System.Drawing.Size(50, 50);
            buttonDeleteImage.TabIndex = 2;
            buttonDeleteImage.UseVisualStyleBackColor = false;
            buttonDeleteImage.Click += new System.EventHandler(this.ButtonDeleteImageClick);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.userControlTextBoxEditPhone);
            this.panelInfo.Controls.Add(this.userControlRadioButtonEditGender);
            this.panelInfo.Controls.Add(this.userControlTextBoxEditEmail);
            this.panelInfo.Controls.Add(this.userControlTextBoxEditIdCard);
            this.panelInfo.Controls.Add(this.userControlTextBoxEditAddress);
            this.panelInfo.Controls.Add(this.userControlDateTimePackerEditDateOfBirth);
            this.panelInfo.Controls.Add(this.userControlTextBoxEditName);
            this.panelInfo.Controls.Add(this.buttonUpdate);
            this.panelInfo.Location = new System.Drawing.Point(359, 82);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(621, 466);
            this.panelInfo.TabIndex = 1;
            this.panelInfo.TabStop = true;
            // 
            // userControlTextBoxEditPhone
            // 
            this.userControlTextBoxEditPhone.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxEditPhone.LabelText = "Phone";
            this.userControlTextBoxEditPhone.Location = new System.Drawing.Point(26, 340);
            this.userControlTextBoxEditPhone.Name = "userControlTextBoxEditPhone";
            this.userControlTextBoxEditPhone.Size = new System.Drawing.Size(568, 46);
            this.userControlTextBoxEditPhone.TabIndex = 6;
            this.userControlTextBoxEditPhone.TextBoxText = "";
            // 
            // userControlRadioButtonEditGender
            // 
            this.userControlRadioButtonEditGender.BackColor = System.Drawing.Color.Transparent;
            this.userControlRadioButtonEditGender.GenderText = "Nam";
            this.userControlRadioButtonEditGender.LabelText = "Giới Tính";
            this.userControlRadioButtonEditGender.Location = new System.Drawing.Point(26, 138);
            this.userControlRadioButtonEditGender.Name = "userControlRadioButtonEditGender";
            this.userControlRadioButtonEditGender.Size = new System.Drawing.Size(568, 46);
            this.userControlRadioButtonEditGender.TabIndex = 2;
            // 
            // userControlTextBoxEditEmail
            // 
            this.userControlTextBoxEditEmail.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxEditEmail.LabelText = "Email";
            this.userControlTextBoxEditEmail.Location = new System.Drawing.Point(26, 288);
            this.userControlTextBoxEditEmail.Name = "userControlTextBoxEditEmail";
            this.userControlTextBoxEditEmail.Size = new System.Drawing.Size(568, 46);
            this.userControlTextBoxEditEmail.TabIndex = 5;
            this.userControlTextBoxEditEmail.TextBoxText = "";
            // 
            // userControlTextBoxEditIdCard
            // 
            this.userControlTextBoxEditIdCard.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxEditIdCard.LabelText = "CMND";
            this.userControlTextBoxEditIdCard.Location = new System.Drawing.Point(26, 236);
            this.userControlTextBoxEditIdCard.Name = "userControlTextBoxEditIdCard";
            this.userControlTextBoxEditIdCard.Size = new System.Drawing.Size(568, 46);
            this.userControlTextBoxEditIdCard.TabIndex = 4;
            this.userControlTextBoxEditIdCard.TextBoxText = "";
            // 
            // userControlTextBoxEditAddress
            // 
            this.userControlTextBoxEditAddress.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxEditAddress.LabelText = "Địa Chỉ";
            this.userControlTextBoxEditAddress.Location = new System.Drawing.Point(26, 190);
            this.userControlTextBoxEditAddress.Name = "userControlTextBoxEditAddress";
            this.userControlTextBoxEditAddress.Size = new System.Drawing.Size(568, 46);
            this.userControlTextBoxEditAddress.TabIndex = 3;
            this.userControlTextBoxEditAddress.TextBoxText = "";
            // 
            // userControlDateTimePackerEditDateOfBirth
            // 
            this.userControlDateTimePackerEditDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.userControlDateTimePackerEditDateOfBirth.DateTimePickerText = "Friday, March 8, 2024";
            this.userControlDateTimePackerEditDateOfBirth.LabelText = "Ngày Sinh";
            this.userControlDateTimePackerEditDateOfBirth.Location = new System.Drawing.Point(26, 86);
            this.userControlDateTimePackerEditDateOfBirth.Name = "userControlDateTimePackerEditDateOfBirth";
            this.userControlDateTimePackerEditDateOfBirth.Size = new System.Drawing.Size(568, 46);
            this.userControlDateTimePackerEditDateOfBirth.TabIndex = 1;
            // 
            // userControlTextBoxEditName
            // 
            this.userControlTextBoxEditName.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxEditName.LabelText = "Họ Tên";
            this.userControlTextBoxEditName.Location = new System.Drawing.Point(26, 34);
            this.userControlTextBoxEditName.Name = "userControlTextBoxEditName";
            this.userControlTextBoxEditName.Size = new System.Drawing.Size(568, 46);
            this.userControlTextBoxEditName.TabIndex = 0;
            this.userControlTextBoxEditName.TextBoxText = "";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.BackgroundImage")));
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUpdate.Location = new System.Drawing.Point(288, 400);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(50, 50);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.Transparent;
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage.Controls.Add(buttonDeleteImage);
            this.panelImage.Controls.Add(this.panelBackground);
            this.panelImage.Controls.Add(this.labelUser);
            this.panelImage.Controls.Add(buttonChangeImage);
            this.panelImage.Location = new System.Drawing.Point(48, 82);
            this.panelImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(305, 346);
            this.panelImage.TabIndex = 0;
            this.panelImage.TabStop = true;
            // 
            // panelBackground
            // 
            this.panelBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBackground.BackgroundImage")));
            this.panelBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBackground.Controls.Add(this.pictureBoxImage);
            this.panelBackground.Location = new System.Drawing.Point(35, 34);
            this.panelBackground.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(240, 240);
            this.panelBackground.TabIndex = 0;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(25, 26);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(190, 190);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 23;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Black;
            this.labelUser.Location = new System.Drawing.Point(120, 34);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 20);
            this.labelUser.TabIndex = 0;
            // 
            // FUpdateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1040, 630);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FUpdateInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FInfo";
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            this.panelBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panelInfo;
        private UserControlTextBoxEdit userControlTextBoxEditPhone;
        private UserControlRadioButtonEdit userControlRadioButtonEditGender;
        private UserControlTextBoxEdit userControlTextBoxEditEmail;
        private UserControlTextBoxEdit userControlTextBoxEditIdCard;
        private UserControlTextBoxEdit userControlTextBoxEditAddress;
        private UserControlDateTimePackerEdit userControlDateTimePackerEditDateOfBirth;
        private UserControlTextBoxEdit userControlTextBoxEditName;
    }
}