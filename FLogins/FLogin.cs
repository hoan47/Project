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
            FController.Instance.OpenCreateAccount();
        }

        private void LinkLabelForgetPasswordLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FController.Instance.OpenForgetPassword();
        }

        private void ButtonLoginClick(object sender, EventArgs e)
        {
            if (backgroundWorker.IsBusy == true)
            {
                return;
            }
            Data.User.UpdateUserPassword(userControlTextBoxAccount.TextBoxText, userControlTextBoxPassword.TextBoxText, userControlTextBoxPassword.TextBoxText);
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

            if(Data.User.IsAccount(out message) == false)
            {
                e.Result = message;
            }
            else if (DataAccess.AccountDAO.FindAccount(Data.User) == false)
            {
                e.Result = "Tài khoản không tồn tại.";
            }
            else if (DataAccess.AccountDAO.Select(Data.User) == false)
            {
                e.Result = "Mật khẩu sai.";
            }
            else
            {
                DataAccess.InfoDAO.Access(Data.User);
                DataAccess.ClientDAO.Access(Data.User);
                DataAccess.HotelDAO.Access(Data.User);
                if (Data.User.Hotels != null)
                {
                    DataAccess.ServiceDAO.Access(Data.User);
                    DataAccess.ImageHotelDAO.Access(Data.User);
                    DataAccess.RoomDAO.Access(Data.User);
                    DataAccess.AmenitiesDAO.Access(Data.User);
                    DataAccess.ImageRoomDAO.Access(Data.User);
                }
                e.Result = "Đăng nhập thành công.";
            }
        }

        public void DackgroundWorkerRunWorkerCompletedLogin(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((string)e.Result == "Đăng nhập thành công.")
            {
                FController.Instance.OpenMain();
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
