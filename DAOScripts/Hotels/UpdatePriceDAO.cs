using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class UpdatePriceDAO : DAO
    {
        public UpdatePriceDAO() : base("HistoryUpdatePrice")
        { }
        public void Access(List<Hotel> hotels)
        {
            try
            {
                sqlConnection.Open();

                foreach (Hotel hotel in hotels)
                {
                    SqlCommand selectCMD = new SqlCommand($"SELECT * FROM {table} WHERE idHotel = '{hotel.IdHotel}'", sqlConnection);
                    SqlDataReader reader = selectCMD.ExecuteReader();

                    while (reader.Read())
                    {
                        hotel.AddUpdatePrice(new UpdatePrice(Convert.ToDateTime(reader[1]), (int)reader[2], (int)reader[3]));
                    }
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

        public bool Insert(Hotel hotel, UpdatePrice updatePrice)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand insertCMD = new SqlCommand($"INSERT INTO {table} " +
                                                       $"VALUES(" +
                                                       $"'{hotel.IdHotel}', " +
                                                       $"'{updatePrice.Time.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                                                       $"'{updatePrice.Value}', " +
                                                       $"'{updatePrice.NumberRoom}')",
                                                       sqlConnection);

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
