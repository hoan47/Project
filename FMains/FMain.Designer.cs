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
            this.toolStripButtonHistory = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPreferential = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonService = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLogOut = new System.Windows.Forms.ToolStripButton();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelOption.SuspendLayout();
            this.toolStripOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOption
            // 
            this.panelOption.Controls.Add(this.toolStripOption);
            this.panelOption.Location = new System.Drawing.Point(0, 170);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(200, 460);
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
            this.toolStripButtonHistory,
            this.toolStripButtonPreferential,
            this.toolStripButtonService,
            this.toolStripButtonSetting,
            this.toolStripButtonLogOut});
            this.toolStripOption.Location = new System.Drawing.Point(0, 0);
            this.toolStripOption.Name = "toolStripOption";
            this.toolStripOption.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripOption.Size = new System.Drawing.Size(200, 460);
            this.toolStripOption.TabIndex = 0;
            this.toolStripOption.TabStop = true;
            this.toolStripOption.Text = "toolStrip1";
            // 
            // toolStripButtonInfo
            // 
            this.toolStripButtonInfor.AutoSize = false;
            this.toolStripButtonInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonInfor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInfo.Image")));
            this.toolStripButtonInfor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonInfor.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonInfor.Name = "toolStripButtonInfo";
            this.toolStripButtonInfor.Size = new System.Drawing.Size(200, 50);
            this.toolStripButtonInfor.Text = "Thông Tin";
            this.toolStripButtonInfor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonInfor.Click += new System.EventHandler(this.ToolStripButtonClick);
            // 
            // toolStripButtonHomePage
            // 
            this.toolStripButtonHomePage.AutoSize = false;
            this.toolStripButtonHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripButtonHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonHomePage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHomePage.Image")));
            this.toolStripButtonHomePage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonHomePage.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonHomePage.Name = "toolStripButtonHomePage";
            this.toolStripButtonHomePage.Size = new System.Drawing.Size(200, 50);
            this.toolStripButtonHomePage.Text = "Trang Chủ";
            this.toolStripButtonHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonHomePage.Click += new System.EventHandler(this.ToolStripButtonClick);
            // 
            // toolStripButtonHistory
            // 
            this.toolStripButtonHistory.AutoSize = false;
            this.toolStripButtonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonHistory.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonHistory.Image")));
            this.toolStripButtonHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonHistory.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonHistory.Name = "toolStripButtonHistory";
            this.toolStripButtonHistory.Size = new System.Drawing.Size(200, 50);
            this.toolStripButtonHistory.Text = "Lịch Sử";
            this.toolStripButtonHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonHistory.Click += new System.EventHandler(this.ToolStripButtonClick);
            // 
            // toolStripButtonPreferential
            // 
            this.toolStripButtonPreferential.AutoSize = false;
            this.toolStripButtonPreferential.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonPreferential.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPreferential.Image")));
            this.toolStripButtonPreferential.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonPreferential.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonPreferential.Name = "toolStripButtonPreferential";
            this.toolStripButtonPreferential.Size = new System.Drawing.Size(200, 50);
            this.toolStripButtonPreferential.Text = "Ưu Đãi";
            this.toolStripButtonPreferential.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonPreferential.Click += new System.EventHandler(this.ToolStripButtonClick);
            // 
            // toolStripButtonService
            // 
            this.toolStripButtonService.AutoSize = false;
            this.toolStripButtonService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonService.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonService.Image")));
            this.toolStripButtonService.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonService.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonService.Name = "toolStripButtonService";
            this.toolStripButtonService.Size = new System.Drawing.Size(200, 50);
            this.toolStripButtonService.Text = "Dịch Vụ";
            this.toolStripButtonService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonService.Click += new System.EventHandler(this.ToolStripButtonClick);
            // 
            // toolStripButtonSetting
            // 
            this.toolStripButtonSetting.AutoSize = false;
            this.toolStripButtonSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonSetting.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSetting.Image")));
            this.toolStripButtonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonSetting.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonSetting.Name = "toolStripButtonSetting";
            this.toolStripButtonSetting.Size = new System.Drawing.Size(200, 50);
            this.toolStripButtonSetting.Text = "Cài Đặt";
            this.toolStripButtonSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonSetting.Click += new System.EventHandler(this.ToolStripButtonClick);
            // 
            // toolStripButtonLogOut
            // 
            this.toolStripButtonLogOut.AutoSize = false;
            this.toolStripButtonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButtonLogOut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLogOut.Image")));
            this.toolStripButtonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripButtonLogOut.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButtonLogOut.Name = "toolStripButtonLogOut";
            this.toolStripButtonLogOut.Size = new System.Drawing.Size(200, 50);
            this.toolStripButtonLogOut.Text = "Đăng Xuất";
            this.toolStripButtonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButtonLogOut.Click += new System.EventHandler(this.ToolStripButtonClick);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.Location = new System.Drawing.Point(25, 12);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 4;
            this.pictureBoxIcon.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMain.BackgroundImage")));
            this.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMain.Location = new System.Drawing.Point(200, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1040, 630);
            this.panelMain.TabIndex = 2;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1240, 630);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.panelOption);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.Text = "FMain";
            this.panelOption.ResumeLayout(false);
            this.toolStripOption.ResumeLayout(false);
            this.toolStripOption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.ToolStrip toolStripOption;
        private System.Windows.Forms.ToolStripButton toolStripButtonInfor;
        private System.Windows.Forms.ToolStripButton toolStripButtonHomePage;
        private System.Windows.Forms.ToolStripButton toolStripButtonHistory;
        private System.Windows.Forms.ToolStripButton toolStripButtonPreferential;
        private System.Windows.Forms.ToolStripButton toolStripButtonService;
        private System.Windows.Forms.ToolStripButton toolStripButtonSetting;
        private System.Windows.Forms.ToolStripButton toolStripButtonLogOut;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        public System.Windows.Forms.Panel panelMain;
    }
}