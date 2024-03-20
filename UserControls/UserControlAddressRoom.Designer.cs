
namespace Project
{
    partial class UserControlAddressRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlAddressRoom));
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.Transparent;
            this.groupBox.Controls.Add(this.comboBox);
            this.groupBox.Controls.Add(this.pictureBox);
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(256, 55);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Địa chỉ";
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.Color.Transparent;
            this.comboBox.BorderColor = System.Drawing.Color.Black;
            this.comboBox.BorderRadius = 10;
            this.comboBox.BorderThickness = 3;
            this.comboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBox.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox.ItemHeight = 24;
            this.comboBox.Location = new System.Drawing.Point(42, 19);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(200, 30);
            this.comboBox.TabIndex = 1;
            this.comboBox.SelectedValueChanged += new System.EventHandler(this.ComboBoxSelectedValueChanged);
            this.comboBox.Enter += new System.EventHandler(this.ComboBoxEnter);
            this.comboBox.Leave += new System.EventHandler(this.ComboBoxLeave);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(6, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(30, 30);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // UserControlHomePaceSearchAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox);
            this.Name = "UserControlHomePaceSearchAddress";
            this.Size = new System.Drawing.Size(256, 55);
            this.groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox;
    }
}
