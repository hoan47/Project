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
            for(int i=1; i<5; i++)
            {
                flowLayoutPanelService.Controls.Add(new UserControlHotel());
            }
        }

        private void flowLayoutPanelService_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
