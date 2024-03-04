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
    public partial class FCreateAccount : Form
    {
        public FCreateAccount()
        {
            InitializeComponent();
        }

        private void ButtonCreateAccountClick(object sender, EventArgs e)
        {
            switch(AccountDAO.CreateAccount(textBoxAccount.Text, textBoxPassword.Text, textBoxNewPassword.Text))
            {
                case AccountDAO.EErrorCreate.account:
                case AccountDAO.EErrorCreate.duplicateAccounts:
                    textBoxAccount.Focus();
                    break;
                case AccountDAO.EErrorCreate.password:
                    textBoxPassword.Focus();
                    break;
            }
        }

        private void TextBoxAccountKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxPassword.Focus();
                e.Handled = true;
            }
        }

        private void TextBoxPasswordKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxNewPassword.Focus();
                e.Handled = true;
            }
        }

        private void TextBoxNewPasswordKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ButtonCreateAccountClick(sender, e);
                e.Handled = true;
            }
        }

        private void FCreateAccountLoad(object sender, EventArgs e)
        {
            textBoxAccount.Focus();
        }
    }
}
