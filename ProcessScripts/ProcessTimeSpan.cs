using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    static class ProcessTimeSpan
    {
        public static TimeSpan TimeSpanPrase(string timeString)
        {
            foreach (string time in timeString.Split(':'))
            {
                if (string.IsNullOrEmpty(time) || string.IsNullOrWhiteSpace(time))
                {
                    ShowMessage.ShowNotification("Vui lòng nhập thời gian.");
                    return new TimeSpan();
                }
            }
            string[] parts = timeString.Split(':');
            int hours, minutes;

            if (parts.Length == 2 && int.TryParse(parts[0], out hours) && int.TryParse(parts[1], out minutes))
            {
                if (0 <= hours && hours <= 23 && -1 < minutes && minutes < 59)
                {
                    return new TimeSpan(hours, minutes, 0);
                }
                ShowMessage.ShowNotification("Thời gian không hợp lệ.");
            }
            return new TimeSpan();
        }
    }
}
