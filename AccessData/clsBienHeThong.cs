using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData
{
    public static class clsBienHeThong
    {
        public static readonly string _ConnectionOTIF = @"Data Source=192.1.1.20,12526;Initial Catalog=OTIF;User ID=sa;Password=sa";
        public static readonly string _ConnectionMAIN = @"Data Source=192.1.1.20,12526;Initial Catalog=IBS_Main;User ID=sa;Password=sa";
        public static int _ChuongTrinhID;
        public static string _MaNV;
    }
}
