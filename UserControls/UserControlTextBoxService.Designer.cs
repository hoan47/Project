
namespace Project
{
    partial class UserControlTextBoxService
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
            this.groupBoxInforService = new System.Windows.Forms.GroupBox();
            this.textBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBoxInforService = new System.Windows.Forms.PictureBox();
            this.groupBoxInforService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInforService)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInforService
            // 
            this.groupBoxInforService.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxInforService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBoxInforService.Controls.Add(this.textBox);
            this.groupBoxInforService.Controls.Add(this.pictureBoxInforService);
            this.groupBoxInforService.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxInforService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInforService.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInforService.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInforService.Name = "groupBoxInforService";
            this.groupBoxInforService.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInforService.Size = new System.Drawing.Size(300, 64);
            this.groupBoxInforService.TabIndex = 0;
            this.groupBoxInforService.TabStop = false;
            this.groupBoxInforService.Text = "groupBox1";
            this.groupBoxInforService.Enter += new System.EventHandler(this.groupBoxInforService_Enter);
            // 
            // textBox
            // 
            this.textBox.BorderColor = System.Drawing.Color.Black;
            this.textBox.BorderRadius = 10;
            this.textBox.BorderThickness = 2;
            this.textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox.DefaultText = "";
            this.textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.Black;
            this.textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox.Location = new System.Drawing.Point(64, 29);
            this.textBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox.Name = "textBox";
            this.textBox.PasswordChar = '\0';
            this.textBox.PlaceholderText = "";
            this.textBox.SelectedText = "";
            this.textBox.Size = new System.Drawing.Size(218, 30);
            this.textBox.TabIndex = 0;
            // 
            // pictureBoxInforService
            // 
            this.pictureBoxInforService.Location = new System.Drawing.Point(5, 20);
            this.pictureBoxInforService.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxInforService.Name = "pictureBoxInforService";
            this.pictureBoxInforService.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxInforService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInforService.TabIndex = 0;
            this.pictureBoxInforService.TabStop = false;
            this.pictureBoxInforService.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // UserControlTextBoxHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBoxInforService);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserControlTextBoxHotel";
            this.Size = new System.Drawing.Size(300, 64);
            this.groupBoxInforService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInforService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInforService;
        private System.Windows.Forms.PictureBox pictureBoxInforService;
        private Guna.UI2.WinForms.Guna2TextBox textBox;
    }
}
