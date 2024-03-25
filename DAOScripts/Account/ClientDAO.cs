using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class ClientDAO : DAO
    {
        public ClientDAO() : base("Client")
        { }

        public void Access(User user)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE userName = '{user.UserName}'", sqlConnection);
                SqlDataReader reader = selectCMD.ExecuteReader();

                if (reader.Read())
                {
                    user.UpdateClient(new Client(Convert.ToInt32(reader[1])));
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

        public bool Insert(User user)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand($"Insert {table}(userName, rankInt) values('{user.UserName}', '{user.Client.RankInt}')", sqlConnection);

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

        public bool Update(User user, int core)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand updateCMD = new SqlCommand(
                    $"UPDATE {table} SET rankInt = '{user.Client.RankInt + core}' WHERE userName = '{user.UserName}'", sqlConnection);

                if (updateCMD.ExecuteNonQuery() == 1)
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
    }
}
