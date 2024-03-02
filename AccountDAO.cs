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
        private static SqlConnection sqlConnection;

        static AccountDAO()
        {
            sqlConnection = new SqlConnection($@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = {AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "DatabaseProject.mdf"}; Integrated Security = True");
        }

        public static EErrorCreate CreateAccount(string userName, string password, string newPassword)
        {
            if (IsAccount(userName) == EErrorCreate.account)
            {
                return EErrorCreate.account;
            }
            if (IsPassword(password, newPassword) == EErrorCreate.password)
            {
                return EErrorCreate.password;
            }
            try
            {
                sqlConnection.Open();
                SqlCommand checkAccountCmd = new SqlCommand($"SELECT COUNT(*) FROM Account WHERE userName = '{userName}'", sqlConnection);

                if ((int)checkAccountCmd.ExecuteScalar() != 0)
                {
                    ShowWarning("Tài khoản đã tồn tại, vui lòng chọn tài khoản khác.");
                    return EErrorCreate.duplicateAccounts;
                }
                else
                {
                    SqlCommand insertAccountCmd = new SqlCommand($"INSERT Account VALUES ('{userName}', '{password}')", sqlConnection);

                    if (insertAccountCmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Tạo tài khoản thành công.", "Thông báo");
                        return EErrorCreate.success;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
            return EErrorCreate.error;
        }

        public static bool FindAccount(string userName)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand checkAccountCmd = new SqlCommand($"SELECT COUNT(*) FROM Account WHERE userName COLLATE Latin1_General_CS_AS = '{userName}'", sqlConnection);

                return (int)checkAccountCmd.ExecuteScalar() != 0;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi: " + e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
            return false;
        }

        public static void UpdatePasswored(string userName, string newPassword)
        {
            if (IsPassword(newPassword, newPassword) == EErrorCreate.success)
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand updatePassword = new SqlCommand($"UPDATE Account SET password = '{newPassword}' WHERE userName COLLATE Latin1_General_CS_AS = '{userName}'", sqlConnection);

                    if (updatePassword.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Cập nhật mật khẩu mới thành công.", "Thông báo");
                    }
                }
                catch (Exception e)
                {
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
            {
                ShowWarning("Tài khoản phải dài hơn 4 và bé hơn 12 kí tự.");
                return EErrorCreate.account;
            }
            if (!userName.Any(char.IsLetter))
            {
                ShowWarning("Tài khoản vui lòng có ít nhất 1 chữ cái.");
                return EErrorCreate.account;
            }
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
        }
    }
}
