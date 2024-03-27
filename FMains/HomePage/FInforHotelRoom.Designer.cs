
namespace Project
{
    partial class FInforHotelRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInforHotelRoom));
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonRight = new Guna.UI2.WinForms.Guna2Button();
            this.buttonLeft = new Guna.UI2.WinForms.Guna2Button();
            this.groupBoxService = new System.Windows.Forms.GroupBox();
            this.listBoxService = new System.Windows.Forms.ListBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.userControlLableCheckIn = new Project.UserControls.UserControlLable();
            this.userControlLablePrice = new Project.UserControls.UserControlLable();
            this.userControlLableArea = new Project.UserControls.UserControlLable();
            this.userControlLableCheckOut = new Project.UserControls.UserControlLable();
            this.userControlLableName = new Project.UserControls.UserControlLable();
            this.userControlLablePeople = new Project.UserControls.UserControlLable();
            this.userControlLableBed = new Project.UserControls.UserControlLable();
            this.userControlLableBedRoom = new Project.UserControls.UserControlLable();
            this.panel.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxService.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderRadius = 12;
            this.panel.Controls.Add(this.panelImage);
            this.panel.Controls.Add(this.groupBoxService);
            this.panel.Controls.Add(this.buttonPay);
            this.panel.Controls.Add(this.buttonBack);
            this.panel.Controls.Add(this.userControlLableCheckIn);
            this.panel.Controls.Add(this.userControlLablePrice);
            this.panel.Controls.Add(this.userControlLableArea);
            this.panel.Controls.Add(this.userControlLableCheckOut);
            this.panel.Controls.Add(this.userControlLableName);
            this.panel.Controls.Add(this.userControlLablePeople);
            this.panel.Controls.Add(this.userControlLableBed);
            this.panel.Controls.Add(this.userControlLableBedRoom);
            this.panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.panel, "panel");
            this.panel.Name = "panel";
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.Transparent;
            this.panelImage.Controls.Add(this.pictureBox);
            this.panelImage.Controls.Add(this.buttonRight);
            this.panelImage.Controls.Add(this.buttonLeft);
            resources.ApplyResources(this.panelImage, "panelImage");
            this.panelImage.Name = "panelImage";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderRadius = 20;
            this.pictureBox.FillColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // buttonRight
            // 
            resources.ApplyResources(this.buttonRight, "buttonRight");
            this.buttonRight.BorderRadius = 5;
            this.buttonRight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonRight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonRight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonRight.FillColor = System.Drawing.Color.Transparent;
            this.buttonRight.ForeColor = System.Drawing.Color.White;
            this.buttonRight.Name = "buttonRight";
            // 
            // buttonLeft
            // 
            resources.ApplyResources(this.buttonLeft, "buttonLeft");
            this.buttonLeft.BorderRadius = 5;
            this.buttonLeft.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLeft.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLeft.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLeft.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLeft.FillColor = System.Drawing.Color.Transparent;
            this.buttonLeft.ForeColor = System.Drawing.Color.White;
            this.buttonLeft.Name = "buttonLeft";
            // 
            // groupBoxService
            // 
            this.groupBoxService.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxService.Controls.Add(this.listBoxService);
            resources.ApplyResources(this.groupBoxService, "groupBoxService");
            this.groupBoxService.Name = "groupBoxService";
            this.groupBoxService.TabStop = false;
            // 
            // listBoxService
            // 
            this.listBoxService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.listBoxService, "listBoxService");
            this.listBoxService.FormattingEnabled = true;
            this.listBoxService.Items.AddRange(new object[] {
            resources.GetString("listBoxService.Items"),
            resources.GetString("listBoxService.Items1"),
            resources.GetString("listBoxService.Items2"),
            resources.GetString("listBoxService.Items3"),
            resources.GetString("listBoxService.Items4")});
            this.listBoxService.Name = "listBoxService";
            // 
            // buttonPay
            // 
            this.buttonPay.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonPay, "buttonPay");
            this.buttonPay.FlatAppearance.BorderSize = 0;
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonBack, "buttonBack");
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBackClick);
            // 
            // userControlLableCheckIn
            // 
            this.userControlLableCheckIn.BackColor = System.Drawing.Color.Transparent;
            this.userControlLableCheckIn.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlLableCheckIn.ImageIcon")));
            this.userControlLableCheckIn.LableText = "01/02/0003 13h00";
            resources.ApplyResources(this.userControlLableCheckIn, "userControlLableCheckIn");
            this.userControlLableCheckIn.Name = "userControlLableCheckIn";
            this.userControlLableCheckIn.SizeUserControl = new System.Drawing.Size(246, 34);
            // 
            // userControlLablePrice
            // 
            this.userControlLablePrice.BackColor = System.Drawing.Color.Transparent;
            this.userControlLablePrice.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlLablePrice.ImageIcon")));
            this.userControlLablePrice.LableText = "Giá: 1.234.567.890 VND";
            resources.ApplyResources(this.userControlLablePrice, "userControlLablePrice");
            this.userControlLablePrice.Name = "userControlLablePrice";
            this.userControlLablePrice.SizeUserControl = new System.Drawing.Size(246, 34);
            // 
            // userControlLableArea
            // 
            this.userControlLableArea.BackColor = System.Drawing.Color.Transparent;
            this.userControlLableArea.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlLableArea.ImageIcon")));
            this.userControlLableArea.LableText = "Diện tích: 999 m^2";
            resources.ApplyResources(this.userControlLableArea, "userControlLableArea");
            this.userControlLableArea.Name = "userControlLableArea";
            this.userControlLableArea.SizeUserControl = new System.Drawing.Size(246, 34);
            // 
            // userControlLableCheckOut
            // 
            this.userControlLableCheckOut.BackColor = System.Drawing.Color.Transparent;
            this.userControlLableCheckOut.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlLableCheckOut.ImageIcon")));
            this.userControlLableCheckOut.LableText = "04/05/0006 11h00";
            resources.ApplyResources(this.userControlLableCheckOut, "userControlLableCheckOut");
            this.userControlLableCheckOut.Name = "userControlLableCheckOut";
            this.userControlLableCheckOut.SizeUserControl = new System.Drawing.Size(246, 34);
            // 
            // userControlLableName
            // 
            this.userControlLableName.BackColor = System.Drawing.Color.Transparent;
            this.userControlLableName.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlLableName.ImageIcon")));
            this.userControlLableName.LableText = "Tên phòng: A001";
            resources.ApplyResources(this.userControlLableName, "userControlLableName");
            this.userControlLableName.Name = "userControlLableName";
            this.userControlLableName.SizeUserControl = new System.Drawing.Size(246, 34);
            // 
            // userControlLablePeople
            // 
            this.userControlLablePeople.BackColor = System.Drawing.Color.Transparent;
            this.userControlLablePeople.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlLablePeople.ImageIcon")));
            this.userControlLablePeople.LableText = "Số người: 3";
            resources.ApplyResources(this.userControlLablePeople, "userControlLablePeople");
            this.userControlLablePeople.Name = "userControlLablePeople";
            this.userControlLablePeople.SizeUserControl = new System.Drawing.Size(246, 34);
            // 
            // userControlLableBed
            // 
            this.userControlLableBed.BackColor = System.Drawing.Color.Transparent;
            this.userControlLableBed.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlLableBed.ImageIcon")));
            this.userControlLableBed.LableText = "Số giường: 2";
            resources.ApplyResources(this.userControlLableBed, "userControlLableBed");
            this.userControlLableBed.Name = "userControlLableBed";
            this.userControlLableBed.SizeUserControl = new System.Drawing.Size(246, 34);
            // 
            // userControlLableBedRoom
            // 
            this.userControlLableBedRoom.BackColor = System.Drawing.Color.Transparent;
            this.userControlLableBedRoom.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlLableBedRoom.ImageIcon")));
            this.userControlLableBedRoom.LableText = "Số phòng ngủ: 1";
            resources.ApplyResources(this.userControlLableBedRoom, "userControlLableBedRoom");
            this.userControlLableBedRoom.Name = "userControlLableBedRoom";
            this.userControlLableBedRoom.SizeUserControl = new System.Drawing.Size(246, 34);
            // 
            // FInforHotelRoom
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FInforHotelRoom";
            this.Load += new System.EventHandler(this.FHomePaceInformationRoomLoad);
            this.panel.ResumeLayout(false);
            this.panelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxService.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel;
        private System.Windows.Forms.Panel panelImage;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2Button buttonRight;
        private Guna.UI2.WinForms.Guna2Button buttonLeft;
        private System.Windows.Forms.GroupBox groupBoxService;
        private System.Windows.Forms.ListBox listBoxService;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonBack;
        private UserControls.UserControlLable userControlLableCheckIn;
        private UserControls.UserControlLable userControlLablePrice;
        private UserControls.UserControlLable userControlLableArea;
        private UserControls.UserControlLable userControlLableCheckOut;
        private UserControls.UserControlLable userControlLableName;
        private UserControls.UserControlLable userControlLablePeople;
        private UserControls.UserControlLable userControlLableBed;
        private UserControls.UserControlLable userControlLableBedRoom;
    }
}