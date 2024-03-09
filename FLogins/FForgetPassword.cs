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

        private void ButtonCreateAccountClick(object sender, EventArgs e)
        {
            FController.Instance.user = new User(userControlTextBoxAccount.TextBoxText);
            if (buttonFindAccount.Text == "Tìm tài khoản")
            {
                if (FController.Instance.accountDAO.FindAccount(FController.Instance.user) == true)
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
            FController.Instance.user = new User(userControlTextBoxAccount.TextBoxText, userControlTextBoxPassword.TextBoxText, userControlTextBoxPassword.TextBoxText);
            if (FController.Instance.user.IsPassword() == true)
            {
                FController.Instance.accountDAO.UpdatePasswored(FController.Instance.user);
                Close();
                FController.Instance.InitializeLogin();
            }
        }
    }
}
