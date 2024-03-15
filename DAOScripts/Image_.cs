using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Image_
    {
        public User User { get; private set; }
        public int Id { get; private set; }
        public Image Image { get; private set; }
        public byte[] ImageByte { get; private set; }

        public Image_(User user, int id, byte[] imageByte)
        {
            User = user;
            Id = id;
            Image = ProcessImage.ByteToImageArray(imageByte);
            ImageByte = imageByte;
        }

        public Image_(User user, int id, Image image)
        {
            User = user;
            Id = id;
            ImageByte = ProcessImage.ImageToByteArray(image);
            Image = image;
        }
    }
}
