
namespace Project.UserControls
{
    partial class UserControlNote
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
            this.panel = new Guna.UI2.WinForms.Guna2Panel();
            this.circlePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BorderRadius = 10;
            this.panel.Controls.Add(this.circlePictureBox);
            this.panel.Controls.Add(this.label);
            this.panel.CustomBorderColor = System.Drawing.Color.Transparent;
            this.panel.FillColor = System.Drawing.Color.White;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(260, 30);
            this.panel.TabIndex = 6;
            // 
            // circlePictureBox
            // 
            this.circlePictureBox.FillColor = System.Drawing.Color.Yellow;
            this.circlePictureBox.ImageRotate = 0F;
            this.circlePictureBox.Location = new System.Drawing.Point(7, 2);
            this.circlePictureBox.Name = "circlePictureBox";
            this.circlePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circlePictureBox.Size = new System.Drawing.Size(25, 25);
            this.circlePictureBox.TabIndex = 3;
            this.circlePictureBox.TabStop = false;
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(38, 2);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(219, 25);
            this.label.TabIndex = 2;
            this.label.Text = "Thông báo từ khách hàng";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControlNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "UserControlNote";
            this.Size = new System.Drawing.Size(260, 30);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox circlePictureBox;
        private System.Windows.Forms.Label label;
    }
}
