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
        private FLoading fLoading;

        public FLogin()
        {
            InitializeComponent();
            backgroundWorker.DoWork += BackgroundWorkerDoWorkLogin;
            backgroundWorker.RunWorkerCompleted += DackgroundWorkerRunWorkerCompletedLogin;
        }

        private void LinkLabelCreateAccountLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FController.Instance.InitializeFCreateAccount();
        }

        private void LinkLabelForgetPasswordLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FController.Instance.InitializeFForgetPassword();
        }

        private void ButtonLoginClick(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy == true)
            {
                return;
            }
            FController.Instance.User.UpdateUserPassword(userControlTextBoxAccount.TextBoxText, userControlTextBoxPassword.TextBoxText, userControlTextBoxPassword.TextBoxText);
            fLoading = new FLoading(FController.Instance, 500);
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

            if(FController.Instance.User.IsAccount(out message) == false)
            {
                e.Result = message;
            }
            else if (FController.Instance.AccountDAO.FindAccount() == false)
            {
                e.Result = "Tài khoản không tồn tại.";
            }
            else if (FController.Instance.AccountDAO.Select() == false)
            {
                e.Result = "Mật khẩu sai.";
            }
            else
            {  
                FController.Instance.InfoDAO.Access();
                FController.Instance.ClientDAO.Access();
                FController.Instance.HotelDAO.Access();
                if (FController.Instance.User.Hotels != null)
                {
                    FController.Instance.ServiceDAO.Access();
                    FController.Instance.ImageHotelDAO.Access();
                    FController.Instance.RoomDAO.Access();
                    FController.Instance.AmenitiesDAO.Access();
                    FController.Instance.ImageRoomDAO.Access();
                }
                e.Result = "Đăng nhập thành công.";
            }
        }

        public void DackgroundWorkerRunWorkerCompletedLogin(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((string)e.Result == "Đăng nhập thành công.")
            {
                FController.Instance.InitializeFMain();
                fLoading.OnLoading();
                FController.Instance.MessageSuccess("Thông báo", (string)e.Result);
            }
            else
            {
                FController.Instance.MessageWarning("Thông báo", (string)e.Result);
            }
            fLoading.OffLoading();
        }

        private void CheckBoxShowPasswordCheckedChanged(object sender, EventArgs e)
        {
            userControlTextBoxPassword.PasswordChar();
        }
    }
}
