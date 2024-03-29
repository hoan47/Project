using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class ApplicationServiceDAO : DAO
    {
        public ApplicationServiceDAO() : base(null)
        {  }

        public void Access(User user, List<Hotel> hotels)
        {
            QueryData.HotelDAO.Access(user, hotels, false);
            QueryData.ServiceDAO.Access(hotels);
            QueryData.ImageHotelDAO.Access(hotels);
            QueryData.RoomDAO.Access(hotels);
            QueryData.AmenitiesDAO.Access(hotels);
            QueryData.ImageRoomDAO.Access(hotels);
        }
    }
}
