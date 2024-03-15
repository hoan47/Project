using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project
{
    public static class CheckInfo
    {

        static public bool IsAccount(string userName)
        {
            if (userName.Length < 5 || userName.Length > 11)
            {
                ShowMessage.ShowWarning("Tài khoản phải dài hơn 4 và bé hơn 12 kí tự.");
                return false;
            }
            if (!userName.Any(char.IsLetter))
            {
                ShowMessage.ShowWarning("Tài khoản vui lòng có ít nhất 1 chữ cái.");
                return false;
            }
            if (userName.Any(char.IsWhiteSpace))
            {
                ShowMessage.ShowWarning("Tài khoản tồn tại khoảng trắng.");
                return false;
            }
            if (Regex.IsMatch(userName, "^[a-z0-9@#_.]+$") == false)
            {
                ShowMessage.ShowWarning("Tài khoản không hợp lệ. Chỉ chấp nhận chữ cái viết thường, số, ., @, #, _.");
                return false;
            }
            return true;
        }

        static public bool IsPassword(string password, string newPassword)
        {
            if (password.Length < 5 || password.Length > 16)
            {
                ShowMessage.ShowWarning("Mật khẩu phải dài hơn 4 và bé hơn 16 kí tự.");
                return false;
            }
            if (password.Any(char.IsWhiteSpace) == true)
            {
                ShowMessage.ShowWarning("Mật khẩu tồn tại khoảng trắng.");
                return false;
            }
            if (Regex.IsMatch(password, "^[a-z0-9@#!_]+$") == false)
            {
                ShowMessage.ShowWarning("Mật khẩu không hợp lệ. Chỉ chấp nhận chữ cái viết thường, số, @, #, !, _");
                return false;
            }
            if (password != newPassword)
            {
                ShowMessage.ShowWarning("Vui lòng nhập lại mật khẩu mới.");
                return false;
            }
            return true;
        }


        static public bool IsName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                ShowMessage.ShowWarning("Họ tên không được để trống.");
                return false;
            }
            string[] nameParts = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (nameParts.Length < 2)
            {
                ShowMessage.ShowWarning("Họ tên phải có ít nhất 2 từ.");
                return false;
            }
            foreach (string part in nameParts)
            {
                if (Regex.IsMatch(part, @"^[\p{L}]+$") == false)
                {
                    ShowMessage.ShowWarning("Họ tên chỉ được chứa chữ cái có dấu hoặc không có dấu.");
                    return false;
                }
            }
            return true;
        }

        static public bool IsAddRess(string provinceAndDistrict)
        {
            if (provinceAndDistrict?.Count(c => c == ',') != 1)
            {
                ShowMessage.ShowWarning("Vui lòng chọn đầy đủ địa chỉ.");
                return false;
            }
            return true;
        }

        static public bool IsIdCard(string idCard)
        {
            if (string.IsNullOrWhiteSpace(idCard))
            {
                ShowMessage.ShowWarning("Chứng minh nhân dân không được để trống.");
                return false;
            }
            if (idCard.Length != 12)
            {
                ShowMessage.ShowWarning("Chứng minh nhân dân phải có 12 số");
                return false;
            }
            if (!Regex.IsMatch(idCard, "^[0-9]+$"))
            {
                ShowMessage.ShowWarning("Chứng minh nhân dân chỉ chứa số");
                return false;
            }
            return true;
        }


        static public bool IsEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                ShowMessage.ShowWarning("Email không được để trống.");
                return false;
            }
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                ShowMessage.ShowWarning("Email không hợp lệ.");
                return false;
            }

            return true;
        }

        static public bool IsPhone(string phone)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                ShowMessage.ShowWarning("Số điện thoại không được để trống.");
                return false;
            }

            if (phone.Length != 10)
            {
                ShowMessage.ShowWarning("Số điện thoại phải có 10 số");
                return false;
            }

            if (phone[0] != '0')
            {
                ShowMessage.ShowWarning("Số điện thoại phải bắt đầu bằng số 0");
                return false;
            }

            if (!Regex.IsMatch(phone, "^[0-9]+$"))
            {
                ShowMessage.ShowWarning("Số điện thoại chỉ chứa số");
                return false;
            }
            return true;
        }
    }
}
