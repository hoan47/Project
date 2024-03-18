using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.UserControls
{
    public partial class UserControlBackground : UserControl
    {
        Color BackCoLor { get { return BackColor; } set { BackColor = value; } }
        public UserControlBackground()
        {
            InitializeComponent();
        }

        private void UserControlBackground_Load(object sender, EventArgs e)
        {

        }
    }
}
