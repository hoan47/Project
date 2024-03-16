
namespace Project
{

    partial class UserControlHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHotel));
            this.groupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pictureBoxHotel = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelNumber = new System.Windows.Forms.Label();
            this.pictureNumber = new System.Windows.Forms.PictureBox();
            this.groupBoxNumber = new System.Windows.Forms.GroupBox();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.pictureBoxAddress = new System.Windows.Forms.PictureBox();
            this.groupBoxPrice = new System.Windows.Forms.GroupBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.pictureBoxPrice = new System.Windows.Forms.PictureBox();
            this.groupBoxPhone = new System.Windows.Forms.GroupBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNumber)).BeginInit();
            this.groupBoxNumber.SuspendLayout();
            this.groupBoxAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddress)).BeginInit();
            this.groupBoxPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrice)).BeginInit();
            this.groupBoxPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox.BorderRadius = 10;
            this.groupBox.BorderThickness = 3;
            this.groupBox.Controls.Add(this.groupBoxPhone);
            this.groupBox.Controls.Add(this.groupBoxPrice);
            this.groupBox.Controls.Add(this.groupBoxAddress);
            this.groupBox.Controls.Add(this.groupBoxNumber);
            this.groupBox.Controls.Add(this.pictureBoxHotel);
            this.groupBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(860, 265);
            this.groupBox.TabIndex = 11;
            this.groupBox.Text = "Khách sạn: ILove";
            this.groupBox.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            // 
            // pictureBoxHotel
            // 
            this.pictureBoxHotel.BackColor = System.Drawing.Color.White;
            this.pictureBoxHotel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxHotel.BorderRadius = 20;
            this.pictureBoxHotel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHotel.Image")));
            this.pictureBoxHotel.ImageRotate = 0F;
            this.pictureBoxHotel.Location = new System.Drawing.Point(15, 54);
            this.pictureBoxHotel.Name = "pictureBoxHotel";
            this.pictureBoxHotel.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHotel.TabIndex = 11;
            this.pictureBoxHotel.TabStop = false;
            this.pictureBoxHotel.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            // 
            // labelNumber
            // 
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumber.Location = new System.Drawing.Point(52, 36);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(238, 32);
            this.labelNumber.TabIndex = 1;
            this.labelNumber.Text = "label1";
            this.labelNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNumber.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            // 
            // pictureNumber
            // 
            this.pictureNumber.Image = ((System.Drawing.Image)(resources.GetObject("pictureNumber.Image")));
            this.pictureNumber.Location = new System.Drawing.Point(6, 28);
            this.pictureNumber.Name = "pictureNumber";
            this.pictureNumber.Size = new System.Drawing.Size(40, 40);
            this.pictureNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureNumber.TabIndex = 0;
            this.pictureNumber.TabStop = false;
            this.pictureNumber.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            // 
            // groupBoxNumber
            // 
            this.groupBoxNumber.Controls.Add(this.labelNumber);
            this.groupBoxNumber.Controls.Add(this.pictureNumber);
            this.groupBoxNumber.Location = new System.Drawing.Point(233, 66);
            this.groupBoxNumber.Name = "groupBoxNumber";
            this.groupBoxNumber.Size = new System.Drawing.Size(300, 74);
            this.groupBoxNumber.TabIndex = 12;
            this.groupBoxNumber.TabStop = false;
            this.groupBoxNumber.Text = "Số Phòng";
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.Controls.Add(this.labelAddress);
            this.groupBoxAddress.Controls.Add(this.pictureBoxAddress);
            this.groupBoxAddress.Location = new System.Drawing.Point(539, 66);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new System.Drawing.Size(300, 74);
            this.groupBoxAddress.TabIndex = 13;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Địa Chỉ";
            // 
            // labelAddress
            // 
            this.labelAddress.BackColor = System.Drawing.Color.Transparent;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(52, 36);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(238, 32);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "label1";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelAddress.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            // 
            // pictureBoxAddress
            // 
            this.pictureBoxAddress.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddress.Image")));
            this.pictureBoxAddress.Location = new System.Drawing.Point(6, 28);
            this.pictureBoxAddress.Name = "pictureBoxAddress";
            this.pictureBoxAddress.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAddress.TabIndex = 0;
            this.pictureBoxAddress.TabStop = false;
            this.pictureBoxAddress.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            // 
            // groupBoxPrice
            // 
            this.groupBoxPrice.Controls.Add(this.labelPrice);
            this.groupBoxPrice.Controls.Add(this.pictureBoxPrice);
            this.groupBoxPrice.Location = new System.Drawing.Point(233, 162);
            this.groupBoxPrice.Name = "groupBoxPrice";
            this.groupBoxPrice.Size = new System.Drawing.Size(300, 74);
            this.groupBoxPrice.TabIndex = 13;
            this.groupBoxPrice.TabStop = false;
            this.groupBoxPrice.Text = "Giá Tiền";
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(52, 36);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(238, 32);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "label1";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPrice.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            // 
            // pictureBoxPrice
            // 
            this.pictureBoxPrice.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrice.Image")));
            this.pictureBoxPrice.Location = new System.Drawing.Point(6, 28);
            this.pictureBoxPrice.Name = "pictureBoxPrice";
            this.pictureBoxPrice.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPrice.TabIndex = 0;
            this.pictureBoxPrice.TabStop = false;
            this.pictureBoxPrice.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            // 
            // groupBoxPhone
            // 
            this.groupBoxPhone.Controls.Add(this.labelPhone);
            this.groupBoxPhone.Controls.Add(this.pictureBoxPhone);
            this.groupBoxPhone.Location = new System.Drawing.Point(539, 162);
            this.groupBoxPhone.Name = "groupBoxPhone";
            this.groupBoxPhone.Size = new System.Drawing.Size(300, 74);
            this.groupBoxPhone.TabIndex = 13;
            this.groupBoxPhone.TabStop = false;
            this.groupBoxPhone.Text = "Số Điện Thoại";
            // 
            // labelPhone
            // 
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(52, 36);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(238, 32);
            this.labelPhone.TabIndex = 1;
            this.labelPhone.Text = "label1";
            this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelPhone.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            // 
            // pictureBoxPhone
            // 
            this.pictureBoxPhone.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhone.Image")));
            this.pictureBoxPhone.Location = new System.Drawing.Point(6, 28);
            this.pictureBoxPhone.Name = "pictureBoxPhone";
            this.pictureBoxPhone.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhone.TabIndex = 0;
            this.pictureBoxPhone.TabStop = false;
            this.pictureBoxPhone.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            // 
            // UserControlHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.groupBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlHotel";
            this.Size = new System.Drawing.Size(860, 265);
            this.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNumber)).EndInit();
            this.groupBoxNumber.ResumeLayout(false);
            this.groupBoxAddress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddress)).EndInit();
            this.groupBoxPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrice)).EndInit();
            this.groupBoxPhone.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxHotel;
        private System.Windows.Forms.GroupBox groupBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.PictureBox pictureBoxPhone;
        private System.Windows.Forms.GroupBox groupBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.PictureBox pictureBoxPrice;
        private System.Windows.Forms.GroupBox groupBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.PictureBox pictureBoxAddress;
        private System.Windows.Forms.GroupBox groupBoxNumber;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.PictureBox pictureNumber;
    }
}
