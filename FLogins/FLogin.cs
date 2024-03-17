using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FLogin : Form
    {
        public FController fController;
        private FLoading fLoading;

        public FLogin(FController fController)
        {
            InitializeComponent();
            backgroundWorker.DoWork += BackgroundWorkerDoWorkLogin;
            backgroundWorker.RunWorkerCompleted += DackgroundWorkerRunWorkerCompletedLogin;
            this.fController = fController;
        }

        private void LinkLabelCreateAccountLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fController.InitializeFCreateAccount();
        }

        private void LinkLabelForgetPasswordLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fController.InitializeFForgetPassword();
        }

        private void ButtonLoginClick(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy == true)
            {
                return;
            }
            fController.User.UpdateUserPassword(userControlTextBoxAccount.TextBoxText, userControlTextBoxPassword.TextBoxText, userControlTextBoxPassword.TextBoxText);
            fLoading = new FLoading(fController, 500);
            fLoading.OnLoading();
            backgroundWorker.RunWorkerAsync();
        }

        private void FLoginLoad(object sender, EventArgs e)
        {
            userControlTextBoxAccount.Focus();
        }

        public void BackgroundWorkerDoWorkLogin(object sender, DoWorkEventArgs e)
        {
            string message;

            if(fController.User.IsAccount(out message) == false)
            {
                e.Result = message;
            }
            else if (fController.AccountDAO.FindAccount() == false)
            {
                e.Result = "Tài khoản không tồn tại.";
            }
            else if (fController.AccountDAO.Select() == false)
            {
                e.Result = "Mật khẩu sai.";
            }
            else
            {
                fController.InfoDAO.Access();
                fController.ClientDAO.Access();
                fController.HotelDAO.Access();
                fController.ImageHotelDAO.Access();
                e.Result = "Đăng nhập thành công.";
            }
        }

        public void DackgroundWorkerRunWorkerCompletedLogin(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((string)e.Result == "Đăng nhập thành công.")
            {
                fController.InitializeFMain();
                fLoading.OnLoading();
                fController.MessageSuccess("Thông báo", (string)e.Result);
            }
            else
            {
                fController.MessageWarning("Thông báo", (string)e.Result);
            }
            fLoading.OffLoading();
        }

        private void CheckBoxShowPasswordCheckedChanged(object sender, EventArgs e)
        {
            userControlTextBoxPassword.PasswordChar();
        }
    }
}
