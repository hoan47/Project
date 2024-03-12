using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Project
{
    public class AddRessDAO : DAO
    {
        static Dictionary<string, List<string>> addresses;
        public Dictionary<string, List<string>> Addreses { get { return addresses; } }

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
                    string province = reader["nameProvince"].ToString();
                    string district = reader["nameDistrict"].ToString();

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
