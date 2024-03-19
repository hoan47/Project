
namespace Project
{
    partial class UserControlAddService
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
            this.groupBoxService = new System.Windows.Forms.GroupBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.textBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.groupBoxService.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxService
            // 
            this.groupBoxService.Controls.Add(this.listBox);
            this.groupBoxService.Controls.Add(this.textBox);
            this.groupBoxService.Controls.Add(this.button);
            this.groupBoxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxService.Location = new System.Drawing.Point(0, 0);
            this.groupBoxService.Name = "groupBoxService";
            this.groupBoxService.Size = new System.Drawing.Size(300, 100);
            this.groupBoxService.TabIndex = 66;
            this.groupBoxService.TabStop = false;
            this.groupBoxService.Text = "Dịch Vụ";
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.Info;
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 17;
            this.listBox.Items.AddRange(new object[] {
            "Bãi giữ xe máy",
            "Bãi giữ xe ô tô",
            "Khu bán đồ ăn",
            "Công viên",
            "Wfi",
            "Hồ bơi",
            "Giặt là",
            "Khu vực hút thuốc"});
            this.listBox.Location = new System.Drawing.Point(10, 40);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(280, 53);
            this.listBox.TabIndex = 3;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.ListBoxSelectedIndexChanged);
            // 
            // textBox
            // 
            this.textBox.BorderColor = System.Drawing.Color.Black;
            this.textBox.BorderRadius = 5;
            this.textBox.BorderThickness = 2;
            this.textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox.DefaultText = "";
            this.textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox.ForeColor = System.Drawing.Color.Black;
            this.textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox.Location = new System.Drawing.Point(74, 12);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox.Name = "textBox";
            this.textBox.PasswordChar = '\0';
            this.textBox.PlaceholderText = "Thêm dịch vụ";
            this.textBox.SelectedText = "";
            this.textBox.Size = new System.Drawing.Size(160, 25);
            this.textBox.TabIndex = 2;
            this.textBox.TextChanged += new System.EventHandler(this.TextBoxTextChanged);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.BackgroundImage = global::Project.Properties.Resources.add;
            this.button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button.FillColor = System.Drawing.Color.Transparent;
            this.button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button.ForeColor = System.Drawing.Color.White;
            this.button.Location = new System.Drawing.Point(259, 12);
            this.button.Name = "button";
            this.button.PressedColor = System.Drawing.Color.Transparent;
            this.button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.button.Size = new System.Drawing.Size(25, 25);
            this.button.TabIndex = 1;
            this.button.Click += new System.EventHandler(this.ButtonClick);
            // 
            // UserControlAddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxService);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserControlAddService";
            this.Size = new System.Drawing.Size(300, 100);
            this.groupBoxService.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxService;
        private Guna.UI2.WinForms.Guna2TextBox textBox;
        private Guna.UI2.WinForms.Guna2CircleButton button;
        private System.Windows.Forms.ListBox listBox;
    }
}
