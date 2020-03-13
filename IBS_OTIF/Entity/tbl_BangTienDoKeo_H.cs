using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBS_OTIF.Entity
{
    public class tbl_BangTienDoKeo_H
    {
        public int ID { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public int Tuan { get; set; }
        public int Nam { get; set; }
        public int DonViID { get; set; }

        public tbl_BangTienDoKeo_H()
        {
        }
    }
}
