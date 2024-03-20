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
            this.panelImage = new System.Windows.Forms.Panel();
            this.pictureBoxImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonRight = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLeft = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.userControlAddService = new Project.UserControlAddService();
            this.userControlAddressHotel = new Project.UserControlAddressHotel();
            this.userControlCheckInOutHotel = new Project.UserControlCheckInOutHotel();
            this.userControlTextBoxName = new Project.UserControls.UserControlTextBox();
            this.userControlTextBoxPhone = new Project.UserControls.UserControlTextBox();
            this.panelInfo.SuspendLayout();
            this.groupBoxDescribe.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo.Controls.Add(this.userControlAddService);
            this.panelInfo.Controls.Add(this.userControlAddressHotel);
            this.panelInfo.Controls.Add(this.userControlCheckInOutHotel);
            this.panelInfo.Controls.Add(this.userControlTextBoxName);
            this.panelInfo.Controls.Add(this.groupBoxDescribe);
            this.panelInfo.Controls.Add(this.userControlTextBoxPhone);
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(312, 511);
            this.panelInfo.TabIndex = 0;
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
            // userControlAddService
            // 
            this.userControlAddService.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlAddService.Location = new System.Drawing.Point(9, 305);
            this.userControlAddService.Name = "userControlAddService";
            this.userControlAddService.Services = ((System.Collections.Generic.List<string>)(resources.GetObject("userControlAddService.Services")));
            this.userControlAddService.Size = new System.Drawing.Size(300, 100);
            this.userControlAddService.TabIndex = 5;
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
            // userControlTextBoxName
            // 
            this.userControlTextBoxName.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxName.Image = ((System.Drawing.Image)(resources.GetObject("userControlTextBoxName.Image")));
            this.userControlTextBoxName.LabelText = "Tên khách sạn";
            this.userControlTextBoxName.Location = new System.Drawing.Point(9, 6);
            this.userControlTextBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.userControlTextBoxName.Name = "userControlTextBoxName";
            this.userControlTextBoxName.Size = new System.Drawing.Size(300, 64);
            this.userControlTextBoxName.TabIndex = 1;
            this.userControlTextBoxName.TextBoxText = "";
            // 
            // userControlTextBoxPhone
            // 
            this.userControlTextBoxPhone.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxPhone.Image = ((System.Drawing.Image)(resources.GetObject("userControlTextBoxPhone.Image")));
            this.userControlTextBoxPhone.LabelText = "Số Điện Thoại";
            this.userControlTextBoxPhone.Location = new System.Drawing.Point(9, 168);
            this.userControlTextBoxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.userControlTextBoxPhone.Name = "userControlTextBoxPhone";
            this.userControlTextBoxPhone.Size = new System.Drawing.Size(300, 64);
            this.userControlTextBoxPhone.TabIndex = 3;
            this.userControlTextBoxPhone.TextBoxText = "";
            // 
            // FUpdateService
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
            this.Name = "FUpdateService";
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
        private UserControlAddService userControlAddService;
    }
}