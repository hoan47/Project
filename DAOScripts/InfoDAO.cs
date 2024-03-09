using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class InfoDAO : DAO
    {
        public InfoDAO() : base("Info")
        { }

        public User Access(User user)
        {
            User newUser = null;

            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE userName = @UserName", sqlConnection);
                selectCMD.Parameters.AddWithValue("@UserName", user.UserName);

                SqlDataReader dataInfo = selectCMD.ExecuteReader();

                if (dataInfo.Read())
                {
                    newUser = new User(
                        user.UserName,
                        user.Password,
                        dataInfo.IsDBNull(1) ? null : dataInfo[1].ToString(),
                        dataInfo.IsDBNull(2) ? DateTime.Now : Convert.ToDateTime(dataInfo[2]),
                        dataInfo.IsDBNull(3) ? null : dataInfo[3].ToString(),
                        dataInfo.IsDBNull(4) ? null : dataInfo[4].ToString(),
                        dataInfo.IsDBNull(5) ? null : dataInfo[5].ToString(),
                        dataInfo.IsDBNull(6) ? null : dataInfo[6].ToString(),
                        dataInfo.IsDBNull(7) ? null : dataInfo[7].ToString(),
                        Convert.ToInt32(dataInfo[8]),
                        dataInfo.IsDBNull(9) ? null : (byte[])dataInfo[9]
                    );
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
            return newUser;
        }


        public bool Insert(User user)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand($"Insert {table}(userName) values('{user.UserName}')", sqlConnection);

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
    }
}
