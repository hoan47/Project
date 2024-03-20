
namespace Project
{
    partial class UserControlHomePaceSearchPeople
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHomePaceSearchPeople));
            this.groupBoxPeople = new System.Windows.Forms.GroupBox();
            this.pictureBoxPeople = new System.Windows.Forms.PictureBox();
            this.guna2NumericUpDownPeople = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.groupBoxPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDownPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPeople
            // 
            this.groupBoxPeople.Controls.Add(this.guna2NumericUpDownPeople);
            this.groupBoxPeople.Controls.Add(this.pictureBoxPeople);
            this.groupBoxPeople.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPeople.Name = "groupBoxPeople";
            this.groupBoxPeople.Size = new System.Drawing.Size(100, 55);
            this.groupBoxPeople.TabIndex = 0;
            this.groupBoxPeople.TabStop = false;
            this.groupBoxPeople.Text = "Số người";
            // 
            // pictureBoxPeople
            // 
            this.pictureBoxPeople.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPeople.Image")));
            this.pictureBoxPeople.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxPeople.Name = "pictureBoxPeople";
            this.pictureBoxPeople.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPeople.TabIndex = 0;
            this.pictureBoxPeople.TabStop = false;
            // 
            // guna2NumericUpDownPeople
            // 
            this.guna2NumericUpDownPeople.BackColor = System.Drawing.Color.Transparent;
            this.guna2NumericUpDownPeople.BorderColor = System.Drawing.Color.Black;
            this.guna2NumericUpDownPeople.BorderRadius = 10;
            this.guna2NumericUpDownPeople.BorderThickness = 3;
            this.guna2NumericUpDownPeople.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2NumericUpDownPeople.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2NumericUpDownPeople.Location = new System.Drawing.Point(42, 19);
            this.guna2NumericUpDownPeople.Name = "guna2NumericUpDownPeople";
            this.guna2NumericUpDownPeople.Size = new System.Drawing.Size(52, 30);
            this.guna2NumericUpDownPeople.TabIndex = 1;
            this.guna2NumericUpDownPeople.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2NumericUpDownPeople.UpDownButtonForeColor = System.Drawing.Color.Black;
            // 
            // UserControlHomePaceSearchPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxPeople);
            this.Name = "UserControlHomePaceSearchPeople";
            this.Size = new System.Drawing.Size(100, 55);
            this.groupBoxPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2NumericUpDownPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPeople;
        private System.Windows.Forms.PictureBox pictureBoxPeople;
        private Guna.UI2.WinForms.Guna2NumericUpDown guna2NumericUpDownPeople;
    }
}
