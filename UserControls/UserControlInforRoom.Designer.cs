namespace Project.UserControls
{
    partial class UserControlInforRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlInforRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControlDiscount1 = new Project.UserControls.UserControlDiscount();
            this.userControlService4 = new Project.UserControls.UserControlTextBoxService();
            this.userControlService3 = new Project.UserControls.UserControlTextBoxService();
            this.userControlService1 = new Project.UserControls.UserControlTextBoxService();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-2, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 11);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 44);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thông Tin Phòng";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(3, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 40);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(646, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 79);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(872, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 122);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(66, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 109);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userControlDiscount1
            // 
            this.userControlDiscount1.BackColor = System.Drawing.Color.White;
            this.userControlDiscount1.Location = new System.Drawing.Point(453, 166);
            this.userControlDiscount1.Name = "userControlDiscount1";
            this.userControlDiscount1.Size = new System.Drawing.Size(439, 238);
            this.userControlDiscount1.TabIndex = 5;
            // 
            // userControlService4
            // 
            this.userControlService4.AutoSize = true;
            this.userControlService4.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.userControlService4.Image = ((System.Drawing.Image)(resources.GetObject("userControlService4.Image")));
            this.userControlService4.LabelText = "Số Lượng";
            this.userControlService4.Location = new System.Drawing.Point(13, 307);
            this.userControlService4.Name = "userControlService4";
            this.userControlService4.Size = new System.Drawing.Size(434, 135);
            this.userControlService4.TabIndex = 4;
            this.userControlService4.TextBoxText = "";
            // 
            // userControlService3
            // 
            this.userControlService3.AutoSize = true;
            this.userControlService3.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.userControlService3.Image = ((System.Drawing.Image)(resources.GetObject("userControlService3.Image")));
            this.userControlService3.LabelText = "Giá Phòng";
            this.userControlService3.Location = new System.Drawing.Point(13, 448);
            this.userControlService3.Name = "userControlService3";
            this.userControlService3.Size = new System.Drawing.Size(434, 135);
            this.userControlService3.TabIndex = 3;
            this.userControlService3.TextBoxText = "";
            // 
            // userControlService1
            // 
            this.userControlService1.AutoSize = true;
            this.userControlService1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.userControlService1.Image = ((System.Drawing.Image)(resources.GetObject("userControlService1.Image")));
            this.userControlService1.LabelText = "Tên Phòng";
            this.userControlService1.Location = new System.Drawing.Point(13, 166);
            this.userControlService1.Name = "userControlService1";
            this.userControlService1.Size = new System.Drawing.Size(434, 135);
            this.userControlService1.TabIndex = 1;
            this.userControlService1.TextBoxText = "";
            // 
            // UserControlInforRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControlDiscount1);
            this.Controls.Add(this.userControlService4);
            this.Controls.Add(this.userControlService3);
            this.Controls.Add(this.userControlService1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserControlInforRoom";
            this.Size = new System.Drawing.Size(1040, 630);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControlTextBoxService userControlService1;
        private UserControlTextBoxService userControlService3;
        private UserControlTextBoxService userControlService4;
        private UserControlDiscount userControlDiscount1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
