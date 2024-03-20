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
            LoadData();
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            ((FMain)Tag).OpenFormChild(new FUpdateHotel(null));
        }

        public void OpenHotelManager(Hotel hotel = null)
        {
            ((FMain)Tag).OpenFormChild(new FHotelManage(hotel));
        }

        private void LoadData()
        {
            if (FController.Instance.User.Hotels == null)
            {
                return; 
            }
            foreach(Hotel hotel in FController.Instance.User.Hotels)
            {
                UserControlHotel userControlHotel = new UserControlHotel(hotel);
                userControlHotel.Tag = this;
                flowLayoutPanelHottel.Controls.Add(userControlHotel);
            }    
        }
    }
}
