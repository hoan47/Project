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
    public partial class UserControlRadioButtonEdit : UserControl
    {
        private Color colorTextBoxEnter = Color.FromArgb(255, 128, 0);
        private Color colorTextBoxLeave = Color.FromArgb(64, 64, 64);
        public string LabelText { get { return label.Text; } set { label.Text = value; } }
        public string GenderText { get { return radioButtonBoy.Checked == true ? "Nam" : "Nữ"; } set { radioButtonGirl.Checked = !(radioButtonBoy.Checked = value == "Nam" ? true : false); } }

        public UserControlRadioButtonEdit()
        {
            InitializeComponent();
        }

        private void Edit(object sender, EventArgs e)
        {
            radioButtonBoy.Enabled = radioButtonGirl.Enabled = !(buttonEdit.Visible = false);
        }

        private void UserControlRadioButtonEditLeave(object sender, EventArgs e)
        {
            if (buttonEdit.Visible == false)
            {
                radioButtonBoy.Enabled =  radioButtonGirl.Enabled = !(buttonEdit.Visible = true);
                panelRoad.BackColor = colorTextBoxLeave;
            }
        }
    }
}
