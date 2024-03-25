using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class ServiceDAO : DAO
    {
        public ServiceDAO() : base("Service")
        { }

        public void Access(User user)
        {
            try
            {
                sqlConnection.Open();

                foreach (Hotel hotel in user.Hotels)
                {
                    SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE idHotel = {hotel.IdHotel}", sqlConnection);
                    SqlDataReader reader = selectCMD.ExecuteReader();
                    List<string> services = new List<string>();

                    while (reader.Read())
                    {
                        if (reader.IsDBNull(1) == false)
                        {
                            services.Add(reader.GetString(1));
                        }
                    }
                    hotel.UpdateService(services);
                    reader.Close();
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

        public bool Insert(Hotel hotel)
        {
            try
            {
                sqlConnection.Open();

                if (hotel.Services.Count != 0)
                {
                    foreach (string service in hotel.Services)
                    {
                        SqlCommand insertCMD = new SqlCommand($"INSERT INTO {table} VALUES " +
                                                               $"('{hotel.IdHotel}', " +
                                                               $"N'{service}')",
                                                               sqlConnection);

                        if (insertCMD.ExecuteNonQuery() == 0)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    SqlCommand insertCMD = new SqlCommand($"INSERT INTO {table}(idHotel) VALUES ('{hotel.IdHotel}')", sqlConnection);
                }    
                return true;
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

        public bool Delete(Hotel hotel)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand updateCMD = new SqlCommand($"Delete {table} WHERE idHotel = '{hotel.IdHotel}'",
                                                    sqlConnection);

                return updateCMD.ExecuteNonQuery() == 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return false;
        }
    }
}
