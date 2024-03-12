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
        public AccountDAO(User user) : base("Account", user)
        { }

        public bool Login()
        {
            if (FindAccount() == false)
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

        public bool Insert()
        {
            if (FindAccount() == true)
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

        public bool FindAccount()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT COUNT(*) FROM {table} WHERE userName = '{user.UserName}'", sqlConnection);

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

        public void Update()
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