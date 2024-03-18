using System.Windows.Forms;

namespace Project
{
    partial class FUpdateService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUpdateService));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelImage = new System.Windows.Forms.Panel();
            this.groupBoxDescribe = new System.Windows.Forms.GroupBox();
            this.textBoxDescribe = new System.Windows.Forms.TextBox();
            this.groupBoxService = new System.Windows.Forms.GroupBox();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.userControlAddressHotel = new Project.UserControlAddressHotel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.userControlTextBoxPhone = new Project.UserControls.UserControlTextBox();
            this.userControlTextBoxName = new Project.UserControls.UserControlTextBox();
            this.userControlCheckInOutHotel = new Project.UserControlCheckInOutHotel();
            this.panelInfo.SuspendLayout();
            this.panelImage.SuspendLayout();
            this.groupBoxDescribe.SuspendLayout();
            this.groupBoxService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.userControlCheckInOutHotel);
            this.panelInfo.Controls.Add(this.userControlTextBoxName);
            this.panelInfo.Controls.Add(this.userControlAddressHotel);
            this.panelInfo.Controls.Add(this.groupBoxDescribe);
            this.panelInfo.Controls.Add(this.userControlTextBoxPhone);
            this.panelInfo.Controls.Add(this.groupBoxService);
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(416, 629);
            this.panelInfo.TabIndex = 0;
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.buttonRight);
            this.panelImage.Controls.Add(this.buttonLeft);
            this.panelImage.Controls.Add(this.pictureBoxImage);
            this.panelImage.Controls.Add(this.pictureBoxBackground);
            this.panelImage.Controls.Add(this.buttonDeleteImage);
            this.panelImage.Controls.Add(this.buttonUploadImage);
            this.panelImage.Location = new System.Drawing.Point(422, 10);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(608, 550);
            this.panelImage.TabIndex = 1;
            // 
            // groupBoxDescribe
            // 
            this.groupBoxDescribe.Controls.Add(this.textBoxDescribe);
            this.groupBoxDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDescribe.Location = new System.Drawing.Point(12, 499);
            this.groupBoxDescribe.Name = "groupBoxDescribe";
            this.groupBoxDescribe.Size = new System.Drawing.Size(400, 119);
            this.groupBoxDescribe.TabIndex = 66;
            this.groupBoxDescribe.TabStop = false;
            this.groupBoxDescribe.Text = "Mô tả";
            // 
            // textBoxDescribe
            // 
            this.textBoxDescribe.AllowDrop = true;
            this.textBoxDescribe.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDescribe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescribe.Location = new System.Drawing.Point(6, 20);
            this.textBoxDescribe.Multiline = true;
            this.textBoxDescribe.Name = "textBoxDescribe";
            this.textBoxDescribe.Size = new System.Drawing.Size(388, 90);
            this.textBoxDescribe.TabIndex = 0;
            // 
            // groupBoxService
            // 
            this.groupBoxService.Controls.Add(this.checkedListBox);
            this.groupBoxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxService.Location = new System.Drawing.Point(12, 372);
            this.groupBoxService.Name = "groupBoxService";
            this.groupBoxService.Size = new System.Drawing.Size(400, 121);
            this.groupBoxService.TabIndex = 65;
            this.groupBoxService.TabStop = false;
            this.groupBoxService.Text = "Dịch Vụ";
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.BackColor = System.Drawing.SystemColors.Info;
            this.buttonUploadImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUploadImage.BackgroundImage")));
            this.buttonUploadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUploadImage.Location = new System.Drawing.Point(253, 491);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(50, 50);
            this.buttonUploadImage.TabIndex = 0;
            this.buttonUploadImage.UseVisualStyleBackColor = false;
            this.buttonUploadImage.Click += new System.EventHandler(this.ButtonUploadImageClick);
            // 
            // buttonDeleteImage
            // 
            this.buttonDeleteImage.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDeleteImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteImage.BackgroundImage")));
            this.buttonDeleteImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteImage.Location = new System.Drawing.Point(325, 491);
            this.buttonDeleteImage.Name = "buttonDeleteImage";
            this.buttonDeleteImage.Size = new System.Drawing.Size(50, 50);
            this.buttonDeleteImage.TabIndex = 1;
            this.buttonDeleteImage.UseVisualStyleBackColor = false;
            this.buttonDeleteImage.Click += new System.EventHandler(this.ButtonDeleteImageClick);
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackground.BackgroundImage")));
            this.pictureBoxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBackground.Location = new System.Drawing.Point(65, 5);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(480, 480);
            this.pictureBoxBackground.TabIndex = 2;
            this.pictureBoxBackground.TabStop = false;
            // 
            // checkedListBox
            // 
            this.checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Hồ bơi",
            "Khu phục vụ đồ ăn",
            "Bãi giữ xe ô tô/xe máy",
            "Wifi",
            "Nhân viên 24/24",
            "Dịch vụ giặt là",
            "Khu vực hút thuốc lá",
            "Công viên"});
            this.checkedListBox.Location = new System.Drawing.Point(6, 22);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(388, 92);
            this.checkedListBox.TabIndex = 0;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxImage.Location = new System.Drawing.Point(75, 15);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(460, 460);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 3;
            this.pictureBoxImage.TabStop = false;
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeft.Location = new System.Drawing.Point(19, 228);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(40, 40);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonLeftClick);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRight.Location = new System.Drawing.Point(551, 228);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(40, 40);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.ButtonRightClick);
            // 
            // userControlAddressHotel
            // 
            this.userControlAddressHotel.ComboBoxText = "";
            this.userControlAddressHotel.Location = new System.Drawing.Point(12, 88);
            this.userControlAddressHotel.Name = "userControlAddressHotel";
            this.userControlAddressHotel.Size = new System.Drawing.Size(400, 110);
            this.userControlAddressHotel.TabIndex = 70;
            this.userControlAddressHotel.TextBoxText = "";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.buttonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.BackgroundImage")));
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdate.Location = new System.Drawing.Point(973, 568);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(50, 50);
            this.buttonUpdate.TabIndex = 49;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // userControlTextBoxPhone
            // 
            this.userControlTextBoxPhone.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxPhone.Image = ((System.Drawing.Image)(resources.GetObject("userControlTextBoxPhone.Image")));
            this.userControlTextBoxPhone.LabelText = "Số Điện Thoại";
            this.userControlTextBoxPhone.Location = new System.Drawing.Point(12, 204);
            this.userControlTextBoxPhone.Name = "userControlTextBoxPhone";
            this.userControlTextBoxPhone.Size = new System.Drawing.Size(400, 74);
            this.userControlTextBoxPhone.TabIndex = 68;
            this.userControlTextBoxPhone.TextBoxText = "";
            // 
            // userControlTextBoxName
            // 
            this.userControlTextBoxName.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxName.Image = ((System.Drawing.Image)(resources.GetObject("userControlTextBoxName.Image")));
            this.userControlTextBoxName.LabelText = "Tên khách sạn";
            this.userControlTextBoxName.Location = new System.Drawing.Point(12, 8);
            this.userControlTextBoxName.Name = "userControlTextBoxName";
            this.userControlTextBoxName.Size = new System.Drawing.Size(400, 74);
            this.userControlTextBoxName.TabIndex = 71;
            this.userControlTextBoxName.TextBoxText = "";
            // 
            // userControlCheckInOutHotel
            // 
            this.userControlCheckInOutHotel.Location = new System.Drawing.Point(12, 284);
            this.userControlCheckInOutHotel.MaskedTextBoxInText = "  :00";
            this.userControlCheckInOutHotel.MaskedTextBoxOutText = "  :00";
            this.userControlCheckInOutHotel.Name = "userControlCheckInOutHotel";
            this.userControlCheckInOutHotel.Size = new System.Drawing.Size(400, 82);
            this.userControlCheckInOutHotel.TabIndex = 72;
            // 
            // FUpdateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1040, 630);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.buttonUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FUpdateService";
            this.Text = "FUpdateService";
            this.panelInfo.ResumeLayout(false);
            this.panelImage.ResumeLayout(false);
            this.groupBoxDescribe.ResumeLayout(false);
            this.groupBoxDescribe.PerformLayout();
            this.groupBoxService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelInfo;
        private UserControlCheckInOutHotel userControlCheckInOutHotel;
        private UserControls.UserControlTextBox userControlTextBoxName;
        private UserControlAddressHotel userControlAddressHotel;
        private GroupBox groupBoxDescribe;
        private TextBox textBoxDescribe;
        private UserControls.UserControlTextBox userControlTextBoxPhone;
        private GroupBox groupBoxService;
        private CheckedListBox checkedListBox;
        private Panel panelImage;
        private Button buttonRight;
        private Button buttonLeft;
        private PictureBox pictureBoxImage;
        private PictureBox pictureBoxBackground;
        private Button buttonDeleteImage;
        private Button buttonUploadImage;
        private Button buttonUpdate;
    }
}