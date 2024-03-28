
namespace Project
{
    partial class UserControlNotificationSystem
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
            this.circleButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.labelSendingTime = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BorderColor = System.Drawing.Color.Pink;
            this.groupBox.BorderRadius = 10;
            this.groupBox.BorderThickness = 3;
            this.groupBox.Controls.Add(this.circleButton);
            this.groupBox.Controls.Add(this.labelSendingTime);
            this.groupBox.Controls.Add(this.labelContent);
            this.groupBox.CustomBorderColor = System.Drawing.Color.Pink;
            this.groupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(700, 60);
            this.groupBox.TabIndex = 5;
            this.groupBox.Text = "Tên khách hàng";
            this.groupBox.TextOffset = new System.Drawing.Point(0, -3);
            // 
            // circleButton
            // 
            this.circleButton.BackColor = System.Drawing.Color.Transparent;
            this.circleButton.BorderColor = System.Drawing.Color.Transparent;
            this.circleButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.circleButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.circleButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.circleButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.circleButton.FillColor = System.Drawing.Color.Red;
            this.circleButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.circleButton.ForeColor = System.Drawing.Color.White;
            this.circleButton.Location = new System.Drawing.Point(670, 3);
            this.circleButton.Name = "circleButton";
            this.circleButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleButton.Size = new System.Drawing.Size(25, 25);
            this.circleButton.TabIndex = 32;
            this.circleButton.Click += new System.EventHandler(this.CircleButtonClick);
            // 
            // labelSendingTime
            // 
            this.labelSendingTime.BackColor = System.Drawing.Color.Transparent;
            this.labelSendingTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSendingTime.Location = new System.Drawing.Point(224, 3);
            this.labelSendingTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSendingTime.Name = "labelSendingTime";
            this.labelSendingTime.Size = new System.Drawing.Size(300, 22);
            this.labelSendingTime.TabIndex = 31;
            this.labelSendingTime.Text = "Vào lúc: 26/04/2004 16:00";
            this.labelSendingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelContent
            // 
            this.labelContent.AutoEllipsis = true;
            this.labelContent.BackColor = System.Drawing.Color.Transparent;
            this.labelContent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContent.Location = new System.Drawing.Point(3, 30);
            this.labelContent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(692, 24);
            this.labelContent.TabIndex = 29;
            this.labelContent.Text = "Bạn nhận được 100 xu.";
            // 
            // UserControlNotificationSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "UserControlNotificationSystem";
            this.Size = new System.Drawing.Size(700, 60);
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
        private Guna.UI2.WinForms.Guna2CircleButton circleButton;
        private System.Windows.Forms.Label labelSendingTime;
        private System.Windows.Forms.Label labelContent;
    }
}
