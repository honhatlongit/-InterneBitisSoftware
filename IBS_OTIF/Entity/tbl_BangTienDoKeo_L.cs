using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBS_OTIF.Entity
{
    public class tbl_BangTienDoKeo_L
    {
        public string ID { get; set; }
        public int ID_Header { get; set; }
        public DateTime NGH { get; set; }
        public string KHACHHANG { get; set; }
        public string SOLSX { get; set; }
        public string MASP { get; set; }
        public string MAMAU { get; set; }
        public int COSO { get; set; }
        public int SLKH { get; set; }
        public int NSU { get; set; }
        public double DMHC { get; set; }
        public double NANGSUAT { get; set; }
        public double CONGCAN { get; set; }
        public int LINE { get; set; }
        public DateTime NGAYBATDAU { get; set; }
        public DateTime NGAYKETTHUC { get; set; }
    }
}
