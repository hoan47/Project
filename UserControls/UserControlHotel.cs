﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class UserControlHotel : System.Windows.Forms.UserControl
    {
        public UserControlHotel()
        {
            this.userControlHotelEditAddress = new UserControls.UserControlHotelEdit(this);
            this.userControlHotelEditName = new UserControls.UserControlHotelEdit(this);
            this.userControlHotelEditPhone = new UserControls.UserControlHotelEdit(this);
            this.userControlHotelEditPrice = new UserControls.UserControlHotelEdit(this);
            InitializeComponent();
        }

        public void UserControlHottelDoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn khách sạn");
        }

        private void UserControlHotel_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxHotel_Click(object sender, EventArgs e)
        {
        }
    }
}