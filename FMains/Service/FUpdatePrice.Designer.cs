
namespace Project
{
    partial class FUpdatePrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUpdatePrice));
            this.groupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.NumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.DateTimePickerEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateTimePickerStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxEnd = new System.Windows.Forms.PictureBox();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox.BorderRadius = 10;
            this.groupBox.BorderThickness = 5;
            this.groupBox.Controls.Add(this.label);
            this.groupBox.Controls.Add(this.NumericUpDown);
            this.groupBox.Controls.Add(this.DateTimePickerEnd);
            this.groupBox.Controls.Add(this.DateTimePickerStart);
            this.groupBox.Controls.Add(this.pictureBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.pictureBoxEnd);
            this.groupBox.Controls.Add(this.pictureBoxStart);
            this.groupBox.Controls.Add(this.buttonUpdate);
            this.groupBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox.FillColor = System.Drawing.Color.Transparent;
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(139, 51);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(474, 247);
            this.groupBox.TabIndex = 21;
            this.groupBox.Text = "Cập nhật giá phòng";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(164, 159);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 15);
            this.label.TabIndex = 31;
            this.label.Text = "100%";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // NumericUpDown
            // 
            this.NumericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.NumericUpDown.BorderColor = System.Drawing.Color.Black;
            this.NumericUpDown.BorderRadius = 10;
            this.NumericUpDown.BorderThickness = 3;
            this.NumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NumericUpDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumericUpDown.Location = new System.Drawing.Point(155, 152);
            this.NumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDown.Name = "NumericUpDown";
            this.NumericUpDown.Size = new System.Drawing.Size(100, 30);
            this.NumericUpDown.TabIndex = 30;
            this.NumericUpDown.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NumericUpDown.UpDownButtonForeColor = System.Drawing.Color.Black;
            this.NumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NumericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDownValueChanged);
            // 
            // DateTimePickerEnd
            // 
            this.DateTimePickerEnd.BorderRadius = 10;
            this.DateTimePickerEnd.BorderThickness = 3;
            this.DateTimePickerEnd.Checked = true;
            this.DateTimePickerEnd.FillColor = System.Drawing.Color.Transparent;
            this.DateTimePickerEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerEnd.Location = new System.Drawing.Point(155, 118);
            this.DateTimePickerEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerEnd.Name = "DateTimePickerEnd";
            this.DateTimePickerEnd.Size = new System.Drawing.Size(188, 30);
            this.DateTimePickerEnd.TabIndex = 29;
            this.DateTimePickerEnd.Value = new System.DateTime(2024, 4, 4, 14, 30, 49, 322);
            // 
            // DateTimePickerStart
            // 
            this.DateTimePickerStart.BorderRadius = 10;
            this.DateTimePickerStart.BorderThickness = 3;
            this.DateTimePickerStart.Checked = true;
            this.DateTimePickerStart.FillColor = System.Drawing.Color.Transparent;
            this.DateTimePickerStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimePickerStart.Location = new System.Drawing.Point(155, 84);
            this.DateTimePickerStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateTimePickerStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerStart.Name = "DateTimePickerStart";
            this.DateTimePickerStart.Size = new System.Drawing.Size(188, 30);
            this.DateTimePickerStart.TabIndex = 28;
            this.DateTimePickerStart.Value = new System.DateTime(2024, 4, 4, 0, 0, 0, 0);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.Location = new System.Drawing.Point(120, 152);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(30, 30);
            this.pictureBox.TabIndex = 27;
            this.pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 175);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 26;
            // 
            // pictureBoxEnd
            // 
            this.pictureBoxEnd.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEnd.Image")));
            this.pictureBoxEnd.Location = new System.Drawing.Point(120, 118);
            this.pictureBoxEnd.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEnd.Name = "pictureBoxEnd";
            this.pictureBoxEnd.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxEnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEnd.TabIndex = 25;
            this.pictureBoxEnd.TabStop = false;
            this.pictureBoxEnd.Click += new System.EventHandler(this.pictureBoxEnd_Click);
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStart.Image")));
            this.pictureBoxStart.Location = new System.Drawing.Point(120, 84);
            this.pictureBoxStart.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxStart.TabIndex = 24;
            this.pictureBoxStart.TabStop = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.buttonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.BackgroundImage")));
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdate.Location = new System.Drawing.Point(418, 197);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(40, 40);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.BorderRadius = 10;
            this.buttonBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBack.FillColor = System.Drawing.Color.Transparent;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(701, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 40);
            this.buttonBack.TabIndex = 22;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBackClick);
            // 
            // FUpdatePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(750, 370);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.buttonBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FUpdatePrice";
            this.Text = "FDisCount";
            this.Load += new System.EventHandler(this.FDiscountLoad);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
        private System.Windows.Forms.Button buttonUpdate;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private Guna.UI2.WinForms.Guna2NumericUpDown NumericUpDown;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateTimePickerStart;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxEnd;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.Label label;
    }
}