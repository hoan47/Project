using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Room
    {
        public int IdRoom { get; private set; }
        public string Name { get; private set; }
        public int NumberRoom { get; private set; }
        public int NumberBeds { get; private set; }
        public int NumberPeople { get; private set; }
        public int Acreage { get; private set; }
        public int Price { get; private set; }
        public ERoomStatus Status { get; private set; }
        public List<Image_> Images { get; private set; }
        public List<string> Amenitiese { get; private set; }

        public Room(int idRoom, string name, int numberRoom, int numberOfBeds, int numberOfPeople, int acreage, int price, ERoomStatus status = ERoomStatus.empty)
        {
            IdRoom = idRoom;
            Name = name;
            NumberRoom = numberRoom;
            NumberBeds = numberOfBeds;
            NumberPeople = numberOfPeople;
            Acreage = acreage;
            Price = price;
            Status = status;
        }

        public void UpdateInfor(string name, int numberRoom, int numberOfBeds, int numberOfPeople, int acreage, int price)
        {
            Name = name;
            NumberRoom = numberRoom;
            NumberBeds = numberOfBeds;
            NumberPeople = numberOfPeople;
            Acreage = acreage;
            Price = price;
        }

        public void UpdateAmenities(List<string> amenitiese)
        {
            Amenitiese = amenitiese;
        }

        public void AddImage(Image_ image)
        {
            if (Images == null)
            {
                Images = new List<Image_>();
            }
            Images.Add(image);
        }

        public static ERoomStatus GetStatus(int status)
        {
            switch(status)
            {
                case 0:
                    return ERoomStatus.rent;
                case 1:
                    return ERoomStatus.repair;
                case 2:
                    return ERoomStatus.oder;
                default:
                    return ERoomStatus.empty;
            }    
        }

        public int GetStatus()
        {
            switch (Status)
            {
                case ERoomStatus.rent:
                    return 0;
                case ERoomStatus.repair:
                    return 1;
                case ERoomStatus.oder:
                    return 2;
                default:
                    return 3;
            }
        }

        public string GetStatusStr()
        {
            switch (Status)
            {
                case ERoomStatus.rent:
                    return "Đang thuê";
                case ERoomStatus.repair:
                    return "Đang sửa";
                case ERoomStatus.oder:
                    return "Đã đặt";
                default:
                    return "Chưa thuê";
            }
        }

        public enum ERoomStatus
        {
            rent = 0,
            repair = 1,
            oder = 2,
            empty = 3
        }
    }
}
