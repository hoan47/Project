
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
            this.groupBoxHistory = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.numericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.pictureBoxPrice = new System.Windows.Forms.PictureBox();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.label = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.groupBoxHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox.BorderRadius = 10;
            this.groupBox.BorderThickness = 5;
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.numericUpDown);
            this.groupBox.Controls.Add(this.label);
            this.groupBox.Controls.Add(this.groupBoxHistory);
            this.groupBox.Controls.Add(this.buttonUpdate);
            this.groupBox.Controls.Add(this.pictureBoxPrice);
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
            // groupBoxHistory
            // 
            this.groupBoxHistory.Controls.Add(this.listBox);
            this.groupBoxHistory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxHistory.Location = new System.Drawing.Point(16, 53);
            this.groupBoxHistory.Name = "groupBoxHistory";
            this.groupBoxHistory.Size = new System.Drawing.Size(442, 140);
            this.groupBoxHistory.TabIndex = 25;
            this.groupBoxHistory.TabStop = false;
            this.groupBoxHistory.Text = "Lịch sử những lần cập nhật giá trước đó";
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.Info;
            this.listBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 17;
            this.listBox.Items.AddRange(new object[] {
            "Không có."});
            this.listBox.Location = new System.Drawing.Point(7, 27);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(429, 106);
            this.listBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label2.Location = new System.Drawing.Point(327, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "%";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // numericUpDown
            // 
            this.numericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDown.BorderColor = System.Drawing.Color.Black;
            this.numericUpDown.BorderRadius = 10;
            this.numericUpDown.BorderThickness = 2;
            this.numericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDown.FillColor = System.Drawing.Color.LightGoldenrodYellow;
            this.numericUpDown.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown.Location = new System.Drawing.Point(297, 206);
            this.numericUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(80, 30);
            this.numericUpDown.TabIndex = 11;
            this.numericUpDown.UpDownButtonFillColor = System.Drawing.Color.Lime;
            this.numericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // pictureBoxPrice
            // 
            this.pictureBoxPrice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrice.BackgroundImage")));
            this.pictureBoxPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxPrice.Location = new System.Drawing.Point(73, 197);
            this.pictureBoxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPrice.Name = "pictureBoxPrice";
            this.pictureBoxPrice.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxPrice.TabIndex = 10;
            this.pictureBoxPrice.TabStop = false;
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
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(118, 213);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(185, 17);
            this.label.TabIndex = 26;
            this.label.Text = "Giá phòng hiện tại nhân với ";
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
            this.groupBoxHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxPrice;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdate;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDown;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
        private System.Windows.Forms.GroupBox groupBoxHistory;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label;
    }
}