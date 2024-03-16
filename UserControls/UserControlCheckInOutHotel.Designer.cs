
namespace Project
{
    partial class UserControlCheckInOutHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlCheckInOutHotel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelIn = new Guna.UI2.WinForms.Guna2Panel();
            this.maskedTextBoxIn = new System.Windows.Forms.MaskedTextBox();
            this.panelOut = new Guna.UI2.WinForms.Guna2Panel();
            this.maskedTextBoxOut = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelIn.SuspendLayout();
            this.panelOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(22, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(214, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panelIn);
            this.groupBox1.Controls.Add(this.panelOut);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 82);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời Gian";
            // 
            // panelIn
            // 
            this.panelIn.BackColor = System.Drawing.Color.White;
            this.panelIn.BorderColor = System.Drawing.Color.Black;
            this.panelIn.BorderRadius = 10;
            this.panelIn.BorderThickness = 2;
            this.panelIn.Controls.Add(this.maskedTextBoxIn);
            this.panelIn.Location = new System.Drawing.Point(90, 40);
            this.panelIn.Name = "panelIn";
            this.panelIn.Size = new System.Drawing.Size(78, 32);
            this.panelIn.TabIndex = 9;
            // 
            // maskedTextBoxIn
            // 
            this.maskedTextBoxIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxIn.Location = new System.Drawing.Point(13, 8);
            this.maskedTextBoxIn.Mask = "00:00";
            this.maskedTextBoxIn.Name = "maskedTextBoxIn";
            this.maskedTextBoxIn.Size = new System.Drawing.Size(53, 15);
            this.maskedTextBoxIn.TabIndex = 8;
            this.maskedTextBoxIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxIn.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxIn.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxIn_MaskInputRejected);
            // 
            // panelOut
            // 
            this.panelOut.BackColor = System.Drawing.Color.White;
            this.panelOut.BorderColor = System.Drawing.Color.Black;
            this.panelOut.BorderRadius = 10;
            this.panelOut.BorderThickness = 2;
            this.panelOut.Controls.Add(this.maskedTextBoxOut);
            this.panelOut.Location = new System.Drawing.Point(281, 40);
            this.panelOut.Name = "panelOut";
            this.panelOut.Size = new System.Drawing.Size(78, 32);
            this.panelOut.TabIndex = 8;
            // 
            // maskedTextBoxOut
            // 
            this.maskedTextBoxOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBoxOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxOut.Location = new System.Drawing.Point(13, 8);
            this.maskedTextBoxOut.Mask = "00:00";
            this.maskedTextBoxOut.Name = "maskedTextBoxOut";
            this.maskedTextBoxOut.Size = new System.Drawing.Size(53, 15);
            this.maskedTextBoxOut.TabIndex = 8;
            this.maskedTextBoxOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBoxOut.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxOut.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBoxOut_MaskInputRejected);
            // 
            // UserControlCheckInOutHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlCheckInOutHotel";
            this.Size = new System.Drawing.Size(400, 82);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelIn.ResumeLayout(false);
            this.panelIn.PerformLayout();
            this.panelOut.ResumeLayout(false);
            this.panelOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIn;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxOut;
        private Guna.UI2.WinForms.Guna2Panel panelOut;
        private Guna.UI2.WinForms.Guna2Panel panelIn;
    }
}
