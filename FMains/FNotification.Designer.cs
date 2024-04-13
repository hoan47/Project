
namespace Project
{
    partial class FNotification
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.userControlNote1 = new Project.UserControls.UserControlNote();
            this.userControlNote2 = new Project.UserControls.UserControlNote();
            this.userControlNote4 = new Project.UserControls.UserControlNote();
            this.userControlNote3 = new Project.UserControls.UserControlNote();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AllowDrop = true;
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(23, 81);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(745, 430);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // userControlNote1
            // 
            this.userControlNote1.FillColorContentCircle = System.Drawing.Color.Yellow;
            this.userControlNote1.Location = new System.Drawing.Point(129, 9);
            this.userControlNote1.Name = "userControlNote1";
            this.userControlNote1.Size = new System.Drawing.Size(260, 30);
            this.userControlNote1.TabIndex = 1;
            this.userControlNote1.TextContent = "Thông báo từ khách hàng";
            // 
            // userControlNote2
            // 
            this.userControlNote2.FillColorContentCircle = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.userControlNote2.Location = new System.Drawing.Point(395, 9);
            this.userControlNote2.Name = "userControlNote2";
            this.userControlNote2.Size = new System.Drawing.Size(260, 30);
            this.userControlNote2.TabIndex = 2;
            this.userControlNote2.TextContent = "Thông báo từ khách sạn";
            // 
            // userControlNote4
            // 
            this.userControlNote4.FillColorContentCircle = System.Drawing.Color.Lime;
            this.userControlNote4.Location = new System.Drawing.Point(395, 45);
            this.userControlNote4.Name = "userControlNote4";
            this.userControlNote4.Size = new System.Drawing.Size(260, 30);
            this.userControlNote4.TabIndex = 4;
            this.userControlNote4.TextContent = "Thông báo biến động xu";
            // 
            // userControlNote3
            // 
            this.userControlNote3.FillColorContentCircle = System.Drawing.Color.Pink;
            this.userControlNote3.Location = new System.Drawing.Point(129, 45);
            this.userControlNote3.Name = "userControlNote3";
            this.userControlNote3.Size = new System.Drawing.Size(260, 30);
            this.userControlNote3.TabIndex = 5;
            this.userControlNote3.TextContent = "Thông báo từ hệ thống";
            // 
            // FNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(780, 512);
            this.Controls.Add(this.userControlNote3);
            this.Controls.Add(this.userControlNote4);
            this.Controls.Add(this.userControlNote2);
            this.Controls.Add(this.userControlNote1);
            this.Controls.Add(this.flowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FNotification";
            this.Text = "FPreferential";
            this.Load += new System.EventHandler(this.FNotificationLoad);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private UserControls.UserControlNote userControlNote1;
        private UserControls.UserControlNote userControlNote2;
        private UserControls.UserControlNote userControlNote4;
        private UserControls.UserControlNote userControlNote3;
    }
}