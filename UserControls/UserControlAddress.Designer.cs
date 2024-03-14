
namespace Project.UserControls
{
    partial class UserControlAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAddress));
            this.userControlComboBoxAddress1 = new Project.UserControlComboBoxAddress();
            this.SuspendLayout();
            // 
            // userControlComboBoxAddress1
            // 
            this.userControlComboBoxAddress1.ComboBoxColor = System.Drawing.Color.White;
            this.userControlComboBoxAddress1.ComboBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlComboBoxAddress1.ComboBoxText = "";
            this.userControlComboBoxAddress1.Location = new System.Drawing.Point(8, 7);
            this.userControlComboBoxAddress1.Name = "userControlComboBoxAddress1";
            this.userControlComboBoxAddress1.Size = new System.Drawing.Size(279, 29);
            this.userControlComboBoxAddress1.SizeUserControl = new System.Drawing.Size(279, 29);
            this.userControlComboBoxAddress1.TabIndex = 0;
            this.userControlComboBoxAddress1.Load += new System.EventHandler(this.userControlComboBoxAddress1_Load);
            // 
            // UserControlAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.userControlComboBoxAddress1);
            this.DoubleBuffered = true;
            this.Name = "UserControlAddress";
            this.Size = new System.Drawing.Size(295, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlComboBoxAddress userControlComboBoxAddress1;
    }
}
