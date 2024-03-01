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
    public partial class FLogin : Form
    {
        FCreateAccount fCreateAccount;
        FForgetPassword forgotPassword;
        public FLogin()
        {
            InitializeComponent();
        }


        private void linkLabelCreateAccountLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (fCreateAccount == null || fCreateAccount.Visible == false)
            {
                fCreateAccount = new FCreateAccount();
            }
            fCreateAccount.Show();
        }

        private void LinkLabelForgetPasswordLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (forgotPassword == null || forgotPassword.Visible == false)
            {
                forgotPassword = new FForgetPassword();
            }
            forgotPassword.Show();
        }

        private void TextBoxAccountKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                textBoxPassword.Focus();
                e.Handled = true;
            }    
        }

        private void TextBoxPasswordKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ButtonLoginClick(sender, e);
                e.Handled = true;
            }
        }

        private void ButtonLoginClick(object sender, EventArgs e)
        {

        }
    }
}
