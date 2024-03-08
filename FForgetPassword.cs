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
            FController.Instance.user = new User(textBoxAccount.Text);
            if (buttonFindAccount.Text == "Tìm tài khoản")
            {
                if (FController.Instance.accountDAO.FindAccount() == true)
                {
                    textBoxAccount.Enabled = !(panelPassword.Visible = true);
                    buttonFindAccount.Text = "Bỏ chọn tài khoản";
                    textBoxPassword.Focus();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tài khoản", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (buttonFindAccount.Text == "Bỏ chọn tài khoản")
            {
                buttonFindAccount.Text = "Tìm tài khoản";
                panelPassword.Visible = !(textBoxAccount.Enabled = true);
                textBoxPassword.Text = string.Empty;
            }    
        }

        private void ButtonUpdatePasswordClick(object sender, EventArgs e)
        {
            FController.Instance.user = new User(textBoxAccount.Text, textBoxPassword.Text, textBoxPassword.Text);
            if (FController.Instance.user.IsPassword() == ErrorUserInfo.success)
            {
                FController.Instance.accountDAO.UpdatePasswored();
            }
        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if ((TextBox)sender == textBoxAccount)
                {
                    ButtonCreateAccountClick(sender, e);
                }
                else if((TextBox)sender == textBoxPassword)
                {
                    ButtonUpdatePasswordClick(sender, e);
                }
                e.Handled = true;
            }
        }

        private void FForgetPasswordLoad(object sender, EventArgs e)
        {
            textBoxAccount.Focus();
        }
    }
}
