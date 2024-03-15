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
        public ImageHotelDAO(User user) : base("ImageHotel", user)
        { }

        public void Access()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE userName = '{user.UserName}'", sqlConnection);
                SqlDataReader reader = selectCMD.ExecuteReader();
                Hotel hotel = null;

                while (reader.Read())
                {
                    Image_ image_ = new Image_(user, (int)reader[1], (byte[])reader[2]);
  
                    if (hotel == null || hotel.IdHotel != (int)reader[1])
                    {
                        hotel = user.Hotels.Find(h => h.IdHotel == (int)reader[1]);
                    }
                    hotel.AddImage(new Image_(user, (int)reader[1], (byte[])reader[2]));
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

        public bool Insert(Image_ image)
        {
            try
            {
                sqlConnection.Open();

                SqlCommand insertCMD = new SqlCommand($"INSERT INTO {table} " +
                                                       $"(userName, idHotel, imageBytes) " +
                                                       $"VALUES " +
                                                       $"(N'{user.UserName}', '{image.Id}', @imageBytes)", 
                                                       sqlConnection);

                insertCMD.Parameters.Add("@imageBytes", SqlDbType.VarBinary).Value = image.ImageByte;

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

        public bool Update(Image_ image)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand updateCMD = new SqlCommand($"UPDATE {table} SET " +
                                                    $"imageBytes = '{image.ImageByte}', " +
                                                    $"WHERE userName = '{user.UserName}' and idHotel = '{image.Id}'",
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

        public bool Delete(Image_ image)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand delteCMD = new SqlCommand($"DELETE FROM {table} " +
                                                      $"WHERE userName = '{user.UserName}' AND idHotel = '{image.Id}' AND imageBytes = @imageBytes",
                                                      sqlConnection);

                delteCMD.Parameters.Add("@imageBytes", SqlDbType.VarBinary).Value = image.ImageByte;
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
