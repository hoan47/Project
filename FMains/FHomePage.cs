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
            
            foreach(HotelRoom hotelRoom in FController.Instance.HotelRooms)
            {
                UserControlHotelRoom userControlHotelRoom = new UserControlHotelRoom(hotelRoom);

                userControlHotelRoom.Tag = this;
                flowLayoutPanel.Controls.Add(userControlHotelRoom);
            }
        }

        private void FHomePage_Load(object sender, EventArgs e)
        {

        }

        public void OpenInforHotelRoom(HotelRoom hotelRoom)
        {
            ((FMain)Tag).OpenFormChild(new FInforHotelRoom(hotelRoom), this, false);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void userControlHomePaceSearchPeople1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelHomePaceSearch_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Search()
        { }
    }
}