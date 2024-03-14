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
    public partial class UserControlAddressEdit : UserControl
    {
        private Color colorTextBoxEnter = Color.FromArgb(255, 128, 0);
        private Color colorTextBoxLeave = Color.FromArgb(64, 64, 64);
        public string ComboBoxText { get { return userControlComboBoxAddress.ComboBoxText; } set { userControlComboBoxAddress.ComboBoxText = value; } }

        public UserControlAddressEdit()
        {
            InitializeComponent();
        }

        private void Edit(object sender, EventArgs e)
        {
            buttonEdit.Visible = !(userControlComboBoxAddress.Enabled = true);
            panelRoad.BackColor = colorTextBoxEnter;
        }

        private void UserControlComboBoxEditLeave(object sender, EventArgs e)
        {
            if(buttonEdit.Visible == false)
            {
                buttonEdit.Visible = !(userControlComboBoxAddress.Enabled = false);
                panelRoad.BackColor = colorTextBoxLeave;
            }
        }
    }
}
