
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHomePaceSearch = new System.Windows.Forms.Button();
            this.userControlService = new Project.UserControlService();
            this.userControlAddressRoom = new Project.UserControlAddressRoom();
            this.UserControlDateTimePackerOut = new Project.UserControlDateTimePacker();
            this.userControlDateTimePackerIn = new Project.UserControlDateTimePacker();
            this.userControlTextBoxRoomPrice = new Project.UserControlTextBoxRoom();
            this.userControlNumericPeople = new Project.UserControlNumeric();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHomePaceSearch);
            this.panel1.Controls.Add(this.userControlService);
            this.panel1.Controls.Add(this.userControlAddressRoom);
            this.panel1.Controls.Add(this.UserControlDateTimePackerOut);
            this.panel1.Controls.Add(this.userControlDateTimePackerIn);
            this.panel1.Controls.Add(this.userControlTextBoxRoomPrice);
            this.panel1.Controls.Add(this.userControlNumericPeople);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 120);
            this.panel1.TabIndex = 0;
            // 
            // buttonHomePaceSearch
            // 
            this.buttonHomePaceSearch.BackColor = System.Drawing.Color.Transparent;
            this.buttonHomePaceSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHomePaceSearch.BackgroundImage")));
            this.buttonHomePaceSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHomePaceSearch.FlatAppearance.BorderSize = 0;
            this.buttonHomePaceSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomePaceSearch.Location = new System.Drawing.Point(713, 61);
            this.buttonHomePaceSearch.Name = "buttonHomePaceSearch";
            this.buttonHomePaceSearch.Size = new System.Drawing.Size(55, 55);
            this.buttonHomePaceSearch.TabIndex = 9;
            this.buttonHomePaceSearch.UseVisualStyleBackColor = false;
            // 
            // userControlService
            // 
            this.userControlService.BackColor = System.Drawing.Color.Transparent;
            this.userControlService.Location = new System.Drawing.Point(557, 3);
            this.userControlService.Name = "userControlService";
            this.userControlService.Size = new System.Drawing.Size(150, 113);
            this.userControlService.TabIndex = 8;
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
            // userControlTextBoxRoomPrice
            // 
            this.userControlTextBoxRoomPrice.BackColor = System.Drawing.Color.Transparent;
            this.userControlTextBoxRoomPrice.Location = new System.Drawing.Point(12, 61);
            this.userControlTextBoxRoomPrice.Name = "userControlTextBoxRoomPrice";
            this.userControlTextBoxRoomPrice.Size = new System.Drawing.Size(150, 55);
            this.userControlTextBoxRoomPrice.TabIndex = 4;
            // 
            // userControlNumericPeople
            // 
            this.userControlNumericPeople.BackColor = System.Drawing.Color.Transparent;
            this.userControlNumericPeople.GrupBoxText = "Số người";
            this.userControlNumericPeople.Image = ((System.Drawing.Image)(resources.GetObject("userControlNumericPeople.Image")));
            this.userControlNumericPeople.Location = new System.Drawing.Point(168, 61);
            this.userControlNumericPeople.Name = "userControlNumericPeople";
            this.userControlNumericPeople.NumericValue = 1;
            this.userControlNumericPeople.Size = new System.Drawing.Size(100, 55);
            this.userControlNumericPeople.TabIndex = 3;
            this.userControlNumericPeople.Load += new System.EventHandler(this.userControlHomePaceSearchPeople1_Load);
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
            this.flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelHomePaceSearch_Paint);
            // 
            // FHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(780, 512);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FHomePage";
            this.Text = "FHomePage";
            this.Load += new System.EventHandler(this.FHomePage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UserControlNumeric userControlNumericPeople;
        private UserControlTextBoxRoom userControlTextBoxRoomPrice;
        private UserControlDateTimePacker userControlDateTimePackerIn;
        private UserControlDateTimePacker UserControlDateTimePackerOut;
        private UserControlAddressRoom userControlAddressRoom;
        private System.Windows.Forms.Button buttonHomePaceSearch;
        private UserControlService userControlService;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}