using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class HotelDAO : DAO
    {
        public HotelDAO(User user) : base("Hotel", user)
        { }

        public void Access()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE userName = '{user.UserName}'", sqlConnection);
                SqlDataReader reader = selectCMD.ExecuteReader();

                while (reader.Read())
                {
                    user.AddHotel(new Hotel(
                        user,
                        reader[1].ToString(),
                        reader[2].ToString(),
                        reader[3].ToString(),
                        (TimeSpan)reader[4],
                        (bool)reader[5],
                        (bool)reader[6],
                        (bool)reader[7],
                        (bool)reader[8],
                        reader[9].ToString(),
                        Convert.ToInt32(reader[10])));
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

        public bool Insert()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand($"insert {table} values (" +
                       $"'{user.UserName}', " +
                       $"'{user.Hotels.Last()?.Name}', " +
                       $"'{user.Hotels.Last()?.Phone}', " +
                       $"'{user.Hotels.Last()?.Address}', " +
                       $"'{user.Hotels.Last()?.CheckInOut.ToString("HH:mm:ss")}', " +
                       $"'{user.Hotels.Last()?.IsFood}', " +
                       $"'{user.Hotels.Last()?.IsPool}', " +
                       $"'{user.Hotels.Last()?.IsCarPark}', " +
                       $"'{user.Hotels.Last()?.IsCook}', " +
                       $"'{user.Hotels.Last()?.Describe}')",
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

        public bool Update(Hotel hotel)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("update {table} "  +
                               $"name = '{hotel.Name}', phone = '{hotel.Phone}', address = '{hotel.Address}', " +
                               $"checkInOut = '{hotel.CheckInOut}', isFood = '{hotel.IsFood}', isPool = '{hotel.IsPool}', " +
                               $"isCarPack = '{hotel.IsCarPark}', isCook = '{hotel.IsCook}', descride = '{hotel.Describe}' " +
                               $"WHERE Id = '{hotel.Id}'", sqlConnection);

                if(command.ExecuteNonQuery() == 1)
                {
                    ShowMessage.ShowNotification("Cập nhật thông tin khách sạn thành công.");
                    return true;
                }
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