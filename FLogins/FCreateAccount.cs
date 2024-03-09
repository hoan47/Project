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
            FController.Instance.user = new User(userControlTextBoxAccount.TextBoxText, userControlTextBoxPassword.TextBoxText, userControlTextBoxNewPassword.TextBoxText);
            if (FController.Instance.user.IsAccount() == true || FController.Instance.user.IsPassword() == true)
            {
                if(FController.Instance.accountDAO.CreateAccount(FController.Instance.user) == true)
                {
                    FController.Instance.infoDAO.Insert(FController.Instance.user);
                }    
            }
        }
    }
}
