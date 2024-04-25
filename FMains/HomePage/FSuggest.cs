using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.FMains.HomePage
{
    public partial class FSuggest : Form
    {
        public FSuggest()
        {
            InitializeComponent();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach(User user in Data.NotMeUsers)
            {
                foreach(Hotel hotel in user.Hotels)
                {
                    foreach(Room room in hotel.Rooms)
                    {
                        if (room.CheckInOuts != null)
                        {
                            string address = hotel.Address.ProvinceAndDistrict.ToString();
                            if (!dic.ContainsKey(address))
                            {
                                dic[address] = 0;
                            }
                            dic[address] += room.CheckInOuts.Count;
                        }
                    }
                }
            }
            string res = "Chưa có thông tin";
            int maxCheckInOuts = 0;

            foreach (KeyValuePair<string, int> pair in dic)
            {
                if (pair.Value > maxCheckInOuts)
                {
                    res = pair.Key;
                    maxCheckInOuts = pair.Value;
                }
            }
            label1.Text = "Địa điểm được ưa chuộng nhất: " + res;
        }
    }
}
