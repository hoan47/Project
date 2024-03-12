using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FLogin : Form, IUser
    {
        public FController fController;
        public User User { get; set; }
        public AccountDAO AccountDAO { get; set; }
        public InfoDAO InfoDAO { get; set; }

        public FLogin(FController fController, User user, AccountDAO accountDAO, InfoDAO infoDAO)
        {
            InitializeComponent();
            this.fController = fController;
            User = user;
            AccountDAO = accountDAO;
            InfoDAO = infoDAO;
        }

        private void LinkLabelCreateAccountLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fController.InitializeFCreateAccount();
        }

        private void LinkLabelForgetPasswordLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fController.InitializeFForgetPassword();
        }

        private void ButtonLoginClick(object sender, EventArgs e)
        {
            User.Update(userControlTextBoxAccount.TextBoxText, userControlTextBoxPassword.TextBoxText, userControlTextBoxPassword.TextBoxText);
            if (AccountDAO.Login() == true)
            {
                InfoDAO.Access();
                fController.InitializeFMain();
                Close();
            }
        }

        private void FLoginLoad(object sender, EventArgs e)
        {
            userControlTextBoxAccount.Focus();
        }

        private void userControlTextBoxAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
