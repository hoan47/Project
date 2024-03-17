using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public static class ProcessImage
    {
        public static byte[] ImageToByteArray(Image image)
        {
            MemoryStream ms = new MemoryStream();

            try
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ms.Close();
            }
            return null;
        }

        public static Image ByteToImageArray(byte[] bytes)
        {
            MemoryStream ms = null; 

            try
            {
                ms = new MemoryStream(bytes);
                return Image.FromStream(ms);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                ms?.Close();
            }
            return null;
        }

        public static bool Compare(Image image1, Image image2)
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

        static public Image OpenFileImageDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string imagePath = openFileDialog.FileName;
                    Image image = Image.FromFile(imagePath);

                    return image;
                }
                catch (Exception ex)
                {
                    ShowMessage.ShowError("Lỗi: Không thể mở tập tin!" + ex.Message);
                }
            }
            return null;
        }
    }
}
