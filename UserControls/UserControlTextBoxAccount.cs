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
    public partial class UserControlTextBoxAccount : UserControl
    {
        public string TextBoxText { get { return textBox.Text; } set { textBox.Text = value; } }

        public UserControlTextBoxAccount()
        {
            InitializeComponent();
        }

        private void TextBoxAccountKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }    
        }

        private void LabelClick(object sender, EventArgs e)
        {
            label.Visible = false;
            textBox.Focus();
        }

        private void TextBoxLeave(object sender, EventArgs e)
        {
            if(textBox.Text == string.Empty)
            {
                label.Visible = true;
            }    
        }

        private void TextBoxEnter(object sender, EventArgs e)
        {
            label.Visible = false;
        }
    }
}
