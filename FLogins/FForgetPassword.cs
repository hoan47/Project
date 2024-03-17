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
        public FForgetPassword()
        {
            InitializeComponent();
        }

        private void ButtonFindAccountClick(object sender, EventArgs e)
        {
            FController.Instance.User.UpdateUserName(userControlTextBoxAccount.TextBoxText);
            if (buttonFindAccount.Text == "Tìm tài khoản")
            {
                if (FController.Instance.AccountDAO.FindAccount() == true)
                {
                    userControlTextBoxAccount.Enabled = !(panelPassword.Visible = true);
                    buttonFindAccount.Text = "Bỏ chọn tài khoản";
                }
                else
                {
                    FController.Instance.MessageWarning("Thông báo", "Không tìm thấy tài khoản");
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
            string message;

            FController.Instance.User.UpdateUserPassword(userControlTextBoxAccount.TextBoxText, userControlTextBoxPassword.TextBoxText, userControlTextBoxPassword.TextBoxText);
            if (FController.Instance.User.IsPassword(out message) == true)
            {
                FController.Instance.AccountDAO.Update();
                Back(sender, e);
            }
            else
            {
                FController.Instance.MessageWarning("Thông báo", message);
            }    
        }

        private void Back(object sender, EventArgs e)
        {
            FController.Instance.InitializeFLogin();
            Close();
        }

        private void FForgetPasswordLoad(object sender, EventArgs e)
        {
            userControlTextBoxAccount.Focus();
        }
    }
}
