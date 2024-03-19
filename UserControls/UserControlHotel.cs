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
    public partial class UserControlHotel : UserControl
    {
        private Hotel hotel;
        private FService fService;

        public UserControlHotel(FService fService, Hotel hotel)
        {
            this.hotel = hotel;
            this.fService = fService;
            InitializeComponent();
            groupBox.Text = "Tên Khách Sạn: " + hotel.Name;
            labelAddress.Text = hotel.Address.AddressValue;
            labelPhone.Text = hotel.Phone;
            labelPrice.Text = "0 - 0";
            pictureBoxHotel.Image = hotel.Images != null ? hotel.Images.Count > 0 ? hotel.Images.First() : Properties.Resources.noImage : Properties.Resources.noImage;
        }

        public void UserControlHottelDoubleClick(object sender, EventArgs e)
        {
            fService.OpenHotel(hotel);
        }
    }
}