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
    public partial class UserControlCheckInOutHotel : UserControl
    {
        public string MaskedTextBoxInText { get { return maskedTextBoxIn.Text; } set { maskedTextBoxIn.Text = value; } }
        public string MaskedTextBoxOutText { get { return maskedTextBoxOut.Text; } set { maskedTextBoxOut.Text = value; } }

        public UserControlCheckInOutHotel()
        {
            InitializeComponent();
        }
    }
}
