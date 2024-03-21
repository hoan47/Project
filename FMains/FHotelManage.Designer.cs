namespace Project
{
    partial class FHotelManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHotelManage));
            this.groupBoxStatus = new Guna.UI2.WinForms.Guna2GroupBox();
            this.radioButtonIsOder = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonIsAll = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonIsEmpty = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonIsRent = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radioButtonIsRepair = new Guna.UI2.WinForms.Guna2RadioButton();
            this.groupBoxDateTime = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dateTimePicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.buttonInforHotel = new Guna.UI2.WinForms.Guna2Button();
            this.buttonAdd = new Guna.UI2.WinForms.Guna2Button();
            this.groupBoxButton = new Guna.UI2.WinForms.Guna2GroupBox();
            this.buttonUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.labelUpdatePrice = new System.Windows.Forms.Label();
            this.panelRoad2 = new System.Windows.Forms.Panel();
            this.panelRoad1 = new System.Windows.Forms.Panel();
            this.labelAddRoom = new System.Windows.Forms.Label();
            this.labelInfoHotel = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxStatus.SuspendLayout();
            this.groupBoxDateTime.SuspendLayout();
            this.groupBoxButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxStatus.BorderColor = System.Drawing.Color.Transparent;
            this.groupBoxStatus.BorderRadius = 15;
            this.groupBoxStatus.Controls.Add(this.radioButtonIsOder);
            this.groupBoxStatus.Controls.Add(this.radioButtonIsAll);
            this.groupBoxStatus.Controls.Add(this.radioButtonIsEmpty);
            this.groupBoxStatus.Controls.Add(this.radioButtonIsRent);
            this.groupBoxStatus.Controls.Add(this.radioButtonIsRepair);
            this.groupBoxStatus.CustomBorderColor = System.Drawing.Color.Moccasin;
            this.groupBoxStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxStatus.ForeColor = System.Drawing.Color.Black;
            this.groupBoxStatus.Location = new System.Drawing.Point(7, 5);
            this.groupBoxStatus.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(209, 115);
            this.groupBoxStatus.TabIndex = 7;
            this.groupBoxStatus.Text = "Trạng Thái Phòng";
            // 
            // radioButtonIsOder
            // 
            this.radioButtonIsOder.AutoSize = true;
            this.radioButtonIsOder.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonIsOder.CheckedState.BorderThickness = 0;
            this.radioButtonIsOder.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonIsOder.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonIsOder.CheckedState.InnerOffset = -4;
            this.radioButtonIsOder.ForeColor = System.Drawing.Color.Black;
            this.radioButtonIsOder.Location = new System.Drawing.Point(102, 66);
            this.radioButtonIsOder.Name = "radioButtonIsOder";
            this.radioButtonIsOder.Size = new System.Drawing.Size(59, 19);
            this.radioButtonIsOder.TabIndex = 12;
            this.radioButtonIsOder.Text = "Đã đặt";
            this.radioButtonIsOder.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonIsOder.UncheckedState.BorderThickness = 2;
            this.radioButtonIsOder.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonIsOder.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radioButtonIsAll
            // 
            this.radioButtonIsAll.AutoSize = true;
            this.radioButtonIsAll.Checked = true;
            this.radioButtonIsAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonIsAll.CheckedState.BorderThickness = 0;
            this.radioButtonIsAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonIsAll.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonIsAll.CheckedState.InnerOffset = -4;
            this.radioButtonIsAll.ForeColor = System.Drawing.Color.Black;
            this.radioButtonIsAll.Location = new System.Drawing.Point(10, 91);
            this.radioButtonIsAll.Name = "radioButtonIsAll";
            this.radioButtonIsAll.Size = new System.Drawing.Size(56, 19);
            this.radioButtonIsAll.TabIndex = 11;
            this.radioButtonIsAll.TabStop = true;
            this.radioButtonIsAll.Text = "Tất cả";
            this.radioButtonIsAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonIsAll.UncheckedState.BorderThickness = 2;
            this.radioButtonIsAll.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonIsAll.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radioButtonIsEmpty
            // 
            this.radioButtonIsEmpty.AutoSize = true;
            this.radioButtonIsEmpty.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonIsEmpty.CheckedState.BorderThickness = 0;
            this.radioButtonIsEmpty.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonIsEmpty.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonIsEmpty.CheckedState.InnerOffset = -4;
            this.radioButtonIsEmpty.ForeColor = System.Drawing.Color.Black;
            this.radioButtonIsEmpty.Location = new System.Drawing.Point(10, 66);
            this.radioButtonIsEmpty.Name = "radioButtonIsEmpty";
            this.radioButtonIsEmpty.Size = new System.Drawing.Size(86, 19);
            this.radioButtonIsEmpty.TabIndex = 10;
            this.radioButtonIsEmpty.Text = "Đang Trống";
            this.radioButtonIsEmpty.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonIsEmpty.UncheckedState.BorderThickness = 2;
            this.radioButtonIsEmpty.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonIsEmpty.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radioButtonIsRent
            // 
            this.radioButtonIsRent.AutoSize = true;
            this.radioButtonIsRent.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonIsRent.CheckedState.BorderThickness = 0;
            this.radioButtonIsRent.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonIsRent.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonIsRent.CheckedState.InnerOffset = -4;
            this.radioButtonIsRent.ForeColor = System.Drawing.Color.Black;
            this.radioButtonIsRent.Location = new System.Drawing.Point(10, 44);
            this.radioButtonIsRent.Name = "radioButtonIsRent";
            this.radioButtonIsRent.Size = new System.Drawing.Size(82, 19);
            this.radioButtonIsRent.TabIndex = 9;
            this.radioButtonIsRent.Text = "Đang Thuê";
            this.radioButtonIsRent.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonIsRent.UncheckedState.BorderThickness = 2;
            this.radioButtonIsRent.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonIsRent.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // radioButtonIsRepair
            // 
            this.radioButtonIsRepair.AutoSize = true;
            this.radioButtonIsRepair.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonIsRepair.CheckedState.BorderThickness = 0;
            this.radioButtonIsRepair.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioButtonIsRepair.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioButtonIsRepair.CheckedState.InnerOffset = -4;
            this.radioButtonIsRepair.ForeColor = System.Drawing.Color.Black;
            this.radioButtonIsRepair.Location = new System.Drawing.Point(102, 44);
            this.radioButtonIsRepair.Name = "radioButtonIsRepair";
            this.radioButtonIsRepair.Size = new System.Drawing.Size(103, 19);
            this.radioButtonIsRepair.TabIndex = 8;
            this.radioButtonIsRepair.Text = "Đang sữa chữa";
            this.radioButtonIsRepair.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioButtonIsRepair.UncheckedState.BorderThickness = 2;
            this.radioButtonIsRepair.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioButtonIsRepair.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // groupBoxDateTime
            // 
            this.groupBoxDateTime.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDateTime.BorderColor = System.Drawing.Color.Transparent;
            this.groupBoxDateTime.BorderRadius = 15;
            this.groupBoxDateTime.Controls.Add(this.dateTimePicker);
            this.groupBoxDateTime.CustomBorderColor = System.Drawing.Color.Moccasin;
            this.groupBoxDateTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxDateTime.ForeColor = System.Drawing.Color.Black;
            this.groupBoxDateTime.Location = new System.Drawing.Point(220, 5);
            this.groupBoxDateTime.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDateTime.Name = "groupBoxDateTime";
            this.groupBoxDateTime.Size = new System.Drawing.Size(252, 116);
            this.groupBoxDateTime.TabIndex = 8;
            this.groupBoxDateTime.Text = "Thời Gian";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.BorderRadius = 10;
            this.dateTimePicker.BorderThickness = 2;
            this.dateTimePicker.Checked = true;
            this.dateTimePicker.FillColor = System.Drawing.Color.PowderBlue;
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker.ForeColor = System.Drawing.Color.Black;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker.Location = new System.Drawing.Point(15, 64);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(225, 30);
            this.dateTimePicker.TabIndex = 8;
            this.dateTimePicker.Value = new System.DateTime(2024, 3, 17, 10, 12, 12, 338);
            // 
            // buttonInforHotel
            // 
            this.buttonInforHotel.BackColor = System.Drawing.Color.Transparent;
            this.buttonInforHotel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInforHotel.BackgroundImage")));
            this.buttonInforHotel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInforHotel.BorderRadius = 10;
            this.buttonInforHotel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonInforHotel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonInforHotel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonInforHotel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonInforHotel.FillColor = System.Drawing.Color.Transparent;
            this.buttonInforHotel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonInforHotel.ForeColor = System.Drawing.Color.Transparent;
            this.buttonInforHotel.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonInforHotel.Location = new System.Drawing.Point(43, 66);
            this.buttonInforHotel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInforHotel.Name = "buttonInforHotel";
            this.buttonInforHotel.Size = new System.Drawing.Size(40, 40);
            this.buttonInforHotel.TabIndex = 0;
            this.buttonInforHotel.Click += new System.EventHandler(this.ButtonInforHotelClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.BorderRadius = 10;
            this.buttonAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonAdd.FillColor = System.Drawing.Color.Transparent;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonAdd.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonAdd.Location = new System.Drawing.Point(141, 66);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(40, 40);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAddClick);
            // 
            // groupBoxButton
            // 
            this.groupBoxButton.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxButton.BorderColor = System.Drawing.Color.Transparent;
            this.groupBoxButton.BorderRadius = 15;
            this.groupBoxButton.Controls.Add(this.buttonUpdate);
            this.groupBoxButton.Controls.Add(this.labelUpdatePrice);
            this.groupBoxButton.Controls.Add(this.panelRoad2);
            this.groupBoxButton.Controls.Add(this.panelRoad1);
            this.groupBoxButton.Controls.Add(this.labelAddRoom);
            this.groupBoxButton.Controls.Add(this.labelInfoHotel);
            this.groupBoxButton.Controls.Add(this.buttonAdd);
            this.groupBoxButton.Controls.Add(this.buttonInforHotel);
            this.groupBoxButton.CustomBorderColor = System.Drawing.Color.Moccasin;
            this.groupBoxButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBoxButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxButton.ForeColor = System.Drawing.Color.Black;
            this.groupBoxButton.Location = new System.Drawing.Point(476, 5);
            this.groupBoxButton.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxButton.Name = "groupBoxButton";
            this.groupBoxButton.Size = new System.Drawing.Size(297, 116);
            this.groupBoxButton.TabIndex = 9;
            this.groupBoxButton.Text = "Chỉnh Sửa";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.BackgroundImage")));
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdate.BorderRadius = 10;
            this.buttonUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonUpdate.FillColor = System.Drawing.Color.Transparent;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.ImageSize = new System.Drawing.Size(35, 35);
            this.buttonUpdate.Location = new System.Drawing.Point(230, 66);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(40, 40);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdateClick);
            // 
            // labelUpdatePrice
            // 
            this.labelUpdatePrice.AutoSize = true;
            this.labelUpdatePrice.BackColor = System.Drawing.Color.Transparent;
            this.labelUpdatePrice.Location = new System.Drawing.Point(214, 46);
            this.labelUpdatePrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUpdatePrice.Name = "labelUpdatePrice";
            this.labelUpdatePrice.Size = new System.Drawing.Size(77, 15);
            this.labelUpdatePrice.TabIndex = 14;
            this.labelUpdatePrice.Text = "Cập Nhật Giá";
            // 
            // panelRoad2
            // 
            this.panelRoad2.BackColor = System.Drawing.Color.Black;
            this.panelRoad2.Location = new System.Drawing.Point(200, 40);
            this.panelRoad2.Margin = new System.Windows.Forms.Padding(2);
            this.panelRoad2.Name = "panelRoad2";
            this.panelRoad2.Size = new System.Drawing.Size(1, 73);
            this.panelRoad2.TabIndex = 13;
            // 
            // panelRoad1
            // 
            this.panelRoad1.BackColor = System.Drawing.Color.Black;
            this.panelRoad1.Location = new System.Drawing.Point(120, 40);
            this.panelRoad1.Margin = new System.Windows.Forms.Padding(2);
            this.panelRoad1.Name = "panelRoad1";
            this.panelRoad1.Size = new System.Drawing.Size(1, 73);
            this.panelRoad1.TabIndex = 12;
            // 
            // labelAddRoom
            // 
            this.labelAddRoom.AutoSize = true;
            this.labelAddRoom.BackColor = System.Drawing.Color.Transparent;
            this.labelAddRoom.Location = new System.Drawing.Point(124, 46);
            this.labelAddRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddRoom.Name = "labelAddRoom";
            this.labelAddRoom.Size = new System.Drawing.Size(75, 15);
            this.labelAddRoom.TabIndex = 11;
            this.labelAddRoom.Text = "Thêm Phòng";
            // 
            // labelInfoHotel
            // 
            this.labelInfoHotel.AutoSize = true;
            this.labelInfoHotel.BackColor = System.Drawing.Color.Transparent;
            this.labelInfoHotel.Location = new System.Drawing.Point(0, 46);
            this.labelInfoHotel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoHotel.Name = "labelInfoHotel";
            this.labelInfoHotel.Size = new System.Drawing.Size(118, 15);
            this.labelInfoHotel.TabIndex = 10;
            this.labelInfoHotel.Text = "Thông Tin Khách Sạn";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AllowDrop = true;
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(2, 125);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(777, 385);
            this.flowLayoutPanel.TabIndex = 11;
            // 
            // FHotelManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(780, 512);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.groupBoxButton);
            this.Controls.Add(this.groupBoxDateTime);
            this.Controls.Add(this.groupBoxStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FHotelManage";
            this.Text = "FHotelManagecs";
            this.Load += new System.EventHandler(this.FHotelManageLoad);
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            this.groupBoxDateTime.ResumeLayout(false);
            this.groupBoxButton.ResumeLayout(false);
            this.groupBoxButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxStatus;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxDateTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker;
        private Guna.UI2.WinForms.Guna2Button buttonInforHotel;
        private Guna.UI2.WinForms.Guna2Button buttonAdd;
        private Guna.UI2.WinForms.Guna2GroupBox groupBoxButton;
        private System.Windows.Forms.Label labelAddRoom;
        private System.Windows.Forms.Label labelInfoHotel;
        private System.Windows.Forms.Panel panelRoad1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panelRoad2;
        private System.Windows.Forms.Label labelUpdatePrice;
        private Guna.UI2.WinForms.Guna2Button buttonUpdate;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonIsOder;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonIsAll;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonIsEmpty;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonIsRent;
        private Guna.UI2.WinForms.Guna2RadioButton radioButtonIsRepair;
    }
}