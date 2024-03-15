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
    public partial class FForgetPassword : Form
    {
        private FController fController;

        public FForgetPassword(FController fController)
        {
            InitializeComponent();
            this.fController = fController;
        }

        private void ButtonFindAccountClick(object sender, EventArgs e)
        {
            fController.User.UpdateUserName(userControlTextBoxAccount.TextBoxText);
            if (buttonFindAccount.Text == "Tìm tài khoản")
            {
                if (fController.AccountDAO.FindAccount() == true)
                {
                    userControlTextBoxAccount.Enabled = !(panelPassword.Visible = true);
                    buttonFindAccount.Text = "Bỏ chọn tài khoản";
                }
                else
                {
                    ShowMessage.ShowWarning("Không tìm thấy tài khoản");
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
            fController.User.UpdateUserPassword(userControlTextBoxAccount.TextBoxText, userControlTextBoxPassword.TextBoxText, userControlTextBoxPassword.TextBoxText);
            if (fController.User.IsPassword() == true)
            {
                fController.AccountDAO.Update();
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
