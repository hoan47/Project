using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class NotificationDAO : DAO
    {
        public NotificationDAO() : base("Notification")
        { }

        public void Access(User user, List<Notification> notifications)
        {
            notifications.Clear();
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE userNameReceiver = '{user.UserName}' ", sqlConnection);
                SqlDataReader reader = selectCMD.ExecuteReader();

                while (reader.Read())
                {
                    Notification notification;

                    switch (reader[6].ToString())
                    {
                        case "system":
                            notification = new NotificationSystem(
                                            (int)reader[0],
                                            reader[2].ToString(), QueryData.InfoDAO.FindAccount(reader[2].ToString()),
                                            Convert.ToDateTime(reader[3]),
                                            reader[4].ToString(),
                                            (bool)reader[5]);

                            break;
                        case "coins":
                            notification = new NotificationCoins(
                                            (int)reader[0],
                                            reader[1].ToString(), QueryData.InfoDAO.FindAccount(reader[1].ToString()),
                                            reader[2].ToString(), QueryData.InfoDAO.FindAccount(reader[2].ToString()),
                                            Convert.ToDateTime(reader[3]),
                                            reader[4].ToString(),
                                            (bool)reader[5]);

                            break;
                        case "hotel":
                            notification = new NotificationHotel(
                                            (int)reader[0],
                                            reader[1].ToString(), QueryData.InfoDAO.FindAccount(reader[1].ToString()),
                                            reader[2].ToString(), QueryData.InfoDAO.FindAccount(reader[2].ToString()),
                                            Convert.ToDateTime(reader[3]),
                                            reader[4].ToString(),
                                            (bool)reader[5],
                                            QueryData.HotelDAO.FindHotel((int)reader[7]),
                                            QueryData.RoomDAO.FindRoom((int)reader[8]),
                                            (int)reader[9],
                                            reader[10].ToString(),
                                            Convert.ToDateTime(reader[11]),
                                            Convert.ToDateTime(reader[12]));

                            break;
                        default:
                            notification = new NotificationClient(
                                            (int)reader[0],
                                            reader[1].ToString(), QueryData.InfoDAO.FindAccount(reader[1].ToString()),
                                            reader[2].ToString(), QueryData.InfoDAO.FindAccount(reader[2].ToString()),
                                            Convert.ToDateTime(reader[3]),
                                            reader[4].ToString(),
                                            (bool)reader[5],
                                            QueryData.HotelDAO.FindHotel((int)reader[7]),
                                            QueryData.RoomDAO.FindRoom((int)reader[8]),
                                            (int)reader[9],
                                            reader[10].ToString(),
                                            Convert.ToDateTime(reader[11]),
                                            Convert.ToDateTime(reader[12]));

                            break;
                    }
                    notifications.Add(notification);
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

        public bool Insert(Notification notification)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = null;

                if (notification is NotificationSystem notificationSystem)
                {
                    insertCMD = new SqlCommand(
                    $"INSERT INTO {table} VALUES " +
                    $"('{notificationSystem.IdNotification}', " +
                    $"{(notificationSystem.UserNameSender == null ? "null" : $"'{notificationSystem.UserNameSender}'")}, " +
                    $"'{notificationSystem.UserNameReceiver}', " +
                    $"'{notificationSystem.Time.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                    $"N'{notificationSystem.Content}', " +
                    $"'{notificationSystem.IsWatched}', " +
                    $"'{notificationSystem.GetTypeStr()}', " +
                    $"null, null, null, null, null, null)",
                    sqlConnection);
                }
                else if (notification is NotificationCoins notificationCoins)
                {
                    insertCMD = new SqlCommand(
                    $"INSERT INTO {table} VALUES " +
                    $"('{notificationCoins.IdNotification}', " +
                    $"{(notificationCoins.UserNameSender == null ? "null" : $"'{notificationCoins.UserNameSender}'")}, " +
                    $"'{notificationCoins.UserNameReceiver}', " +
                    $"'{notificationCoins.Time.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                    $"N'{notificationCoins.Content}', " +
                    $"'{notificationCoins.IsWatched}', " +
                    $"'{notificationCoins.GetTypeStr()}', " +
                    $"null, null, null, null, null, null)",
                    sqlConnection);
                }
                else if (notification is NotificationHotel notificationHotel)
                {
                    insertCMD = new SqlCommand(
                    $"INSERT INTO {table} VALUES " +
                    $"('{notificationHotel.IdNotification}', " +
                    $"{(notificationHotel.UserNameSender == null ? "null" : $"'{notificationHotel.UserNameSender}'")}, " +
                    $"'{notificationHotel.UserNameReceiver}', " +
                    $"'{notificationHotel.Time.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                    $"N'{notificationHotel.Content}', " +
                    $"'{notificationHotel.IsWatched}', " +
                    $"'{notificationHotel.GetTypeStr()}', " +
                    $"'{notificationHotel.Hotel.IdHotel}', " +
                    $"'{notificationHotel.Room.IdRoom}', " +
                    $"'{notificationHotel.DepositCoins}', " +
                    $"N'{notificationHotel.Status}', " +
                    $"'{notificationHotel.CheckIn.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                    $"'{notificationHotel.CheckOut.ToString("yyyy-MM-dd HH:mm:ss")}')",
                    sqlConnection);
                }
                else if (notification is NotificationClient notificationClient)
                {
                    insertCMD = new SqlCommand(
                    $"INSERT INTO {table} VALUES " +
                    $"('{notificationClient.IdNotification}', " +
                    $"{(notificationClient.UserNameSender == null ? "null" : $"'{notificationClient.UserNameSender}'")}, " +
                    $"'{notificationClient.UserNameReceiver}', " +
                    $"'{notificationClient.Time.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                    $"N'{notificationClient.Content}', " +
                    $"'{notificationClient.IsWatched}', " +
                    $"'{notificationClient.GetTypeStr()}', " +
                    $"'{notificationClient.Hotel.IdHotel}', " +
                    $"'{notificationClient.Room.IdRoom}', " +
                    $"'{notificationClient.DepositCoins}', " +
                    $"N'{notificationClient.Status}', " +
                    $"'{notificationClient.CheckIn.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                    $"'{notificationClient.CheckOut.ToString("yyyy-MM-dd HH:mm:ss")}')",
                    sqlConnection);
                }

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

        public bool Update(Notification notification)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand updateCMD = null;

                if (notification is NotificationSystem notificationSystem)
                {
                    updateCMD = new SqlCommand(
                    $"UPDATE {table} SET " +
                    $"isWatched = '{notificationSystem.IsWatched}' " +
                    $"WHERE idNotification = '{notificationSystem.IdNotification}'",
                    sqlConnection);
                }
                else if (notification is NotificationCoins notificationCoins)
                {
                    updateCMD = new SqlCommand(
                    $"UPDATE {table} SET " +
                    $"isWatched = '{notificationCoins.IsWatched}' " +
                    $"WHERE idNotification = '{notificationCoins.IdNotification}'",
                    sqlConnection);
                }
                else if (notification is NotificationHotel notificationHotel)
                {
                    updateCMD = new SqlCommand(
                    $"UPDATE {table} SET " +
                    $"isWatched = '{notificationHotel.IsWatched}', " +
                    $"status = N'{notificationHotel.Status}' " +
                    $"WHERE idNotification = '{notificationHotel.IdNotification}'",
                    sqlConnection);
                }
                else if (notification is NotificationClient notificationClient)
                {
                    updateCMD = new SqlCommand(
                    $"UPDATE {table} SET " +
                    $"isWatched = '{notificationClient.IsWatched}', " +
                    $"status = N'{notificationClient.Status}' " +
                    $"WHERE idNotification = '{notificationClient.IdNotification}'",
                    sqlConnection);
                }

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
