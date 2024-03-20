using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class ImageHotelDAO : DAO
    {
        public ImageHotelDAO() : base("ImageHotel")
        { }

        public void Access()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE userName = '{FController.Instance.User.UserName}'", sqlConnection);
                SqlDataReader reader = selectCMD.ExecuteReader();
                Hotel hotel = null;

                while (reader.Read())
                {
                    if (hotel == null || hotel.IdHotel != (int)reader[1])
                    {
                        hotel = FController.Instance.User.Hotels.Find(h => h.IdHotel == (int)reader[1]);
                    }
                    hotel.AddImage(new Image_((int)reader[2], (byte[])reader[3], ProcessImage.ByteToImageArray((byte[])reader[3])));
                }
                reader.Close();
            }
            catch (Exception e)
            {
                ShowMessage.ShowError(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public bool Insert(Hotel hotel, Image_ image)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand($"INSERT {table} " +
                                                       $"VALUES " +
                                                       $"('{FController.Instance.User.UserName}', '{hotel.IdHotel}', '{image.IdImage}', @imageBytes)", 
                                                       sqlConnection);

                insertCMD.Parameters.Add("@imageBytes", SqlDbType.VarBinary).Value = image.ImageBytes;

                if (insertCMD.ExecuteNonQuery() == 1)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                ShowMessage.ShowError(e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return false;
        }

        public bool Delete(Hotel hotel, Image_ image)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand delteCMD = new SqlCommand($"DELETE FROM {table} " +
                                                      $"WHERE userName = '{FController.Instance.User.UserName}' and idHotel = {hotel.IdHotel} and idImage = {image.IdImage}",
                                                      sqlConnection);

                return delteCMD.ExecuteNonQuery() == 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return false;
        }
    }
}
