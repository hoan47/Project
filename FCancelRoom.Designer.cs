
namespace Project
{
    partial class FCancelRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCancelRoom));
            this.groupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.buttonBack = new Guna.UI2.WinForms.Guna2Button();
            this.groupBoxMessage = new System.Windows.Forms.GroupBox();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.buttonComfirm = new Guna.UI2.WinForms.Guna2Button();
            this.label = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.groupBoxMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox.BorderRadius = 10;
            this.groupBox.BorderThickness = 3;
            this.groupBox.Controls.Add(this.buttonBack);
            this.groupBox.Controls.Add(this.groupBoxMessage);
            this.groupBox.Controls.Add(this.buttonComfirm);
            this.groupBox.Controls.Add(this.label);
            this.groupBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.groupBox.CustomBorderThickness = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.Black;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(933, 276);
            this.groupBox.TabIndex = 4;
            this.groupBox.Text = "Hủy phòng";
            this.groupBox.TextOffset = new System.Drawing.Point(0, -3);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBack.BackgroundImage")));
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.BorderRadius = 10;
            this.buttonBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonBack.FillColor = System.Drawing.Color.Transparent;
            this.buttonBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(877, 41);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(40, 37);
            this.buttonBack.TabIndex = 28;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBackClick);
            // 
            // groupBoxMessage
            // 
            this.groupBoxMessage.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMessage.Controls.Add(this.richTextBoxMessage);
            this.groupBoxMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMessage.Location = new System.Drawing.Point(68, 54);
            this.groupBoxMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMessage.Name = "groupBoxMessage";
            this.groupBoxMessage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxMessage.Size = new System.Drawing.Size(799, 139);
            this.groupBoxMessage.TabIndex = 27;
            this.groupBoxMessage.TabStop = false;
            this.groupBoxMessage.Text = "Gửi lí do hủy phòng tới khách sạn";
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.BackColor = System.Drawing.Color.White;
            this.richTextBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMessage.Location = new System.Drawing.Point(9, 30);
            this.richTextBoxMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(781, 102);
            this.richTextBoxMessage.TabIndex = 0;
            this.richTextBoxMessage.Text = "Lí do khác";
            // 
            // buttonComfirm
            // 
            this.buttonComfirm.BackColor = System.Drawing.Color.Transparent;
            this.buttonComfirm.BorderRadius = 10;
            this.buttonComfirm.BorderThickness = 2;
            this.buttonComfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonComfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonComfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonComfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonComfirm.FillColor = System.Drawing.Color.Yellow;
            this.buttonComfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComfirm.ForeColor = System.Drawing.Color.Black;
            this.buttonComfirm.Location = new System.Drawing.Point(409, 229);
            this.buttonComfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonComfirm.Name = "buttonComfirm";
            this.buttonComfirm.Size = new System.Drawing.Size(149, 39);
            this.buttonComfirm.TabIndex = 3;
            this.buttonComfirm.Text = "Xác nhận";
            this.buttonComfirm.Click += new System.EventHandler(this.ButtonComfirmClick);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(68, 197);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(799, 27);
            this.label.TabIndex = 2;
            this.label.Text = "Hủy phòng bạn sẽ không được bồi thường với bất kì lí do gì bạn chắc chứ.\r\n";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FCancelRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(933, 276);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FCancelRoom";
            this.Text = "FCancelRoom";
            this.groupBox.ResumeLayout(false);
            this.groupBoxMessage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupBox;
        private Guna.UI2.WinForms.Guna2Button buttonComfirm;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBoxMessage;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private Guna.UI2.WinForms.Guna2Button buttonBack;
    }
}