
namespace Project
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
            this.pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonRight = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLeft = new Guna.UI2.WinForms.Guna2Button();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.userControlTextBoxAcreage = new Project.UserControlTextBoxService();
            this.userControlServiceEdit = new Project.UserControlServiceEdit();
            this.userControlNumericNumnberBed = new Project.UserControlNumeric();
            this.userControlNumericNumberRoom = new Project.UserControlNumeric();
            this.userControlNumericNumberPeople = new Project.UserControlNumeric();
            this.userControlTextBoxServiceName = new Project.UserControlTextBoxService();
            this.userControlPrice = new Project.UserControls.UserControlPrice();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelImage
            // 
            this.panelImage.Controls.Add(this.pictureBox);
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
            // pictureBox
            // 
            this.pictureBox.BorderRadius = 20;
            this.pictureBox.FillColor = System.Drawing.SystemColors.Info;
            this.pictureBox.Image = global::Project.Properties.Resources.noImage;
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.Location = new System.Drawing.Point(50, 20);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(360, 360);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
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
            this.buttonDeleteImage.BackColor = System.Drawing.Color.LightCyan;
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
            this.buttonUploadImage.BackColor = System.Drawing.Color.LightCyan;
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
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.BorderRadius = 10;
            this.buttonBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBack.FillColor = System.Drawing.Color.Transparent;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(730, 6);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 40);
            this.buttonBack.TabIndex = 15;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBackClick);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.LightCyan;
            this.buttonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.BackgroundImage")));
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdate.Location = new System.Drawing.Point(729, 461);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(40, 40);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // userControlTextBoxAcreage
            // 
            this.userControlTextBoxAcreage.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxAcreage.Image = ((System.Drawing.Image)(resources.GetObject("userControlTextBoxAcreage.Image")));
            this.userControlTextBoxAcreage.LabelText = "Diện tích phòng";
            this.userControlTextBoxAcreage.Location = new System.Drawing.Point(469, 119);
            this.userControlTextBoxAcreage.Margin = new System.Windows.Forms.Padding(2);
            this.userControlTextBoxAcreage.Name = "userControlTextBoxAcreage";
            this.userControlTextBoxAcreage.Size = new System.Drawing.Size(300, 64);
            this.userControlTextBoxAcreage.TabIndex = 14;
            this.userControlTextBoxAcreage.TextBoxPlaceholderText = "Mét vuông";
            this.userControlTextBoxAcreage.TextBoxText = "";
            // 
            // userControlServiceEdit
            // 
            this.userControlServiceEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlServiceEdit.GroupBoxText = "Tiện nghi";
            this.userControlServiceEdit.ListBoxBackColor = System.Drawing.Color.LightCyan;
            this.userControlServiceEdit.Location = new System.Drawing.Point(469, 188);
            this.userControlServiceEdit.Name = "userControlServiceEdit";
            this.userControlServiceEdit.Size = new System.Drawing.Size(300, 100);
            this.userControlServiceEdit.TabIndex = 12;
            this.userControlServiceEdit.TextBoxPlaceholderText = "Thêm tiện nghi";
            this.userControlServiceEdit.Value = ((System.Collections.Generic.List<string>)(resources.GetObject("userControlServiceEdit.Value")));
            // 
            // userControlNumericNumnberBed
            // 
            this.userControlNumericNumnberBed.GrupBoxText = "Số giường";
            this.userControlNumericNumnberBed.Image = ((System.Drawing.Image)(resources.GetObject("userControlNumericNumnberBed.Image")));
            this.userControlNumericNumnberBed.Location = new System.Drawing.Point(575, 356);
            this.userControlNumericNumnberBed.Name = "userControlNumericNumnberBed";
            this.userControlNumericNumnberBed.NumericValue = 1;
            this.userControlNumericNumnberBed.Size = new System.Drawing.Size(100, 55);
            this.userControlNumericNumnberBed.TabIndex = 11;
            // 
            // userControlNumericNumberRoom
            // 
            this.userControlNumericNumberRoom.GrupBoxText = "Số phòng ngủ";
            this.userControlNumericNumberRoom.Image = ((System.Drawing.Image)(resources.GetObject("userControlNumericNumberRoom.Image")));
            this.userControlNumericNumberRoom.Location = new System.Drawing.Point(469, 356);
            this.userControlNumericNumberRoom.Name = "userControlNumericNumberRoom";
            this.userControlNumericNumberRoom.NumericValue = 1;
            this.userControlNumericNumberRoom.Size = new System.Drawing.Size(100, 55);
            this.userControlNumericNumberRoom.TabIndex = 10;
            // 
            // userControlNumericNumberPeople
            // 
            this.userControlNumericNumberPeople.GrupBoxText = "Số người";
            this.userControlNumericNumberPeople.Image = ((System.Drawing.Image)(resources.GetObject("userControlNumericNumberPeople.Image")));
            this.userControlNumericNumberPeople.Location = new System.Drawing.Point(469, 417);
            this.userControlNumericNumberPeople.Name = "userControlNumericNumberPeople";
            this.userControlNumericNumberPeople.NumericValue = 1;
            this.userControlNumericNumberPeople.Size = new System.Drawing.Size(100, 55);
            this.userControlNumericNumberPeople.TabIndex = 9;
            // 
            // userControlTextBoxServiceName
            // 
            this.userControlTextBoxServiceName.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxServiceName.Image = ((System.Drawing.Image)(resources.GetObject("userControlTextBoxServiceName.Image")));
            this.userControlTextBoxServiceName.LabelText = "Tên phòng";
            this.userControlTextBoxServiceName.Location = new System.Drawing.Point(469, 51);
            this.userControlTextBoxServiceName.Margin = new System.Windows.Forms.Padding(2);
            this.userControlTextBoxServiceName.Name = "userControlTextBoxServiceName";
            this.userControlTextBoxServiceName.Size = new System.Drawing.Size(300, 64);
            this.userControlTextBoxServiceName.TabIndex = 0;
            this.userControlTextBoxServiceName.TextBoxPlaceholderText = "";
            this.userControlTextBoxServiceName.TextBoxText = "";
            // 
            // userControlPrice
            // 
            this.userControlPrice.BackColor = System.Drawing.Color.Transparent;
            this.userControlPrice.ColorUserControl = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.userControlPrice.Location = new System.Drawing.Point(469, 294);
            this.userControlPrice.Name = "userControlPrice";
            this.userControlPrice.Price = 0;
            this.userControlPrice.Size = new System.Drawing.Size(256, 56);
            this.userControlPrice.TabIndex = 16;
            // 
            // FUpdateRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(780, 512);
            this.Controls.Add(this.userControlPrice);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.userControlTextBoxAcreage);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.userControlServiceEdit);
            this.Controls.Add(this.userControlNumericNumnberBed);
            this.Controls.Add(this.userControlNumericNumberRoom);
            this.Controls.Add(this.userControlNumericNumberPeople);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.userControlTextBoxServiceName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FUpdateRoom";
            this.Text = "FUpdateRoom";
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlTextBoxService userControlTextBoxServiceName;
        private System.Windows.Forms.Panel panelImage;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2Button buttonRight;
        private Guna.UI2.WinForms.Guna2Button buttonLeft;
        private System.Windows.Forms.Button buttonDeleteImage;
        private System.Windows.Forms.Button buttonUploadImage;
        private UserControlNumeric userControlNumericNumberPeople;
        private UserControlNumeric userControlNumericNumberRoom;
        private UserControlNumeric userControlNumericNumnberBed;
        private UserControlServiceEdit userControlServiceEdit;
        private System.Windows.Forms.Button buttonUpdate;
        private UserControlTextBoxService userControlTextBoxAcreage;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private UserControls.UserControlPrice userControlPrice;
    }
}