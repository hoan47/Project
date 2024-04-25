using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project
{
    public class RentalDAO  : DAO
    {
        public RentalDAO() : base("Rental")
        { }
        public void Access(List<Hotel> hotels)
        {
            try
            {
                sqlConnection.Open();
                foreach (Hotel hotel in hotels)
                {
                    foreach (Room room in hotel.Rooms)
                    {
                        SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE idRoom = '{room.IdRoom}'", sqlConnection);
                        SqlDataReader reader = selectCMD.ExecuteReader();
                        while (reader.Read())
                        {
                            room.AddCheckInOuts((DateTime)reader[2], (DateTime)reader[3]);
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
        public bool Insert(User user, Room room, DateTime firstDay, DateTime lastDay)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand($"INSERT INTO {table} " +
                                                       $"VALUES " +
                                                       $"('{room.IdRoom}', " +
                                                       $"'{user.UserName}', " +
                                                       $"'{firstDay.Date}', " +
                                                       $"'{lastDay.Date}')",
                                                       sqlConnection);

                return insertCMD.ExecuteNonQuery() == 1;
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

    }
}
