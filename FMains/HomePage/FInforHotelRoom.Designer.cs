
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
            this.groupBoxService = new System.Windows.Forms.GroupBox();
            this.listBoxService = new System.Windows.Forms.ListBox();
            this.userControlLableCheckIn = new Project.UserControls.UserControlLable();
            this.userControlLablePrice = new Project.UserControls.UserControlLable();
            this.userControlLableArea = new Project.UserControls.UserControlLable();
            this.userControlLableCheckOut = new Project.UserControls.UserControlLable();
            this.userControlLableName = new Project.UserControls.UserControlLable();
            this.userControlLablePeople = new Project.UserControls.UserControlLable();
            this.userControlLableBed = new Project.UserControls.UserControlLable();
            this.userControlLableBedRoom = new Project.UserControls.UserControlLable();
            this.groupBoxConfirm = new Guna.UI2.WinForms.Guna2GroupBox();
            this.labelOldTotalPrice = new System.Windows.Forms.Label();
            this.buttonConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.userControlLableTotalPrice = new Project.UserControls.UserControlLable();
            this.groupBoxPolicy = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLeft = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.buttonRight = new Guna.UI2.WinForms.Guna2Button();
            this.butonBack = new Guna.UI2.WinForms.Guna2Button();
            this.panel.SuspendLayout();
            this.groupBoxService.SuspendLayout();
            this.groupBoxConfirm.SuspendLayout();
            this.groupBoxPolicy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
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
            // groupBoxConfirm
            // 
            this.groupBoxConfirm.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBoxConfirm.BorderRadius = 10;
            this.groupBoxConfirm.BorderThickness = 3;
            this.groupBoxConfirm.Controls.Add(this.label1);
            this.groupBoxConfirm.Controls.Add(this.groupBoxPolicy);
            this.groupBoxConfirm.Controls.Add(this.buttonConfirm);
            this.groupBoxConfirm.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBoxConfirm.CustomBorderThickness = new System.Windows.Forms.Padding(0, 20, 0, 0);
            resources.ApplyResources(this.groupBoxConfirm, "groupBoxConfirm");
            this.groupBoxConfirm.ForeColor = System.Drawing.Color.Black;
            this.groupBoxConfirm.Name = "groupBoxConfirm";
            this.groupBoxConfirm.TextOffset = new System.Drawing.Point(0, -10);
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
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
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
            // groupBoxPolicy
            // 
            this.groupBoxPolicy.Controls.Add(this.richTextBox1);
            resources.ApplyResources(this.groupBoxPolicy, "groupBoxPolicy");
            this.groupBoxPolicy.Name = "groupBoxPolicy";
            this.groupBoxPolicy.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            this.groupBoxService.ResumeLayout(false);
            this.groupBoxConfirm.ResumeLayout(false);
            this.groupBoxPolicy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel;
        private System.Windows.Forms.GroupBox groupBoxService;
        private System.Windows.Forms.ListBox listBoxService;
        private UserControls.UserControlLable userControlLableCheckIn;
        private UserControls.UserControlLable userControlLablePrice;
        private UserControls.UserControlLable userControlLableArea;
        private UserControls.UserControlLable userControlLableCheckOut;
        private UserControls.UserControlLable userControlLableName;
        private UserControls.UserControlLable userControlLablePeople;
        private UserControls.UserControlLable userControlLableBed;
        private UserControls.UserControlLable userControlLableBedRoom;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxConfirm;
        private System.Windows.Forms.Label labelOldTotalPrice;
        private Guna.UI2.WinForms.Guna2Button buttonConfirm;
        private UserControls.UserControlLable userControlLableTotalPrice;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBoxPolicy;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2Button buttonRight;
        private Guna.UI2.WinForms.Guna2Button buttonLeft;
        private Guna.UI2.WinForms.Guna2Button butonBack;
    }
}