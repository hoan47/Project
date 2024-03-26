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
    public partial class FHomePage : Form
    {
        public FHomePage()
        {
            InitializeComponent();
        }

        private void FHomePageLoad(object sender, EventArgs e)
        {
            foreach(Hotel hotel in Data.HotelServices)
            {
                UserControlShowHotel userControlHotel = new UserControlShowHotel(hotel);

                userControlHotel.Tag = this;
                flowLayoutPanel.Controls.Add(userControlHotel);
            }    
        }

        public void OpenHotel(Hotel hotel)
        {
            ((FMain)Tag).OpenFormChild(new FShowHotelRoom(hotel), this, false);
        }
    }
}