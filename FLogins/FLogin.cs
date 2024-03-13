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
    public partial class FLogin : Form, IUser
    {
        public FController fController;
        public User User { get; set; }
        public AccountDAO AccountDAO { get; set; }
        public InfoDAO InfoDAO { get; set; }

        public FLogin(FController fController, User user, AccountDAO accountDAO, InfoDAO infoDAO)
        {
            InitializeComponent();
            backgroundWorker.DoWork += BackgroundWorkerDoWorkLogin;
            backgroundWorker.RunWorkerCompleted += DackgroundWorkerRunWorkerCompletedLogin;
            this.fController = fController;
            User = user;
            AccountDAO = accountDAO;
            InfoDAO = infoDAO;
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
            User.Update(userControlTextBoxAccount.TextBoxText, userControlTextBoxPassword.TextBoxText, userControlTextBoxPassword.TextBoxText);
            fController.userControlLoading = new UserControlLoading(fController, 1000);
            fController.userControlLoading.OnLoading();
            backgroundWorker.RunWorkerAsync();
        }

        private void FLoginLoad(object sender, EventArgs e)
        {
            userControlTextBoxAccount.Focus();
        }

        public void BackgroundWorkerDoWorkLogin(object sender, DoWorkEventArgs e)
        {
            bool isSuccess = AccountDAO.Login();

            if (isSuccess == true)
            {
                InfoDAO.Access();
            }
            e.Result = isSuccess;
        }

        public void DackgroundWorkerRunWorkerCompletedLogin(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((bool)e.Result == true)
            {
                fController.InitializeFMain();
                fController.userControlLoading.OnLoading();
                fController.MessageSuccess("Thông báo", "Đăng nhập thành công.");
            }
            fController.userControlLoading.OffLoading();
        }
    }
}
