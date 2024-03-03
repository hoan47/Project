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
            if (buttonFindAccount.Text == "Tìm tài khoản")
            {
                if (AccountDAO.FindAccount(textBoxAccount.Text) == true)
                {
                    panelPassword.Visible = true;
                    buttonFindAccount.Text = "Bỏ chọn tài khoản";
                    textBoxAccount.Enabled = false;
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
                textBoxAccount.Enabled = true;
                textBoxPassword.Text = string.Empty;
                panelPassword.Visible = false;
            }    
        }

        private void ButtonUpdatePasswordClick(object sender, EventArgs e)
        {
            AccountDAO.UpdatePasswored(textBoxAccount.Text, textBoxPassword.Text);
        }

        private void TextBoxAccountKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ButtonCreateAccountClick(sender, e);
                e.Handled = true;
            }
            MessageBox.Show("hi");
        }

        private void TextBoxPasswordKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ButtonUpdatePasswordClick(sender, e);
                e.Handled = true;
            }
        }
    }
}
