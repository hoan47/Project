﻿using System;
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
        public InfoDAO(User user) : base("Info", user)
        {  }

        public void Access()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE userName = '{user.UserName}'", sqlConnection);
                SqlDataReader dataInfo = selectCMD.ExecuteReader();

                if (dataInfo.Read())
                {
                    user.UpdateInfo(
                        dataInfo.IsDBNull(1) ? "Nguyen Van An" : dataInfo[1].ToString(),
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

        public bool Update()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand($"UPDATE {table} SET " +
                 $"name = N'{user.Name}', " +
                 $"dateOfBirth = '{user.DateOfBirth.ToString("yyyyMMdd")}', " +
                 $"gender = N'{user.Gender}', " +
                 $"address = N'{user.Address}', " +
                 $"idCard = '{user.IdCard}', " +
                 $"email = '{user.Email}', " +
                 $"phone = '{user.Phone}', " +
                 $"imageBytes = @imageBytes " +
                 $"WHERE userName = '{user.UserName}'", sqlConnection);
                insertCMD.Parameters.Add("@imageBytes", SqlDbType.VarBinary).Value = ProcessImage.ImageToByteArray(user.Image);
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
