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
    public partial class FCancelRoom : Form
    {
        public FCancelRoom()
        {
            InitializeComponent();
        }

        private void ButtonBackClick(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
