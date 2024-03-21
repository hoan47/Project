using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class HotetRoomDAO : DAO
    {
        public HotetRoomDAO() : base("null")
        { }

        public void Access()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand selectCMD = new SqlCommand($"SELECT * FROM Hotel WHERE userName <> '{FController.Instance.User.UserName}'", sqlConnection);
                SqlDataReader reader = selectCMD.ExecuteReader();
                List<Hotel> hotels = new List<Hotel>();

                while (reader.Read())
                {
                    hotels.Add(new Hotel(
                        Convert.ToInt32(reader[1]),
                        reader[2].ToString(),
                        reader[3].ToString(),
                        new Address(reader[4].ToString()),
                        (TimeSpan)reader[5],
                        (TimeSpan)reader[6],
                        reader[7].ToString()));
                }
                reader.Close();

                foreach (Hotel hotel in hotels)
                {
                    selectCMD = new SqlCommand($"SELECT * FROM ImageHotel WHERE idHotel = '{hotel.IdHotel}'", sqlConnection);
                    reader = selectCMD.ExecuteReader();

                    while (reader.Read())
                    {
                        hotel.AddImage(new Image_((int)reader[1], (byte[])reader[2], ProcessImage.ByteToImageArray((byte[])reader[2])));
                    }
                    reader.Close();

                    selectCMD = new SqlCommand($"SELECT * FROM Room WHERE idHotel = '{hotel.IdHotel}'", sqlConnection);
                    reader = selectCMD.ExecuteReader();

                    while (reader.Read())
                    {
                        hotel.AddRoom(new Room(
                            (int)reader[1],
                            reader[2].ToString(),
                            (int)reader[3],
                            (int)reader[4],
                            (int)reader[5],
                            (int)reader[6],
                            (int)reader[7],
                            Room.GetStatus((int)reader[8])));
                    }
                    reader.Close();

                    if (hotel.Rooms == null)
                    {
                        continue;
                    }
                    foreach (Room room in hotel.Rooms)
                    {
                        selectCMD = new SqlCommand($"SELECT * FROM ImageRoom WHERE idRoom = '{room.IdRoom}'", sqlConnection);
                        reader = selectCMD.ExecuteReader();

                        while (reader.Read())
                        {
                            room.AddImage(new Image_((int)reader[1], (byte[])reader[2], ProcessImage.ByteToImageArray((byte[])reader[2])));
                        }
                        FController.Instance.HotelRooms.Add(new HotelRoom(hotel.Name, hotel.Address, room.Name, room.NumberRoom, room.NumberBeds, room.NumberPeople, hotel.CheckIn, hotel.CheckOut, DateTime.Now, DateTime.Now, hotel.Phone, room.Acreage, room.Price, hotel.Describe, hotel.Services, room.Amenitiese, hotel.Images, room.Images));
                        reader.Close();
                    }
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
    }
}
