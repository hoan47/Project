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
    public partial class FForgetPassword : Form, IUser
    {
        public FController fController { get; set; }
        public User User { get; set; }
        public AccountDAO AccountDAO { get; set; }
        public InfoDAO InfoDAO { get; set; }

        public FForgetPassword(FController fController, User user, AccountDAO accountDAO, InfoDAO infoDAO)
        {
            InitializeComponent();
            this.fController = fController;
            this.User = user;
            this.AccountDAO = accountDAO;
            this.InfoDAO = infoDAO;
        }

        private void ButtonFindAccountClick(object sender, EventArgs e)
        {
            User.Update(userControlTextBoxAccount.TextBoxText);
            if (buttonFindAccount.Text == "Tìm tài khoản")
            {
                if (AccountDAO.FindAccount() == true)
                {
                    userControlTextBoxAccount.Enabled = !(panelPassword.Visible = true);
                    buttonFindAccount.Text = "Bỏ chọn tài khoản";
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (buttonFindAccount.Text == "Bỏ chọn tài khoản")
            {
                buttonFindAccount.Text = "Tìm tài khoản";
                panelPassword.Visible = !(userControlTextBoxAccount.Enabled = true);
                userControlTextBoxPassword.TextBoxText = string.Empty;
            }    
        }

        private void ButtonUpdatePasswordClick(object sender, EventArgs e)
        {
            User.Update(userControlTextBoxAccount.TextBoxText, userControlTextBoxPassword.TextBoxText, userControlTextBoxPassword.TextBoxText);
            if (User.IsPassword() == true)
            {
                AccountDAO.Update();
                Back(sender, e);
            }
        }

        private void Back(object sender, EventArgs e)
        {
            fController.InitializeFLogin();
            Close();
        }

        private void FForgetPasswordLoad(object sender, EventArgs e)
        {
            userControlTextBoxAccount.Focus();
        }
    }
}
