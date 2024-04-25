using System;
using System.Collections.Generic;
using System.Drawing;
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
        public int OldPrice { get; private set; }
        public List<KeyValuePair<DateTime, DateTime>> CheckInOuts { get; private set; }

        public Room(int idRoom, string name, int numberRoom, int numberOfBeds, int numberOfPeople, int acreage, int price, ERoomStatus status, int oldPrice)
        {
            IdRoom = idRoom;
            Name = name;
            NumberRoom = numberRoom;
            NumberBeds = numberOfBeds;
            NumberPeople = numberOfPeople;
            Acreage = acreage;
            OldPrice = price;
            Price = price;
            Status = status;
            OldPrice = oldPrice;
        }

        public void UpdatePrice(double percent)
        {
            OldPrice = Price;
            Price = (int)Math.Floor(Price * percent);
        }

        public void UpdateInfor(string name, int numberRoom, int numberOfBeds, int numberOfPeople, int acreage, int price)
        {
            Name = name;
            NumberRoom = numberRoom;
            NumberBeds = numberOfBeds;
            NumberPeople = numberOfPeople;
            Acreage = acreage;
            OldPrice = Price;
            Price = price;
        }

        public void UpdateAmenities(List<string> amenitiese)
        {
            Amenitiese = amenitiese;
        }

        public Image GetImageRoom(bool isFirst = true)
        {
            return Images != null ? (Images.Count > 0 ? (isFirst == true ? Images.First().Image : Images.Last().Image) : Properties.Resources.noImage) : Properties.Resources.noImage;
        }

        public void AddImage(Image_ image)
        {
            if (Images == null)
            {
                Images = new List<Image_>();
            }
            Images.Add(image);
        }
        public void AddCheckInOuts(DateTime firstDay, DateTime lastDay)
        {
            if (CheckInOuts == null)
            {
                CheckInOuts = new List<KeyValuePair<DateTime, DateTime>>();
            }
            CheckInOuts.Add(new KeyValuePair<DateTime, DateTime>(firstDay, lastDay));
        }
        public void RemoveCheckInOuts(DateTime firstDay, DateTime lastDay)
        {
            int index = 0;

            foreach (KeyValuePair<DateTime, DateTime> keyValuePair in CheckInOuts)
            {
                if (keyValuePair.Key.Date == firstDay.Date)
                {
                    break;
                }
                index++;
            }
            CheckInOuts.RemoveAt(index);
        }
        public static ERoomStatus GetStatus(int status)
        {
            switch (status)
            {
                case 0:
                    return ERoomStatus.rent;
                case 1:
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
                case ERoomStatus.oder:
                    return 1;
                default:
                    return 2;
            }
        }

        public string GetStatusStr()
        {
            return GetStatusStr(Status);
        }

        public static string GetStatusStr(ERoomStatus status)
        {
            switch (status)
            {
                case ERoomStatus.rent:
                    return "Đang thuê";
                case ERoomStatus.oder:
                    return "Đã đặt";
                default:
                    return "Chưa thuê";
            }
        }

        public enum ERoomStatus
        {
            rent = 0,
            oder = 1,
            empty = 2
        }
    }
}
