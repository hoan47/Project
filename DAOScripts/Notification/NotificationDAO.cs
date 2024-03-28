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
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE userNameReceiver = '{user.UserName}' ", sqlConnection);
                SqlDataReader reader = selectCMD.ExecuteReader();

                while (reader.Read())
                {
                    Notification notification;

                    switch (reader[5].ToString())
                    {
                        case "system":
                            notification = new NotificationSystem(
                                            DataAccess.InfoDAO.FindAccount(reader[0].ToString()),
                                            DataAccess.InfoDAO.FindAccount(reader[1].ToString()),
                                            Convert.ToDateTime(reader[2]),
                                            reader[3].ToString(),
                                            (bool)reader[4]);

                            break;
                        case "coins":
                            notification = new NotificationCoins(
                                            DataAccess.InfoDAO.FindAccount(reader[0].ToString()),
                                            DataAccess.InfoDAO.FindAccount(reader[1].ToString()),
                                            Convert.ToDateTime(reader[2]),
                                            reader[3].ToString(),
                                            (bool)reader[4]);

                            break;
                        case "hotel":
                            notification = new NotificationHotel(
                                            DataAccess.InfoDAO.FindAccount(reader[0].ToString()),
                                            DataAccess.InfoDAO.FindAccount(reader[1].ToString()),
                                            Convert.ToDateTime(reader[2]),
                                            reader[3].ToString(),
                                            (bool)reader[4],
                                            DataAccess.HotelDAO.FindHotel((int)reader[6]),
                                            DataAccess.RoomDAO.FindRoom((int)reader[7]),
                                            (int)reader[8],
                                            reader[9].ToString(),
                                            Convert.ToDateTime(reader[10]),
                                            Convert.ToDateTime(reader[11]));

                            break;
                        default:
                            notification = new NotificationClient(
                                            DataAccess.InfoDAO.FindAccount(reader[0].ToString()),
                                            DataAccess.InfoDAO.FindAccount(reader[1].ToString()),
                                            Convert.ToDateTime(reader[2]),
                                            reader[3].ToString(),
                                            (bool)reader[4],
                                            DataAccess.HotelDAO.FindHotel((int)reader[6]),
                                            DataAccess.RoomDAO.FindRoom((int)reader[7]),
                                            (int)reader[8],
                                            reader[9].ToString(),
                                            Convert.ToDateTime(reader[10]),
                                            Convert.ToDateTime(reader[11]));

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

        public bool Insert(User user, Notification notifications)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand(
                    $"INSERT INTO {table} " +
                    $"VALUES " +
                    $"('{notifications.Sender.UserName}', " +
                    $"('{notifications.Receiver.UserName}', " +
                    $"N'{notifications.Sender}', " +
                    $"'{notifications.Time.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                    $"'{notifications.Content}', " +
                    $"'{notifications.IsWatched}', " +
                    $"'{notifications.GetTypeStr()}', null, null, null, null, null, null)",
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

        public bool Update(User user, Notification notifications)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand updateCMD = new SqlCommand(
                    $"UPDATE {table} SET " +
                    $"userNameSender = N'{notifications.Sender}', " +
                    $"userNameReceiver = N'{notifications.Sender}', " +
                    $"sendingTime = '{notifications.Time.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                    $"content = N'{notifications.Content}', " +
                    $"isWatched = '{notifications.IsWatched}', " +
                    $"type = '{notifications.GetTypeStr()}' " +
                    $"WHERE userName = '{user.UserName}'",
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
