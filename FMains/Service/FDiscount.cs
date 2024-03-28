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
    public partial class FDiscount : Form
    {
        public FDiscount()
        {
            InitializeComponent();
        }

        private void ButtonBackClick(object sender, EventArgs e)
        {
            ((FHotelManage)Tag).LoadData();
            ((FHotelManage)Tag).EnabledGroupBox();
            Dispose();
        }
    }
}
