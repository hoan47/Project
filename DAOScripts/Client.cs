using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Client
    {
        public User User { get; private set; } 
        public int RankInt { get; private set; }

        public Client(User user)
        {
            User = user;
            RankInt = 5;
        }

        public ERank GetRank()
        {
            switch(RankInt)
            {
                case (int)ERank.rankCopper:
                    return ERank.rankCopper;
                case (int)ERank.rankSilver:
                    return ERank.rankSilver;
                default:
                    return ERank.rankYellow;
            }    
        }

        public string RankStr()
        {
            switch(RankInt)
            {
                case (int)ERank.rankCopper:
                    return "Hạng Đồng";
                case (int)ERank.rankSilver:
                    return "Hạng Bạc";
                default:
                    return "Hạng Vàng";
            }  
        }    

        public Image RankImage()
        {
            switch (RankInt)
            {
                case (int)ERank.rankCopper:
                    return Properties.Resources.copper;
                case (int)ERank.rankSilver:
                    return Properties.Resources.silver;
                default:
                    return Properties.Resources.yellow;
            }
        }

        public string StatusRank()
        {
            switch (GetRank())
            {
                case ERank.rankCopper:
                    return $"Bạn cần thêm {ERank.rankSilver - User.Client.RankInt} điểm để mở khóa hạng Bạc.";
                case ERank.rankSilver:
                    return $"Bạn cần thêm {ERank.rankYellow - User.Client.RankInt} điểm để mở khóa hạng Vàng.";
                default:
                    return $"Bạn hiện tại đang ở mức hạng cao nhất.";
            }
        }

        public enum ERank
        {
            rankCopper = 5,
            rankSilver = 16,
            rankYellow = 30
        }
    }
}
