
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
            this.pictureBoxHotel = new System.Windows.Forms.PictureBox();
            this.userControlerLableName = new Project.UserControlerLable();
            this.userControlerLableAddress = new Project.UserControlerLable();
            this.userControlerLablePrice = new Project.UserControlerLable();
            this.userControlerLablePhone = new Project.UserControlerLable();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHotel
            // 
            this.pictureBoxHotel.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHotel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHotel.Image")));
            this.pictureBoxHotel.Location = new System.Drawing.Point(29, 47);
            this.pictureBoxHotel.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxHotel.Name = "pictureBoxHotel";
            this.pictureBoxHotel.Size = new System.Drawing.Size(173, 160);
            this.pictureBoxHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHotel.TabIndex = 6;
            this.pictureBoxHotel.TabStop = false;
            this.pictureBoxHotel.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            // 
            // userControlerLableName
            // 
            this.userControlerLableName.BackColor = System.Drawing.Color.Transparent;
            this.userControlerLableName.GroupBoxText = "Tên";
            this.userControlerLableName.LableText = "";
            this.userControlerLableName.Location = new System.Drawing.Point(216, 47);
            this.userControlerLableName.Margin = new System.Windows.Forms.Padding(4);
            this.userControlerLableName.Name = "userControlerLableName";
            this.userControlerLableName.PictureBoxImage = ((System.Drawing.Image)(resources.GetObject("userControlerLableName.PictureBoxImage")));
            this.userControlerLableName.Size = new System.Drawing.Size(313, 74);
            this.userControlerLableName.TabIndex = 7;
            // 
            // userControlerLableAddress
            // 
            this.userControlerLableAddress.BackColor = System.Drawing.Color.Transparent;
            this.userControlerLableAddress.GroupBoxText = "Địa Chỉ";
            this.userControlerLableAddress.LableText = "";
            this.userControlerLableAddress.Location = new System.Drawing.Point(538, 47);
            this.userControlerLableAddress.Margin = new System.Windows.Forms.Padding(4);
            this.userControlerLableAddress.Name = "userControlerLableAddress";
            this.userControlerLableAddress.PictureBoxImage = ((System.Drawing.Image)(resources.GetObject("userControlerLableAddress.PictureBoxImage")));
            this.userControlerLableAddress.Size = new System.Drawing.Size(313, 74);
            this.userControlerLableAddress.TabIndex = 8;
            // 
            // userControlerLablePrice
            // 
            this.userControlerLablePrice.BackColor = System.Drawing.Color.Transparent;
            this.userControlerLablePrice.GroupBoxText = "Giá Tiền";
            this.userControlerLablePrice.LableText = "";
            this.userControlerLablePrice.Location = new System.Drawing.Point(216, 132);
            this.userControlerLablePrice.Margin = new System.Windows.Forms.Padding(4);
            this.userControlerLablePrice.Name = "userControlerLablePrice";
            this.userControlerLablePrice.PictureBoxImage = ((System.Drawing.Image)(resources.GetObject("userControlerLablePrice.PictureBoxImage")));
            this.userControlerLablePrice.Size = new System.Drawing.Size(313, 74);
            this.userControlerLablePrice.TabIndex = 9;
            // 
            // userControlerLablePhone
            // 
            this.userControlerLablePhone.BackColor = System.Drawing.Color.Transparent;
            this.userControlerLablePhone.GroupBoxText = "Số Điện Thoại";
            this.userControlerLablePhone.LableText = "";
            this.userControlerLablePhone.Location = new System.Drawing.Point(538, 133);
            this.userControlerLablePhone.Margin = new System.Windows.Forms.Padding(4);
            this.userControlerLablePhone.Name = "userControlerLablePhone";
            this.userControlerLablePhone.PictureBoxImage = ((System.Drawing.Image)(resources.GetObject("userControlerLablePhone.PictureBoxImage")));
            this.userControlerLablePhone.Size = new System.Drawing.Size(313, 74);
            this.userControlerLablePhone.TabIndex = 10;
            // 
            // UserControlHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.userControlerLablePhone);
            this.Controls.Add(this.userControlerLablePrice);
            this.Controls.Add(this.userControlerLableAddress);
            this.Controls.Add(this.userControlerLableName);
            this.Controls.Add(this.pictureBoxHotel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlHotel";
            this.Size = new System.Drawing.Size(867, 239);
            this.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxHotel;
        private UserControlerLable userControlerLableName;
        private UserControlerLable userControlerLableAddress;
        private UserControlerLable userControlerLablePrice;
        private UserControlerLable userControlerLablePhone;
    }
}
