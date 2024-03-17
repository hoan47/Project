using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class InfoDAO : DAO
    {
        public InfoDAO() : base("Info")
        {  }

        public void Access()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE userName = '{FController.Instance.User.UserName}'", sqlConnection);
                SqlDataReader dataInfo = selectCMD.ExecuteReader();

                if (dataInfo.Read())
                {
                    FController.Instance.User.UpdateInfo(
                        dataInfo.IsDBNull(1) ? "Nguyen Van An" : dataInfo[1].ToString(),
                        dataInfo.IsDBNull(2) ? DateTime.Now : Convert.ToDateTime(dataInfo[2]),
                        dataInfo.IsDBNull(3) ? "Nam" : dataInfo[3].ToString(),
                        dataInfo.IsDBNull(4) ? null : new Address(dataInfo[4].ToString()),
                        dataInfo.IsDBNull(5) ? null : dataInfo[5].ToString(),
                        dataInfo.IsDBNull(6) ? null : dataInfo[6].ToString(),
                        dataInfo.IsDBNull(7) ? null : dataInfo[7].ToString(),
                        dataInfo.IsDBNull(8) ? null : (byte[])dataInfo[8]
                    );
                }
                dataInfo.Close();
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
