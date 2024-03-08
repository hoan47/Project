using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class AccountDAO : DAO
    {
        public ErrorUserInfo Login()
        {
            if (FindAccount() == false)
            {
                ShowMessage.ShowWarning("Tài khoản không tồn tại.");
                return ErrorUserInfo.account;
            }
            try
            {
                sqlConnection.Open();
                SqlCommand checkAccountCmd = new SqlCommand($"SELECT COUNT(*) FROM Account WHERE userName = '{FController.Instance.user.UserName}' and password = '{FController.Instance.user.Password}'", sqlConnection);

                if ((int)checkAccountCmd.ExecuteScalar() != 0)
                {
                    ShowMessage.ShowNotification("Đăng nhập thành công.");
                    return ErrorUserInfo.success;
                }
                else
                {
                    ShowMessage.ShowWarning("Mật khẩu sai.");
                    return ErrorUserInfo.password;
                }
            }
            catch (Exception e)
            {
                ShowMessage.ShowError(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return ErrorUserInfo.error;
        }

        public ErrorUserInfo CreateAccount()
        {
            if (FindAccount() == true)
            {
                ShowMessage.ShowWarning("Tài khoản đã tồn tại, vui lòng chọn tài khoản khác.");
                return ErrorUserInfo.duplicateAccounts;
            }
            try
            {
                sqlConnection.Open();
                SqlCommand insertAccountCmd = new SqlCommand($"INSERT Account VALUES ('{FController.Instance.user.UserName}', '{FController.Instance.user.Password}')", sqlConnection);

                if (insertAccountCmd.ExecuteNonQuery() == 1)
                {
                    ShowMessage.ShowNotification("Tạo tài khoản thành công.");
                    return ErrorUserInfo.success;
                }
            }
            catch (Exception e)
            {
                ShowMessage.ShowError(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return ErrorUserInfo.error;
        }

        public bool FindAccount()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand checkAccountCmd = new SqlCommand($"SELECT COUNT(*) FROM Account WHERE userName COLLATE Latin1_General_CS_AS = '{FController.Instance.user.UserName}'", sqlConnection);

                return (int)checkAccountCmd.ExecuteScalar() != 0;
            }
            catch (Exception e)
            {
                ShowMessage.ShowError(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return false;
        }

        public void UpdatePasswored()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand updatePassword = new SqlCommand($"UPDATE Account SET password = '{FController.Instance.user.NewPassword}' WHERE userName = '{FController.Instance.user.UserName}'", sqlConnection);

                if (updatePassword.ExecuteNonQuery() == 1)
                {
                    ShowMessage.ShowNotification("Đổi mật khẩu thành công");
                }
            }
            catch (Exception e)
            {
                ShowMessage.ShowError(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}