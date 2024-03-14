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
            for(int i=0; i<10; i++)
            {
                flowLayoutPanelHomePageSearch.Controls.Add(new UserControls.UserControlHomePaceSearch());
            }
        }
    }
}
