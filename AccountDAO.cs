using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
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
            sqlConnection = new SqlConnection(Properties.Settings.Default.connectionStr);
        }

        private static bool Cmd(string cmdStr, string message)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(cmdStr, sqlConnection);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show(message);
                return true;
            }
            sqlConnection.Close();
            return false;
        }

        public static void CreateAccount(string userName, string password, string newPassword)
        {
            if (IsAccount(userName) == true && IsPassword(password, newPassword) == true)
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand checkAccountCmd = new SqlCommand($"SELECT COUNT(*) FROM Account WHERE userName COLLATE Latin1_General_CS_AS = '{userName}'", sqlConnection);

                    if ((int)checkAccountCmd.ExecuteScalar() != 0)
                    {
                        ShowWarning("Tài khoản đã tồn tại, vui lòng chọn tài khoản khác.");
                    }
                    else
                    {
                        SqlCommand insertAccountCmd = new SqlCommand($"INSERT Account VALUES ('{userName}' COLLATE SQL_Latin1_General_CP1_CS_AS, '{password}')", sqlConnection);

                        if (insertAccountCmd.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Tạo tài khoản thành công.", "Thông báo");
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
            }
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
            if (IsPassword(newPassword, newPassword) == true)
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand updatePassword = new SqlCommand($"UPDATE Account SET password = '{newPassword}' WHERE userName COLLATE Latin1_General_CS_AS = '{userName}'", sqlConnection);

                    if(updatePassword.ExecuteNonQuery() == 1)
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

        private static bool IsAccount(string userName)
        {
            if (userName.Length < 5 || userName.Length > 11)
            {
                ShowWarning("Tài khoản phải dài hơn 4 và bé hơn 12 kí tự.");
                return false;
            }
            if (!userName.Any(char.IsLetter))
            {
                ShowWarning("Tài khoản vui lòng có ít nhất 1 chữ cái.");
                return false;
            }
            if (userName.Any(char.IsWhiteSpace))
            {
                ShowWarning("Tài khoản tồn tại khoảng trắng.");
                return false;
            }
            if (Regex.IsMatch(userName, "^[a-z0-9@#!_]+$") == false)
            {
                ShowWarning("Tài khoản không hợp lệ. Chỉ chấp nhận chữ cái viết thường, số, @, #, !, _");
                return false;
            }
            return true;
        }

        private static bool IsPassword(string password, string newPassword)
        {
            if(password != newPassword)
            {
                ShowWarning("Vui lòng nhập lại mật khẩu.");
                return false;
            }
            if (password.Length < 5 || password.Length > 16)
            {
                ShowWarning("Mật khẩu phải dài hơn 4 và bé hơn 16 kí tự.");
                return false;
            }
            if (password.Any(char.IsWhiteSpace) == true)
            {
                ShowWarning("Mật khẩu tồn tại khoảng trắng.");
                return false;
            }
            if(Regex.IsMatch(password, "^[a-z0-9@#!_]+$") == false)
            {
                ShowWarning("Mật khẩu không hợp lệ. Chỉ chấp nhận chữ cái viết thường, số, @, #, !, _");
                return false;
            }    
            return true;
        }
    }
}
