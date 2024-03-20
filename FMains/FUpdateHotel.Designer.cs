using System.Windows.Forms;

namespace Project
{
    partial class FUpdateHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUpdateHotel));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.userControlTextBoxHotelPhone = new Project.UserControlTextBoxHotel();
            this.userControlTextBoxHotelName = new Project.UserControlTextBoxHotel();
            this.userControlAddService = new Project.UserControlServiceEdit();
            this.userControlAddressHotel = new Project.UserControlAddressHotel();
            this.userControlCheckInOutHotel = new Project.UserControlCheckInOutHotel();
            this.groupBoxDescribe = new System.Windows.Forms.GroupBox();
            this.textBoxDescribe = new System.Windows.Forms.TextBox();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pictureBoxImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonRight = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLeft = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panelInfo.SuspendLayout();
            this.groupBoxDescribe.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.userControlTextBoxHotelPhone);
            this.panelInfo.Controls.Add(this.userControlTextBoxHotelName);
            this.panelInfo.Controls.Add(this.userControlAddService);
            this.panelInfo.Controls.Add(this.userControlAddressHotel);
            this.panelInfo.Controls.Add(this.userControlCheckInOutHotel);
            this.panelInfo.Controls.Add(this.groupBoxDescribe);
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(312, 511);
            this.panelInfo.TabIndex = 0;
            this.panelInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInfo_Paint);
            // 
            // userControlTextBoxHotelPhone
            // 
            this.userControlTextBoxHotelPhone.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxHotelPhone.Image = ((System.Drawing.Image)(resources.GetObject("userControlTextBoxHotelPhone.Image")));
            this.userControlTextBoxHotelPhone.LabelText = "Số điện thoại";
            this.userControlTextBoxHotelPhone.Location = new System.Drawing.Point(9, 168);
            this.userControlTextBoxHotelPhone.Margin = new System.Windows.Forms.Padding(2);
            this.userControlTextBoxHotelPhone.Name = "userControlTextBoxHotelPhone";
            this.userControlTextBoxHotelPhone.Size = new System.Drawing.Size(300, 64);
            this.userControlTextBoxHotelPhone.TabIndex = 9;
            this.userControlTextBoxHotelPhone.TextBoxText = "";
            // 
            // userControlTextBoxHotelName
            // 
            this.userControlTextBoxHotelName.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxHotelName.Image = ((System.Drawing.Image)(resources.GetObject("userControlTextBoxHotelName.Image")));
            this.userControlTextBoxHotelName.LabelText = "Tên khách sạn";
            this.userControlTextBoxHotelName.Location = new System.Drawing.Point(9, 6);
            this.userControlTextBoxHotelName.Margin = new System.Windows.Forms.Padding(2);
            this.userControlTextBoxHotelName.Name = "userControlTextBoxHotelName";
            this.userControlTextBoxHotelName.Size = new System.Drawing.Size(300, 64);
            this.userControlTextBoxHotelName.TabIndex = 8;
            this.userControlTextBoxHotelName.TextBoxText = "";
            // 
            // userControlAddService
            // 
            this.userControlAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlAddService.GroupBoxText = "Dịch Vụ";
            this.userControlAddService.Location = new System.Drawing.Point(4, 305);
            this.userControlAddService.Name = "userControlAddService";
            this.userControlAddService.Services = ((System.Collections.Generic.List<string>)(resources.GetObject("userControlAddService.Services")));
            this.userControlAddService.Size = new System.Drawing.Size(300, 100);
            this.userControlAddService.TabIndex = 7;
            this.userControlAddService.TextBoxPlaceholderText = "Thêm dịch vụ";
            // 
            // userControlAddressHotel
            // 
            this.userControlAddressHotel.ComboBoxText = "";
            this.userControlAddressHotel.Location = new System.Drawing.Point(9, 74);
            this.userControlAddressHotel.Margin = new System.Windows.Forms.Padding(2);
            this.userControlAddressHotel.Name = "userControlAddressHotel";
            this.userControlAddressHotel.Size = new System.Drawing.Size(300, 90);
            this.userControlAddressHotel.TabIndex = 2;
            this.userControlAddressHotel.TextBoxText = "";
            // 
            // userControlCheckInOutHotel
            // 
            this.userControlCheckInOutHotel.Location = new System.Drawing.Point(9, 236);
            this.userControlCheckInOutHotel.Margin = new System.Windows.Forms.Padding(2);
            this.userControlCheckInOutHotel.MaskedTextBoxInText = "  :00";
            this.userControlCheckInOutHotel.MaskedTextBoxOutText = "  :00";
            this.userControlCheckInOutHotel.Name = "userControlCheckInOutHotel";
            this.userControlCheckInOutHotel.Size = new System.Drawing.Size(300, 64);
            this.userControlCheckInOutHotel.TabIndex = 4;
            // 
            // groupBoxDescribe
            // 
            this.groupBoxDescribe.Controls.Add(this.textBoxDescribe);
            this.groupBoxDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDescribe.Location = new System.Drawing.Point(9, 410);
            this.groupBoxDescribe.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDescribe.Name = "groupBoxDescribe";
            this.groupBoxDescribe.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDescribe.Size = new System.Drawing.Size(300, 99);
            this.groupBoxDescribe.TabIndex = 6;
            this.groupBoxDescribe.TabStop = false;
            this.groupBoxDescribe.Text = "Mô tả";
            // 
            // textBoxDescribe
            // 
            this.textBoxDescribe.AllowDrop = true;
            this.textBoxDescribe.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxDescribe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescribe.Location = new System.Drawing.Point(4, 19);
            this.textBoxDescribe.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescribe.Multiline = true;
            this.textBoxDescribe.Name = "textBoxDescribe";
            this.textBoxDescribe.Size = new System.Drawing.Size(291, 72);
            this.textBoxDescribe.TabIndex = 0;
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.pictureBoxImage);
            this.panelImage.Controls.Add(this.buttonRight);
            this.panelImage.Controls.Add(this.buttonLeft);
            this.panelImage.Controls.Add(this.buttonDeleteImage);
            this.panelImage.Controls.Add(this.buttonUploadImage);
            this.panelImage.Location = new System.Drawing.Point(316, 8);
            this.panelImage.Margin = new System.Windows.Forms.Padding(2);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(456, 447);
            this.panelImage.TabIndex = 7;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderRadius = 20;
            this.pictureBoxImage.FillColor = System.Drawing.SystemColors.Info;
            this.pictureBoxImage.Image = global::Project.Properties.Resources.noImage;
            this.pictureBoxImage.ImageRotate = 0F;
            this.pictureBoxImage.Location = new System.Drawing.Point(50, 20);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(360, 360);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 6;
            this.pictureBoxImage.TabStop = false;
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
            this.buttonRight.Location = new System.Drawing.Point(413, 188);
            this.buttonRight.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(22, 32);
            this.buttonRight.TabIndex = 9;
            this.buttonRight.Click += new System.EventHandler(this.ButtonRightClick);
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
            this.buttonLeft.Location = new System.Drawing.Point(24, 188);
            this.buttonLeft.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(22, 32);
            this.buttonLeft.TabIndex = 8;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonLeftClick);
            // 
            // buttonDeleteImage
            // 
            this.buttonDeleteImage.BackColor = System.Drawing.SystemColors.Info;
            this.buttonDeleteImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDeleteImage.BackgroundImage")));
            this.buttonDeleteImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteImage.Location = new System.Drawing.Point(244, 399);
            this.buttonDeleteImage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeleteImage.Name = "buttonDeleteImage";
            this.buttonDeleteImage.Size = new System.Drawing.Size(40, 40);
            this.buttonDeleteImage.TabIndex = 2;
            this.buttonDeleteImage.UseVisualStyleBackColor = false;
            this.buttonDeleteImage.Click += new System.EventHandler(this.ButtonDeleteImageClick);
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.BackColor = System.Drawing.SystemColors.Info;
            this.buttonUploadImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUploadImage.BackgroundImage")));
            this.buttonUploadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUploadImage.Location = new System.Drawing.Point(190, 399);
            this.buttonUploadImage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(40, 40);
            this.buttonUploadImage.TabIndex = 1;
            this.buttonUploadImage.UseVisualStyleBackColor = false;
            this.buttonUploadImage.Click += new System.EventHandler(this.ButtonUploadImageClick);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.buttonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.BackgroundImage")));
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdate.Location = new System.Drawing.Point(730, 463);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(40, 40);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // FUpdateHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(780, 512);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.buttonUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FUpdateHotel";
            this.Text = "FUpdateService";
            this.panelInfo.ResumeLayout(false);
            this.groupBoxDescribe.ResumeLayout(false);
            this.groupBoxDescribe.PerformLayout();
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonUpdate;
        private Panel panelInfo;
        private GroupBox groupBoxDescribe;
        private TextBox textBoxDescribe;
        private UserControlCheckInOutHotel userControlCheckInOutHotel;
        private Panel panelImage;
        private Button buttonUploadImage;
        private Button buttonDeleteImage;
        private UserControlAddressHotel userControlAddressHotel;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxImage;
        private Guna.UI2.WinForms.Guna2Button buttonRight;
        private Guna.UI2.WinForms.Guna2Button buttonLeft;
        private UserControlServiceEdit userControlAddService;
        private UserControlTextBoxHotel userControlTextBoxHotelPhone;
        private UserControlTextBoxHotel userControlTextBoxHotelName;
    }
}