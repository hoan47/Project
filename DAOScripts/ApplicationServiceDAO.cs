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
        { }

        public void Access(List<User> notMeUsers)
        {
            foreach (User notMeUser in notMeUsers)
            {
                QueryData.InfoDAO.Access(notMeUser);
                QueryData.HotelDAO.Access(notMeUser);
                QueryData.ServiceDAO.Access(notMeUser.Hotels);
                QueryData.ImageHotelDAO.Access(notMeUser.Hotels);
                QueryData.RoomDAO.Access(notMeUser.Hotels);
                QueryData.AmenitiesDAO.Access(notMeUser.Hotels);
                QueryData.ImageRoomDAO.Access(notMeUser.Hotels);
            }
        }
    }
}
