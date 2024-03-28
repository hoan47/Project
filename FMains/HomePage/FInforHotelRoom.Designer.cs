
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
            this.butonBack = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonRight = new Guna.UI2.WinForms.Guna2Button();
            this.labelOldTotalPrice = new System.Windows.Forms.Label();
            this.buttonLeft = new Guna.UI2.WinForms.Guna2Button();
            this.groupBoxConfirm = new Guna.UI2.WinForms.Guna2GroupBox();
            this.labelContent = new System.Windows.Forms.Label();
            this.groupBoxPolicy = new System.Windows.Forms.GroupBox();
            this.richTextBoxPolicy = new System.Windows.Forms.RichTextBox();
            this.buttonConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.groupBoxService = new System.Windows.Forms.GroupBox();
            this.listBoxService = new System.Windows.Forms.ListBox();
            this.userControlLableTotalPrice = new Project.UserControls.UserControlLable();
            this.userControlLableCheckIn = new Project.UserControls.UserControlLable();
            this.userControlLablePrice = new Project.UserControls.UserControlLable();
            this.userControlLableAcreage = new Project.UserControls.UserControlLable();
            this.userControlLableCheckOut = new Project.UserControls.UserControlLable();
            this.userControlLableRoomName = new Project.UserControls.UserControlLable();
            this.userControlLableNumnberPeople = new Project.UserControls.UserControlLable();
            this.userControlLableNumberBed = new Project.UserControls.UserControlLable();
            this.userControlLableNumberRoom = new Project.UserControls.UserControlLable();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxConfirm.SuspendLayout();
            this.groupBoxPolicy.SuspendLayout();
            this.groupBoxService.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderRadius = 10;
            this.panel.Controls.Add(this.butonBack);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.buttonRight);
            this.panel.Controls.Add(this.labelOldTotalPrice);
            this.panel.Controls.Add(this.buttonLeft);
            this.panel.Controls.Add(this.userControlLableTotalPrice);
            this.panel.Controls.Add(this.groupBoxConfirm);
            this.panel.Controls.Add(this.groupBoxService);
            this.panel.Controls.Add(this.userControlLableCheckIn);
            this.panel.Controls.Add(this.userControlLablePrice);
            this.panel.Controls.Add(this.userControlLableAcreage);
            this.panel.Controls.Add(this.userControlLableCheckOut);
            this.panel.Controls.Add(this.userControlLableRoomName);
            this.panel.Controls.Add(this.userControlLableNumnberPeople);
            this.panel.Controls.Add(this.userControlLableNumberBed);
            this.panel.Controls.Add(this.userControlLableNumberRoom);
            this.panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.panel, "panel");
            this.panel.Name = "panel";
            // 
            // butonBack
            // 
            this.butonBack.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.butonBack, "butonBack");
            this.butonBack.BorderRadius = 10;
            this.butonBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butonBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butonBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butonBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butonBack.FillColor = System.Drawing.Color.Transparent;
            this.butonBack.ForeColor = System.Drawing.Color.White;
            this.butonBack.Name = "butonBack";
            this.butonBack.Click += new System.EventHandler(this.ButtonBackClick);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderRadius = 20;
            this.pictureBox.FillColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonRight, "buttonRight");
            this.buttonRight.BorderRadius = 5;
            this.buttonRight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonRight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonRight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonRight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonRight.FillColor = System.Drawing.Color.Transparent;
            this.buttonRight.ForeColor = System.Drawing.Color.White;
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Click += new System.EventHandler(this.ButtonRightClick);
            // 
            // labelOldTotalPrice
            // 
            this.labelOldTotalPrice.AllowDrop = true;
            this.labelOldTotalPrice.AutoEllipsis = true;
            this.labelOldTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelOldTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.labelOldTotalPrice, "labelOldTotalPrice");
            this.labelOldTotalPrice.Name = "labelOldTotalPrice";
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonLeft, "buttonLeft");
            this.buttonLeft.BorderRadius = 5;
            this.buttonLeft.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLeft.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonLeft.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonLeft.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonLeft.FillColor = System.Drawing.Color.Transparent;
            this.buttonLeft.ForeColor = System.Drawing.Color.White;
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Click += new System.EventHandler(this.ButtonLeftClick);
            // 
            // groupBoxConfirm
            // 
            this.groupBoxConfirm.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBoxConfirm.BorderRadius = 10;
            this.groupBoxConfirm.BorderThickness = 3;
            this.groupBoxConfirm.Controls.Add(this.labelContent);
            this.groupBoxConfirm.Controls.Add(this.groupBoxPolicy);
            this.groupBoxConfirm.Controls.Add(this.buttonConfirm);
            this.groupBoxConfirm.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBoxConfirm.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            resources.ApplyResources(this.groupBoxConfirm, "groupBoxConfirm");
            this.groupBoxConfirm.ForeColor = System.Drawing.Color.Black;
            this.groupBoxConfirm.Name = "groupBoxConfirm";
            this.groupBoxConfirm.TextOffset = new System.Drawing.Point(0, -10);
            // 
            // labelContent
            // 
            resources.ApplyResources(this.labelContent, "labelContent");
            this.labelContent.Name = "labelContent";
            // 
            // groupBoxPolicy
            // 
            this.groupBoxPolicy.Controls.Add(this.richTextBoxPolicy);
            resources.ApplyResources(this.groupBoxPolicy, "groupBoxPolicy");
            this.groupBoxPolicy.Name = "groupBoxPolicy";
            this.groupBoxPolicy.TabStop = false;
            // 
            // richTextBoxPolicy
            // 
            this.richTextBoxPolicy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBoxPolicy, "richTextBoxPolicy");
            this.richTextBoxPolicy.Name = "richTextBoxPolicy";
            this.richTextBoxPolicy.ReadOnly = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.BorderRadius = 10;
            this.buttonConfirm.BorderThickness = 2;
            this.buttonConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            resources.ApplyResources(this.buttonConfirm, "buttonConfirm");
            this.buttonConfirm.ForeColor = System.Drawing.Color.Black;
            this.buttonConfirm.Name = "buttonConfirm";
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
            // userControlLableTotalPrice
            // 
            this.userControlLableTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.userControlLableTotalPrice.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlLableTotalPrice.ImageIcon")));
            this.userControlLableTotalPrice.LableText = "Giá 10 ngày: 9.000.000 VND";
            resources.ApplyResources(this.userControlLableTotalPrice, "userControlLableTotalPrice");
            this.userControlLableTotalPrice.Name = "userControlLableTotalPrice";
            this.userControlLableTotalPrice.SizeUserControl = new System.Drawing.Size(246, 34);
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
            this.userControlLablePrice.LableText = "Giá ngày: 1.000.000 VND";
            resources.ApplyResources(this.userControlLablePrice, "userControlLablePrice");
            this.userControlLablePrice.Name = "userControlLablePrice";
            this.userControlLablePrice.SizeUserControl = new System.Drawing.Size(246, 34);
            // 
            // userControlLableAcreage
            // 
            this.userControlLableAcreage.BackColor = System.Drawing.Color.Transparent;
            this.userControlLableAcreage.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlLableAcreage.ImageIcon")));
            this.userControlLableAcreage.LableText = "Diện tích: 999 m^2";
            resources.ApplyResources(this.userControlLableAcreage, "userControlLableAcreage");
            this.userControlLableAcreage.Name = "userControlLableAcreage";
            this.userControlLableAcreage.SizeUserControl = new System.Drawing.Size(246, 34);
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
            // userControlLableRoomName
            // 
            this.userControlLableRoomName.BackColor = System.Drawing.Color.Transparent;
            this.userControlLableRoomName.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlLableRoomName.ImageIcon")));
            this.userControlLableRoomName.LableText = "Tên phòng: A001";
            resources.ApplyResources(this.userControlLableRoomName, "userControlLableRoomName");
            this.userControlLableRoomName.Name = "userControlLableRoomName";
            this.userControlLableRoomName.SizeUserControl = new System.Drawing.Size(246, 34);
            // 
            // userControlLableNumnberPeople
            // 
            this.userControlLableNumnberPeople.BackColor = System.Drawing.Color.Transparent;
            this.userControlLableNumnberPeople.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlLableNumnberPeople.ImageIcon")));
            this.userControlLableNumnberPeople.LableText = "Số người: 3";
            resources.ApplyResources(this.userControlLableNumnberPeople, "userControlLableNumnberPeople");
            this.userControlLableNumnberPeople.Name = "userControlLableNumnberPeople";
            this.userControlLableNumnberPeople.SizeUserControl = new System.Drawing.Size(246, 34);
            // 
            // userControlLableNumberBed
            // 
            this.userControlLableNumberBed.BackColor = System.Drawing.Color.Transparent;
            this.userControlLableNumberBed.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlLableNumberBed.ImageIcon")));
            this.userControlLableNumberBed.LableText = "Số giường: 2";
            resources.ApplyResources(this.userControlLableNumberBed, "userControlLableNumberBed");
            this.userControlLableNumberBed.Name = "userControlLableNumberBed";
            this.userControlLableNumberBed.SizeUserControl = new System.Drawing.Size(246, 34);
            // 
            // userControlLableNumberRoom
            // 
            this.userControlLableNumberRoom.BackColor = System.Drawing.Color.Transparent;
            this.userControlLableNumberRoom.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlLableNumberRoom.ImageIcon")));
            this.userControlLableNumberRoom.LableText = "Số phòng ngủ: 1";
            resources.ApplyResources(this.userControlLableNumberRoom, "userControlLableNumberRoom");
            this.userControlLableNumberRoom.Name = "userControlLableNumberRoom";
            this.userControlLableNumberRoom.SizeUserControl = new System.Drawing.Size(246, 34);
            // 
            // FInforHotelRoom
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FInforHotelRoom";
            this.Load += new System.EventHandler(this.HotelRoomLoad);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxConfirm.ResumeLayout(false);
            this.groupBoxPolicy.ResumeLayout(false);
            this.groupBoxService.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel;
        private System.Windows.Forms.GroupBox groupBoxService;
        private System.Windows.Forms.ListBox listBoxService;
        private UserControls.UserControlLable userControlLableCheckIn;
        private UserControls.UserControlLable userControlLablePrice;
        private UserControls.UserControlLable userControlLableAcreage;
        private UserControls.UserControlLable userControlLableCheckOut;
        private UserControls.UserControlLable userControlLableRoomName;
        private UserControls.UserControlLable userControlLableNumnberPeople;
        private UserControls.UserControlLable userControlLableNumberBed;
        private UserControls.UserControlLable userControlLableNumberRoom;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxConfirm;
        private System.Windows.Forms.Label labelOldTotalPrice;
        private Guna.UI2.WinForms.Guna2Button buttonConfirm;
        private UserControls.UserControlLable userControlLableTotalPrice;
        private System.Windows.Forms.RichTextBox richTextBoxPolicy;
        private System.Windows.Forms.GroupBox groupBoxPolicy;
        private System.Windows.Forms.Label labelContent;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2Button buttonRight;
        private Guna.UI2.WinForms.Guna2Button buttonLeft;
        private Guna.UI2.WinForms.Guna2Button butonBack;
    }
}