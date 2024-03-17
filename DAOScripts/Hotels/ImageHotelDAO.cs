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
                    hotel.AddImage(ProcessImage.ByteToImageArray((byte[])reader[2]));
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

        public bool Insert(Hotel hotel, Image image)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand insertCMD = new SqlCommand($"INSERT INTO {table} " +
                                                       $"(userName, idHotel, imageBytes) " +
                                                       $"VALUES " +
                                                       $"(N'{FController.Instance.User.UserName}', '{hotel.IdHotel}', @imageBytes)", 
                                                       sqlConnection);

                insertCMD.Parameters.Add("@imageBytes", SqlDbType.VarBinary).Value = ProcessImage.ImageToByteArray(image);

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

        public bool Update(Hotel hotel, Image image)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand updateCMD = new SqlCommand($"UPDATE {table} SET " +
                                                    $"imageBytes = '{ProcessImage.ImageToByteArray(image)}', " +
                                                    $"WHERE userName = '{FController.Instance.User.UserName}' and idHotel = '{hotel.IdHotel}'",
                                                    sqlConnection);

                return updateCMD.ExecuteNonQuery() == 1;
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

        public bool Delete(Hotel hotel, Image image)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand delteCMD = new SqlCommand($"DELETE FROM {table} " +
                                                      $"WHERE userName = '{FController.Instance.User.UserName}' AND idHotel = '{hotel.IdHotel}' AND imageBytes = @imageBytes",
                                                      sqlConnection);

                delteCMD.Parameters.Add("@imageBytes", SqlDbType.VarBinary).Value = ProcessImage.ImageToByteArray(image);
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
