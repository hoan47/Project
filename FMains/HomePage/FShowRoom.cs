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
    public partial class FShowRoom : Form
    {
        private Hotel hotel;

        public FShowRoom(Hotel hotel)
        {
            InitializeComponent();
            this.hotel = hotel;
            userControlLable1.LableText = hotel.Address.AddressValue;
        }

        private void FShowRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
