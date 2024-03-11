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
    public partial class UserControlSearch : System.Windows.Forms.UserControl
    {
        public string TextVisible { get; set; }

        public UserControlSearch()
        {
            InitializeComponent();
            label.Text = TextVisible;
        }


        private void Processed(object sender, EventArgs e)
        {
            if (label.Visible == true)
            {
                textBox.Focus();
            }
            label.Visible = !label.Visible;
            textBox.Text = string.Empty;
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }    
        }
    }
}
