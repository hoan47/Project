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
            fController.User.UpdateUserPassword(userControlTextBoxAccount.TextBoxText, userControlTextBoxPassword.TextBoxText, userControlTextBoxNewPassword.TextBoxText);
            fController.User.UpdateClient(new Client(fController.User));
            if (fController.User.IsAccount() == true && fController.User.IsPassword() == true)
            {
                if(fController.AccountDAO.Insert() == true)
                {
                    fController.InfoDAO.Insert();
                    fController.ClientDAO.Insert();
                    ShowMessage.ShowNotification("Tạo tài khoản thành công.");
                    Back(sender, e);
                }
                else
                {
                    ShowMessage.ShowWarning("Tài khoản đã tồn tại, vui lòng chọn tài khoản khác.");
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
