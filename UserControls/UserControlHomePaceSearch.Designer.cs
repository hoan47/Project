
namespace Project.UserControls
{
    partial class UserControlHomePaceSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHomePaceSearch));
            this.pictureBoxHomePageSearch = new System.Windows.Forms.PictureBox();
            this.userControlHomePaceSearchItemPrice = new Project.UserControls.UserControlHomePaceSearchItem();
            this.userControlHomePaceSearchItemAddress = new Project.UserControls.UserControlHomePaceSearchItem();
            this.userControlHomePaceSearchItemPhone = new Project.UserControls.UserControlHomePaceSearchItem();
            this.userControlHomePaceSearchItemName = new Project.UserControls.UserControlHomePaceSearchItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomePageSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHomePageSearch
            // 
            this.pictureBoxHomePageSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHomePageSearch.Image")));
            this.pictureBoxHomePageSearch.Location = new System.Drawing.Point(5, 5);
            this.pictureBoxHomePageSearch.Name = "pictureBoxHomePageSearch";
            this.pictureBoxHomePageSearch.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxHomePageSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHomePageSearch.TabIndex = 0;
            this.pictureBoxHomePageSearch.TabStop = false;
            // 
            // userControlHomePaceSearchItemPrice
            // 
            this.userControlHomePaceSearchItemPrice.GroupBox = "Giá";
            this.userControlHomePaceSearchItemPrice.Label = "1.234.567.890 VND";
            this.userControlHomePaceSearchItemPrice.Location = new System.Drawing.Point(317, 54);
            this.userControlHomePaceSearchItemPrice.Name = "userControlHomePaceSearchItemPrice";
            this.userControlHomePaceSearchItemPrice.PictureBox = ((System.Drawing.Image)(resources.GetObject("userControlHomePaceSearchItemPrice.PictureBox")));
            this.userControlHomePaceSearchItemPrice.Size = new System.Drawing.Size(200, 50);
            this.userControlHomePaceSearchItemPrice.TabIndex = 4;
            // 
            // userControlHomePaceSearchItemAddress
            // 
            this.userControlHomePaceSearchItemAddress.GroupBox = "Địa chỉ";
            this.userControlHomePaceSearchItemAddress.Label = "TP Hồ Chí Minh, Thủ Đức, Võ Văn Ngân";
            this.userControlHomePaceSearchItemAddress.Location = new System.Drawing.Point(317, 0);
            this.userControlHomePaceSearchItemAddress.Name = "userControlHomePaceSearchItemAddress";
            this.userControlHomePaceSearchItemAddress.PictureBox = ((System.Drawing.Image)(resources.GetObject("userControlHomePaceSearchItemAddress.PictureBox")));
            this.userControlHomePaceSearchItemAddress.Size = new System.Drawing.Size(200, 50);
            this.userControlHomePaceSearchItemAddress.TabIndex = 3;
            // 
            // userControlHomePaceSearchItemPhone
            // 
            this.userControlHomePaceSearchItemPhone.GroupBox = "Số điện thoại";
            this.userControlHomePaceSearchItemPhone.Label = "0123456789";
            this.userControlHomePaceSearchItemPhone.Location = new System.Drawing.Point(112, 54);
            this.userControlHomePaceSearchItemPhone.Name = "userControlHomePaceSearchItemPhone";
            this.userControlHomePaceSearchItemPhone.PictureBox = ((System.Drawing.Image)(resources.GetObject("userControlHomePaceSearchItemPhone.PictureBox")));
            this.userControlHomePaceSearchItemPhone.Size = new System.Drawing.Size(200, 50);
            this.userControlHomePaceSearchItemPhone.TabIndex = 2;
            // 
            // userControlHomePaceSearchItemName
            // 
            this.userControlHomePaceSearchItemName.GroupBox = "Tên khách sạn";
            this.userControlHomePaceSearchItemName.Label = "Tình một đêm";
            this.userControlHomePaceSearchItemName.Location = new System.Drawing.Point(111, 0);
            this.userControlHomePaceSearchItemName.Name = "userControlHomePaceSearchItemName";
            this.userControlHomePaceSearchItemName.PictureBox = ((System.Drawing.Image)(resources.GetObject("userControlHomePaceSearchItemName.PictureBox")));
            this.userControlHomePaceSearchItemName.Size = new System.Drawing.Size(200, 50);
            this.userControlHomePaceSearchItemName.TabIndex = 1;
            // 
            // UserControlHomePaceSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.userControlHomePaceSearchItemPrice);
            this.Controls.Add(this.userControlHomePaceSearchItemAddress);
            this.Controls.Add(this.userControlHomePaceSearchItemPhone);
            this.Controls.Add(this.userControlHomePaceSearchItemName);
            this.Controls.Add(this.pictureBoxHomePageSearch);
            this.Name = "UserControlHomePaceSearch";
            this.Size = new System.Drawing.Size(525, 110);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomePageSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHomePageSearch;
        private UserControlHomePaceSearchItem userControlHomePaceSearchItemName;
        private UserControlHomePaceSearchItem userControlHomePaceSearchItemPhone;
        private UserControlHomePaceSearchItem userControlHomePaceSearchItemAddress;
        private UserControlHomePaceSearchItem userControlHomePaceSearchItemPrice;
    }
}
