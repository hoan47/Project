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
    public class ImageRoomDAO : DAO
    {
        public ImageRoomDAO() : base("ImageRoom")
        { }

        public void Access(List<Hotel> hotels)
        {
            try
            {
                sqlConnection.Open();

                foreach (Hotel hotel in hotels)
                {
                    if(hotel.Rooms == null)
                    {
                        continue;
                    }
                    foreach (Room room in hotel.Rooms)
                    {
                        SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE idRoom = '{room.IdRoom}'", sqlConnection);
                        SqlDataReader reader = selectCMD.ExecuteReader();

                        while (reader.Read())
                        {
                            room.AddImage(new Image_((int)reader[1], (byte[])reader[2], ProcessImage.ByteToImageArray((byte[])reader[2])));
                        }
                        reader.Close();
                    }
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
        }

        public bool Insert(Room room, Image_ image)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand($"INSERT {table} " +
                                                       $"VALUES " +
                                                       $"('{room.IdRoom}', '{image.IdImage}', @imageBytes)",
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

        public bool Delete(Image_ image)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand delteCMD = new SqlCommand($"DELETE FROM {table} " +
                                                      $"WHERE idImage = {image.IdImage}",
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
