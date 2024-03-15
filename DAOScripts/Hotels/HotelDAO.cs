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
                        Convert.ToInt32(reader[1]),
                        reader[2].ToString(),
                        reader[3].ToString(),
                        new Address(reader[4].ToString()),
                        (TimeSpan)reader[5],
                        (TimeSpan)reader[6],
                        (bool)reader[7],
                        (bool)reader[8],
                        (bool)reader[9],
                        (bool)reader[10],
                        (bool)reader[11],
                        (bool)reader[12],
                        (bool)reader[13],
                        (bool)reader[14],
                        reader[15].ToString(),
                        null));
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

        public bool Insert(Hotel hotel)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand($"INSERT INTO {table} " +
                                                       $"VALUES " +
                                                       $"('{user.UserName}', " +
                                                       $"'{hotel.IdHotel}', " +
                                                       $"N'{hotel.Name}', " +
                                                       $"'{hotel.Phone}', " +
                                                       $"N'{hotel.Address.AddressValue}', " +
                                                       $"'{hotel.CheckIn.ToString()}', " +
                                                       $"'{hotel.CheckOut.ToString()}', " +
                                                       $"'{hotel.IsPool}', " +
                                                       $"'{hotel.IsFoodServingArea}', " +
                                                       $"'{hotel.IsCarPark}', " +
                                                       $"'{hotel.IsWifi}', " +
                                                       $"'{hotel.IsServeFullTime}', " +
                                                       $"'{hotel.IsLaundryService}', " +
                                                       $"'{hotel.IsSmokingArea}', " +
                                                       $"'{hotel.IsPark}', " +
                                                       $"N'{hotel.Describe}')",
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
                SqlCommand updateCMD = new SqlCommand($"UPDATE {table} SET " +
                                                    $"name = N'{hotel.Name}', " +
                                                    $"phone = '{hotel.Phone}', " +
                                                    $"address = N'{hotel.Address.AddressValue}', " +
                                                    $"checkIn = '{hotel.CheckIn.ToString()}', " +
                                                    $"checkOut = '{hotel.CheckOut.ToString()}', " +
                                                    $"isPool = '{hotel.IsPool}', " +
                                                    $"isFoodServingArea = '{hotel.IsFoodServingArea}', " +
                                                    $"isCarPark = '{hotel.IsCarPark}', " +
                                                    $"isWifi = '{hotel.IsWifi}', " +
                                                    $"isServeFullTime = '{hotel.IsServeFullTime}', " +
                                                    $"isSmokingArea = '{hotel.IsSmokingArea}', " +
                                                    $"isLaundryService = '{hotel.IsLaundryService}', " +
                                                    $"isPark = '{hotel.IsPark}', " +
                                                    $"describe = N'{hotel.Describe}' " +
                                                    $"WHERE userName = '{hotel.User.UserName}' and idHotel = '{hotel.IdHotel}'",
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