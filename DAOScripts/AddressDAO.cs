using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Project
{
    public class AddRessDAO : DAO
    {
        public static Dictionary<string, List<string>> addresses;

        static AddRessDAO()
        {
            addresses = new Dictionary<string, List<string>>();
        }

        public AddRessDAO() : base("Address", null)
        {
            if (addresses.Count == 0)
            {
                InitializeDataMap();
            }
        }

        private void InitializeDataMap()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table}", sqlConnection);
                SqlDataReader reader = selectCMD.ExecuteReader();

                while (reader.Read())
                {
                    string province = reader[0].ToString();
                    string district = reader[1].ToString();

                    if (addresses.ContainsKey(province))
                    {
                        addresses[province].Add(district);
                    }
                    else
                    {
                        addresses.Add(province, new List<string> { district });
                    }
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
    }
}
