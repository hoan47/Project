using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class DataAccess
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
        public static RoomDAO RoomDAO { get; private set; }
        public static AmenitiesDAO AmenitiesDAO { get; private set; }
        public static ImageRoomDAO ImageRoomDAO { get; private set; }

        static DataAccess()
        {
            IdDAO = new IdDAO();
            AddressDAO = new AddRessDAO();

            AccountDAO = new AccountDAO();
            InfoDAO = new InforDAO();
            ClientDAO = new ClientDAO();

            HotelDAO = new HotelDAO();
            ServiceDAO = new ServiceDAO();
            ImageHotelDAO = new ImageHotelDAO();

            RoomDAO = new RoomDAO();
            AmenitiesDAO = new AmenitiesDAO();
            ImageRoomDAO = new ImageRoomDAO();
        }
    }
}
