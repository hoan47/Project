using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class InforDAO : DAO
    {
        public InforDAO() : base("Infor")
        {  }

        public void Access(User user)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE userName = '{user.UserName}'", sqlConnection);
                SqlDataReader reader = selectCMD.ExecuteReader();

                if (reader.Read())
                {
                    user.UpdateInfor(
                        reader.IsDBNull(1) ? "Nguyen Van A" : reader[1].ToString(),
                        reader.IsDBNull(2) ? DateTime.Now : Convert.ToDateTime(reader[2]),
                        reader.IsDBNull(3) ? "Nam" : reader[3].ToString(),
                        reader.IsDBNull(4) ? null : new Address(reader[4].ToString()),
                        reader.IsDBNull(5) ? null : reader[5].ToString(),
                        reader.IsDBNull(6) ? null : reader[6].ToString(),
                        reader.IsDBNull(7) ? null : reader[7].ToString(),
                        reader.IsDBNull(8) ? null : (byte[])reader[8]
                    );
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
                SqlCommand insertCMD = new SqlCommand($"Insert {table}(userName, imageBytes) values('{user.UserName}', @imageBytes)", sqlConnection);
                insertCMD.Parameters.Add("@imageBytes", SqlDbType.VarBinary).Value = ProcessImage.ImageToByteArray(Properties.Resources.noImage);

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

        public bool Update(User user)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand($"UPDATE {table} SET " +
                 $"name = N'{user.Name}', " +
                 $"dateOfBirth = '{user.DateOfBirth.ToString("yyyyMMdd")}', " +
                 $"gender = N'{user.Gender}', " +
                 $"address = N'{user.Address.AddressValue}', " +
                 $"idCard = '{user.IdCard}', " +
                 $"email = '{user.Email}', " +
                 $"phone = '{user.Phone}', " +
                 $"imageBytes = @imageBytes " +
                 $"WHERE userName = '{user.UserName}'", sqlConnection);
                insertCMD.Parameters.Add("@imageBytes", SqlDbType.VarBinary).Value = user.ImageBytes;
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

        public string FindAccount(string userName)
        {
            string name = null;

            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT name, phone FROM {table} WHERE userName = '{userName}'", sqlConnection);

                SqlDataReader reader = selectCMD.ExecuteReader();

                if (reader.Read())
                {
                    name = reader[0].ToString();
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
            return name;
        }
    }
}
