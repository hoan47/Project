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
        public AccountDAO() : base("Account")
        { }

        public bool Login(User user)
        {
            if (FindAccount(user) == false)
            {
                ShowMessage.ShowWarning("Tài khoản không tồn tại.");
                return false;
            }
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT COUNT(*) FROM {table} WHERE userName = '{user.UserName}' and password = '{user.Password}'", sqlConnection);

                if ((int)selectCMD.ExecuteScalar() != 0)
                {
                    ShowMessage.ShowNotification("Đăng nhập thành công.");
                    return true;
                }
                else
                {
                    ShowMessage.ShowWarning("Mật khẩu sai.");
                    return false;
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
            return false;
        }

        public bool CreateAccount(User user)
        {
            if (FindAccount(user) == true)
            {
                ShowMessage.ShowWarning("Tài khoản đã tồn tại, vui lòng chọn tài khoản khác.");
                return false;
            }
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand($"INSERT {table} VALUES ('{user.UserName}', '{user.Password}')", sqlConnection);

                if (insertCMD.ExecuteNonQuery() == 1)
                {
                    ShowMessage.ShowNotification("Tạo tài khoản thành công.");
                    return true;
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
            return false;
        }

        public bool FindAccount(User user)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT COUNT(*) FROM {table} WHERE userName COLLATE Latin1_General_CS_AS = '{user.UserName}'", sqlConnection);

                return (int)selectCMD.ExecuteScalar() != 0;
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

        public void UpdatePasswored(User user)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand updateCMD = new SqlCommand($"UPDATE {table} SET password = '{user.NewPassword}' WHERE userName = '{user.UserName}'", sqlConnection);

                if (updateCMD.ExecuteNonQuery() == 1)
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