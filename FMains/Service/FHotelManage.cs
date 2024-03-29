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
            FUpdateRoom fUpdateRoom = new FUpdateRoom(hotel, room);

            fUpdateRoom.Tag = this;
            ((FMain)((FService)Tag).Tag).OpenFormChild(null, fUpdateRoom, this);
        }

        private void ButtonInforHotelClick(object sender, EventArgs e)
        {
            FUpdateHotel fUpdateHotel = new FUpdateHotel(hotel);

            fUpdateHotel.Tag = this;
            ((FMain)((FService)Tag).Tag).OpenFormChild(null, fUpdateHotel, this);
        }

        private void ButtonUpdateClick(object sender, EventArgs e)
        {
            if(hotel.Rooms == null || hotel.Rooms.Count == 0)
            {
                FController.Instance.MessageWarning("Thông báo", "Bạn vui lòng tạo phòng trước khi sử dụng tính năng này.", this);
                return;
            }    
            EnabledGroupBox();
            foreach (Control control in flowLayoutPanel.Controls)
            {
                control.Visible = false;
            }
            ((FMain)((FService)Tag).Tag).OpenFormChild(flowLayoutPanel, new FUpdatePrice(hotel), this);
        }

        public void EnabledGroupBox()
        {
            groupBoxStatus.Enabled = groupBoxDateTime.Enabled = groupBoxButton.Enabled = !groupBoxButton.Enabled;
        }

        public void LoadData()
        {
            if (hotel.Rooms == null)
            {
                return;
            }
            foreach(Control control in flowLayoutPanel.Controls)
            {
                if(control is UserControlRoom == false)
                {
                    flowLayoutPanel.Controls.Remove(control);
                    control.Dispose();
                }    
            }    
            if (flowLayoutPanel.Controls.Count <= hotel.Rooms.Count)
            {
                for (int i = 0; i < hotel.Rooms.Count; i++)
                {
                    if (flowLayoutPanel.Controls.Count != i)
                    {
                        ((UserControlRoom)flowLayoutPanel.Controls[i]).UpdateUI(hotel.Rooms[i]);
                    }
                    else
                    {
                        UserControlRoom userControlRoom = new UserControlRoom(hotel.Rooms[i]);

                        userControlRoom.Tag = this;
                        flowLayoutPanel.Controls.Add(userControlRoom);
                    }
                    flowLayoutPanel.Controls[i].Visible = true;
                }
            }
        }

        private void FHotelManageLoad(object sender, EventArgs e)
        {
            LoadData();
        } 
    }
}
