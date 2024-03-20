namespace Project
{
    partial class FUpdateInfor
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
            System.Windows.Forms.Button buttonDeleteImage;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUpdateInfor));
            System.Windows.Forms.Button buttonChangeImage;
            this.panelInfo = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pictureBoxImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelRank = new System.Windows.Forms.Label();
            this.pictureBoxImageRank = new System.Windows.Forms.PictureBox();
            this.userControlAddressEditAddress = new Project.UserControlAddressEdit();
            this.userControlTextBoxEditPhone = new Project.UserControlTextBoxEdit();
            this.userControlRadioButtonEditGender = new Project.UserControlRadioButtonEdit();
            this.userControlTextBoxEditEmail = new Project.UserControlTextBoxEdit();
            this.userControlTextBoxEditIdCard = new Project.UserControlTextBoxEdit();
            this.userControlTextBoxEditSpecificLocation = new Project.UserControlTextBoxEdit();
            this.userControlDateTimePackerEditDateOfBirth = new Project.UserControlDateTimePackerEdit();
            this.userControlTextBoxEditName = new Project.UserControlTextBoxEdit();
            buttonDeleteImage = new System.Windows.Forms.Button();
            buttonChangeImage = new System.Windows.Forms.Button();
            this.panelInfo.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageRank)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeleteImage
            // 
            buttonDeleteImage.AutoSize = true;
            buttonDeleteImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            buttonDeleteImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteImage.BackgroundImage")));
            buttonDeleteImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonDeleteImage.Location = new System.Drawing.Point(111, 206);
            buttonDeleteImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            buttonDeleteImage.Name = "buttonDeleteImage";
            buttonDeleteImage.Size = new System.Drawing.Size(40, 40);
            buttonDeleteImage.TabIndex = 2;
            buttonDeleteImage.UseVisualStyleBackColor = false;
            buttonDeleteImage.Click += new System.EventHandler(this.ButtonDeleteImageClick);
            // 
            // buttonChangeImage
            // 
            buttonChangeImage.AutoSize = true;
            buttonChangeImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            buttonChangeImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonChangeImage.BackgroundImage")));
            buttonChangeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            buttonChangeImage.Location = new System.Drawing.Point(59, 206);
            buttonChangeImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            buttonChangeImage.Name = "buttonChangeImage";
            buttonChangeImage.Size = new System.Drawing.Size(40, 40);
            buttonChangeImage.TabIndex = 1;
            buttonChangeImage.UseVisualStyleBackColor = false;
            buttonChangeImage.Click += new System.EventHandler(this.ButtonChangeImageClick);
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.userControlAddressEditAddress);
            this.panelInfo.Controls.Add(this.userControlTextBoxEditPhone);
            this.panelInfo.Controls.Add(this.userControlRadioButtonEditGender);
            this.panelInfo.Controls.Add(this.userControlTextBoxEditEmail);
            this.panelInfo.Controls.Add(this.userControlTextBoxEditIdCard);
            this.panelInfo.Controls.Add(this.userControlTextBoxEditSpecificLocation);
            this.panelInfo.Controls.Add(this.userControlDateTimePackerEditDateOfBirth);
            this.panelInfo.Controls.Add(this.userControlTextBoxEditName);
            this.panelInfo.Controls.Add(this.buttonUpdate);
            this.panelInfo.Location = new System.Drawing.Point(270, 42);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(466, 436);
            this.panelInfo.TabIndex = 1;
            this.panelInfo.TabStop = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.AutoSize = true;
            this.buttonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.BackgroundImage")));
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUpdate.Location = new System.Drawing.Point(214, 377);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(40, 40);
            this.buttonUpdate.TabIndex = 8;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.Transparent;
            this.panelImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelImage.Controls.Add(this.pictureBoxImage);
            this.panelImage.Controls.Add(buttonDeleteImage);
            this.panelImage.Controls.Add(this.labelUser);
            this.panelImage.Controls.Add(buttonChangeImage);
            this.panelImage.Location = new System.Drawing.Point(40, 154);
            this.panelImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(201, 253);
            this.panelImage.TabIndex = 0;
            this.panelImage.TabStop = true;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderRadius = 20;
            this.pictureBoxImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBoxImage.ImageRotate = 0F;
            this.pictureBoxImage.Location = new System.Drawing.Point(15, 15);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(170, 170);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 24;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Black;
            this.labelUser.Location = new System.Drawing.Point(90, 28);
            this.labelUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(0, 17);
            this.labelUser.TabIndex = 0;
            // 
            // labelRank
            // 
            this.labelRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRank.Location = new System.Drawing.Point(81, 2);
            this.labelRank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(122, 25);
            this.labelRank.TabIndex = 5;
            this.labelRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxImageRank
            // 
            this.pictureBoxImageRank.Location = new System.Drawing.Point(81, 28);
            this.pictureBoxImageRank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxImageRank.Name = "pictureBoxImageRank";
            this.pictureBoxImageRank.Size = new System.Drawing.Size(122, 122);
            this.pictureBoxImageRank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImageRank.TabIndex = 4;
            this.pictureBoxImageRank.TabStop = false;
            // 
            // userControlAddressEditAddress
            // 
            this.userControlAddressEditAddress.ComboBoxText = "";
            this.userControlAddressEditAddress.Location = new System.Drawing.Point(20, 154);
            this.userControlAddressEditAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlAddressEditAddress.Name = "userControlAddressEditAddress";
            this.userControlAddressEditAddress.Size = new System.Drawing.Size(426, 37);
            this.userControlAddressEditAddress.TabIndex = 3;
            // 
            // userControlTextBoxEditPhone
            // 
            this.userControlTextBoxEditPhone.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxEditPhone.LabelText = "Phone";
            this.userControlTextBoxEditPhone.Location = new System.Drawing.Point(20, 317);
            this.userControlTextBoxEditPhone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlTextBoxEditPhone.Name = "userControlTextBoxEditPhone";
            this.userControlTextBoxEditPhone.Size = new System.Drawing.Size(426, 37);
            this.userControlTextBoxEditPhone.TabIndex = 7;
            this.userControlTextBoxEditPhone.TextBoxText = "";
            // 
            // userControlRadioButtonEditGender
            // 
            this.userControlRadioButtonEditGender.BackColor = System.Drawing.Color.Transparent;
            this.userControlRadioButtonEditGender.GenderText = "Nam";
            this.userControlRadioButtonEditGender.LabelText = "Giới Tính";
            this.userControlRadioButtonEditGender.Location = new System.Drawing.Point(20, 112);
            this.userControlRadioButtonEditGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlRadioButtonEditGender.Name = "userControlRadioButtonEditGender";
            this.userControlRadioButtonEditGender.Size = new System.Drawing.Size(426, 37);
            this.userControlRadioButtonEditGender.TabIndex = 2;
            // 
            // userControlTextBoxEditEmail
            // 
            this.userControlTextBoxEditEmail.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxEditEmail.LabelText = "Email";
            this.userControlTextBoxEditEmail.Location = new System.Drawing.Point(20, 276);
            this.userControlTextBoxEditEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlTextBoxEditEmail.Name = "userControlTextBoxEditEmail";
            this.userControlTextBoxEditEmail.Size = new System.Drawing.Size(426, 37);
            this.userControlTextBoxEditEmail.TabIndex = 6;
            this.userControlTextBoxEditEmail.TextBoxText = "";
            // 
            // userControlTextBoxEditIdCard
            // 
            this.userControlTextBoxEditIdCard.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxEditIdCard.LabelText = "CMND";
            this.userControlTextBoxEditIdCard.Location = new System.Drawing.Point(20, 236);
            this.userControlTextBoxEditIdCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlTextBoxEditIdCard.Name = "userControlTextBoxEditIdCard";
            this.userControlTextBoxEditIdCard.Size = new System.Drawing.Size(426, 37);
            this.userControlTextBoxEditIdCard.TabIndex = 5;
            this.userControlTextBoxEditIdCard.TextBoxText = "";
            // 
            // userControlTextBoxEditSpecificLocation
            // 
            this.userControlTextBoxEditSpecificLocation.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxEditSpecificLocation.LabelText = "Địa Chỉ Cụ Thể";
            this.userControlTextBoxEditSpecificLocation.Location = new System.Drawing.Point(20, 195);
            this.userControlTextBoxEditSpecificLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlTextBoxEditSpecificLocation.Name = "userControlTextBoxEditSpecificLocation";
            this.userControlTextBoxEditSpecificLocation.Size = new System.Drawing.Size(426, 37);
            this.userControlTextBoxEditSpecificLocation.TabIndex = 4;
            this.userControlTextBoxEditSpecificLocation.TextBoxText = "";
            // 
            // userControlDateTimePackerEditDateOfBirth
            // 
            this.userControlDateTimePackerEditDateOfBirth.BackColor = System.Drawing.Color.Transparent;
            this.userControlDateTimePackerEditDateOfBirth.DateTimePickerText = "Friday, March 8, 2024";
            this.userControlDateTimePackerEditDateOfBirth.LabelText = "Ngày Sinh";
            this.userControlDateTimePackerEditDateOfBirth.Location = new System.Drawing.Point(20, 70);
            this.userControlDateTimePackerEditDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlDateTimePackerEditDateOfBirth.Name = "userControlDateTimePackerEditDateOfBirth";
            this.userControlDateTimePackerEditDateOfBirth.Size = new System.Drawing.Size(426, 37);
            this.userControlDateTimePackerEditDateOfBirth.TabIndex = 1;
            // 
            // userControlTextBoxEditName
            // 
            this.userControlTextBoxEditName.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxEditName.LabelText = "Họ Tên";
            this.userControlTextBoxEditName.Location = new System.Drawing.Point(20, 28);
            this.userControlTextBoxEditName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlTextBoxEditName.Name = "userControlTextBoxEditName";
            this.userControlTextBoxEditName.Size = new System.Drawing.Size(426, 37);
            this.userControlTextBoxEditName.TabIndex = 0;
            this.userControlTextBoxEditName.TextBoxText = "";
            // 
            // FUpdateInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(780, 512);
            this.Controls.Add(this.labelRank);
            this.Controls.Add(this.pictureBoxImageRank);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FUpdateInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FInfo";
            this.Load += new System.EventHandler(this.FUpdateInfoLoad);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageRank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panelInfo;
        private UserControlTextBoxEdit userControlTextBoxEditPhone;
        private UserControlRadioButtonEdit userControlRadioButtonEditGender;
        private UserControlTextBoxEdit userControlTextBoxEditEmail;
        private UserControlTextBoxEdit userControlTextBoxEditIdCard;
        private UserControlTextBoxEdit userControlTextBoxEditSpecificLocation;
        private UserControlDateTimePackerEdit userControlDateTimePackerEditDateOfBirth;
        private UserControlTextBoxEdit userControlTextBoxEditName;
        private System.Windows.Forms.PictureBox pictureBoxImageRank;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labelRank;
        private UserControlAddressEdit userControlAddressEditAddress;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxImage;
    }
}