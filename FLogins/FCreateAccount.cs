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
        public FController fController;

        public FCreateAccount(FController fController)
        {
            InitializeComponent();
            this.fController = fController;
        }

        private void ButtonCreateAccountClick(object sender, EventArgs e)
        {
            string message;

            fController.User.UpdateUserPassword(userControlTextBoxAccount.TextBoxText, userControlTextBoxPassword.TextBoxText, userControlTextBoxNewPassword.TextBoxText);
            fController.User.UpdateClient(new Client(fController.User));
            if (fController.User.IsAccount(out message) == true && fController.User.IsPassword(out message) == true)
            {
                if(fController.AccountDAO.Insert() == true)
                {
                    fController.InfoDAO.Insert();
                    fController.ClientDAO.Insert();
                    fController.MessageSuccess("Thông báo", "Tạo tài khoản thành công.");
                    Back(sender, e);
                }
                else
                {
                    fController.MessageWarning("Thông báo", "Tài khoản đã tồn tại, vui lòng chọn tài khoản khác.");
                }
            }
            else
            {
                fController.MessageWarning("Thông báo", message);
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
