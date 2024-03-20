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
        public byte[] ImageBytes { get; private set; }
        public Image Image { get; private set; }
        public Client Client { get; private set; }
        public List<Hotel> Hotels { get; private set; }

        public User() 
        { }

        public void UpdateUserName(string userName)
        {
            UserName = userName;
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

        public void UpdateInfor(string name, DateTime dateOfBirth, string gender, Address address, string idCard, string email, string phone, byte[] imageBytes)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            IdCard = idCard;
            Email = email;
            Phone = phone;
            ImageBytes = imageBytes;
            Image = ProcessImage.ByteToImageArray(imageBytes);
            StandardizedName();
        }

        public void UpdateInfor(string name, DateTime dateOfBirth, string gender, Address address, string idCard, string email, string phone, byte[] imageBytes, Image image)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            IdCard = idCard;
            Email = email;
            Phone = phone;
            ImageBytes = imageBytes;
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

        public int SelectNewIdHotel()
        {
            return Hotels == null ? 0 : Hotels.Max(h => h.IdHotel) + 1;
        }

        public Hotel GetIndex(int index)
        {
            return Hotels == null ? null : 0 <= index && index < Hotels.Count ? Hotels[index] : null;
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

        public bool IsAccount(out string massage)
        {
            return CheckInfor.IsAccount(UserName, out massage);
        }

        public bool IsPassword(out string massage)
        {
            return CheckInfor.IsPassword(Password, NewPassword, out massage);
        }

        public bool IsName(out string massage)
        {
            return CheckInfor.IsName(Name, out massage);
        }

        public bool IsAddress(out string massage)
        {
            return Address.IsAddRess(out massage);
        }

        public bool IsIdCard(out string massage)
        {
            return CheckInfor.IsIdCard(IdCard, out massage);
        }

        public bool IsPhone(out string massage)
        {
            return CheckInfor.IsPhone(Phone, out massage);
        }

        public bool IsEmail(out string massage)
        {
            return CheckInfor.IsEmail(Email, out massage);
        }
    }
}