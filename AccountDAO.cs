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
    static class AccountDAO
    {
<<<<<<< Updated upstream
        private static SqlConnection sqlConnection;

        static AccountDAO()
        {
            sqlConnection = new SqlConnection($@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = {AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "DatabaseProject.mdf"}; Integrated Security = True");
        }

        public static EErrorCreate CreateAccount(string userName, string password, string newPassword)
=======
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
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
=======
                ShowMessage.ShowError(e.Message);
>>>>>>> Stashed changes
            }
            finally
            {
                sqlConnection.Close();
            }
            return ErrorUserInfo.error;
        }

<<<<<<< Updated upstream
        public static bool FindAccount(string userName)
=======
        public bool FindAccount()
>>>>>>> Stashed changes
        {
            try
            {
                sqlConnection.Open();
                SqlCommand checkAccountCmd = new SqlCommand($"SELECT COUNT(*) FROM Account WHERE userName COLLATE Latin1_General_CS_AS = '{FController.Instance.user.UserName}'", sqlConnection);

                return (int)checkAccountCmd.ExecuteScalar() != 0;
            }
            catch (Exception e)
            {
<<<<<<< Updated upstream
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
=======
                ShowMessage.ShowError(e.Message);
>>>>>>> Stashed changes
            }
            finally
            {
                sqlConnection.Close();
            }
            return false;
        }

<<<<<<< Updated upstream
        public static void UpdatePasswored(string userName, string newPassword)
=======
        public void UpdatePasswored()
>>>>>>> Stashed changes
        {
            try
            {
                sqlConnection.Open();
                SqlCommand updatePassword = new SqlCommand($"UPDATE Account SET password = '{FController.Instance.user.NewPassword}' WHERE userName = '{FController.Instance.user.UserName}'", sqlConnection);

                if (updatePassword.ExecuteNonQuery() == 1)
                {
<<<<<<< Updated upstream
                    MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        private static void ShowWarning(string message)
        {
            MessageBox.Show(message, "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static EErrorCreate IsAccount(string userName)
        {
            if (userName.Length < 5 || userName.Length > 11)
=======
                    ShowMessage.ShowNotification("Cập nhật mật khẩu mới thành công.");
                }
            }
            catch (Exception e)
>>>>>>> Stashed changes
            {
                ShowMessage.ShowError(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
<<<<<<< Updated upstream
            if (userName.Any(char.IsWhiteSpace))
            {
                ShowWarning("Tài khoản tồn tại khoảng trắng.");
                return EErrorCreate.account;
            }
            if (Regex.IsMatch(userName, "^[a-z0-9@#_.]+$") == false)
            {
                ShowWarning("Tài khoản không hợp lệ. Chỉ chấp nhận chữ cái viết thường, số, ., @, #, _.");
                return EErrorCreate.account;
            }
            return EErrorCreate.success;
        }

        private static EErrorCreate IsPassword(string password, string newPassword)
        {
            if (password.Length < 5 || password.Length > 16)
            {
                ShowWarning("Mật khẩu phải dài hơn 4 và bé hơn 16 kí tự.");
                return EErrorCreate.password;
            }
            if (password.Any(char.IsWhiteSpace) == true)
            {
                ShowWarning("Mật khẩu tồn tại khoảng trắng.");
                return EErrorCreate.password;
            }
            if (Regex.IsMatch(password, "^[a-z0-9@#!_]+$") == false)
            {
                ShowWarning("Mật khẩu không hợp lệ. Chỉ chấp nhận chữ cái viết thường, số, @, #, !, _");
                return EErrorCreate.password;
            }
            if (password != newPassword)
            {
                ShowWarning("Vui lòng nhập lại mật khẩu mới.");
                return EErrorCreate.password;
            }
            return EErrorCreate.success;
        }

        public enum EErrorCreate
        {
            account,
            duplicateAccounts,
            password,
            success,
            error
=======
>>>>>>> Stashed changes
        }
    }
}
