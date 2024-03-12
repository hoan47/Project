
namespace Project
{
    partial class UserControlHotelEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHotelEdit));
            this.labelHotelEdit = new System.Windows.Forms.Label();
            this.pictureBoxHotelEdit = new System.Windows.Forms.PictureBox();
            this.groupBoxHotelEdit = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotelEdit)).BeginInit();
            this.groupBoxHotelEdit.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHotelEdit
            // 
            this.labelHotelEdit.AutoEllipsis = true;
            this.labelHotelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHotelEdit.Location = new System.Drawing.Point(36, 27);
            this.labelHotelEdit.Name = "labelHotelEdit";
            this.labelHotelEdit.Size = new System.Drawing.Size(199, 18);
            this.labelHotelEdit.TabIndex = 1;
            this.labelHotelEdit.Text = "";
            this.labelHotelEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelHotelEdit.DoubleClick += new System.EventHandler(this.DoubleClickUser);
            // 
            // pictureBoxHotelEdit
            // 
            this.pictureBoxHotelEdit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHotelEdit.Image")));
            this.pictureBoxHotelEdit.Location = new System.Drawing.Point(6, 21);
            this.pictureBoxHotelEdit.Name = "pictureBoxHotelEdit";
            this.pictureBoxHotelEdit.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxHotelEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHotelEdit.TabIndex = 0;
            this.pictureBoxHotelEdit.TabStop = false;
            this.pictureBoxHotelEdit.DoubleClick += new System.EventHandler(this.DoubleClickUser);
            // 
            // groupBoxHotelEdit
            // 
            this.groupBoxHotelEdit.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxHotelEdit.Controls.Add(this.panel);
            this.groupBoxHotelEdit.Location = new System.Drawing.Point(0, 0);
            this.groupBoxHotelEdit.Name = "groupBoxHotelEdit";
            this.groupBoxHotelEdit.Size = new System.Drawing.Size(235, 60);
            this.groupBoxHotelEdit.TabIndex = 2;
            this.groupBoxHotelEdit.TabStop = false;
            this.groupBoxHotelEdit.Text = "Tên";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pictureBoxHotelEdit);
            this.panel.Controls.Add(this.labelHotelEdit);
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(235, 60);
            this.panel.TabIndex = 0;
            this.panel.DoubleClick += new System.EventHandler(this.DoubleClickUser);
            // 
            // UserControlHotelEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBoxHotelEdit);
            this.Name = "UserControlHotelEdit";
            this.Size = new System.Drawing.Size(235, 60);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHotelEdit)).EndInit();
            this.groupBoxHotelEdit.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHotelEdit;
        private System.Windows.Forms.Label labelHotelEdit;
        private System.Windows.Forms.GroupBox groupBoxHotelEdit;
        private System.Windows.Forms.Panel panel;
    }
}
