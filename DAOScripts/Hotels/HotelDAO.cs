﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class HotelDAO : DAO
    {
        public HotelDAO() : base("Hotel")
        { }

        public void Access(User user, List<Hotel> hotels, bool isUser = true)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE userName {(isUser == true ? "=" : "<>")} '{user.UserName}'", sqlConnection);
                SqlDataReader reader = selectCMD.ExecuteReader();

                while (reader.Read())
                {
                    hotels.Add(new Hotel(
                        Convert.ToInt32(reader[1]),
                        reader[2].ToString(),
                        reader[3].ToString(),
                        new Address(reader[4].ToString()),
                        (TimeSpan)reader[5],
                        (TimeSpan)reader[6],
                        reader[7].ToString()));
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

        public bool Insert(User user, Hotel hotel)
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

        public bool Update(User user, Hotel hotel)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand updateCMD = new SqlCommand($"UPDATE {table} SET " +
                                                    $"name = N'{hotel.Name}', " +
                                                    $"phone = '{hotel.Phone}', " +
                                                    $"address = N'{hotel.Address.AddressValue}', " +
                                                    $"checkIn = '{hotel.CheckIn}', " +
                                                    $"checkOut = '{hotel.CheckOut}', " +
                                                    $"describe = N'{hotel.Describe}' " +
                                                    $"WHERE userName = '{user.UserName}' and idHotel = '{hotel.IdHotel}'",
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