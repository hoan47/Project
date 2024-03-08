using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class User
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public string NewPassword { get; private set; }
        public string Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Gender { get; private set; }
        public string AddRess { get; private set; }
        public string IdCard { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }

        public User() { }

        public User(string userName)
        {
            UserName = userName;
        }

        public User(string userName, string password, string newPassword)
        {
            UserName = userName;
            Password = password;
            NewPassword = newPassword;
        }

        public ErrorUserInfo IsAccount()
        {
            if (UserName.Length < 5 || UserName.Length > 11)
            {
                ShowMessage.ShowWarning("Tài khoản phải dài hơn 4 và bé hơn 12 kí tự.");
                return ErrorUserInfo.account;
            }
            if (!UserName.Any(char.IsLetter))
            {
                ShowMessage.ShowWarning("Tài khoản vui lòng có ít nhất 1 chữ cái.");
                return ErrorUserInfo.account;
            }
            if (UserName.Any(char.IsWhiteSpace))
            {
                ShowMessage.ShowWarning("Tài khoản tồn tại khoảng trắng.");
                return ErrorUserInfo.account;
            }
            if (Regex.IsMatch(UserName, "^[a-z0-9@#_.]+$") == false)
            {
                ShowMessage.ShowWarning("Tài khoản không hợp lệ. Chỉ chấp nhận chữ cái viết thường, số, ., @, #, _.");
                return ErrorUserInfo.account;
            }
            return ErrorUserInfo.success;
        }

        public ErrorUserInfo IsPassword()
        {
            if (Password.Length < 5 || Password.Length > 16)
            {
                ShowMessage.ShowWarning("Mật khẩu phải dài hơn 4 và bé hơn 16 kí tự.");
                return ErrorUserInfo.password;
            }
            if (Password.Any(char.IsWhiteSpace) == true)
            {
                ShowMessage.ShowWarning("Mật khẩu tồn tại khoảng trắng.");
                return ErrorUserInfo.password;
            }
            if (Regex.IsMatch(Password, "^[a-z0-9@#!_]$") == false)
            {
                ShowMessage.ShowWarning("Mật khẩu không hợp lệ. Chỉ chấp nhận chữ cái viết thường, số, @, #, !, _");
                return ErrorUserInfo.password;
            }
            if (Password != NewPassword)
            {
                ShowMessage.ShowWarning("Vui lòng nhập lại mật khẩu mới.");
                return ErrorUserInfo.newPassWord;
            }
            return ErrorUserInfo.success;
        }

        private void StandardizedName()
        {
            if (Name != null)
            {
                CultureInfo cultureInfo = new CultureInfo("vi-VN", false);
                TextInfo textInfo = cultureInfo.TextInfo;
                Name = textInfo.ToTitleCase(Name.Trim());
            }
        }

        public ErrorUserInfo IsName()
        {
            if(Name.Length < 2 && Name.Split(' ').Length < 2)
            {
                ShowMessage.ShowWarning("Họ tên ít nhất phải có 2 từ");
                return ErrorUserInfo.name;
            }
            if (Regex.IsMatch(Name, "^[a-z]$") == false)
            {
                ShowMessage.ShowWarning("Họ tên chỉ được chứ chữ cái.");
                return ErrorUserInfo.name;
            }
            return ErrorUserInfo.success;
        }

        public ErrorUserInfo IsIdCard()
        {
            if(IdCard.Length != 10)
            {
                ShowMessage.ShowWarning("Chứng minh nhân dân phải có 12 số");
                return ErrorUserInfo.idCard;
            }    
            if(Regex.IsMatch(IdCard, "^[0-9]$") == false)
            {
                ShowMessage.ShowWarning("Chứng minh nhân dân chỉ chứa số");
                return ErrorUserInfo.idCard;
            }
            return ErrorUserInfo.success;
        }

        public ErrorUserInfo IsPhone()
        {
            if (Phone.Length != 10)
            {
                ShowMessage.ShowWarning("Số điện thoại phải có 10 số");
                return ErrorUserInfo.phone;
            }
            if (Regex.IsMatch(Phone, "^(0[0-9])$") == false)
            {
                ShowMessage.ShowWarning("Số điện thoại chỉ chứa số");
                return ErrorUserInfo.phone;
            }
            return ErrorUserInfo.success;
        }

        public ErrorUserInfo IsEmail()
        {
            if (Regex.IsMatch(Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$") == false)
            {
                ShowMessage.ShowWarning("Email không hợp lệ.");
                return ErrorUserInfo.email;
            }
            return ErrorUserInfo.success;
        }
    }

    public enum ErrorUserInfo
    {
        account,
        duplicateAccounts,
        password,
        newPassWord,
        name,
        idCard,
        phone,
        email,
        success,
        error
    }
}
