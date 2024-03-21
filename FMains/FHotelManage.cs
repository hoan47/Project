using Guna.UI2.WinForms;
using Project.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Project
{
    public partial class FHotelManage : Form
    {
        private Hotel hotel;

        public FHotelManage(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            OpenUpdateRoom();
        }

        public void OpenUpdateRoom(Room room = null)
        {
            ((FMain)((FService)Tag).Tag).OpenFormChild(new FUpdateRoom(hotel, room), this);
        }

        private void ButtonInforHotelClick(object sender, EventArgs e)
        {
            ((FMain)((FService)Tag).Tag).OpenFormChild(new FUpdateHotel(hotel), this, false);
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            if(hotel.Rooms == null)
            {
                return;
            }    
            foreach(Room room in hotel.Rooms)
            {
                UserControlRoom userControlRoom = new UserControlRoom(room);

                userControlRoom.Tag = this;
                flowLayoutPanel.Controls.Add(userControlRoom);
            }
        }

        private void FHotelManageLoad(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
