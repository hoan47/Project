using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Project
{
    public static class CheckInfor
    {
        static public bool IsAccount(string userName, out string message)
        {
            if (userName.Length < 5 || userName.Length > 11)
            {
                message = "Tài khoản phải dài hơn 4 và bé hơn 12 kí tự.";
                return false;
            }
            if (!userName.Any(char.IsLetter))
            {
                message = "Tài khoản vui lòng có ít nhất 1 chữ cái.";
                return false;
            }
            if (userName.Any(char.IsWhiteSpace))
            {
                message = "Tài khoản tồn tại khoảng trắng.";
                return false;
            }
            if (Regex.IsMatch(userName, "^[a-z0-9@#_.]+$") == false)
            {
                message = "Tài khoản không hợp lệ. Chỉ chấp nhận chữ cái viết thường, số, ., @, #, _.";
                return false;
            }
            message = "Tài khoản hợp lệ.";
            return true;
        }

        static public bool IsPassword(string password, string newPassword, out string message)
        {
            if (password.Length < 5 || password.Length > 16)
            {
                message = "Mật khẩu phải dài hơn 4 và bé hơn 16 kí tự.";
                return false;
            }
            if (password.Any(char.IsWhiteSpace) == true)
            {
                message = "Mật khẩu tồn tại khoảng trắng.";
                return false;
            }
            if (Regex.IsMatch(password, "^[a-z0-9@#!_]+$") == false)
            {
                message = "Mật khẩu không hợp lệ. Chỉ chấp nhận chữ cái viết thường, số, @, #, !, _";
                return false;
            }
            if (password != newPassword)
            {
                message = "Vui lòng nhập lại mật khẩu mới.";
                return false;
            }
            message = "Mật khẩu hợp lệ.";
            return true;
        }


        static public bool IsName(string name, out string message)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                message = "Họ tên không được để trống.";
                return false;
            }
            string[] nameParts = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (nameParts.Length < 2)
            {
                message = "Họ tên phải có ít nhất 2 từ.";
                return false;
            }
            foreach (string part in nameParts)
            {
                if (Regex.IsMatch(part, @"^[\p{L}]+$") == false)
                {
                    message = "Họ tên chỉ được chứa chữ cái có dấu hoặc không có dấu.";
                    return false;
                }
            }
            message = "Họ tên hợp lệ.";
            return true;
        }

        static public bool IsAddRess(string provinceAndDistrict, out string message)
        {
            if (provinceAndDistrict?.Count(c => c == ',') != 1)
            {
                message = "Vui lòng chọn đầy đủ địa chỉ.";
                return false;
            }
            message = "Địa chỉ hợp lệ.";
            return true;
        }

        static public bool IsIdCard(string idCard, out string message)
        {
            if (string.IsNullOrWhiteSpace(idCard))
            {
                message = "Chứng minh nhân dân không được để trống.";
                return false;
            }
            if (idCard.Length != 12)
            {
                message = "Chứng minh nhân dân phải có 12 số";
                return false;
            }
            if (!Regex.IsMatch(idCard, "^[0-9]+$"))
            {
                message = "Chứng minh nhân dân chỉ chứa số";
                return false;
            }
            message = "Chứng minh hợp lệ.";
            return true;
        }


        static public bool IsEmail(string email, out string message)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                message = "Email không được để trống.";
                return false;
            }
            if (!Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                message = "Email không hợp lệ.";
                return false;
            }
            message = "Email hợp lệ.";
            return true;
        }

        static public bool IsPhone(string phone, out string message)
        {
            if (string.IsNullOrWhiteSpace(phone))
            {
                message = "Số điện thoại không được để trống.";
                return false;
            }

            if (phone.Length != 10)
            {
                message = "Số điện thoại phải có 10 số.";
                return false;
            }

            if (phone[0] != '0')
            {
                message = "Số điện thoại phải bắt đầu bằng số 0.";
                return false;
            }

            if (!Regex.IsMatch(phone, "^[0-9]+$"))
            {
                message = "Số điện thoại chỉ chứa số.";
                return false;
            }
            message = "Số điện thoại hợp lệ.";
            return true;
        }
    }
}
