using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
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
