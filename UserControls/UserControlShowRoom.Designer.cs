
namespace Project
{
    partial class UserControlShowRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlShowRoom));
            this.groupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.pictureBoxIconPrice = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelOldPrice = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.pictureBoxSale = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelAcreage = new System.Windows.Forms.Label();
            this.labelNumberBed = new System.Windows.Forms.Label();
            this.labelNumberRoom = new System.Windows.Forms.Label();
            this.labelNumberPeople = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSale)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BorderColor = System.Drawing.Color.GreenYellow;
            this.groupBox.BorderRadius = 5;
            this.groupBox.BorderThickness = 3;
            this.groupBox.Controls.Add(this.pictureBoxIconPrice);
            this.groupBox.Controls.Add(this.pictureBox);
            this.groupBox.Controls.Add(this.labelOldPrice);
            this.groupBox.Controls.Add(this.labelPrice);
            this.groupBox.Controls.Add(this.pictureBoxSale);
            this.groupBox.Controls.Add(this.labelAcreage);
            this.groupBox.Controls.Add(this.labelNumberBed);
            this.groupBox.Controls.Add(this.labelNumberRoom);
            this.groupBox.Controls.Add(this.labelNumberPeople);
            this.groupBox.CustomBorderColor = System.Drawing.Color.GreenYellow;
            this.groupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 134);
            this.groupBox.TabIndex = 0;
            this.groupBox.Text = "Tên phòng:";
            this.groupBox.TextOffset = new System.Drawing.Point(0, -10);
            this.groupBox.Click += new System.EventHandler(this.ShowRoomClick);
            // 
            // pictureBoxIconPrice
            // 
            this.pictureBoxIconPrice.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconPrice.Image")));
            this.pictureBoxIconPrice.ImageRotate = 0F;
            this.pictureBoxIconPrice.Location = new System.Drawing.Point(163, 100);
            this.pictureBoxIconPrice.Name = "pictureBoxIconPrice";
            this.pictureBoxIconPrice.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxIconPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIconPrice.TabIndex = 5;
            this.pictureBoxIconPrice.TabStop = false;
            this.pictureBoxIconPrice.Click += new System.EventHandler(this.ShowRoomClick);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.Location = new System.Drawing.Point(6, 23);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(70, 70);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.ShowRoomClick);
            // 
            // labelOldPrice
            // 
            this.labelOldPrice.AllowDrop = true;
            this.labelOldPrice.AutoEllipsis = true;
            this.labelOldPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOldPrice.Font = new System.Drawing.Font("Yu Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOldPrice.Location = new System.Drawing.Point(8, 97);
            this.labelOldPrice.Name = "labelOldPrice";
            this.labelOldPrice.Size = new System.Drawing.Size(154, 17);
            this.labelOldPrice.TabIndex = 6;
            this.labelOldPrice.Text = "1000000";
            this.labelOldPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelOldPrice.Click += new System.EventHandler(this.ShowRoomClick);
            // 
            // labelPrice
            // 
            this.labelPrice.AllowDrop = true;
            this.labelPrice.AutoEllipsis = true;
            this.labelPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPrice.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(8, 112);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(154, 18);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "1000000";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPrice.Click += new System.EventHandler(this.ShowRoomClick);
            // 
            // pictureBoxSale
            // 
            this.pictureBoxSale.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSale.Image")));
            this.pictureBoxSale.ImageRotate = 0F;
            this.pictureBoxSale.Location = new System.Drawing.Point(160, 0);
            this.pictureBoxSale.Name = "pictureBoxSale";
            this.pictureBoxSale.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxSale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSale.TabIndex = 0;
            this.pictureBoxSale.TabStop = false;
            this.pictureBoxSale.Click += new System.EventHandler(this.ShowRoomClick);
            // 
            // labelAcreage
            // 
            this.labelAcreage.AutoEllipsis = true;
            this.labelAcreage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAcreage.Location = new System.Drawing.Point(78, 76);
            this.labelAcreage.Name = "labelAcreage";
            this.labelAcreage.Size = new System.Drawing.Size(115, 16);
            this.labelAcreage.TabIndex = 4;
            this.labelAcreage.Text = "Diện tích: 999 m^2";
            this.labelAcreage.Click += new System.EventHandler(this.ShowRoomClick);
            // 
            // labelNumberBed
            // 
            this.labelNumberBed.AutoEllipsis = true;
            this.labelNumberBed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberBed.Location = new System.Drawing.Point(78, 60);
            this.labelNumberBed.Name = "labelNumberBed";
            this.labelNumberBed.Size = new System.Drawing.Size(115, 16);
            this.labelNumberBed.TabIndex = 3;
            this.labelNumberBed.Text = "Số giường: 0";
            this.labelNumberBed.Click += new System.EventHandler(this.ShowRoomClick);
            // 
            // labelNumberRoom
            // 
            this.labelNumberRoom.AutoEllipsis = true;
            this.labelNumberRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberRoom.Location = new System.Drawing.Point(78, 44);
            this.labelNumberRoom.Name = "labelNumberRoom";
            this.labelNumberRoom.Size = new System.Drawing.Size(115, 16);
            this.labelNumberRoom.TabIndex = 2;
            this.labelNumberRoom.Text = "Số phòng ngủ: 0";
            this.labelNumberRoom.Click += new System.EventHandler(this.ShowRoomClick);
            // 
            // labelNumberPeople
            // 
            this.labelNumberPeople.AutoEllipsis = true;
            this.labelNumberPeople.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberPeople.Location = new System.Drawing.Point(78, 28);
            this.labelNumberPeople.Name = "labelNumberPeople";
            this.labelNumberPeople.Size = new System.Drawing.Size(115, 16);
            this.labelNumberPeople.TabIndex = 1;
            this.labelNumberPeople.Text = "Số người: 0";
            this.labelNumberPeople.Click += new System.EventHandler(this.ShowRoomClick);
            // 
            // UserControlShowRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox);
            this.Name = "UserControlShowRoom";
            this.Size = new System.Drawing.Size(200, 134);
            this.Load += new System.EventHandler(this.UserControlShowRoomLoad);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
        private System.Windows.Forms.Label labelNumberBed;
        private System.Windows.Forms.Label labelNumberRoom;
        private System.Windows.Forms.Label labelNumberPeople;
        private System.Windows.Forms.Label labelAcreage;
        private System.Windows.Forms.Label labelOldPrice;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxIconPrice;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxSale;
        private System.Windows.Forms.Label labelPrice;
    }
}
