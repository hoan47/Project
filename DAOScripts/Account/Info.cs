using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Info
    {
        public string UserName { get; private set; }
        public string Name { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public string Gender { get; private set; }
        public Address Address { get; private set; }
        public string IdCard { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public byte[] ImageBytes { get; private set; }
        public Image Image { get; private set; }

        public Info(string name, DateTime dateOfBirth, string gender, Address address, string idCard, string email, string phone, byte[] imageBytes)
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
        }
    }
}
