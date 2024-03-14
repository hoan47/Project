namespace Project.UserControls
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
            this.textBoxInforService = new System.Windows.Forms.TextBox();
            this.pictureBoxInforService = new System.Windows.Forms.PictureBox();
            this.groupBoxInforService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInforService)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxInforService
            // 
            this.groupBoxInforService.Controls.Add(this.textBoxInforService);
            this.groupBoxInforService.Controls.Add(this.pictureBoxInforService);
            this.groupBoxInforService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInforService.Location = new System.Drawing.Point(1, 4);
            this.groupBoxInforService.Name = "groupBoxInforService";
            this.groupBoxInforService.Size = new System.Drawing.Size(430, 128);
            this.groupBoxInforService.TabIndex = 0;
            this.groupBoxInforService.TabStop = false;
            this.groupBoxInforService.Text = "groupBox1";
            // 
            // textBoxInforService
            // 
            this.textBoxInforService.Location = new System.Drawing.Point(58, 77);
            this.textBoxInforService.Name = "textBoxInforService";
            this.textBoxInforService.Size = new System.Drawing.Size(372, 24);
            this.textBoxInforService.TabIndex = 1;
            this.textBoxInforService.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // pictureBoxInforService
            // 
            this.pictureBoxInforService.Location = new System.Drawing.Point(6, 52);
            this.pictureBoxInforService.Name = "pictureBoxInforService";
            this.pictureBoxInforService.Size = new System.Drawing.Size(49, 49);
            this.pictureBoxInforService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInforService.TabIndex = 0;
            this.pictureBoxInforService.TabStop = false;
            this.pictureBoxInforService.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // UserControlService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Controls.Add(this.groupBoxInforService);
            this.Name = "UserControlService";
            this.Size = new System.Drawing.Size(434, 135);
            this.groupBoxInforService.ResumeLayout(false);
            this.groupBoxInforService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInforService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInforService;
        private System.Windows.Forms.TextBox textBoxInforService;
        private System.Windows.Forms.PictureBox pictureBoxInforService;
    }
}
