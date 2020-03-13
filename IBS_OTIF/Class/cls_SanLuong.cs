using AccessData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBS_OTIF.Class
{
    public class cls_SanLuong
    {
        Provider _Provider;
        public cls_SanLuong()
        {
            _Provider = new Provider(Otif_DungChung._ConnectionString);
        }

        public DataTable LaySanLuongKHKD(int dvID, DateTime tuNgay, DateTime denNgay)
        {
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@dvID", SqlDbType.Int);
            sqlParameters[0].Value = dvID;
            sqlParameters[1] = new SqlParameter("@tuNgay", SqlDbType.Date);
            sqlParameters[1].Value = tuNgay;
            sqlParameters[2] = new SqlParameter("@denNgay", SqlDbType.Date);
            sqlParameters[2].Value = denNgay;
            return _Provider.ExecuteQuery("sp_DoSanLuong", sqlParameters);
        }

        public DataTable XemSanLuong(int dvID, DateTime tuNgay, DateTime denNgay)
        {
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@dvID", SqlDbType.Int);
            sqlParameters[0].Value = dvID;
            sqlParameters[1] = new SqlParameter("@tuNgay", SqlDbType.Date);
            sqlParameters[1].Value = tuNgay;
            sqlParameters[2] = new SqlParameter("@denNgay", SqlDbType.Date);
            sqlParameters[2].Value = denNgay;
            return _Provider.ExecuteQuery("sp_XemSanLuong", sqlParameters);
        }
    }
}
