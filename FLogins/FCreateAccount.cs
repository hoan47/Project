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
            string message;

            FController.Instance.User.UpdateUserPassword(userControlTextBoxAccount.TextBoxText, userControlTextBoxPassword.TextBoxText, userControlTextBoxNewPassword.TextBoxText);
            FController.Instance.User.UpdateClient(new Client());
            if (FController.Instance.User.IsAccount(out message) == true && FController.Instance.User.IsPassword(out message) == true)
            {
                if(FController.Instance.AccountDAO.Insert() == true)
                {
                    FController.Instance.InfoDAO.Insert();
                    FController.Instance.ClientDAO.Insert();
                    FController.Instance.MessageSuccess("Thông báo", "Tạo tài khoản thành công.");
                    Back(sender, e);
                }
                else
                {
                    FController.Instance.MessageWarning("Thông báo", "Tài khoản đã tồn tại, vui lòng chọn tài khoản khác.");
                }
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

        private void FCreateAccountLoad(object sender, EventArgs e)
        {
            userControlTextBoxAccount.Focus();
        }
    }
}
