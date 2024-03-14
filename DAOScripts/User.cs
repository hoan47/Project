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
        public Address Address { get; private set; }
        public string IdCard { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public int ImageId { get; private set; }
        public Image Image { get; private set; }
        public Client Client { get; private set; }
        public List<Hotel> Hotels { get; private set; }

        public User() 
        { }

        public void UpdateUserName(string userName)
        {
            Name = userName;
        }

        public void UpdateClient(Client client)
        {
            Client = client;
        }

        public void UpdateUserPassword(string userName, string password, string newPassword)
        {
            UserName = userName;
            Password = password;
            NewPassword = newPassword;
        }

        public void UpdateInfo(string name, DateTime dateOfBirth, string gender, Address address, string idCard, string email, string phone, Image image)
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
        }

        public void UpdateInfo(string name, DateTime dateOfBirth, string gender, Address address, string idCard, string email, string phone, int imageID, Image image)
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
        }

        public void AddHotel(Hotel hotel)
        {
            if (Hotels == null)
            {
                Hotels = new List<Hotel>();
            }
            Hotels.Add(hotel);
        }

        private void StandardizedName()
        {
            CultureInfo cultureInfo = new CultureInfo("vi-VN", false);
            TextInfo textInfo = cultureInfo.TextInfo;
            string[] words = Name.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = textInfo.ToTitleCase(words[i].ToLower());
            }
            Name = string.Join(" ", words);
        }

        public Image GetImageNormal()
        {
            return Gender == "Nam" ? Properties.Resources.man : Properties.Resources.girl;
        }

        public bool IsAccount()
        {
            return CheckInfo.IsAccount(UserName);
        }

        public bool IsPassword()
        {
            return CheckInfo.IsPassword(Password, NewPassword);
        }

        public bool IsName()
        {
            return CheckInfo.IsName(Name);
        }

        public bool IsAddress()
        {
            return Address.IsAddRess();
        }

        public bool IsIdCard()
        {
            return CheckInfo.IsIdCard(IdCard);
        }

        public bool IsPhone()
        {
            return CheckInfo.IsPhone(Phone);
        }

        public bool IsEmail()
        {
            return CheckInfo.IsEmail(Email);
        }
    }
}