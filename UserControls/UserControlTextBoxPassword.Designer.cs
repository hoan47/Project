
namespace Project.UserControls
{
    partial class UserControlTextBoxPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTextBoxPassword));
            this.panelRoadPassword = new System.Windows.Forms.Panel();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panelRoadPassword
            // 
            this.panelRoadPassword.BackColor = System.Drawing.Color.Aqua;
            this.panelRoadPassword.Location = new System.Drawing.Point(21, 39);
            this.panelRoadPassword.Name = "panelRoadPassword";
            this.panelRoadPassword.Size = new System.Drawing.Size(274, 3);
            this.panelRoadPassword.TabIndex = 7;
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPassword.Image")));
            this.pictureBoxPassword.Location = new System.Drawing.Point(20, 8);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPassword.TabIndex = 6;
            this.pictureBoxPassword.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(61, 9);
            this.textBox.MaxLength = 16;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(234, 27);
            this.textBox.TabIndex = 0;
            this.textBox.UseSystemPasswordChar = true;
            this.textBox.Enter += new System.EventHandler(this.TextBoxEnter);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAccountKeyPress);
            this.textBox.Leave += new System.EventHandler(this.TextBoxLeave);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label.Location = new System.Drawing.Point(61, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(234, 27);
            this.label.TabIndex = 0;
            this.label.Text = "Tài khoản";
            this.label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label.Click += new System.EventHandler(this.LabelClick);
            // 
            // UserControlTextBoxPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.panelRoadPassword);
            this.Controls.Add(this.pictureBoxPassword);
            this.Name = "UserControlTextBoxPassword";
            this.Size = new System.Drawing.Size(314, 50);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelRoadPassword;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label;
    }
}
