
namespace Project
{
    partial class UserControlAddressEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAddressEdit));
            this.panelRoad = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.userControlComboBoxAddress = new Project.UserControlComboBoxAddress();
            this.SuspendLayout();
            // 
            // panelRoad
            // 
            this.panelRoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelRoad.Location = new System.Drawing.Point(19, 38);
            this.panelRoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelRoad.Name = "panelRoad";
            this.panelRoad.Size = new System.Drawing.Size(533, 2);
            this.panelRoad.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(16, 17);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(68, 20);
            this.label.TabIndex = 8;
            this.label.Text = "Địa chỉ";
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEdit.BackgroundImage")));
            this.buttonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Location = new System.Drawing.Point(519, 6);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(33, 31);
            this.buttonEdit.TabIndex = 0;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.Edit);
            // 
            // userControlComboBoxAddress
            // 
            this.userControlComboBoxAddress.BackColor = System.Drawing.Color.White;
            this.userControlComboBoxAddress.ComboBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.userControlComboBoxAddress.ComboBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlComboBoxAddress.ComboBoxText = "";
            this.userControlComboBoxAddress.Enabled = false;
            this.userControlComboBoxAddress.Location = new System.Drawing.Point(210, 9);
            this.userControlComboBoxAddress.Name = "userControlComboBoxAddress";
            this.userControlComboBoxAddress.Size = new System.Drawing.Size(222, 28);
            this.userControlComboBoxAddress.SizeUserControl = new System.Drawing.Size(222, 28);
            this.userControlComboBoxAddress.TabIndex = 1;
            // 
            // UserControlAddressEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRoad);
            this.Controls.Add(this.userControlComboBoxAddress);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label);
            this.Name = "UserControlAddressEdit";
            this.Size = new System.Drawing.Size(568, 46);
            this.Leave += new System.EventHandler(this.UserControlComboBoxEditLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Panel panelRoad;
        private System.Windows.Forms.Label label;
        private UserControlComboBoxAddress userControlComboBoxAddress;
    }
}
