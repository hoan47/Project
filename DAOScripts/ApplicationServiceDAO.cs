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
            DataAccess.HotelDAO.Access(user, hotels, false);
            DataAccess.ServiceDAO.Access(hotels);
            DataAccess.ImageHotelDAO.Access(hotels);
            DataAccess.RoomDAO.Access(hotels);
            DataAccess.AmenitiesDAO.Access(hotels);
            DataAccess.ImageRoomDAO.Access(hotels);
        }
    }
}
