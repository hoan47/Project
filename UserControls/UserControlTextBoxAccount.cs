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
    }
}
