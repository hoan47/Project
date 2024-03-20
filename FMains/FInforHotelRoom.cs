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
    public partial class FInforHotelRoom : Form
    {
        public FInforHotelRoom(HotelRoom hotelRoom)
        {
            InitializeComponent();
        }

        private void FHomePaceInformationRoom_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
