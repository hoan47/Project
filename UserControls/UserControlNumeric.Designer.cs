
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
            // groupBox
            // 
            this.groupBox.Controls.Add(this.numericUpDownPeople);
            this.groupBox.Controls.Add(this.pictureBox);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(100, 55);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Số người";
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
            // numericUpDownPeople
            // 
            this.numericUpDownPeople.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownPeople.BorderColor = System.Drawing.Color.Black;
            this.numericUpDownPeople.BorderRadius = 10;
            this.numericUpDownPeople.BorderThickness = 2;
            this.numericUpDownPeople.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownPeople.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownPeople.Location = new System.Drawing.Point(45, 20);
            this.numericUpDownPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPeople.Name = "numericUpDownPeople";
            this.numericUpDownPeople.Size = new System.Drawing.Size(51, 30);
            this.numericUpDownPeople.TabIndex = 1;
            this.numericUpDownPeople.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.numericUpDownPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UserControlNumeric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "UserControlNumeric";
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
