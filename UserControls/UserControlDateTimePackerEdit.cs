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
    public partial class UserControlDateTimePackerEdit : UserControl
    {
        private Color colorTextBoxEnter = Color.FromArgb(255, 128, 0);
        private Color colorTextBoxLeave = Color.FromArgb(64, 64, 64);
        public string LabelText { get { return label.Text; } set { label.Text = value; } }
        public string TextBoxText { get { return dateTimePicker.Text; } set { dateTimePicker.Text = value; } }

        public UserControlDateTimePackerEdit()
        {
            InitializeComponent();
        }

        private void Edit(object sender, EventArgs e)
        {
                dateTimePicker.Enabled = !(buttonEdit.Visible = false);
                panelRoad.BackColor = colorTextBoxEnter;
        }

        private void UserControlDateTimePackerEditLeave(object sender, EventArgs e)
        {
            if(buttonEdit.Visible == false)
            {
                dateTimePicker.Enabled = !(buttonEdit.Visible = true);
                panelRoad.BackColor = colorTextBoxLeave;
            }
        }
    }
}
