
namespace Project
{
    partial class UserControlNotificationService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlNotificationService));
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.labelSendingTime = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonCancel = new Guna.UI2.WinForms.Guna2Button();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.pictureBoxOut = new System.Windows.Forms.PictureBox();
            this.pictureBoxIn = new System.Windows.Forms.PictureBox();
            this.pictureBoxPrice = new System.Windows.Forms.PictureBox();
            this.pictureBoxRoom = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.panelRoad = new System.Windows.Forms.Panel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelIn = new System.Windows.Forms.Label();
            this.labelOut = new System.Windows.Forms.Label();
            this.labelNameRoom = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.circleButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.groupBox);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(700, 224);
            this.panel.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox.BorderRadius = 10;
            this.groupBox.BorderThickness = 3;
            this.groupBox.Controls.Add(this.circleButton);
            this.groupBox.Controls.Add(this.labelSendingTime);
            this.groupBox.Controls.Add(this.labelStatus);
            this.groupBox.Controls.Add(this.buttonCancel);
            this.groupBox.Controls.Add(this.groupBoxMessage);
            this.groupBox.Controls.Add(this.pictureBoxOut);
            this.groupBox.Controls.Add(this.pictureBoxIn);
            this.groupBox.Controls.Add(this.pictureBoxPrice);
            this.groupBox.Controls.Add(this.pictureBoxRoom);
            this.groupBox.Controls.Add(this.pictureBoxPhone);
            this.groupBox.Controls.Add(this.panelRoad);
            this.groupBox.Controls.Add(this.labelPrice);
            this.groupBox.Controls.Add(this.labelIn);
            this.groupBox.Controls.Add(this.labelOut);
            this.groupBox.Controls.Add(this.labelNameRoom);
            this.groupBox.Controls.Add(this.labelPhone);
            this.groupBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(700, 224);
            this.groupBox.TabIndex = 2;
            this.groupBox.Text = "Tên Khách Sạn";
            this.groupBox.TextOffset = new System.Drawing.Point(0, -3);
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
            this.labelStatus.Location = new System.Drawing.Point(6, 188);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(246, 22);
            this.labelStatus.TabIndex = 33;
            this.labelStatus.Text = "Trạng thái: đang chờ xác nhận";
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonCancel.BorderRadius = 10;
            this.buttonCancel.BorderThickness = 2;
            this.buttonCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonCancel.FillColor = System.Drawing.Color.Yellow;
            this.buttonCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Black;
            this.buttonCancel.Location = new System.Drawing.Point(572, 185);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(117, 30);
            this.buttonCancel.TabIndex = 32;
            this.buttonCancel.Text = "Hủy phòng";
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.Controls.Add(this.richTextBoxMessage);
            this.groupBoxMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMessage.Location = new System.Drawing.Point(359, 33);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Size = new System.Drawing.Size(336, 64);
            this.groupBoxMessage.TabIndex = 26;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "Lời nhắn từ khách sạn";
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.BackColor = System.Drawing.Color.White;
            this.richTextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMessage.Location = new System.Drawing.Point(7, 18);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.ReadOnly = true;
            this.richTextBoxMessage.Size = new System.Drawing.Size(323, 38);
            this.richTextBoxMessage.TabIndex = 0;
            this.richTextBoxMessage.Text = "Rất hân hạnh được phục vụ quý khách\nSự hài lòng của quý khách là thành công của c" +
    "húng tôi.\n";
            // 
            // pictureBoxOut
            // 
            this.pictureBoxOut.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOut.Image")));
            this.pictureBoxOut.Location = new System.Drawing.Point(360, 143);
            this.pictureBoxOut.Name = "pictureBoxOut";
            this.pictureBoxOut.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOut.TabIndex = 25;
            this.pictureBoxOut.TabStop = false;
            // 
            // pictureBoxIn
            // 
            this.pictureBoxIn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIn.Image")));
            this.pictureBoxIn.Location = new System.Drawing.Point(360, 107);
            this.pictureBoxIn.Name = "pictureBoxIn";
            this.pictureBoxIn.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIn.TabIndex = 24;
            this.pictureBoxIn.TabStop = false;
            // 
            // pictureBoxPrice
            // 
            this.pictureBoxPrice.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrice.Image")));
            this.pictureBoxPrice.Location = new System.Drawing.Point(10, 126);
            this.pictureBoxPrice.Name = "pictureBoxPrice";
            this.pictureBoxPrice.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPrice.TabIndex = 23;
            this.pictureBoxPrice.TabStop = false;
            // 
            // pictureBoxRoom
            // 
            this.pictureBoxRoom.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRoom.Image")));
            this.pictureBoxRoom.Location = new System.Drawing.Point(10, 90);
            this.pictureBoxRoom.Name = "pictureBoxRoom";
            this.pictureBoxRoom.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRoom.TabIndex = 22;
            this.pictureBoxRoom.TabStop = false;
            // 
            // pictureBoxPhone
            // 
            this.pictureBoxPhone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhone.Image")));
            this.pictureBoxPhone.Location = new System.Drawing.Point(10, 54);
            this.pictureBoxPhone.Name = "pictureBoxPhone";
            this.pictureBoxPhone.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhone.TabIndex = 21;
            this.pictureBoxPhone.TabStop = false;
            // 
            // panelRoad
            // 
            this.panelRoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelRoad.Location = new System.Drawing.Point(5, 178);
            this.panelRoad.Margin = new System.Windows.Forms.Padding(2);
            this.panelRoad.Name = "panelRoad";
            this.panelRoad.Size = new System.Drawing.Size(690, 2);
            this.panelRoad.TabIndex = 15;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoEllipsis = true;
            this.labelPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(45, 134);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(300, 22);
            this.labelPrice.TabIndex = 13;
            this.labelPrice.Text = "Tiền đặt cọc: 100000";
            // 
            // labelIn
            // 
            this.labelIn.AutoEllipsis = true;
            this.labelIn.BackColor = System.Drawing.Color.Transparent;
            this.labelIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIn.Location = new System.Drawing.Point(395, 115);
            this.labelIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(300, 22);
            this.labelIn.TabIndex = 5;
            this.labelIn.Text = "Check out: 26/04/2004 16:00";
            // 
            // labelOut
            // 
            this.labelOut.AutoEllipsis = true;
            this.labelOut.BackColor = System.Drawing.Color.Transparent;
            this.labelOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOut.Location = new System.Drawing.Point(395, 151);
            this.labelOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(300, 22);
            this.labelOut.TabIndex = 4;
            this.labelOut.Text = "Check in: 26/04/2004 16:00";
            // 
            // labelNameRoom
            // 
            this.labelNameRoom.AutoEllipsis = true;
            this.labelNameRoom.BackColor = System.Drawing.Color.Transparent;
            this.labelNameRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameRoom.Location = new System.Drawing.Point(45, 98);
            this.labelNameRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameRoom.Name = "labelNameRoom";
            this.labelNameRoom.Size = new System.Drawing.Size(300, 22);
            this.labelNameRoom.TabIndex = 3;
            this.labelNameRoom.Text = "Tên phòng : P01";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoEllipsis = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(45, 62);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(300, 22);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "SĐT: 0336849370";
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
            this.circleButton.TabIndex = 34;
            this.circleButton.Click += new System.EventHandler(this.CircleButtonClick);
            // 
            // UserControlNotificationService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel);
            this.Name = "UserControlNotificationService";
            this.Size = new System.Drawing.Size(700, 224);
            this.panel.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBoxMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
        private System.Windows.Forms.Label labelStatus;
        private Guna.UI2.WinForms.Guna2Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.PictureBox pictureBoxOut;
        private System.Windows.Forms.PictureBox pictureBoxIn;
        private System.Windows.Forms.PictureBox pictureBoxPrice;
        private System.Windows.Forms.PictureBox pictureBoxRoom;
        private System.Windows.Forms.PictureBox pictureBoxPhone;
        private System.Windows.Forms.Panel panelRoad;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Label labelNameRoom;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelSendingTime;
        private Guna.UI2.WinForms.Guna2CircleButton circleButton;
    }
}
