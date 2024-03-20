
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
            this.flowLayoutPanelHomePaceSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.userControlHomePaceService = new Project.UserControlHomePaceService();
            this.userControlHomePaceSearchAddress = new Project.UserControlHomePaceSearchAddress();
            this.userControlHomePaceSearchTimeOut = new Project.UserControlHomePaceSearchTime();
            this.userControlHomePaceSearchTimeIn = new Project.UserControlHomePaceSearchTime();
            this.userControlHomePaceSearchPrice = new Project.UserControlHomePaceSearchPrice();
            this.userControlHomePaceSearchPeople = new Project.UserControlHomePaceSearchPeople();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHomePaceSearch);
            this.panel1.Controls.Add(this.userControlHomePaceService);
            this.panel1.Controls.Add(this.userControlHomePaceSearchAddress);
            this.panel1.Controls.Add(this.userControlHomePaceSearchTimeOut);
            this.panel1.Controls.Add(this.userControlHomePaceSearchTimeIn);
            this.panel1.Controls.Add(this.userControlHomePaceSearchPrice);
            this.panel1.Controls.Add(this.userControlHomePaceSearchPeople);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 120);
            this.panel1.TabIndex = 0;
            // 
            // buttonHomePaceSearch
            // 
            this.buttonHomePaceSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHomePaceSearch.BackgroundImage")));
            this.buttonHomePaceSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHomePaceSearch.FlatAppearance.BorderSize = 0;
            this.buttonHomePaceSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHomePaceSearch.Location = new System.Drawing.Point(713, 61);
            this.buttonHomePaceSearch.Name = "buttonHomePaceSearch";
            this.buttonHomePaceSearch.Size = new System.Drawing.Size(55, 55);
            this.buttonHomePaceSearch.TabIndex = 9;
            this.buttonHomePaceSearch.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelHomePaceSearch
            // 
            this.flowLayoutPanelHomePaceSearch.AllowDrop = true;
            this.flowLayoutPanelHomePaceSearch.AutoScroll = true;
            this.flowLayoutPanelHomePaceSearch.Location = new System.Drawing.Point(5, 121);
            this.flowLayoutPanelHomePaceSearch.Name = "flowLayoutPanelHomePaceSearch";
            this.flowLayoutPanelHomePaceSearch.Size = new System.Drawing.Size(775, 390);
            this.flowLayoutPanelHomePaceSearch.TabIndex = 1;
            this.flowLayoutPanelHomePaceSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelHomePaceSearch_Paint);
            // 
            // userControlHomePaceService
            // 
            this.userControlHomePaceService.Location = new System.Drawing.Point(557, 3);
            this.userControlHomePaceService.Name = "userControlHomePaceService";
            this.userControlHomePaceService.Size = new System.Drawing.Size(150, 113);
            this.userControlHomePaceService.TabIndex = 8;
            // 
            // userControlHomePaceSearchAddress
            // 
            this.userControlHomePaceSearchAddress.Location = new System.Drawing.Point(12, 3);
            this.userControlHomePaceSearchAddress.Name = "userControlHomePaceSearchAddress";
            this.userControlHomePaceSearchAddress.Size = new System.Drawing.Size(256, 55);
            this.userControlHomePaceSearchAddress.TabIndex = 7;
            // 
            // userControlHomePaceSearchTimeOut
            // 
            this.userControlHomePaceSearchTimeOut.GroupBoxText = "Ngày trả phòng";
            this.userControlHomePaceSearchTimeOut.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlHomePaceSearchTimeOut.ImageIcon")));
            this.userControlHomePaceSearchTimeOut.Location = new System.Drawing.Point(274, 61);
            this.userControlHomePaceSearchTimeOut.Name = "userControlHomePaceSearchTimeOut";
            this.userControlHomePaceSearchTimeOut.Size = new System.Drawing.Size(277, 55);
            this.userControlHomePaceSearchTimeOut.TabIndex = 6;
            // 
            // userControlHomePaceSearchTimeIn
            // 
            this.userControlHomePaceSearchTimeIn.GroupBoxText = "Ngày nhận phòng";
            this.userControlHomePaceSearchTimeIn.ImageIcon = ((System.Drawing.Image)(resources.GetObject("userControlHomePaceSearchTimeIn.ImageIcon")));
            this.userControlHomePaceSearchTimeIn.Location = new System.Drawing.Point(274, 3);
            this.userControlHomePaceSearchTimeIn.Name = "userControlHomePaceSearchTimeIn";
            this.userControlHomePaceSearchTimeIn.Size = new System.Drawing.Size(277, 55);
            this.userControlHomePaceSearchTimeIn.TabIndex = 5;
            // 
            // userControlHomePaceSearchPrice
            // 
            this.userControlHomePaceSearchPrice.Location = new System.Drawing.Point(12, 61);
            this.userControlHomePaceSearchPrice.Name = "userControlHomePaceSearchPrice";
            this.userControlHomePaceSearchPrice.Size = new System.Drawing.Size(150, 55);
            this.userControlHomePaceSearchPrice.TabIndex = 4;
            // 
            // userControlHomePaceSearchPeople
            // 
            this.userControlHomePaceSearchPeople.Location = new System.Drawing.Point(168, 61);
            this.userControlHomePaceSearchPeople.Name = "userControlHomePaceSearchPeople";
            this.userControlHomePaceSearchPeople.Size = new System.Drawing.Size(100, 55);
            this.userControlHomePaceSearchPeople.TabIndex = 3;
            this.userControlHomePaceSearchPeople.Load += new System.EventHandler(this.userControlHomePaceSearchPeople1_Load);
            // 
            // FHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(780, 512);
            this.Controls.Add(this.flowLayoutPanelHomePaceSearch);
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
        private UserControlHomePaceSearchPeople userControlHomePaceSearchPeople;
        private UserControlHomePaceSearchPrice userControlHomePaceSearchPrice;
        private UserControlHomePaceSearchTime userControlHomePaceSearchTimeIn;
        private UserControlHomePaceSearchTime userControlHomePaceSearchTimeOut;
        private UserControlHomePaceSearchAddress userControlHomePaceSearchAddress;
        private System.Windows.Forms.Button buttonHomePaceSearch;
        private UserControlHomePaceService userControlHomePaceService;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHomePaceSearch;
    }
}