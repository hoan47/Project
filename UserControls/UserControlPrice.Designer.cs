
namespace Project.UserControls
{
    partial class UserControlPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlPrice));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBoxIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.panelRoad = new System.Windows.Forms.Panel();
            this.guna2HScrollBar = new Guna.UI2.WinForms.Guna2HScrollBar();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.pictureBoxIcon);
            this.groupBox.Controls.Add(this.labelPrice);
            this.groupBox.Controls.Add(this.panelRoad);
            this.groupBox.Controls.Add(this.guna2HScrollBar);
            this.groupBox.Controls.Add(this.pictureBox);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(256, 56);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Giá tiền";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIcon.Image")));
            this.pictureBoxIcon.ImageRotate = 0F;
            this.pictureBoxIcon.Location = new System.Drawing.Point(212, 10);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIcon.TabIndex = 3;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelPrice
            // 
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.Location = new System.Drawing.Point(50, 10);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(166, 20);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "10.000";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panelRoad
            // 
            this.panelRoad.BackColor = System.Drawing.Color.White;
            this.panelRoad.ForeColor = System.Drawing.Color.Transparent;
            this.panelRoad.Location = new System.Drawing.Point(50, 42);
            this.panelRoad.Name = "panelRoad";
            this.panelRoad.Size = new System.Drawing.Size(175, 2);
            this.panelRoad.TabIndex = 1;
            // 
            // guna2HScrollBar
            // 
            this.guna2HScrollBar.BackColor = System.Drawing.Color.Transparent;
            this.guna2HScrollBar.BorderRadius = 8;
            this.guna2HScrollBar.FillColor = System.Drawing.Color.Transparent;
            this.guna2HScrollBar.InUpdate = false;
            this.guna2HScrollBar.LargeChange = 10;
            this.guna2HScrollBar.Location = new System.Drawing.Point(42, 33);
            this.guna2HScrollBar.Minimum = 1;
            this.guna2HScrollBar.Name = "guna2HScrollBar";
            this.guna2HScrollBar.ScrollbarSize = 20;
            this.guna2HScrollBar.Size = new System.Drawing.Size(195, 20);
            this.guna2HScrollBar.TabIndex = 0;
            this.guna2HScrollBar.ThumbColor = System.Drawing.Color.White;
            this.guna2HScrollBar.ThumbSize = 5F;
            this.guna2HScrollBar.ThumbStyle = Guna.UI2.WinForms.Enums.ThumbStyle.Inset;
            this.guna2HScrollBar.Value = 1;
            this.guna2HScrollBar.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(6, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(30, 30);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // UserControlPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox);
            this.Name = "UserControlPrice";
            this.Size = new System.Drawing.Size(256, 56);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelPrice;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxIcon;
        private System.Windows.Forms.Panel panelRoad;
        private Guna.UI2.WinForms.Guna2HScrollBar guna2HScrollBar;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
