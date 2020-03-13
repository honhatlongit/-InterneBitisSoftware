using AccessData;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace IBS_OTIF.Class
{
    public static class Otif_DungChung
    {
        public static readonly string _ConnectionString = @"Data Source=192.1.1.20,12526;Initial Catalog=OTIF;User ID=sa;Password=sa";
        public static int _DonViID;
        public static int _Tuan =  GetWeek(DateTime.Now);
        public static int _Nam = DateTime.Now.Year;
        public static int GetWeek(this DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo
                .InvariantCulture
                .Calendar
                .GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public static void GetDonVi()
        {
            _DonViID = new cls_DonVi().Get_DonViID(clsBienHeThong._MaNV);
        }
    }
}
