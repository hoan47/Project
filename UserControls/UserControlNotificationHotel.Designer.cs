﻿
namespace Project
{
    partial class UserControlNotificationHotel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlNotificationHotel));
            this.groupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.circleButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.labelSendingTime = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonProcessed = new Guna.UI2.WinForms.Guna2Button();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.pictureBoxOut = new System.Windows.Forms.PictureBox();
            this.pictureBoxIn = new System.Windows.Forms.PictureBox();
            this.pictureBoxPrice = new System.Windows.Forms.PictureBox();
            this.pictureBoxRoom = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.pictureBoxNameClient = new System.Windows.Forms.PictureBox();
            this.panelRoad = new System.Windows.Forms.Panel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelIn = new System.Windows.Forms.Label();
            this.labelOut = new System.Windows.Forms.Label();
            this.labelNameRoom = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelNameHotel = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNameClient)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BorderColor = System.Drawing.Color.Yellow;
            this.groupBox.BorderRadius = 10;
            this.groupBox.BorderThickness = 3;
            this.groupBox.Controls.Add(this.circleButton);
            this.groupBox.Controls.Add(this.labelSendingTime);
            this.groupBox.Controls.Add(this.labelStatus);
            this.groupBox.Controls.Add(this.buttonProcessed);
            this.groupBox.Controls.Add(this.groupBoxMessage);
            this.groupBox.Controls.Add(this.pictureBoxOut);
            this.groupBox.Controls.Add(this.pictureBoxIn);
            this.groupBox.Controls.Add(this.pictureBoxPrice);
            this.groupBox.Controls.Add(this.pictureBoxRoom);
            this.groupBox.Controls.Add(this.pictureBoxPhone);
            this.groupBox.Controls.Add(this.pictureBoxNameClient);
            this.groupBox.Controls.Add(this.panelRoad);
            this.groupBox.Controls.Add(this.labelPrice);
            this.groupBox.Controls.Add(this.labelIn);
            this.groupBox.Controls.Add(this.labelOut);
            this.groupBox.Controls.Add(this.labelNameRoom);
            this.groupBox.Controls.Add(this.labelPhone);
            this.groupBox.Controls.Add(this.labelNameHotel);
            this.groupBox.CustomBorderColor = System.Drawing.Color.Yellow;
            this.groupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(700, 232);
            this.groupBox.TabIndex = 3;
            this.groupBox.Text = "Tên khách hàng:";
            this.groupBox.TextOffset = new System.Drawing.Point(0, -3);
            // 
            // circleButton
            // 
            this.circleButton.BackColor = System.Drawing.Color.Transparent;
            this.circleButton.BorderColor = System.Drawing.Color.Transparent;
            this.circleButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.circleButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.circleButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.circleButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.circleButton.FillColor = System.Drawing.Color.Red;
            this.circleButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.circleButton.ForeColor = System.Drawing.Color.White;
            this.circleButton.Location = new System.Drawing.Point(672, 3);
            this.circleButton.Name = "circleButton";
            this.circleButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleButton.Size = new System.Drawing.Size(25, 25);
            this.circleButton.TabIndex = 33;
            this.circleButton.Click += new System.EventHandler(this.CircleButtonClick);
            // 
            // labelSendingTime
            // 
            this.labelSendingTime.BackColor = System.Drawing.Color.Transparent;
            this.labelSendingTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSendingTime.Location = new System.Drawing.Point(224, 3);
            this.labelSendingTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSendingTime.Name = "labelSendingTime";
            this.labelSendingTime.Size = new System.Drawing.Size(300, 22);
            this.labelSendingTime.TabIndex = 32;
            this.labelSendingTime.Text = "Vào lúc: 26/04/2004 16:00";
            this.labelSendingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(9, 195);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(589, 22);
            this.labelStatus.TabIndex = 29;
            this.labelStatus.Text = "Trạng thái: đang chờ xác nhận";
            // 
            // buttonProcessed
            // 
            this.buttonProcessed.BackColor = System.Drawing.Color.Transparent;
            this.buttonProcessed.BorderRadius = 10;
            this.buttonProcessed.BorderThickness = 2;
            this.buttonProcessed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonProcessed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonProcessed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonProcessed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonProcessed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonProcessed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcessed.ForeColor = System.Drawing.Color.Black;
            this.buttonProcessed.Location = new System.Drawing.Point(603, 192);
            this.buttonProcessed.Name = "buttonProcessed";
            this.buttonProcessed.Size = new System.Drawing.Size(85, 30);
            this.buttonProcessed.TabIndex = 28;
            this.buttonProcessed.Text = "Xử lí";
            this.buttonProcessed.Click += new System.EventHandler(this.ButtonProcessedClick);
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMessage.Controls.Add(this.richTextBoxMessage);
            this.groupBoxMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMessage.Location = new System.Drawing.Point(358, 33);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(336, 76);
            this.groupBoxMessage.TabIndex = 27;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "Lời nhắn từ khách hàng";
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.BackColor = System.Drawing.Color.White;
            this.richTextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMessage.Location = new System.Drawing.Point(7, 18);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.ReadOnly = true;
            this.richTextBoxMessage.Size = new System.Drawing.Size(323, 52);
            this.richTextBoxMessage.TabIndex = 0;
            this.richTextBoxMessage.Text = "Mong không bị lừa đảo";
            // 
            // pictureBoxOut
            // 
            this.pictureBoxOut.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOut.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOut.Image")));
            this.pictureBoxOut.Location = new System.Drawing.Point(359, 151);
            this.pictureBoxOut.Name = "pictureBoxOut";
            this.pictureBoxOut.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOut.TabIndex = 25;
            this.pictureBoxOut.TabStop = false;
            // 
            // pictureBoxIn
            // 
            this.pictureBoxIn.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIn.Image")));
            this.pictureBoxIn.Location = new System.Drawing.Point(359, 115);
            this.pictureBoxIn.Name = "pictureBoxIn";
            this.pictureBoxIn.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIn.TabIndex = 24;
            this.pictureBoxIn.TabStop = false;
            // 
            // pictureBoxPrice
            // 
            this.pictureBoxPrice.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPrice.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrice.Image")));
            this.pictureBoxPrice.Location = new System.Drawing.Point(10, 148);
            this.pictureBoxPrice.Name = "pictureBoxPrice";
            this.pictureBoxPrice.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPrice.TabIndex = 23;
            this.pictureBoxPrice.TabStop = false;
            // 
            // pictureBoxRoom
            // 
            this.pictureBoxRoom.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRoom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRoom.Image")));
            this.pictureBoxRoom.Location = new System.Drawing.Point(10, 112);
            this.pictureBoxRoom.Name = "pictureBoxRoom";
            this.pictureBoxRoom.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRoom.TabIndex = 22;
            this.pictureBoxRoom.TabStop = false;
            // 
            // pictureBoxPhone
            // 
            this.pictureBoxPhone.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPhone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhone.Image")));
            this.pictureBoxPhone.Location = new System.Drawing.Point(10, 76);
            this.pictureBoxPhone.Name = "pictureBoxPhone";
            this.pictureBoxPhone.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhone.TabIndex = 21;
            this.pictureBoxPhone.TabStop = false;
            // 
            // pictureBoxNameClient
            // 
            this.pictureBoxNameClient.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNameClient.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNameClient.Image")));
            this.pictureBoxNameClient.Location = new System.Drawing.Point(10, 40);
            this.pictureBoxNameClient.Name = "pictureBoxNameClient";
            this.pictureBoxNameClient.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxNameClient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNameClient.TabIndex = 20;
            this.pictureBoxNameClient.TabStop = false;
            // 
            // panelRoad
            // 
            this.panelRoad.BackColor = System.Drawing.Color.Yellow;
            this.panelRoad.Location = new System.Drawing.Point(5, 185);
            this.panelRoad.Margin = new System.Windows.Forms.Padding(2);
            this.panelRoad.Name = "panelRoad";
            this.panelRoad.Size = new System.Drawing.Size(690, 2);
            this.panelRoad.TabIndex = 15;
            // 
            // labelPrice
            // 
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(45, 156);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(300, 22);
            this.labelPrice.TabIndex = 13;
            this.labelPrice.Text = "Tiền đặt cọc: 100000";
            // 
            // labelIn
            // 
            this.labelIn.BackColor = System.Drawing.Color.Transparent;
            this.labelIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIn.Location = new System.Drawing.Point(394, 123);
            this.labelIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(300, 22);
            this.labelIn.TabIndex = 5;
            this.labelIn.Text = "Check out: 26/04/2004 16:00";
            // 
            // labelOut
            // 
            this.labelOut.BackColor = System.Drawing.Color.Transparent;
            this.labelOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOut.Location = new System.Drawing.Point(394, 159);
            this.labelOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(300, 22);
            this.labelOut.TabIndex = 4;
            this.labelOut.Text = "Check in: 26/04/2004 16:00";
            // 
            // labelNameRoom
            // 
            this.labelNameRoom.BackColor = System.Drawing.Color.Transparent;
            this.labelNameRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameRoom.Location = new System.Drawing.Point(45, 120);
            this.labelNameRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameRoom.Name = "labelNameRoom";
            this.labelNameRoom.Size = new System.Drawing.Size(300, 22);
            this.labelNameRoom.TabIndex = 3;
            this.labelNameRoom.Text = "Tên phòng: P01";
            // 
            // labelPhone
            // 
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(45, 84);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(300, 22);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "SĐT: 0336849370";
            // 
            // labelNameHotel
            // 
            this.labelNameHotel.BackColor = System.Drawing.Color.Transparent;
            this.labelNameHotel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameHotel.Location = new System.Drawing.Point(45, 48);
            this.labelNameHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameHotel.Name = "labelNameHotel";
            this.labelNameHotel.Size = new System.Drawing.Size(300, 22);
            this.labelNameHotel.TabIndex = 1;
            this.labelNameHotel.Text = "Khách sạn : Nguyễn Văn Hưng";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.groupBox);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(700, 232);
            this.panel.TabIndex = 4;
            // 
            // UserControlNotificationHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "UserControlNotificationHotel";
            this.Size = new System.Drawing.Size(700, 232);
            this.groupBox.ResumeLayout(false);
            this.groupBoxMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNameClient)).EndInit();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
        private System.Windows.Forms.Label labelStatus;
        private Guna.UI2.WinForms.Guna2Button buttonProcessed;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.PictureBox pictureBoxOut;
        private System.Windows.Forms.PictureBox pictureBoxIn;
        private System.Windows.Forms.PictureBox pictureBoxPrice;
        private System.Windows.Forms.PictureBox pictureBoxRoom;
        private System.Windows.Forms.PictureBox pictureBoxPhone;
        private System.Windows.Forms.PictureBox pictureBoxNameClient;
        private System.Windows.Forms.Panel panelRoad;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Label labelNameRoom;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelNameHotel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label labelSendingTime;
        private Guna.UI2.WinForms.Guna2CircleButton circleButton;
    }
}
