
namespace Project
{
    partial class UserControlShowHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlShowHotel));
            this.labelName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelEvaluate = new System.Windows.Forms.Label();
            this.pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoEllipsis = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(110, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(250, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Tên: Tình một đêm";
            this.labelName.Click += new System.EventHandler(this.UserControlHomePaceSearchRoomClick);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoEllipsis = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(10, 110);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(350, 16);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Địa chỉ: Thành phố Hồ Chí Minh, Quận Thủ Đức, Đường Võ Văn Ngân";
            this.labelAddress.Click += new System.EventHandler(this.UserControlHomePaceSearchRoomClick);
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(110, 50);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(187, 16);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "Số điện thoại: 0123456789";
            this.labelPhone.Click += new System.EventHandler(this.UserControlHomePaceSearchRoomClick);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(110, 80);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(132, 16);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Giá: 1.234.567.890";
            this.labelPrice.Click += new System.EventHandler(this.UserControlHomePaceSearchRoomClick);
            // 
            // labelEvaluate
            // 
            this.labelEvaluate.AutoEllipsis = true;
            this.labelEvaluate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvaluate.Location = new System.Drawing.Point(10, 140);
            this.labelEvaluate.Name = "labelEvaluate";
            this.labelEvaluate.Size = new System.Drawing.Size(305, 16);
            this.labelEvaluate.TabIndex = 5;
            this.labelEvaluate.Text = "Đánh giá:";
            this.labelEvaluate.Click += new System.EventHandler(this.UserControlHomePaceSearchRoomClick);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.Location = new System.Drawing.Point(5, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(100, 100);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.UserControlHomePaceSearchRoomClick);
            // 
            // UserControlHotelShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelEvaluate);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelName);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "UserControlHotelShow";
            this.Size = new System.Drawing.Size(370, 170);
            this.Click += new System.EventHandler(this.UserControlHomePaceSearchRoomClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelEvaluate;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
    }
}