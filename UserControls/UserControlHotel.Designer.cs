
namespace Project
{
    partial class UserControlHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHotel));
            this.pictureBoxHotel = new System.Windows.Forms.PictureBox();
            this.userControlService1 = new Project.UserControls.UserControlService();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHotel
            // 
            this.pictureBoxHotel.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHotel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHotel.Image")));
            this.pictureBoxHotel.Location = new System.Drawing.Point(21, 30);
            this.pictureBoxHotel.Name = "pictureBoxHotel";
            this.pictureBoxHotel.Size = new System.Drawing.Size(130, 131);
            this.pictureBoxHotel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHotel.TabIndex = 6;
            this.pictureBoxHotel.TabStop = false;
            // 
            // userControlService1
            // 
            this.userControlService1.AutoSize = true;
            this.userControlService1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.userControlService1.Image = ((System.Drawing.Image)(resources.GetObject("userControlService1.Image")));
            this.userControlService1.LabelText = "Tên khách sạn";
            this.userControlService1.Location = new System.Drawing.Point(184, 30);
            this.userControlService1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlService1.Name = "userControlService1";
            this.userControlService1.Size = new System.Drawing.Size(311, 58);
            this.userControlService1.TabIndex = 7;
            this.userControlService1.TextBoxText = "";
            // 
            // UserControlHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.userControlService1);
            this.Controls.Add(this.pictureBoxHotel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Name = "UserControlHotel";
            this.Size = new System.Drawing.Size(650, 181);
            this.DoubleClick += new System.EventHandler(this.UserControlHottelDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxHotel;
        private UserControls.UserControlService userControlService1;
    }
}
