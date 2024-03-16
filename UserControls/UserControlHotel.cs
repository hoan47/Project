using System;
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
        private int index;
        private FController fController;
        private Hotel hotel;
        private FService fService;

        public UserControlHotel(FController fController, FService fService, int index)
        {
            this.index = index;
            this.fController = fController;
            this.fService = fService;
            hotel = fController.User.Hotels[index];
            InitializeComponent();
            groupBox.Text = hotel.Name;
            labelAddress.Text = hotel.Address.AddressValue;
            labelPhone.Text = hotel.Phone;
            labelPrice.Text = "0 - 0";
            pictureBoxHotel.Image = hotel.Images != null ? hotel.Images.Count > 0 ? hotel.Images.First().Image : Properties.Resources.noImage : Properties.Resources.noImage;
        }

        public void UserControlHottelDoubleClick(object sender, EventArgs e)
        {
            fService.OpenHotel(index);
        }
    }
}