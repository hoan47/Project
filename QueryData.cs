using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class QueryData
    {
        public static IdDAO IdDAO { get; private set; }
        public static AddRessDAO AddressDAO { get; private set; }
        public static Client Client { get; private set; }
        public static AccountDAO AccountDAO { get; private set; }
        public static InforDAO InfoDAO { get; private set; }
        public static ClientDAO ClientDAO { get; private set; }
        public static HotelDAO HotelDAO { get; private set; }
        public static ServiceDAO ServiceDAO { get; private set; }
        public static ImageHotelDAO ImageHotelDAO { get; private set; }
        public static UpdatePriceDAO UpdatePriceDAO { get; private set; }
        public static RoomDAO RoomDAO { get; private set; }
        public static AmenitiesDAO AmenitiesDAO { get; private set; }
        public static ImageRoomDAO ImageRoomDAO { get; private set; }
        public static NotificationDAO NotificationDAO { get; private set; }
        public static ApplicationServiceDAO ApplicationServiceDAO { get; private set; }

        static QueryData()
        {
            IdDAO = new IdDAO();
            AddressDAO = new AddRessDAO();

            AccountDAO = new AccountDAO();
            InfoDAO = new InforDAO();
            ClientDAO = new ClientDAO();

            HotelDAO = new HotelDAO();
            ServiceDAO = new ServiceDAO();
            ImageHotelDAO = new ImageHotelDAO();
            UpdatePriceDAO = new UpdatePriceDAO();

            RoomDAO = new RoomDAO();
            AmenitiesDAO = new AmenitiesDAO();
            ImageRoomDAO = new ImageRoomDAO();

            NotificationDAO = new NotificationDAO();

            ApplicationServiceDAO = new ApplicationServiceDAO();
        }

        public static void Access()
        {
            InfoDAO.Access(Data.User);
            ClientDAO.Access(Data.User);
            HotelDAO.Access(Data.User);
            NotificationDAO.Access(Data.User, Data.Notifications);
            if (Data.User.Hotels != null)
            {
                ServiceDAO.Access(Data.User.Hotels);
                ImageHotelDAO.Access(Data.User.Hotels);
                RoomDAO.Access(Data.User.Hotels);
                AmenitiesDAO.Access(Data.User.Hotels);
                ImageRoomDAO.Access(Data.User.Hotels);
                UpdatePriceDAO.Access(Data.User.Hotels);
            }

            AccountDAO.AccessNotMe(Data.User, Data.NotMeUsers);
            ApplicationServiceDAO.Access(Data.NotMeUsers);
        }
    }
}
