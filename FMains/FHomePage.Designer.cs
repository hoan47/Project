
namespace Project
{
    partial class FHomePage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHomePage));
            this.panelSearch = new System.Windows.Forms.Panel();
            this.pictureBoxYesNo = new System.Windows.Forms.PictureBox();
            this.checkBoxYesRent = new System.Windows.Forms.CheckBox();
            this.checkBoxNoRent = new System.Windows.Forms.CheckBox();
            this.labelMinMax = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelPeople = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxPeople = new System.Windows.Forms.PictureBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.pictureBoxCity = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userControlComboBoxAddress = new Project.UserControlComboBoxAddress();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCity)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.userControlComboBoxAddress);
            this.panelSearch.Controls.Add(this.pictureBoxYesNo);
            this.panelSearch.Controls.Add(this.checkBoxYesRent);
            this.panelSearch.Controls.Add(this.checkBoxNoRent);
            this.panelSearch.Controls.Add(this.labelMinMax);
            this.panelSearch.Controls.Add(this.labelPrice);
            this.panelSearch.Controls.Add(this.pictureBox1);
            this.panelSearch.Controls.Add(this.labelPeople);
            this.panelSearch.Controls.Add(this.numericUpDown1);
            this.panelSearch.Controls.Add(this.pictureBoxPeople);
            this.panelSearch.Controls.Add(this.labelAddress);
            this.panelSearch.Controls.Add(this.pictureBoxCity);
            this.panelSearch.Controls.Add(this.textBox2);
            this.panelSearch.Controls.Add(this.textBox1);
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(307, 630);
            this.panelSearch.TabIndex = 3;
            // 
            // pictureBoxYesNo
            // 
            this.pictureBoxYesNo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxYesNo.Image")));
            this.pictureBoxYesNo.Location = new System.Drawing.Point(17, 219);
            this.pictureBoxYesNo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxYesNo.Name = "pictureBoxYesNo";
            this.pictureBoxYesNo.Size = new System.Drawing.Size(53, 49);
            this.pictureBoxYesNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxYesNo.TabIndex = 16;
            this.pictureBoxYesNo.TabStop = false;
            // 
            // checkBoxYesRent
            // 
            this.checkBoxYesRent.AutoSize = true;
            this.checkBoxYesRent.Location = new System.Drawing.Point(81, 247);
            this.checkBoxYesRent.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxYesRent.Name = "checkBoxYesRent";
            this.checkBoxYesRent.Size = new System.Drawing.Size(80, 21);
            this.checkBoxYesRent.TabIndex = 15;
            this.checkBoxYesRent.Text = "Đã thuê";
            this.checkBoxYesRent.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoRent
            // 
            this.checkBoxNoRent.AutoSize = true;
            this.checkBoxNoRent.Location = new System.Drawing.Point(81, 219);
            this.checkBoxNoRent.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxNoRent.Name = "checkBoxNoRent";
            this.checkBoxNoRent.Size = new System.Drawing.Size(95, 21);
            this.checkBoxNoRent.TabIndex = 14;
            this.checkBoxNoRent.Text = "Chưa thuê";
            this.checkBoxNoRent.UseVisualStyleBackColor = true;
            this.checkBoxNoRent.CheckedChanged += new System.EventHandler(this.checkBoxNoRent_CheckedChanged);
            // 
            // labelMinMax
            // 
            this.labelMinMax.AutoSize = true;
            this.labelMinMax.ForeColor = System.Drawing.Color.Black;
            this.labelMinMax.Location = new System.Drawing.Point(77, 159);
            this.labelMinMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinMax.Name = "labelMinMax";
            this.labelMinMax.Size = new System.Drawing.Size(188, 17);
            this.labelMinMax.TabIndex = 13;
            this.labelMinMax.Text = "Min ------------------------- Max";
            this.labelMinMax.Click += new System.EventHandler(this.labelMinMax_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.ForeColor = System.Drawing.Color.Black;
            this.labelPrice.Location = new System.Drawing.Point(77, 135);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(62, 17);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "Giá thuê";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 130);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // labelPeople
            // 
            this.labelPeople.AutoSize = true;
            this.labelPeople.ForeColor = System.Drawing.Color.Black;
            this.labelPeople.Location = new System.Drawing.Point(77, 73);
            this.labelPeople.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeople.Name = "labelPeople";
            this.labelPeople.Size = new System.Drawing.Size(64, 17);
            this.labelPeople.TabIndex = 10;
            this.labelPeople.Text = "Số người";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(77, 97);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(213, 22);
            this.numericUpDown1.TabIndex = 9;
            // 
            // pictureBoxPeople
            // 
            this.pictureBoxPeople.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPeople.Image")));
            this.pictureBoxPeople.Location = new System.Drawing.Point(16, 73);
            this.pictureBoxPeople.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPeople.Name = "pictureBoxPeople";
            this.pictureBoxPeople.Size = new System.Drawing.Size(53, 49);
            this.pictureBoxPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPeople.TabIndex = 7;
            this.pictureBoxPeople.TabStop = false;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.ForeColor = System.Drawing.Color.Black;
            this.labelAddress.Location = new System.Drawing.Point(77, 15);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(51, 17);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "Địa chỉ";
            this.labelAddress.Click += new System.EventHandler(this.labelAddress_Click);
            // 
            // pictureBoxCity
            // 
            this.pictureBoxCity.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCity.Image")));
            this.pictureBoxCity.Location = new System.Drawing.Point(16, 15);
            this.pictureBoxCity.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCity.Name = "pictureBoxCity";
            this.pictureBoxCity.Size = new System.Drawing.Size(53, 49);
            this.pictureBoxCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCity.TabIndex = 5;
            this.pictureBoxCity.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 187);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 187);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 3;
            // 
            // userControlComboBoxAddress
            // 
            this.userControlComboBoxAddress.Location = new System.Drawing.Point(77, 39);
            this.userControlComboBoxAddress.Name = "userControlComboBoxAddress";
            this.userControlComboBoxAddress.Size = new System.Drawing.Size(212, 24);
            this.userControlComboBoxAddress.TabIndex = 17;
            // 
            // FHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1040, 630);
            this.Controls.Add(this.panelSearch);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FHomePage";
            this.Text = "FHomePage";
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBoxCity;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pictureBoxPeople;
        private System.Windows.Forms.CheckBox checkBoxYesRent;
        private System.Windows.Forms.CheckBox checkBoxNoRent;
        private System.Windows.Forms.Label labelMinMax;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPeople;
        private System.Windows.Forms.PictureBox pictureBoxYesNo;
        private UserControlComboBoxAddress userControlComboBoxAddress;
    }
}