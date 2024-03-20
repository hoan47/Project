
namespace Project
{
    partial class UserControlNumeric
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlNumeric));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.numericUpDownPeople = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPeople
            // 
            this.groupBox.Controls.Add(this.numericUpDownPeople);
            this.groupBox.Controls.Add(this.pictureBox);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBoxPeople";
            this.groupBox.Size = new System.Drawing.Size(100, 55);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Số người";
            // 
            // pictureBoxPeople
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPeople.Image")));
            this.pictureBox.Location = new System.Drawing.Point(6, 19);
            this.pictureBox.Name = "pictureBoxPeople";
            this.pictureBox.Size = new System.Drawing.Size(30, 30);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // guna2NumericUpDownPeople
            // 
            this.numericUpDownPeople.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownPeople.BorderColor = System.Drawing.Color.Black;
            this.numericUpDownPeople.BorderRadius = 10;
            this.numericUpDownPeople.BorderThickness = 3;
            this.numericUpDownPeople.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownPeople.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownPeople.Location = new System.Drawing.Point(42, 19);
            this.numericUpDownPeople.Name = "guna2NumericUpDownPeople";
            this.numericUpDownPeople.Size = new System.Drawing.Size(52, 30);
            this.numericUpDownPeople.TabIndex = 1;
            this.numericUpDownPeople.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.numericUpDownPeople.UpDownButtonForeColor = System.Drawing.Color.Black;
            // 
            // UserControlHomePaceSearchPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "UserControlHomePaceSearchPeople";
            this.Size = new System.Drawing.Size(100, 55);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDownPeople;
    }
}
