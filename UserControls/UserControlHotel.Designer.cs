
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
            this.userControlHotelEditAddress = new Project.UserControlHotelEdit();
            this.userControlHotelEditName = new Project.UserControlHotelEdit();
            this.userControlHotelEditPhone = new Project.UserControlHotelEdit();
            this.userControlHotelEditPrice = new Project.UserControlHotelEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHotel
            // 
            this.pictureBoxHotel.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHotel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHotel.Image")));
            this.pictureBoxHotel.Location = new System.Drawing.Point(20, 31);
            this.pictureBoxHotel.Name = "pictureBoxHotel";
            this.pictureBoxHotel.Size = new System.Drawing.Size(130, 130);
            this.pictureBoxHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHotel.TabIndex = 6;
            this.pictureBoxHotel.TabStop = false;
            this.pictureBoxHotel.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            // 
            // userControlHotelEditPhone
            // 
            this.userControlHotelEditPhone.BackColor = System.Drawing.Color.Transparent;
            this.userControlHotelEditPhone.GroupBoxText = "SDT";
            this.userControlHotelEditPhone.LabelHotelEdit = "SDT: ";
            this.userControlHotelEditPhone.Location = new System.Drawing.Point(399, 98);
            this.userControlHotelEditPhone.Name = "userControlHotelEditPhone";
            this.userControlHotelEditPhone.PictureBoxHotelEdit = ((System.Drawing.Image)(resources.GetObject("userControlHotelEditPhone.PictureBoxHotelEdit")));
            this.userControlHotelEditPhone.Size = new System.Drawing.Size(235, 60);
            this.userControlHotelEditPhone.TabIndex = 10;
            this.userControlHotelEditPhone.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            // 
            // userControlHotelEditPrice
            // 
            this.userControlHotelEditPrice.BackColor = System.Drawing.Color.Transparent;
            this.userControlHotelEditPrice.GroupBoxText = "Giá: ";
            this.userControlHotelEditPrice.LabelHotelEdit = "Giá: ";
            this.userControlHotelEditPrice.Location = new System.Drawing.Point(157, 98);
            this.userControlHotelEditPrice.Name = "userControlHotelEditPrice";
            this.userControlHotelEditPrice.PictureBoxHotelEdit = ((System.Drawing.Image)(resources.GetObject("userControlHotelEditPrice.PictureBoxHotelEdit")));
            this.userControlHotelEditPrice.Size = new System.Drawing.Size(235, 60);
            this.userControlHotelEditPrice.TabIndex = 9;
            this.userControlHotelEditPrice.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            // 
            // userControlHotelEditAddress
            // 
            this.userControlHotelEditAddress.BackColor = System.Drawing.Color.Transparent;
            this.userControlHotelEditAddress.GroupBoxText = "Địa chỉ";
            this.userControlHotelEditAddress.LabelHotelEdit = "Dak lak, playku, ho chinh minh, ha nodddddddddddddd";
            this.userControlHotelEditAddress.Location = new System.Drawing.Point(399, 31);
            this.userControlHotelEditAddress.Name = "userControlHotelEditAddress";
            this.userControlHotelEditAddress.PictureBoxHotelEdit = ((System.Drawing.Image)(resources.GetObject("userControlHotelEditAddress.PictureBoxHotelEdit")));
            this.userControlHotelEditAddress.Size = new System.Drawing.Size(235, 60);
            this.userControlHotelEditAddress.TabIndex = 8;
            this.userControlHotelEditAddress.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            // 
            // userControlHotelEditName
            // 
            this.userControlHotelEditName.BackColor = System.Drawing.Color.Transparent;
            this.userControlHotelEditName.GroupBoxText = "Tên khách sạn";
            this.userControlHotelEditName.LabelHotelEdit = "Tên khách sạn: ";
            this.userControlHotelEditName.Location = new System.Drawing.Point(157, 31);
            this.userControlHotelEditName.Name = "userControlHotelEditName";
            this.userControlHotelEditName.PictureBoxHotelEdit = ((System.Drawing.Image)(resources.GetObject("userControlHotelEditName.PictureBoxHotelEdit")));
            this.userControlHotelEditName.Size = new System.Drawing.Size(235, 60);
            this.userControlHotelEditName.TabIndex = 7;
            this.userControlHotelEditName.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            // 
            // UserControlHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.userControlHotelEditPhone);
            this.Controls.Add(this.userControlHotelEditPrice);
            this.Controls.Add(this.userControlHotelEditAddress);
            this.Controls.Add(this.userControlHotelEditName);
            this.Controls.Add(this.pictureBoxHotel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "UserControlHotel";
            this.Size = new System.Drawing.Size(650, 181);
            this.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxHotel;
        private UserControlHotelEdit userControlHotelEditName;
        private UserControlHotelEdit userControlHotelEditAddress;
        private UserControlHotelEdit userControlHotelEditPrice;
        private UserControlHotelEdit userControlHotelEditPhone;
    }
}
