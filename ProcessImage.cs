using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public static class ProcessImage
    {
        public static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        public static Image ByteToImageArray(byte[] bytes)
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        public static bool Comparer(Image image1, Image image2)
        {
            if (image1.Width != image2.Width || image1.Height != image2.Height)
            {
                return false;
            }

            Bitmap bitmap1 = new Bitmap(image1);
            Bitmap bitmap2 = new Bitmap(image2);

            for (int x = 0; x < image1.Width; x++)
            {
                for (int y = 0; y < image1.Height; y++)
                {
                    if (bitmap1.GetPixel(x, y) != bitmap2.GetPixel(x, y))
                    {
                        return false;
                    }
                }
            }

            return true; 
        }
    }
}
