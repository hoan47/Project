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
            this.groupBoxDescribe = new System.Windows.Forms.GroupBox();
            this.textBoxDescribe = new System.Windows.Forms.TextBox();
            this.groupBoxService = new System.Windows.Forms.GroupBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.panelImage = new System.Windows.Forms.Panel();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.pictureBoxImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonLeft = new Guna.UI2.WinForms.Guna2Button();
            this.buttonRight = new Guna.UI2.WinForms.Guna2Button();
            this.userControlAddressHotel = new Project.UserControlAddressHotel();
            this.userControlCheckInOutHotel = new Project.UserControlCheckInOutHotel();
            this.userControlTextBoxName = new Project.UserControls.UserControlTextBox();
            this.userControlTextBoxPhone = new Project.UserControls.UserControlTextBox();
            this.panelInfo.SuspendLayout();
            this.groupBoxDescribe.SuspendLayout();
            this.groupBoxService.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.userControlAddressHotel);
            this.panelInfo.Controls.Add(this.userControlCheckInOutHotel);
            this.panelInfo.Controls.Add(this.userControlTextBoxName);
            this.panelInfo.Controls.Add(this.groupBoxDescribe);
            this.panelInfo.Controls.Add(this.userControlTextBoxPhone);
            this.panelInfo.Controls.Add(this.groupBoxService);
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(416, 629);
            this.panelInfo.TabIndex = 0;
            // 
            // groupBoxDescribe
            // 
            this.groupBoxDescribe.Controls.Add(this.textBoxDescribe);
            this.groupBoxDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDescribe.Location = new System.Drawing.Point(12, 500);
            this.groupBoxDescribe.Name = "groupBoxDescribe";
            this.groupBoxDescribe.Size = new System.Drawing.Size(400, 120);
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
            this.groupBoxService.Location = new System.Drawing.Point(12, 380);
            this.groupBoxService.Name = "groupBoxService";
            this.groupBoxService.Size = new System.Drawing.Size(400, 120);
            this.groupBoxService.TabIndex = 65;
            this.groupBoxService.TabStop = false;
            this.groupBoxService.Text = "Dịch Vụ";
            // 
            // checkedListBox
            // 
            this.checkedListBox.BackColor = System.Drawing.SystemColors.Info;
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
            // panelImage
            // 
            this.panelImage.Controls.Add(this.buttonRight);
            this.panelImage.Controls.Add(this.buttonLeft);
            this.panelImage.Controls.Add(this.pictureBoxImage);
            this.panelImage.Controls.Add(this.buttonDeleteImage);
            this.panelImage.Controls.Add(this.buttonUploadImage);
            this.panelImage.Location = new System.Drawing.Point(422, 10);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(608, 550);
            this.panelImage.TabIndex = 1;
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
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.buttonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.BackgroundImage")));
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdate.Location = new System.Drawing.Point(973, 570);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(50, 50);
            this.buttonUpdate.TabIndex = 49;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderRadius = 20;
            this.pictureBoxImage.FillColor = System.Drawing.SystemColors.Info;
            this.pictureBoxImage.ImageRotate = 0F;
            this.pictureBoxImage.Location = new System.Drawing.Point(65, 5);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(480, 480);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 6;
            this.pictureBoxImage.TabStop = false;
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeft.BorderRadius = 5;
            this.buttonLeft.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLeft.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLeft.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLeft.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLeft.FillColor = System.Drawing.Color.Transparent;
            this.buttonLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonLeft.ForeColor = System.Drawing.Color.White;
            this.buttonLeft.Location = new System.Drawing.Point(32, 231);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 40);
            this.buttonLeft.TabIndex = 7;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonLeftClick);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRight.BorderRadius = 5;
            this.buttonRight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonRight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonRight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonRight.FillColor = System.Drawing.Color.Transparent;
            this.buttonRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonRight.ForeColor = System.Drawing.Color.White;
            this.buttonRight.Location = new System.Drawing.Point(551, 231);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 40);
            this.buttonRight.TabIndex = 8;
            this.buttonRight.Click += new System.EventHandler(this.ButtonRightClick);
            // 
            // userControlAddressHotel
            // 
            this.userControlAddressHotel.Location = new System.Drawing.Point(12, 88);
            this.userControlAddressHotel.Name = "userControlAddressHotel";
            this.userControlAddressHotel.Size = new System.Drawing.Size(400, 110);
            this.userControlAddressHotel.TabIndex = 73;
            this.userControlAddressHotel.TextBoxText = "";
            // 
            // userControlCheckInOutHotel
            // 
            this.userControlCheckInOutHotel.Location = new System.Drawing.Point(12, 292);
            this.userControlCheckInOutHotel.MaskedTextBoxInText = "  :00";
            this.userControlCheckInOutHotel.MaskedTextBoxOutText = "  :00";
            this.userControlCheckInOutHotel.Name = "userControlCheckInOutHotel";
            this.userControlCheckInOutHotel.Size = new System.Drawing.Size(400, 82);
            this.userControlCheckInOutHotel.TabIndex = 72;
            // 
            // userControlTextBoxName
            // 
            this.userControlTextBoxName.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxName.Image = ((System.Drawing.Image)(resources.GetObject("userControlTextBoxName.Image")));
            this.userControlTextBoxName.LabelText = "Tên khách sạn";
            this.userControlTextBoxName.Location = new System.Drawing.Point(12, 8);
            this.userControlTextBoxName.Name = "userControlTextBoxName";
            this.userControlTextBoxName.Size = new System.Drawing.Size(400, 82);
            this.userControlTextBoxName.TabIndex = 71;
            this.userControlTextBoxName.TextBoxText = "";
            // 
            // userControlTextBoxPhone
            // 
            this.userControlTextBoxPhone.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxPhone.Image = ((System.Drawing.Image)(resources.GetObject("userControlTextBoxPhone.Image")));
            this.userControlTextBoxPhone.LabelText = "Số Điện Thoại";
            this.userControlTextBoxPhone.Location = new System.Drawing.Point(12, 204);
            this.userControlTextBoxPhone.Name = "userControlTextBoxPhone";
            this.userControlTextBoxPhone.Size = new System.Drawing.Size(400, 82);
            this.userControlTextBoxPhone.TabIndex = 68;
            this.userControlTextBoxPhone.TextBoxText = "";
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
            this.groupBoxDescribe.ResumeLayout(false);
            this.groupBoxDescribe.PerformLayout();
            this.groupBoxService.ResumeLayout(false);
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonUpdate;
        private Panel panelInfo;
        private GroupBox groupBoxService;
        private CheckedListBox checkedListBox;
        private UserControls.UserControlTextBox userControlTextBoxPhone;
        private GroupBox groupBoxDescribe;
        private TextBox textBoxDescribe;
        private UserControls.UserControlTextBox userControlTextBoxName;
        private UserControlCheckInOutHotel userControlCheckInOutHotel;
        private Panel panelImage;
        private Button buttonUploadImage;
        private Button buttonDeleteImage;
        private UserControlAddressHotel userControlAddressHotel;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxImage;
        private Guna.UI2.WinForms.Guna2Button buttonRight;
        private Guna.UI2.WinForms.Guna2Button buttonLeft;
    }
}