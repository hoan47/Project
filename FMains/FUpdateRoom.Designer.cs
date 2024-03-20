
namespace Project.FMains
{
    partial class FUpdateRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUpdateRoom));
            this.panelImage = new System.Windows.Forms.Panel();
            this.pictureBoxImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonRight = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLeft = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.userControlServiceEdit1 = new Project.UserControlServiceEdit();
            this.userControlNumeric3 = new Project.UserControlNumeric();
            this.userControlNumeric2 = new Project.UserControlNumeric();
            this.userControlNumeric1 = new Project.UserControlNumeric();
            this.userControlTextBoxHotel2 = new Project.UserControlTextBoxHotel();
            this.userControlTextBoxHotelName = new Project.UserControlTextBoxHotel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.userControlTextBoxHotel3 = new Project.UserControlTextBoxHotel();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.pictureBoxImage);
            this.panelImage.Controls.Add(this.buttonRight);
            this.panelImage.Controls.Add(this.buttonLeft);
            this.panelImage.Controls.Add(this.buttonDeleteImage);
            this.panelImage.Controls.Add(this.buttonUploadImage);
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Margin = new System.Windows.Forms.Padding(2);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(456, 447);
            this.panelImage.TabIndex = 8;
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
            // 
            // userControlServiceEdit1
            // 
            this.userControlServiceEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlServiceEdit1.GroupBoxText = "Tiện nghi";
            this.userControlServiceEdit1.Location = new System.Drawing.Point(460, 216);
            this.userControlServiceEdit1.Name = "userControlServiceEdit1";
            this.userControlServiceEdit1.Services = ((System.Collections.Generic.List<string>)(resources.GetObject("userControlServiceEdit1.Services")));
            this.userControlServiceEdit1.Size = new System.Drawing.Size(300, 100);
            this.userControlServiceEdit1.TabIndex = 12;
            this.userControlServiceEdit1.TextBoxPlaceholderText = "Thêm tiện nghi";
            // 
            // userControlNumeric3
            // 
            this.userControlNumeric3.GrupBoxText = "Số giường";
            this.userControlNumeric3.Image = ((System.Drawing.Image)(resources.GetObject("userControlNumeric3.Image")));
            this.userControlNumeric3.Location = new System.Drawing.Point(566, 322);
            this.userControlNumeric3.Name = "userControlNumeric3";
            this.userControlNumeric3.NumericValue = 0;
            this.userControlNumeric3.Size = new System.Drawing.Size(100, 55);
            this.userControlNumeric3.TabIndex = 11;
            // 
            // userControlNumeric2
            // 
            this.userControlNumeric2.GrupBoxText = "Số phòng";
            this.userControlNumeric2.Image = ((System.Drawing.Image)(resources.GetObject("userControlNumeric2.Image")));
            this.userControlNumeric2.Location = new System.Drawing.Point(460, 322);
            this.userControlNumeric2.Name = "userControlNumeric2";
            this.userControlNumeric2.NumericValue = 0;
            this.userControlNumeric2.Size = new System.Drawing.Size(100, 55);
            this.userControlNumeric2.TabIndex = 10;
            // 
            // userControlNumeric1
            // 
            this.userControlNumeric1.GrupBoxText = "Số người";
            this.userControlNumeric1.Image = ((System.Drawing.Image)(resources.GetObject("userControlNumeric1.Image")));
            this.userControlNumeric1.Location = new System.Drawing.Point(460, 383);
            this.userControlNumeric1.Name = "userControlNumeric1";
            this.userControlNumeric1.NumericValue = 0;
            this.userControlNumeric1.Size = new System.Drawing.Size(100, 55);
            this.userControlNumeric1.TabIndex = 9;
            // 
            // userControlTextBoxHotel2
            // 
            this.userControlTextBoxHotel2.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxHotel2.Image = ((System.Drawing.Image)(resources.GetObject("userControlTextBoxHotel2.Image")));
            this.userControlTextBoxHotel2.LabelText = "Giá phòng";
            this.userControlTextBoxHotel2.Location = new System.Drawing.Point(460, 79);
            this.userControlTextBoxHotel2.Margin = new System.Windows.Forms.Padding(2);
            this.userControlTextBoxHotel2.Name = "userControlTextBoxHotel2";
            this.userControlTextBoxHotel2.Size = new System.Drawing.Size(300, 64);
            this.userControlTextBoxHotel2.TabIndex = 1;
            this.userControlTextBoxHotel2.TextBoxText = "";
            // 
            // userControlTextBoxHotelName
            // 
            this.userControlTextBoxHotelName.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxHotelName.Image = ((System.Drawing.Image)(resources.GetObject("userControlTextBoxHotelName.Image")));
            this.userControlTextBoxHotelName.LabelText = "Tên phòng";
            this.userControlTextBoxHotelName.Location = new System.Drawing.Point(460, 11);
            this.userControlTextBoxHotelName.Margin = new System.Windows.Forms.Padding(2);
            this.userControlTextBoxHotelName.Name = "userControlTextBoxHotelName";
            this.userControlTextBoxHotelName.Size = new System.Drawing.Size(300, 64);
            this.userControlTextBoxHotelName.TabIndex = 0;
            this.userControlTextBoxHotelName.TextBoxText = "";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.buttonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.BackgroundImage")));
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdate.Location = new System.Drawing.Point(713, 422);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(40, 40);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // userControlTextBoxHotel3
            // 
            this.userControlTextBoxHotel3.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxHotel3.Image = ((System.Drawing.Image)(resources.GetObject("userControlTextBoxHotel3.Image")));
            this.userControlTextBoxHotel3.LabelText = "Diện tích phòng";
            this.userControlTextBoxHotel3.Location = new System.Drawing.Point(460, 147);
            this.userControlTextBoxHotel3.Margin = new System.Windows.Forms.Padding(2);
            this.userControlTextBoxHotel3.Name = "userControlTextBoxHotel3";
            this.userControlTextBoxHotel3.Size = new System.Drawing.Size(300, 64);
            this.userControlTextBoxHotel3.TabIndex = 14;
            this.userControlTextBoxHotel3.TextBoxText = "";
            // 
            // FUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(764, 473);
            this.Controls.Add(this.userControlTextBoxHotel3);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.userControlServiceEdit1);
            this.Controls.Add(this.userControlNumeric3);
            this.Controls.Add(this.userControlNumeric2);
            this.Controls.Add(this.userControlNumeric1);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.userControlTextBoxHotel2);
            this.Controls.Add(this.userControlTextBoxHotelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FUpdateRoom";
            this.Text = "FUpdateRoom";
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlTextBoxHotel userControlTextBoxHotelName;
        private System.Windows.Forms.Panel panelImage;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxImage;
        private Guna.UI2.WinForms.Guna2Button buttonRight;
        private Guna.UI2.WinForms.Guna2Button buttonLeft;
        private System.Windows.Forms.Button buttonDeleteImage;
        private System.Windows.Forms.Button buttonUploadImage;
        private UserControlTextBoxHotel userControlTextBoxHotel2;
        private UserControlNumeric userControlNumeric1;
        private UserControlNumeric userControlNumeric2;
        private UserControlNumeric userControlNumeric3;
        private UserControlServiceEdit userControlServiceEdit1;
        private System.Windows.Forms.Button buttonUpdate;
        private UserControlTextBoxHotel userControlTextBoxHotel3;
    }
}