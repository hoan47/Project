
using System.Drawing;

namespace Project
{
    partial class FHomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHomePage));
            this.panelSearchHotel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.groupBoxService = new System.Windows.Forms.GroupBox();
            this.checkedListBoxService = new System.Windows.Forms.CheckedListBox();
            this.userControlPrice1 = new Project.UserControls.UserControlPrice();
            this.userControlAddressRoom = new Project.UserControlAddressRoom();
            this.UserControlDateTimePackerOut = new Project.UserControlDateTimePacker();
            this.userControlDateTimePackerIn = new Project.UserControlDateTimePacker();
            this.panelSearchHotel.SuspendLayout();
            this.groupBoxService.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearchHotel
            // 
            this.panelSearchHotel.Controls.Add(this.groupBoxService);
            this.panelSearchHotel.Controls.Add(this.userControlPrice1);
            this.panelSearchHotel.Controls.Add(this.buttonSearch);
            this.panelSearchHotel.Controls.Add(this.userControlAddressRoom);
            this.panelSearchHotel.Controls.Add(this.UserControlDateTimePackerOut);
            this.panelSearchHotel.Controls.Add(this.userControlDateTimePackerIn);
            this.panelSearchHotel.Location = new System.Drawing.Point(0, 0);
            this.panelSearchHotel.Name = "panelSearchHotel";
            this.panelSearchHotel.Size = new System.Drawing.Size(780, 120);
            this.panelSearchHotel.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AllowDrop = true;
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel.Location = new System.Drawing.Point(5, 121);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(775, 390);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.BorderRadius = 10;
            this.buttonSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonSearch.FillColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSearch.ForeColor = System.Drawing.Color.White;
            this.buttonSearch.Location = new System.Drawing.Point(728, 61);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(40, 40);
            this.buttonSearch.TabIndex = 9;
            // 
            // groupBoxService
            // 
            this.groupBoxService.Controls.Add(this.checkedListBoxService);
            this.groupBoxService.Location = new System.Drawing.Point(557, 3);
            this.groupBoxService.Name = "groupBoxService";
            this.groupBoxService.Size = new System.Drawing.Size(165, 112);
            this.groupBoxService.TabIndex = 11;
            this.groupBoxService.TabStop = false;
            this.groupBoxService.Text = "Dịch vụ";
            // 
            // checkedListBoxService
            // 
            this.checkedListBoxService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkedListBoxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxService.FormattingEnabled = true;
            this.checkedListBoxService.Items.AddRange(new object[] {
            "Bãi giữ xe máy",
            "Bãi giữ xe ô tô",
            "Khu bán đồ ăn",
            "Công viên",
            "Wfi",
            "Hồ bơi",
            "Giặt là",
            "Khu vực hút thuốc"});
            this.checkedListBoxService.Location = new System.Drawing.Point(6, 17);
            this.checkedListBoxService.Name = "checkedListBoxService";
            this.checkedListBoxService.Size = new System.Drawing.Size(152, 89);
            this.checkedListBoxService.TabIndex = 0;
            // 
            // userControlPrice1
            // 
            this.userControlPrice1.BackColor = System.Drawing.Color.Transparent;
            this.userControlPrice1.ColorUserControl = System.Drawing.Color.White;
            this.userControlPrice1.Location = new System.Drawing.Point(13, 61);
            this.userControlPrice1.Name = "userControlPrice1";
            this.userControlPrice1.Price = 1000000;
            this.userControlPrice1.Size = new System.Drawing.Size(256, 56);
            this.userControlPrice1.TabIndex = 10;
            // 
            // userControlAddressRoom
            // 
            this.userControlAddressRoom.BackColor = System.Drawing.Color.Transparent;
            this.userControlAddressRoom.ComboBoxText = "";
            this.userControlAddressRoom.Location = new System.Drawing.Point(12, 3);
            this.userControlAddressRoom.Name = "userControlAddressRoom";
            this.userControlAddressRoom.Size = new System.Drawing.Size(256, 55);
            this.userControlAddressRoom.TabIndex = 7;
            // 
            // UserControlDateTimePackerOut
            // 
            this.UserControlDateTimePackerOut.BackColor = System.Drawing.Color.Transparent;
            this.UserControlDateTimePackerOut.GroupBoxText = "Ngày trả phòng";
            this.UserControlDateTimePackerOut.ImageIcon = ((System.Drawing.Image)(resources.GetObject("UserControlDateTimePackerOut.ImageIcon")));
            this.UserControlDateTimePackerOut.Location = new System.Drawing.Point(274, 61);
            this.UserControlDateTimePackerOut.Name = "UserControlDateTimePackerOut";
            this.UserControlDateTimePackerOut.Size = new System.Drawing.Size(277, 55);
            this.UserControlDateTimePackerOut.TabIndex = 6;
            // 
            // userControlDateTimePackerIn
            // 
            this.userControlDateTimePackerIn.BackColor = System.Drawing.Color.Transparent;
            this.userControlDateTimePackerIn.GroupBoxText = "Ngày nhận phòng";
            this.userControlDateTimePackerIn.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlDateTimePackerIn.ImageIcon")));
            this.userControlDateTimePackerIn.Location = new System.Drawing.Point(274, 3);
            this.userControlDateTimePackerIn.Name = "userControlDateTimePackerIn";
            this.userControlDateTimePackerIn.Size = new System.Drawing.Size(277, 55);
            this.userControlDateTimePackerIn.TabIndex = 5;
            // 
            // FHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(780, 512);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panelSearchHotel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FHomePage";
            this.Text = "FHomePage";
            this.Load += new System.EventHandler(this.FHomePageLoad);
            this.panelSearchHotel.ResumeLayout(false);
            this.groupBoxService.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearchHotel;
        private UserControlDateTimePacker UserControlDateTimePackerOut;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private Guna.UI2.WinForms.Guna2Button buttonSearch;
        private UserControls.UserControlPrice userControlPrice1;
        private System.Windows.Forms.GroupBox groupBoxService;
        private System.Windows.Forms.CheckedListBox checkedListBoxService;
        private UserControlAddressRoom userControlAddressRoom;
        private UserControlDateTimePacker userControlDateTimePackerIn;
    }
}