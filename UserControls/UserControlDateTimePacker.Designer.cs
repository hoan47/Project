﻿
namespace Project
{
    partial class UserControlDateTimePacker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDateTimePacker));
            this.pictureBoxIn = new System.Windows.Forms.PictureBox();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).BeginInit();
            this.groupBoxTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxIn
            // 
            this.pictureBoxIn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIn.Image")));
            this.pictureBoxIn.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxIn.Name = "pictureBoxIn";
            this.pictureBoxIn.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIn.TabIndex = 0;
            this.pictureBoxIn.TabStop = false;
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTime.Controls.Add(this.dateTimePickerTime);
            this.groupBoxTime.Controls.Add(this.pictureBoxIn);
            this.groupBoxTime.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(277, 55);
            this.groupBoxTime.TabIndex = 1;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Ngày nhận phòng";
            this.groupBoxTime.Enter += new System.EventHandler(this.groupBoxTime_Enter);
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.BorderRadius = 10;
            this.dateTimePickerTime.BorderThickness = 3;
            this.dateTimePickerTime.Checked = true;
            this.dateTimePickerTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dateTimePickerTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerTime.Location = new System.Drawing.Point(42, 19);
            this.dateTimePickerTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.Size = new System.Drawing.Size(229, 30);
            this.dateTimePickerTime.TabIndex = 1;
            this.dateTimePickerTime.Value = new System.DateTime(2024, 3, 20, 9, 7, 4, 745);
            // 
            // UserControlDateTimePacker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxTime);
            this.Name = "UserControlDateTimePacker";
            this.Size = new System.Drawing.Size(277, 55);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).EndInit();
            this.groupBoxTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxIn;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerTime;
    }
}
