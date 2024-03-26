namespace Project
{
    partial class UserControlRoom
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
            this.groupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dateTimePickerOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dateTimePickerIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelOut = new System.Windows.Forms.Label();
            this.labelIn = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.BorderColor = System.Drawing.Color.Black;
            this.groupBox.BorderRadius = 15;
            this.groupBox.Controls.Add(this.dateTimePickerOut);
            this.groupBox.Controls.Add(this.dateTimePickerIn);
            this.groupBox.Controls.Add(this.labelOut);
            this.groupBox.Controls.Add(this.labelIn);
            this.groupBox.Controls.Add(this.labelStatus);
            this.groupBox.Controls.Add(this.panel2);
            this.groupBox.CustomBorderColor = System.Drawing.Color.LightSeaGreen;
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(10, 10);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(340, 180);
            this.groupBox.TabIndex = 0;
            this.groupBox.Text = "Phòng P01";
            this.groupBox.Click += new System.EventHandler(this.UserControlClick);
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.BorderRadius = 10;
            this.dateTimePickerOut.Checked = true;
            this.dateTimePickerOut.FillColor = System.Drawing.Color.DarkSalmon;
            this.dateTimePickerOut.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.dateTimePickerOut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerOut.Location = new System.Drawing.Point(98, 106);
            this.dateTimePickerOut.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(220, 25);
            this.dateTimePickerOut.TabIndex = 8;
            this.dateTimePickerOut.Value = new System.DateTime(2024, 3, 17, 12, 53, 6, 551);
            this.dateTimePickerOut.Click += new System.EventHandler(this.UserControlClick);
            this.dateTimePickerOut.DoubleClick += new System.EventHandler(this.UserControlClick);
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.BorderRadius = 10;
            this.dateTimePickerIn.Checked = true;
            this.dateTimePickerIn.FillColor = System.Drawing.Color.LightSalmon;
            this.dateTimePickerIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerIn.Location = new System.Drawing.Point(98, 70);
            this.dateTimePickerIn.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(220, 25);
            this.dateTimePickerIn.TabIndex = 7;
            this.dateTimePickerIn.Value = new System.DateTime(2024, 3, 17, 12, 53, 6, 546);
            this.dateTimePickerIn.Click += new System.EventHandler(this.UserControlClick);
            this.dateTimePickerIn.DoubleClick += new System.EventHandler(this.UserControlClick);
            // 
            // labelOut
            // 
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(15, 112);
            this.labelOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(81, 19);
            this.labelOut.TabIndex = 5;
            this.labelOut.Text = "Check Out :";
            this.labelOut.Click += new System.EventHandler(this.UserControlClick);
            this.labelOut.DoubleClick += new System.EventHandler(this.UserControlClick);
            // 
            // labelIn
            // 
            this.labelIn.AutoSize = true;
            this.labelIn.Location = new System.Drawing.Point(16, 76);
            this.labelIn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(69, 19);
            this.labelIn.TabIndex = 4;
            this.labelIn.Text = "Check In :";
            this.labelIn.Click += new System.EventHandler(this.UserControlClick);
            this.labelIn.DoubleClick += new System.EventHandler(this.UserControlClick);
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(168, 152);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(166, 19);
            this.labelStatus.TabIndex = 1;
            this.labelStatus.Text = "Tình Trạng :";
            this.labelStatus.Click += new System.EventHandler(this.UserControlClick);
            this.labelStatus.DoubleClick += new System.EventHandler(this.UserControlClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(3, 143);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 1);
            this.panel2.TabIndex = 0;
            this.panel2.DoubleClick += new System.EventHandler(this.UserControlClick);
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(360, 200);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerOut;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Label labelIn;
    }
}
