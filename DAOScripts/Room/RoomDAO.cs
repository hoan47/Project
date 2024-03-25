using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class RoomDAO : DAO
    {
        public RoomDAO() : base("Room")
        { }

        public void Access(User user)
        {
            try
            {
                sqlConnection.Open();

                foreach (Hotel hotel in user.Hotels)
                {
                    SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE idHotel = '{hotel.IdHotel}'", sqlConnection);
                    SqlDataReader reader = selectCMD.ExecuteReader();

                    while (reader.Read())
                    {
                        hotel.AddRoom(new Room(
                            (int)reader[1],
                            reader[2].ToString(),
                            (int)reader[3],
                            (int)reader[4],
                            (int)reader[5],
                            (int)reader[6],
                            (int)reader[7],
                            Room.GetStatus((int)reader[8])));
                    }
                    reader.Close();
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

        public bool Insert(Hotel hotel, Room room)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand($"INSERT INTO {table} " +
                                                       $"VALUES(" +
                                                       $"'{hotel.IdHotel}', " +
                                                       $"'{room.IdRoom}', " +
                                                       $"N'{room.Name}', " +
                                                       $"'{room.NumberRoom}', " +
                                                       $"'{room.NumberBeds}', " +
                                                       $"'{room.NumberPeople}', " +
                                                       $"'{room.Acreage}', " +
                                                       $"'{room.Price}', " +
                                                       $"'{room.GetStatus()}')",
                                                       sqlConnection);

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

        public bool Update(Room room)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand updateCMD = new SqlCommand($"UPDATE {table} SET " +
                                                    $"name = N'{room.Name}', " +
                                                    $"numberRoom = '{room.NumberRoom}', " +
                                                    $"numberBeds = '{room.NumberBeds}', " +
                                                    $"numberPeople = '{room.NumberPeople}', " +
                                                    $"acreage = '{room.Acreage}', " +
                                                    $"price = '{room.Price}', " +
                                                    $"status = '{room.GetStatus()}' " +
                                                    $"WHERE idRoom = '{room.IdRoom}'",
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
