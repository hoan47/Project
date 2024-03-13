
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
            this.labelSearch = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.pictureBoxYesNo = new System.Windows.Forms.PictureBox();
            this.checkBoxYesRent = new System.Windows.Forms.CheckBox();
            this.checkBoxNoRent = new System.Windows.Forms.CheckBox();
            this.labelMinMax = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.pictureBoxPrice = new System.Windows.Forms.PictureBox();
            this.labelPeople = new System.Windows.Forms.Label();
            this.numericUpDownPeople = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxPeople = new System.Windows.Forms.PictureBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.pictureBoxCity = new System.Windows.Forms.PictureBox();
            this.textBoxPriceMax = new System.Windows.Forms.TextBox();
            this.textBoxPriceMin = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelHomePageSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.userControlSearch1 = new Project.UserControls.UserControlSearch();
            this.userControlComboBoxAddress = new Project.UserControlComboBoxAddress();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYesNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCity)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.userControlSearch1);
            this.panelSearch.Controls.Add(this.labelSearch);
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.userControlComboBoxAddress);
            this.panelSearch.Controls.Add(this.pictureBoxYesNo);
            this.panelSearch.Controls.Add(this.checkBoxYesRent);
            this.panelSearch.Controls.Add(this.checkBoxNoRent);
            this.panelSearch.Controls.Add(this.labelMinMax);
            this.panelSearch.Controls.Add(this.labelPrice);
            this.panelSearch.Controls.Add(this.pictureBoxPrice);
            this.panelSearch.Controls.Add(this.labelPeople);
            this.panelSearch.Controls.Add(this.numericUpDownPeople);
            this.panelSearch.Controls.Add(this.pictureBoxPeople);
            this.panelSearch.Controls.Add(this.labelAddress);
            this.panelSearch.Controls.Add(this.pictureBoxCity);
            this.panelSearch.Controls.Add(this.textBoxPriceMax);
            this.panelSearch.Controls.Add(this.textBoxPriceMin);
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(230, 512);
            this.panelSearch.TabIndex = 3;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(119, 269);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(91, 25);
            this.labelSearch.TabIndex = 19;
            this.labelSearch.Text = "Tìm kiếm";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(13, 225);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 100);
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // pictureBoxYesNo
            // 
            this.pictureBoxYesNo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxYesNo.Image")));
            this.pictureBoxYesNo.Location = new System.Drawing.Point(13, 178);
            this.pictureBoxYesNo.Name = "pictureBoxYesNo";
            this.pictureBoxYesNo.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxYesNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxYesNo.TabIndex = 16;
            this.pictureBoxYesNo.TabStop = false;
            // 
            // checkBoxYesRent
            // 
            this.checkBoxYesRent.AutoSize = true;
            this.checkBoxYesRent.Location = new System.Drawing.Point(61, 201);
            this.checkBoxYesRent.Name = "checkBoxYesRent";
            this.checkBoxYesRent.Size = new System.Drawing.Size(64, 17);
            this.checkBoxYesRent.TabIndex = 15;
            this.checkBoxYesRent.Text = "Đã thuê";
            this.checkBoxYesRent.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoRent
            // 
            this.checkBoxNoRent.AutoSize = true;
            this.checkBoxNoRent.Location = new System.Drawing.Point(61, 178);
            this.checkBoxNoRent.Name = "checkBoxNoRent";
            this.checkBoxNoRent.Size = new System.Drawing.Size(75, 17);
            this.checkBoxNoRent.TabIndex = 14;
            this.checkBoxNoRent.Text = "Chưa thuê";
            this.checkBoxNoRent.UseVisualStyleBackColor = true;
            this.checkBoxNoRent.CheckedChanged += new System.EventHandler(this.checkBoxNoRent_CheckedChanged);
            // 
            // labelMinMax
            // 
            this.labelMinMax.AutoSize = true;
            this.labelMinMax.ForeColor = System.Drawing.Color.Black;
            this.labelMinMax.Location = new System.Drawing.Point(58, 129);
            this.labelMinMax.Name = "labelMinMax";
            this.labelMinMax.Size = new System.Drawing.Size(125, 13);
            this.labelMinMax.TabIndex = 13;
            this.labelMinMax.Text = "Min ------------------------- Max";
            this.labelMinMax.Click += new System.EventHandler(this.labelMinMax_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.ForeColor = System.Drawing.Color.Black;
            this.labelPrice.Location = new System.Drawing.Point(58, 110);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(47, 13);
            this.labelPrice.TabIndex = 12;
            this.labelPrice.Text = "Giá thuê";
            // 
            // pictureBoxPrice
            // 
            this.pictureBoxPrice.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrice.Image")));
            this.pictureBoxPrice.Location = new System.Drawing.Point(13, 106);
            this.pictureBoxPrice.Name = "pictureBoxPrice";
            this.pictureBoxPrice.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPrice.TabIndex = 11;
            this.pictureBoxPrice.TabStop = false;
            // 
            // labelPeople
            // 
            this.labelPeople.AutoSize = true;
            this.labelPeople.ForeColor = System.Drawing.Color.Black;
            this.labelPeople.Location = new System.Drawing.Point(58, 59);
            this.labelPeople.Name = "labelPeople";
            this.labelPeople.Size = new System.Drawing.Size(49, 13);
            this.labelPeople.TabIndex = 10;
            this.labelPeople.Text = "Số người";
            // 
            // numericUpDownPeople
            // 
            this.numericUpDownPeople.Location = new System.Drawing.Point(58, 79);
            this.numericUpDownPeople.Name = "numericUpDownPeople";
            this.numericUpDownPeople.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownPeople.TabIndex = 9;
            // 
            // pictureBoxPeople
            // 
            this.pictureBoxPeople.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPeople.Image")));
            this.pictureBoxPeople.Location = new System.Drawing.Point(12, 59);
            this.pictureBoxPeople.Name = "pictureBoxPeople";
            this.pictureBoxPeople.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxPeople.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPeople.TabIndex = 7;
            this.pictureBoxPeople.TabStop = false;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.ForeColor = System.Drawing.Color.Black;
            this.labelAddress.Location = new System.Drawing.Point(58, 12);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(40, 13);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "Địa chỉ";
            this.labelAddress.Click += new System.EventHandler(this.labelAddress_Click);
            // 
            // pictureBoxCity
            // 
            this.pictureBoxCity.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCity.Image")));
            this.pictureBoxCity.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCity.Name = "pictureBoxCity";
            this.pictureBoxCity.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCity.TabIndex = 5;
            this.pictureBoxCity.TabStop = false;
            // 
            // textBoxPriceMax
            // 
            this.textBoxPriceMax.Location = new System.Drawing.Point(118, 152);
            this.textBoxPriceMax.Name = "textBoxPriceMax";
            this.textBoxPriceMax.Size = new System.Drawing.Size(100, 20);
            this.textBoxPriceMax.TabIndex = 4;
            // 
            // textBoxPriceMin
            // 
            this.textBoxPriceMin.Location = new System.Drawing.Point(12, 152);
            this.textBoxPriceMin.Name = "textBoxPriceMin";
            this.textBoxPriceMin.Size = new System.Drawing.Size(100, 20);
            this.textBoxPriceMin.TabIndex = 3;
            // 
            // flowLayoutPanelHomePageSearch
            // 
            this.flowLayoutPanelHomePageSearch.AutoScroll = true;
            this.flowLayoutPanelHomePageSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.flowLayoutPanelHomePageSearch.Location = new System.Drawing.Point(230, 0);
            this.flowLayoutPanelHomePageSearch.Name = "flowLayoutPanelHomePageSearch";
            this.flowLayoutPanelHomePageSearch.Size = new System.Drawing.Size(550, 512);
            this.flowLayoutPanelHomePageSearch.TabIndex = 4;
            // 
            // userControlSearch1
            // 
            this.userControlSearch1.BackColor = System.Drawing.Color.Transparent;
            this.userControlSearch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControlSearch1.BackgroundImage")));
            this.userControlSearch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userControlSearch1.Location = new System.Drawing.Point(8, 471);
            this.userControlSearch1.Margin = new System.Windows.Forms.Padding(2);
            this.userControlSearch1.Name = "userControlSearch1";
            this.userControlSearch1.Size = new System.Drawing.Size(210, 30);
            this.userControlSearch1.TabIndex = 20;
            this.userControlSearch1.TextVisible = null;
            // 
            // userControlComboBoxAddress
            // 
            this.userControlComboBoxAddress.Location = new System.Drawing.Point(58, 32);
            this.userControlComboBoxAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userControlComboBoxAddress.Name = "userControlComboBoxAddress";
            this.userControlComboBoxAddress.Size = new System.Drawing.Size(159, 20);
            this.userControlComboBoxAddress.TabIndex = 17;
            // 
            // FHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(780, 512);
            this.Controls.Add(this.flowLayoutPanelHomePageSearch);
            this.Controls.Add(this.panelSearch);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FHomePage";
            this.Text = "FHomePage";
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxYesNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox textBoxPriceMax;
        private System.Windows.Forms.TextBox textBoxPriceMin;
        private System.Windows.Forms.PictureBox pictureBoxCity;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.NumericUpDown numericUpDownPeople;
        private System.Windows.Forms.PictureBox pictureBoxPeople;
        private System.Windows.Forms.CheckBox checkBoxYesRent;
        private System.Windows.Forms.CheckBox checkBoxNoRent;
        private System.Windows.Forms.Label labelMinMax;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.PictureBox pictureBoxPrice;
        private System.Windows.Forms.Label labelPeople;
        private System.Windows.Forms.PictureBox pictureBoxYesNo;
        private UserControlComboBoxAddress userControlComboBoxAddress;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearch;
        private UserControls.UserControlSearch userControlSearch1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHomePageSearch;
    }
}