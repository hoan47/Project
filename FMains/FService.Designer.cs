
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
            this.flowLayoutPanelService = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.pictureBoxHotel = new System.Windows.Forms.PictureBox();
            this.pictureBoxQuantity = new System.Windows.Forms.PictureBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelService
            // 
            this.flowLayoutPanelService.AutoScroll = true;
            this.flowLayoutPanelService.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelService.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelService.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanelService.Location = new System.Drawing.Point(12, 98);
            this.flowLayoutPanelService.Name = "flowLayoutPanelService";
            this.flowLayoutPanelService.Size = new System.Drawing.Size(680, 402);
            this.flowLayoutPanelService.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdd.BackgroundImage")));
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(698, 430);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(70, 70);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // pictureBoxHotel
            // 
            this.pictureBoxHotel.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHotel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHotel.Image")));
            this.pictureBoxHotel.Location = new System.Drawing.Point(1, -18);
            this.pictureBoxHotel.Name = "pictureBoxHotel";
            this.pictureBoxHotel.Size = new System.Drawing.Size(242, 115);
            this.pictureBoxHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHotel.TabIndex = 2;
            this.pictureBoxHotel.TabStop = false;
            // 
            // pictureBoxQuantity
            // 
            this.pictureBoxQuantity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxQuantity.BackgroundImage")));
            this.pictureBoxQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxQuantity.Location = new System.Drawing.Point(472, 55);
            this.pictureBoxQuantity.Name = "pictureBoxQuantity";
            this.pictureBoxQuantity.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxQuantity.TabIndex = 3;
            this.pictureBoxQuantity.TabStop = false;
            // 
            // labelQuantity
            // 
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(560, 55);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(132, 40);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "= 16";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(520, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(780, 512);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.pictureBoxQuantity);
            this.Controls.Add(this.pictureBoxHotel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.flowLayoutPanelService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FService";
            this.Text = "FService";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelService;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.PictureBox pictureBoxHotel;
        private System.Windows.Forms.PictureBox pictureBoxQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}