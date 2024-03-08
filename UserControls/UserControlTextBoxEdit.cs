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
    public partial class UserControlTextBoxEdit : UserControl
    {
        private Color colorTextBoxEnter = Color.FromArgb(255, 128, 0);
        private Color colorTextBoxLeave = Color.FromArgb(64, 64, 64);
        public string LabelText { get { return label.Text; } set { label.Text = value; }}
        public string TextBoxText { get { return textBox.Text; } set { textBox.Text = value; }}

        public UserControlTextBoxEdit()
        {
            InitializeComponent();
        }

        private void Edit(object sender, EventArgs e)
        {
            buttonEdit.Visible = !(textBox.Enabled = true);
            panelRoad.BackColor = colorTextBoxEnter;
        }

        private void UserControlTextBoxEditLeave(object sender, EventArgs e)
        {
            if(buttonEdit.Visible == false)
            {
                buttonEdit.Visible = !(textBox.Enabled = false);
                panelRoad.BackColor = colorTextBoxLeave;
            }
        }
    }
}
