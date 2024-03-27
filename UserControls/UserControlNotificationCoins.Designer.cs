
namespace Project
{
    partial class UserControlNotificationCoins
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
            this.labelStatus = new System.Windows.Forms.Label();
            this.circlePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.groupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.AutoEllipsis = true;
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Location = new System.Drawing.Point(3, 30);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(692, 48);
            this.labelStatus.TabIndex = 29;
            this.labelStatus.Text = "Bạn nhận được 100 xu.\r\nTừ việc cập nhật thông tin.";
            // 
            // circlePictureBox
            // 
            this.circlePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.circlePictureBox.FillColor = System.Drawing.Color.Red;
            this.circlePictureBox.ImageRotate = 0F;
            this.circlePictureBox.Location = new System.Drawing.Point(675, 5);
            this.circlePictureBox.Name = "circlePictureBox";
            this.circlePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circlePictureBox.Size = new System.Drawing.Size(20, 20);
            this.circlePictureBox.TabIndex = 30;
            this.circlePictureBox.TabStop = false;
            // 
            // groupBox
            // 
            this.groupBox.BorderColor = System.Drawing.Color.Lime;
            this.groupBox.BorderRadius = 10;
            this.groupBox.BorderThickness = 3;
            this.groupBox.Controls.Add(this.circlePictureBox);
            this.groupBox.Controls.Add(this.labelStatus);
            this.groupBox.CustomBorderColor = System.Drawing.Color.Lime;
            this.groupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(700, 78);
            this.groupBox.TabIndex = 4;
            this.groupBox.Text = "Tên khách hàng";
            this.groupBox.TextOffset = new System.Drawing.Point(0, -3);
            // 
            // UserControlNotificationCoins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "UserControlNotificationCoins";
            this.Size = new System.Drawing.Size(700, 78);
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private Guna.UI2.WinForms.Guna2CirclePictureBox circlePictureBox;
        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
    }
}
