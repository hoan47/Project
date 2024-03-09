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
        { }

        public void Access()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE userName = '{FController.Instance.user.UserName}'", sqlConnection);
                SqlDataReader dataInfo = selectCMD.ExecuteReader();

                if (dataInfo.Read())
                {
                    FController.Instance.user.UpdateInfo(
                        dataInfo.IsDBNull(1) ? null : dataInfo[1].ToString(),
                        dataInfo.IsDBNull(2) ? DateTime.Now : Convert.ToDateTime(dataInfo[2]),
                        dataInfo.IsDBNull(3) ? "Nam" : dataInfo[3].ToString(),
                        dataInfo.IsDBNull(4) ? null : dataInfo[4].ToString(),
                        dataInfo.IsDBNull(5) ? null : dataInfo[5].ToString(),
                        dataInfo.IsDBNull(6) ? null : dataInfo[6].ToString(),
                        dataInfo.IsDBNull(7) ? null : dataInfo[7].ToString(),
                        Convert.ToInt32(dataInfo[8]),
                        dataInfo.IsDBNull(9) ? Properties.Resources.man : ProcessImage.ByteToImageArray((byte[])dataInfo[9])
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
        }


        public bool Insert()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand($"Insert {table}(userName) values('{FController.Instance.user.UserName}')", sqlConnection);

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
                 $"name = N'{FController.Instance.user.Name}', " +
                 $"dateOfBirth = '{FController.Instance.user.DateOfBirth.ToString("yyyyMMdd")}', " +
                 $"gender = N'{FController.Instance.user.Gender}', " +
                 $"address = N'{FController.Instance.user.Address}', " +
                 $"idCard = '{FController.Instance.user.IdCard}', " +
                 $"email = '{FController.Instance.user.Email}', " +
                 $"phone = '{FController.Instance.user.Phone}', " +
                 $"imageBytes = @imageBytes " +
                 $"WHERE userName = '{FController.Instance.user.UserName}'", sqlConnection);

                if (FController.Instance.user.Image == null)
                {
                    insertCMD.Parameters.Add("@imageBytes", SqlDbType.VarBinary).Value = DBNull.Value;
                }
                else
                {
                    insertCMD.Parameters.Add("@imageBytes", SqlDbType.VarBinary).Value = ProcessImage.ImageToByteArray(FController.Instance.user.Image);
                }

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
