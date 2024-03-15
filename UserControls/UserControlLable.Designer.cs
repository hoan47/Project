
namespace Project
{
    partial class UserControlerLable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlerLable));
            this.labelContect = new System.Windows.Forms.Label();
            this.pictureBoxHotelEdit = new System.Windows.Forms.PictureBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotelEdit)).BeginInit();
            this.groupBox.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelContect
            // 
            this.labelContect.AutoEllipsis = true;
            this.labelContect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContect.Location = new System.Drawing.Point(56, 33);
            this.labelContect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContect.Name = "labelContect";
            this.labelContect.Size = new System.Drawing.Size(249, 22);
            this.labelContect.TabIndex = 1;
            this.labelContect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelContect.DoubleClick += new System.EventHandler(this.DoubleClickUser);
            // 
            // pictureBoxHotelEdit
            // 
            this.pictureBoxHotelEdit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHotelEdit.Image")));
            this.pictureBoxHotelEdit.Location = new System.Drawing.Point(8, 26);
            this.pictureBoxHotelEdit.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxHotelEdit.Name = "pictureBoxHotelEdit";
            this.pictureBoxHotelEdit.Size = new System.Drawing.Size(40, 37);
            this.pictureBoxHotelEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHotelEdit.TabIndex = 0;
            this.pictureBoxHotelEdit.TabStop = false;
            this.pictureBoxHotelEdit.DoubleClick += new System.EventHandler(this.DoubleClickUser);
            // 
            // groupBoxHotelEdit
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.panel);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBoxHotelEdit";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(313, 74);
            this.groupBox.TabIndex = 2;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Tên";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pictureBoxHotelEdit);
            this.panel.Controls.Add(this.labelContect);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(313, 74);
            this.panel.TabIndex = 0;
            this.panel.DoubleClick += new System.EventHandler(this.DoubleClickUser);
            // 
            // UserControlerLable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserControlerLable";
            this.Size = new System.Drawing.Size(313, 74);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotelEdit)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHotelEdit;
        private System.Windows.Forms.Label labelContect;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Panel panel;
    }
}
