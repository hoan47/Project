
namespace Project
{
    partial class FService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FService));
            this.flowLayoutPanelHottel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelHottel
            // 
            this.flowLayoutPanelHottel.AutoScroll = true;
            this.flowLayoutPanelHottel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelHottel.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelHottel.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanelHottel.Location = new System.Drawing.Point(16, 13);
            this.flowLayoutPanelHottel.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelHottel.Name = "flowLayoutPanelHottel";
            this.flowLayoutPanelHottel.Size = new System.Drawing.Size(907, 603);
            this.flowLayoutPanelHottel.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdd.BackgroundImage")));
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdd.BorderColor = System.Drawing.Color.Transparent;
            this.buttonAdd.BorderRadius = 5;
            this.buttonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdd.FillColor = System.Drawing.Color.Transparent;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(978, 566);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(50, 50);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // FService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1040, 630);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.flowLayoutPanelHottel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FService";
            this.Text = "FService";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHottel;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
    }
}