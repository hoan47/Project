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

        public void Access()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE userName = '{FController.Instance.User.UserName}'", sqlConnection);
                SqlDataReader reader = selectCMD.ExecuteReader();

                if (reader.Read())
                {
                    FController.Instance.User.UpdateInfor(
                        reader.IsDBNull(1) ? "Nguyen Van An" : reader[1].ToString(),
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


        public bool Insert()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand($"Insert {table}(userName, imageBytes) values('{FController.Instance.User.UserName}', @imageBytes)", sqlConnection);
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

        public bool Update()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand($"UPDATE {table} SET " +
                 $"name = N'{FController.Instance.User.Name}', " +
                 $"dateOfBirth = '{FController.Instance.User.DateOfBirth.ToString("yyyyMMdd")}', " +
                 $"gender = N'{FController.Instance.User.Gender}', " +
                 $"address = N'{FController.Instance.User.Address.AddressValue}', " +
                 $"idCard = '{FController.Instance.User.IdCard}', " +
                 $"email = '{FController.Instance.User.Email}', " +
                 $"phone = '{FController.Instance.User.Phone}', " +
                 $"imageBytes = @imageBytes " +
                 $"WHERE userName = '{FController.Instance.User.UserName}'", sqlConnection);
                insertCMD.Parameters.Add("@imageBytes", SqlDbType.VarBinary).Value = FController.Instance.User.ImageBytes;
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
