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

            Data.User.UpdateUserPassword(userControlTextBoxAccount.TextBoxText, userControlTextBoxPassword.TextBoxText, userControlTextBoxNewPassword.TextBoxText);
            Data.User.UpdateClient(new Client());
            if (Data.User.IsAccount(out message) == true && Data.User.IsPassword(out message) == true)
            {
                if(DataAccess.AccountDAO.Insert(Data.User) == true)
                {
                    DataAccess.InfoDAO.Insert(Data.User);
                    DataAccess.ClientDAO.Insert(Data.User);
                    FController.Instance.MessageSuccess("Thông báo", "Tạo tài khoản thành công.");
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
            FController.Instance.OpenLogin();
            Close();
        }

        private void FCreateAccountLoad(object sender, EventArgs e)
        {
            userControlTextBoxAccount.Focus();
        }
    }
}
