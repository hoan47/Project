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
    public partial class UserControlHomePaceSearchTime : UserControl
    {
        public Image ImageIcon { get { return pictureBoxIn.Image; } set { pictureBoxIn.Image = value; } }
        public string GroupBoxText { get { return groupBoxTime.Text; } set { groupBoxTime.Text = value; } }

        public UserControlHomePaceSearchTime()
        {
            InitializeComponent();
        }

        private void groupBoxTime_Enter(object sender, EventArgs e)
        {

        }
    }
}
