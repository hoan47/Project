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
<<<<<<< Updated upstream
            switch(AccountDAO.CreateAccount(textBoxAccount.Text, textBoxPassword.Text, textBoxNewPassword.Text))
=======
            FController.Instance.user = new User(textBoxAccount.Text, textBoxPassword.Text, textBoxNewPassword.Text);
            if (FController.Instance.user.IsAccount() == ErrorUserInfo.account)
>>>>>>> Stashed changes
            {
                textBoxAccount.Focus();
                return;
            }
            switch (FController.Instance.user.IsPassword())
            {
                case ErrorUserInfo.password:
                    textBoxPassword.Focus();
                    return;
                case ErrorUserInfo.newPassWord:
                    textBoxNewPassword.Focus();
                    return;
            }
            if (FController.Instance.accountDAO.CreateAccount() == ErrorUserInfo.duplicateAccounts)
            {
                textBoxAccount.Focus();
            }
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (((TextBox)sender) == textBoxAccount)
                {
                    textBoxPassword.Focus();
                }
                else if(((TextBox)sender) == textBoxPassword)
                {
                    textBoxNewPassword.Focus();
                }    
                else if(((TextBox)sender) == textBoxNewPassword)
                {
                    ButtonCreateAccountClick(sender, e);
                }
                e.Handled = true;
            }
        }

        private void FCreateAccountLoad(object sender, EventArgs e)
        {
            textBoxAccount.Focus();
        }
    }
}
