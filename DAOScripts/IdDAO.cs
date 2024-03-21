using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class IdDAO : DAO
    {
        public IdDAO() : base("Id")
        { }

        public int SelectId
        {
            get
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table}", sqlConnection);
                    SqlDataReader reader = selectCMD.ExecuteReader();

                    if (reader.Read())
                    {
                        return (int)reader[0] + 1;
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
                return -1;
            }
        }

        public int ChangeId()
        {
            try
            {
                int newValue = SelectId;

                sqlConnection.Open();
                SqlCommand updateCMD = new SqlCommand($"Update {table} set value = {newValue} ", sqlConnection);

                if (updateCMD.ExecuteNonQuery() == 1)
                {
                    return newValue + 1;
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
            return -1;
        }
    }
}
