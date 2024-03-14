namespace Project.FMains
{
    partial class FRegisterRoom
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
            this.userControlInforRoom1 = new Project.UserControls.UserControlInforRoom();
            this.SuspendLayout();
            // 
            // userControlInforRoom1
            // 
            this.userControlInforRoom1.BackColor = System.Drawing.Color.Khaki;
            this.userControlInforRoom1.Location = new System.Drawing.Point(0, 0);
            this.userControlInforRoom1.Name = "userControlInforRoom1";
            this.userControlInforRoom1.Size = new System.Drawing.Size(1040, 630);
            this.userControlInforRoom1.TabIndex = 0;
            this.userControlInforRoom1.Load += new System.EventHandler(this.userControlInforRoom1_Load);
            // 
            // FRegisterRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 630);
            this.Controls.Add(this.userControlInforRoom1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRegisterRoom";
            this.Text = "FRegisterRoom";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.UserControlInforRoom userControlInforRoom1;
    }
}