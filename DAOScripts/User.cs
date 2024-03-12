using System;
using System.Collections.Generic;
using System.Drawing;
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
        public string Address { get; private set; }
        public string IdCard { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public int ImageId { get; private set; }
        public Image Image { get; private set; }
        public Client Client { get; private set; }

        public User() 
        { }

        public void Update(string userName)
        {
            UserName = userName;
        }

        public void Update(string userName, string password, string newPassword)
        {
            UserName = userName;
            Password = password;
            NewPassword = newPassword;
        }

        public void UpdateInfo(string name, DateTime dateOfBirth, string gender, string address, string idCard, string email, string phone, Image image)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            IdCard = idCard;
            Email = email;
            Phone = phone;
            Image = image;
            StandardizedName();
            InitializeClient();
        }

        public void UpdateInfo(string name, DateTime dateOfBirth, string gender, string address, string idCard, string email, string phone, int imageID, Image image)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            IdCard = idCard;
            Email = email;
            Phone = phone;
            ImageId = imageID;
            Image = image;
            StandardizedName();
            InitializeClient();
        }

        private void InitializeClient()
        {
            if (Client == null && Name != null && Address != null && IdCard != null && Email != null && Phone != null)
            {
                Client = new Client(this);
            }
        }

        public Image GetImageNormal()
        {
            return Gender == "Nam" ? Properties.Resources.man : Properties.Resources.girl;
        }

        public bool IsAccount()
        {
            if (UserName.Length < 5 || UserName.Length > 11)
            {
                ShowMessage.ShowWarning("Tài khoản phải dài hơn 4 và bé hơn 12 kí tự.");
                return false;
            }
            if (!UserName.Any(char.IsLetter))
            {
                ShowMessage.ShowWarning("Tài khoản vui lòng có ít nhất 1 chữ cái.");
                return false;
            }
            if (UserName.Any(char.IsWhiteSpace))
            {
                ShowMessage.ShowWarning("Tài khoản tồn tại khoảng trắng.");
                return false;
            }
            if (Regex.IsMatch(UserName, "^[a-z0-9@#_.]+$") == false)
            {
                ShowMessage.ShowWarning("Tài khoản không hợp lệ. Chỉ chấp nhận chữ cái viết thường, số, ., @, #, _.");
                return false;
            }
            return true;
        }

        public bool IsPassword()
        {
            if (Password.Length < 5 || Password.Length > 16)
            {
                ShowMessage.ShowWarning("Mật khẩu phải dài hơn 4 và bé hơn 16 kí tự.");
                return false;
            }
            if (Password.Any(char.IsWhiteSpace) == true)
            {
                ShowMessage.ShowWarning("Mật khẩu tồn tại khoảng trắng.");
                return false;
            }
            if (Regex.IsMatch(Password, "^[a-z0-9@#!_]+$") == false)
            {
                ShowMessage.ShowWarning("Mật khẩu không hợp lệ. Chỉ chấp nhận chữ cái viết thường, số, @, #, !, _");
                return false;
            }
            if (Password != NewPassword)
            {
                ShowMessage.ShowWarning("Vui lòng nhập lại mật khẩu mới.");
                return false;
            }
            return true;
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

        public bool IsName()
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                ShowMessage.ShowWarning("Họ tên không được để trống.");
                return false;
            }

            string[] nameParts = Name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (nameParts.Length < 2)
            {
                ShowMessage.ShowWarning("Họ tên phải có ít nhất 2 từ.");
                return false;
            }

            foreach (string part in nameParts)
            {
                if (!Regex.IsMatch(part, @"^[\p{L}]+$"))
                {
                    ShowMessage.ShowWarning("Họ tên chỉ được chứa chữ cái có dấu hoặc không có dấu.");
                    return false;
                }
            }

            return true;
        }

        public bool IsAddress()
        {
            if (string.IsNullOrWhiteSpace(Address))
            {
                ShowMessage.ShowWarning("Địa chỉ không được để trống.");
                return false;
            }
            return true;
        }

        public bool IsIdCard()
        {
            if (string.IsNullOrWhiteSpace(IdCard))
            {
                ShowMessage.ShowWarning("Chứng minh nhân dân không được để trống.");
                return false;
            }

            if (IdCard.Length != 12)
            {
                ShowMessage.ShowWarning("Chứng minh nhân dân phải có 12 số");
                return false;
            }

            if (!Regex.IsMatch(IdCard, "^[0-9]+$"))
            {
                ShowMessage.ShowWarning("Chứng minh nhân dân chỉ chứa số");
                return false;
            }

            return true;
        }

        public bool IsPhone()
        {
            if (string.IsNullOrWhiteSpace(Phone))
            {
                ShowMessage.ShowWarning("Số điện thoại không được để trống.");
                return false;
            }

            if (Phone.Length != 10)
            {
                ShowMessage.ShowWarning("Số điện thoại phải có 10 số");
                return false;
            }

            if (Phone[0] != '0')
            {
                ShowMessage.ShowWarning("Số điện thoại phải bắt đầu bằng số 0");
                return false;
            }

            if (!Regex.IsMatch(Phone, "^[0-9]+$"))
            {
                ShowMessage.ShowWarning("Số điện thoại chỉ chứa số");
                return false;
            }

            return true;
        }

        public bool IsEmail()
        {
            if (string.IsNullOrWhiteSpace(Email))
            {
                ShowMessage.ShowWarning("Email không được để trống.");
                return false;
            }

            if (!Regex.IsMatch(Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                ShowMessage.ShowWarning("Email không hợp lệ.");
                return false;
            }

            return true;
        }
    }
}
