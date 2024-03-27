namespace Project
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.panelOption = new System.Windows.Forms.Panel();
            this.toolStripOption = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonInfor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHomePage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNotification = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonHistory = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonService = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLogOut = new System.Windows.Forms.ToolStripButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBoxConins = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelCoins = new System.Windows.Forms.Label();
            this.panelOption.SuspendLayout();
            this.toolStripOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConins)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOption
            // 
            this.panelOption.Controls.Add(this.toolStripOption);
            this.panelOption.Location = new System.Drawing.Point(0, 75);
            this.panelOption.Margin = new System.Windows.Forms.Padding(2);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(150, 441);
            this.panelOption.TabIndex = 3;
            // 
            // toolStripOption
            // 
            this.toolStripOption.AutoSize = false;
            this.toolStripOption.BackColor = System.Drawing.Color.White;
            this.toolStripOption.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripOption.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripOption.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonInfor,
            this.toolStripButtonHomePage,
            this.toolStripButtonNotification,
            this.toolStripButtonHistory,
            this.toolStripButtonService,
            this.toolStripButtonLogOut});
            this.toolStripOption.Location = new System.Drawing.Point(0, 0);
            this.toolStripOption.Name = "toolStripOption";
            this.toolStripOption.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripOption.Size = new System.Drawing.Size(150, 441);
            this.toolStripOption.TabIndex = 0;
            this.toolStripOption.TabStop = true;
            this.toolStripOption.Text = "toolStrip1";
            // 
            // toolStripButtonInfor
            // 
            this.toolStripButtonInfor.AutoSize = false;
            this.toolStripButtonInfor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripButtonInfor.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonInfor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInfor.Image")));
            this.toolStripButtonInfor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonInfor.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonInfor.Name = "toolStripButtonInfor";
            this.toolStripButtonInfor.Size = new System.Drawing.Size(200, 60);
            this.toolStripButtonInfor.Text = "Thông Tin";
            this.toolStripButtonInfor.Click += new System.EventHandler(this.ToolStripButtonClick);
            // 
            // toolStripButtonHomePage
            // 
            this.toolStripButtonHomePage.AutoSize = false;
            this.toolStripButtonHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonHomePage.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonHomePage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHomePage.Image")));
            this.toolStripButtonHomePage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonHomePage.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonHomePage.Name = "toolStripButtonHomePage";
            this.toolStripButtonHomePage.Size = new System.Drawing.Size(200, 60);
            this.toolStripButtonHomePage.Text = "Trang Chủ";
            this.toolStripButtonHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonHomePage.Click += new System.EventHandler(this.ToolStripButtonClick);
            // 
            // toolStripButtonNotification
            // 
            this.toolStripButtonNotification.AutoSize = false;
            this.toolStripButtonNotification.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonNotification.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNotification.Image")));
            this.toolStripButtonNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonNotification.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonNotification.Name = "toolStripButtonNotification";
            this.toolStripButtonNotification.Size = new System.Drawing.Size(200, 60);
            this.toolStripButtonNotification.Text = "Thông Báo(10)";
            this.toolStripButtonNotification.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonNotification.ToolTipText = "Thông Báo";
            this.toolStripButtonNotification.Click += new System.EventHandler(this.ToolStripButtonClick);
            // 
            // toolStripButtonHistory
            // 
            this.toolStripButtonHistory.AutoSize = false;
            this.toolStripButtonHistory.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonHistory.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHistory.Image")));
            this.toolStripButtonHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonHistory.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonHistory.Name = "toolStripButtonHistory";
            this.toolStripButtonHistory.Size = new System.Drawing.Size(200, 60);
            this.toolStripButtonHistory.Text = "Lịch Sử";
            this.toolStripButtonHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonHistory.Click += new System.EventHandler(this.ToolStripButtonClick);
            // 
            // toolStripButtonService
            // 
            this.toolStripButtonService.AutoSize = false;
            this.toolStripButtonService.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonService.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonService.Image")));
            this.toolStripButtonService.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonService.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonService.Name = "toolStripButtonService";
            this.toolStripButtonService.Size = new System.Drawing.Size(200, 60);
            this.toolStripButtonService.Text = "Dịch Vụ";
            this.toolStripButtonService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonService.Click += new System.EventHandler(this.ToolStripButtonClick);
            // 
            // toolStripButtonLogOut
            // 
            this.toolStripButtonLogOut.AutoSize = false;
            this.toolStripButtonLogOut.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonLogOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLogOut.Image")));
            this.toolStripButtonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonLogOut.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonLogOut.Name = "toolStripButtonLogOut";
            this.toolStripButtonLogOut.Size = new System.Drawing.Size(200, 60);
            this.toolStripButtonLogOut.Text = "Đăng Xuất";
            this.toolStripButtonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonLogOut.Click += new System.EventHandler(this.ToolStripButtonClick);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMain.Location = new System.Drawing.Point(150, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(780, 512);
            this.panelMain.TabIndex = 2;
            // 
            // pictureBoxConins
            // 
            this.pictureBoxConins.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxConins.Image")));
            this.pictureBoxConins.ImageRotate = 0F;
            this.pictureBoxConins.Location = new System.Drawing.Point(55, 0);
            this.pictureBoxConins.Name = "pictureBoxConins";
            this.pictureBoxConins.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxConins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxConins.TabIndex = 4;
            this.pictureBoxConins.TabStop = false;
            // 
            // labelCoins
            // 
            this.labelCoins.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCoins.Location = new System.Drawing.Point(0, 38);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(150, 35);
            this.labelCoins.TabIndex = 5;
            this.labelCoins.Text = "0";
            this.labelCoins.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 512);
            this.Controls.Add(this.pictureBoxConins);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.panelOption);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.Text = "FMain";
            this.Load += new System.EventHandler(this.FMainLoad);
            this.panelOption.ResumeLayout(false);
            this.toolStripOption.ResumeLayout(false);
            this.toolStripOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.ToolStrip toolStripOption;
        private System.Windows.Forms.ToolStripButton toolStripButtonInfor;
        private System.Windows.Forms.ToolStripButton toolStripButtonHomePage;
        private System.Windows.Forms.ToolStripButton toolStripButtonHistory;
        private System.Windows.Forms.ToolStripButton toolStripButtonNotification;
        private System.Windows.Forms.ToolStripButton toolStripButtonService;
        private System.Windows.Forms.ToolStripButton toolStripButtonLogOut;
        public System.Windows.Forms.Panel panelMain;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxConins;
        private System.Windows.Forms.Label labelCoins;
    }
}