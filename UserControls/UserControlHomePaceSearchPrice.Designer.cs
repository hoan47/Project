
namespace Project
{
    partial class UserControlHomePaceSearchPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHomePaceSearchPrice));
            this.groupBoxPrice = new System.Windows.Forms.GroupBox();
            this.guna2TextBoxPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPrice
            // 
            this.groupBoxPrice.Controls.Add(this.guna2TextBoxPrice);
            this.groupBoxPrice.Controls.Add(this.pictureBox1);
            this.groupBoxPrice.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPrice.Name = "groupBoxPrice";
            this.groupBoxPrice.Size = new System.Drawing.Size(150, 55);
            this.groupBoxPrice.TabIndex = 0;
            this.groupBoxPrice.TabStop = false;
            this.groupBoxPrice.Text = "Giá tiền";
            // 
            // guna2TextBoxPrice
            // 
            this.guna2TextBoxPrice.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBoxPrice.BorderRadius = 10;
            this.guna2TextBoxPrice.BorderThickness = 3;
            this.guna2TextBoxPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBoxPrice.DefaultText = "";
            this.guna2TextBoxPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBoxPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBoxPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBoxPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBoxPrice.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBoxPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBoxPrice.Location = new System.Drawing.Point(42, 19);
            this.guna2TextBoxPrice.Name = "guna2TextBoxPrice";
            this.guna2TextBoxPrice.PasswordChar = '\0';
            this.guna2TextBoxPrice.PlaceholderText = "Giá tiền";
            this.guna2TextBoxPrice.SelectedText = "";
            this.guna2TextBoxPrice.Size = new System.Drawing.Size(102, 30);
            this.guna2TextBoxPrice.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // UserControlHomePaceSearchPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxPrice);
            this.Name = "UserControlHomePaceSearchPrice";
            this.Size = new System.Drawing.Size(150, 55);
            this.groupBoxPrice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBoxPrice;
    }
}
