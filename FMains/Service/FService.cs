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
    public partial class FService : Form
    {
        public FService()
        {
            InitializeComponent();
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            ((FMain)Tag).OpenFormChild(null, new FUpdateHotel(null), this);
        }

        public void OpenHotelManager(Hotel hotel = null)
        {
            ((FMain)Tag).OpenFormChild(new FHotelManage(hotel), this);
        }

        private void LoadData()
        {
            if (Data.User.Hotels == null)
            {
                return; 
            }
            foreach(Hotel hotel in Data.User.Hotels)
            {
                UserControlHotel userControlHotel = new UserControlHotel(hotel);
                userControlHotel.Tag = this;
                flowLayoutPanelHottel.Controls.Add(userControlHotel);
            }    
        }

        private void FServiceLoad(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
