
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
            this.groupBoxService = new System.Windows.Forms.GroupBox();
            this.checkedListBoxService = new System.Windows.Forms.CheckedListBox();
            this.buttonSearch = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.userControlPrice = new Project.UserControls.UserControlPrice();
            this.userControlAddressHotel = new Project.UserControlAddressRoom();
            this.userControlDateTimePackerOut = new Project.UserControlDateTimePacker();
            this.userControlDateTimePackerIn = new Project.UserControlDateTimePacker();
            this.panelSearchHotel.SuspendLayout();
            this.groupBoxService.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearchHotel
            // 
            this.panelSearchHotel.Controls.Add(this.groupBoxService);
            this.panelSearchHotel.Controls.Add(this.userControlPrice);
            this.panelSearchHotel.Controls.Add(this.buttonSearch);
            this.panelSearchHotel.Controls.Add(this.userControlAddressHotel);
            this.panelSearchHotel.Controls.Add(this.userControlDateTimePackerOut);
            this.panelSearchHotel.Controls.Add(this.userControlDateTimePackerIn);
            this.panelSearchHotel.Location = new System.Drawing.Point(0, 0);
            this.panelSearchHotel.Name = "panelSearchHotel";
            this.panelSearchHotel.Size = new System.Drawing.Size(780, 120);
            this.panelSearchHotel.TabIndex = 0;
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
            this.buttonSearch.Location = new System.Drawing.Point(728, 69);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(40, 40);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearchClick);
            this.buttonSearch.DoubleClick += new System.EventHandler(this.ButtonSearchClick);
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
            // userControlPrice
            // 
            this.userControlPrice.BackColor = System.Drawing.Color.Transparent;
            this.userControlPrice.ColorUserControl = System.Drawing.Color.White;
            this.userControlPrice.Location = new System.Drawing.Point(12, 61);
            this.userControlPrice.Name = "userControlPrice";
            this.userControlPrice.Price = 1000000;
            this.userControlPrice.Size = new System.Drawing.Size(256, 56);
            this.userControlPrice.TabIndex = 10;
            // 
            // userControlAddressHotel
            // 
            this.userControlAddressHotel.BackColor = System.Drawing.Color.Transparent;
            this.userControlAddressHotel.ComboBoxText = "";
            this.userControlAddressHotel.Location = new System.Drawing.Point(12, 3);
            this.userControlAddressHotel.Name = "userControlAddressHotel";
            this.userControlAddressHotel.Size = new System.Drawing.Size(256, 55);
            this.userControlAddressHotel.TabIndex = 7;
            // 
            // userControlDateTimePackerOut
            // 
            this.userControlDateTimePackerOut.BackColor = System.Drawing.Color.Transparent;
            this.userControlDateTimePackerOut.DateTime = new System.DateTime(2024, 3, 30, 0, 0, 0, 0);
            this.userControlDateTimePackerOut.GroupBoxText = "Ngày trả phòng";
            this.userControlDateTimePackerOut.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlDateTimePackerOut.ImageIcon")));
            this.userControlDateTimePackerOut.Location = new System.Drawing.Point(274, 61);
            this.userControlDateTimePackerOut.Name = "userControlDateTimePackerOut";
            this.userControlDateTimePackerOut.Size = new System.Drawing.Size(277, 55);
            this.userControlDateTimePackerOut.TabIndex = 6;
            // 
            // userControlDateTimePackerIn
            // 
            this.userControlDateTimePackerIn.BackColor = System.Drawing.Color.Transparent;
            this.userControlDateTimePackerIn.DateTime = new System.DateTime(2024, 3, 30, 0, 0, 0, 0);
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
        private UserControlDateTimePacker userControlDateTimePackerOut;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private Guna.UI2.WinForms.Guna2Button buttonSearch;
        private UserControls.UserControlPrice userControlPrice;
        private System.Windows.Forms.GroupBox groupBoxService;
        private System.Windows.Forms.CheckedListBox checkedListBoxService;
        private UserControlAddressRoom userControlAddressHotel;
        private UserControlDateTimePacker userControlDateTimePackerIn;
    }
}