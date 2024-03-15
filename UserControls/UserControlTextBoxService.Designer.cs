namespace Project.UserControls
{
    partial class UserControlTextBoxService
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTextBoxService));
            this.groupBoxInforService = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxInforService = new System.Windows.Forms.PictureBox();
            this.groupBoxInforService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInforService)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInforService
            // 
            this.groupBoxInforService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxInforService.Controls.Add(this.panel1);
            this.groupBoxInforService.Controls.Add(this.pictureBoxInforService);
            this.groupBoxInforService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxInforService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInforService.Location = new System.Drawing.Point(1, 3);
            this.groupBoxInforService.Name = "groupBoxInforService";
            this.groupBoxInforService.Size = new System.Drawing.Size(425, 76);
            this.groupBoxInforService.TabIndex = 0;
            this.groupBoxInforService.TabStop = false;
            this.groupBoxInforService.Text = "groupBox1";
            this.groupBoxInforService.Enter += new System.EventHandler(this.groupBoxInforService_Enter);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(85, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 36);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxInforService
            // 
            this.pictureBoxInforService.Location = new System.Drawing.Point(6, 23);
            this.pictureBoxInforService.Name = "pictureBoxInforService";
            this.pictureBoxInforService.Size = new System.Drawing.Size(49, 49);
            this.pictureBoxInforService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInforService.TabIndex = 0;
            this.pictureBoxInforService.TabStop = false;
            this.pictureBoxInforService.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // UserControlTextBoxService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Controls.Add(this.groupBoxInforService);
            this.Name = "UserControlTextBoxService";
            this.Size = new System.Drawing.Size(429, 82);
            this.groupBoxInforService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInforService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInforService;
        private System.Windows.Forms.PictureBox pictureBoxInforService;
        private System.Windows.Forms.Panel panel1;
    }
}
