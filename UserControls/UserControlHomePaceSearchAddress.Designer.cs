
namespace Project
{
    partial class UserControlHomePaceSearchAddress
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlHomePaceSearchAddress));
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.pictureBoxAddress = new System.Windows.Forms.PictureBox();
            this.userControlComboBoxAddress = new Project.UserControlComboBoxAddress();
            this.pictureBoxFrame = new System.Windows.Forms.PictureBox();
            this.groupBoxAddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAddress.Controls.Add(this.userControlComboBoxAddress);
            this.groupBoxAddress.Controls.Add(this.pictureBoxAddress);
            this.groupBoxAddress.Controls.Add(this.pictureBoxFrame);
            this.groupBoxAddress.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new System.Drawing.Size(256, 55);
            this.groupBoxAddress.TabIndex = 0;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Địa chỉ";
            this.groupBoxAddress.Enter += new System.EventHandler(this.groupBoxAddress_Enter);
            // 
            // pictureBoxAddress
            // 
            this.pictureBoxAddress.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAddress.Image")));
            this.pictureBoxAddress.Location = new System.Drawing.Point(6, 19);
            this.pictureBoxAddress.Name = "pictureBoxAddress";
            this.pictureBoxAddress.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAddress.TabIndex = 0;
            this.pictureBoxAddress.TabStop = false;
            // 
            // userControlComboBoxAddress
            // 
            this.userControlComboBoxAddress.BackColor = System.Drawing.Color.Transparent;
            this.userControlComboBoxAddress.ComboBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlComboBoxAddress.ComboBoxText = "";
            this.userControlComboBoxAddress.Location = new System.Drawing.Point(49, 24);
            this.userControlComboBoxAddress.Margin = new System.Windows.Forms.Padding(2);
            this.userControlComboBoxAddress.Name = "userControlComboBoxAddress";
            this.userControlComboBoxAddress.Size = new System.Drawing.Size(190, 21);
            this.userControlComboBoxAddress.SizeUserControl = new System.Drawing.Size(190, 21);
            this.userControlComboBoxAddress.TabIndex = 1;
            // 
            // pictureBoxFrame
            // 
            this.pictureBoxFrame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxFrame.BackgroundImage")));
            this.pictureBoxFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFrame.Location = new System.Drawing.Point(42, 19);
            this.pictureBoxFrame.Name = "pictureBoxFrame";
            this.pictureBoxFrame.Size = new System.Drawing.Size(208, 30);
            this.pictureBoxFrame.TabIndex = 2;
            this.pictureBoxFrame.TabStop = false;
            // 
            // UserControlHomePaceSearchAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxAddress);
            this.Name = "UserControlHomePaceSearchAddress";
            this.Size = new System.Drawing.Size(256, 55);
            this.groupBoxAddress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddress;
        private System.Windows.Forms.PictureBox pictureBoxAddress;
        private UserControlComboBoxAddress userControlComboBoxAddress;
        private System.Windows.Forms.PictureBox pictureBoxFrame;
    }
}
