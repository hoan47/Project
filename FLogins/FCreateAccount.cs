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
    public partial class FCreateAccount : Form, IUser
    {
        public FController fController { get; set; }
        public User User { get; set; }
        public AccountDAO AccountDAO { get; set; }
        public InfoDAO InfoDAO { get; set; }
        public ClientDAO ClientDAO { get; set; }

        public FCreateAccount(FController fController, User user, AccountDAO accountDAO, InfoDAO infoDAO, ClientDAO clientDAO)
        {
            InitializeComponent();
            this.fController = fController;
            User = user;
            AccountDAO = accountDAO;
            InfoDAO = infoDAO;
            ClientDAO = clientDAO;
        }

        private void ButtonCreateAccountClick(object sender, EventArgs e)
        {
            User.UpdateUserPassword(userControlTextBoxAccount.TextBoxText, userControlTextBoxPassword.TextBoxText, userControlTextBoxNewPassword.TextBoxText);
            User.UpdateClient(new Client(User));
            if (User.IsAccount() == true && User.IsPassword() == true)
            {
                if(AccountDAO.Insert() == true)
                {
                    InfoDAO.Insert();
                    ClientDAO.Insert();
                    Back(sender, e);
                }    
            }
        }

        private void Back(object sender, EventArgs e)
        {
            fController.InitializeFLogin();
            Close();
        }

        private void FCreateAccountLoad(object sender, EventArgs e)
        {
            userControlTextBoxAccount.Focus();
        }
    }
}
