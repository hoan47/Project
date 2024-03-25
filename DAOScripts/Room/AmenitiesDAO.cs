using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class AmenitiesDAO : DAO
    {
        public AmenitiesDAO() : base("Amenities")
        { }

        public void Access(User user)
        {
            try
            {
                sqlConnection.Open();

                foreach (Hotel hotel in user.Hotels)
                {
                    if (hotel.Rooms == null)
                    {
                        continue;
                    }
                    foreach (Room room in hotel.Rooms)
                    {
                        SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE idRoom = {room.IdRoom}", sqlConnection);
                        SqlDataReader reader = selectCMD.ExecuteReader();
                        List<string> services = new List<string>();

                        while (reader.Read())
                        {
                            if (reader.IsDBNull(1) == false)
                            {
                                services.Add(reader.GetString(1));
                            }
                        }
                        room.UpdateAmenities(services);
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

        public bool Insert(Room room)
        {
            try
            {
                sqlConnection.Open();

                if (room.Amenitiese.Count != 0)
                {
                    foreach (string service in room.Amenitiese)
                    {
                        SqlCommand insertCMD = new SqlCommand($"INSERT INTO {table} VALUES " +
                                                               $"('{room.IdRoom}', " +
                                                               $"N'{service}')",
                                                               sqlConnection);

                        if (insertCMD.ExecuteNonQuery() == 0)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    SqlCommand insertCMD = new SqlCommand($"INSERT INTO {table}(idRoom) VALUES ('{room.IdRoom}')", sqlConnection);
                }
                return true;
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

        public bool Delete(Room room)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand updateCMD = new SqlCommand($"Delete {table} WHERE idRoom = '{room.IdRoom}'",
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
    }
}
