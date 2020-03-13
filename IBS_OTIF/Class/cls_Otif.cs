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
    public class cls_Otif
    {
        Provider _Provider;
        public cls_Otif()
        {
            _Provider = new Provider(Otif_DungChung._ConnectionString);
        }

        public DataTable TongHopTuanTheoTDK(int tuan, int nam)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@tuan", SqlDbType.Int);
            sqlParameters[0].Value = tuan;
            sqlParameters[1] = new SqlParameter("@nam", SqlDbType.Int);
            sqlParameters[1].Value = nam;

            return _Provider.ExecuteQuery("sp_TinhOTIFTheoTuan_TDK", sqlParameters);
        }

        public DataTable TongHopTuanTheoNgayDP(int tuan, int nam)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@tuan", SqlDbType.Int);
            sqlParameters[0].Value = tuan;
            sqlParameters[1] = new SqlParameter("@nam", SqlDbType.Int);
            sqlParameters[1].Value = nam;

            return _Provider.ExecuteQuery("sp_TinhOTIFTheoTuan_NgayDP", sqlParameters);
        }

        public DataTable TongHopTuan(int tuan, int nam)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@tuan", SqlDbType.Int);
            sqlParameters[0].Value = tuan;
            sqlParameters[1] = new SqlParameter("@nam", SqlDbType.Int);
            sqlParameters[1].Value = nam;

            return _Provider.ExecuteQuery("sp_TinhOTIFTheoTuan", sqlParameters);
        }
        public DataTable TongHopTuan_BieuDo(int tuan, int nam)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@tuan", SqlDbType.Int);
            sqlParameters[0].Value = tuan;
            sqlParameters[1] = new SqlParameter("@nam", SqlDbType.Int);
            sqlParameters[1].Value = nam;

            return _Provider.ExecuteQuery("sp_TinhOTIFTheoTuan_BieuDo", sqlParameters);
        }
        public DataTable KetQuaTongHop(int donvi, int tuan, int nam)
        {
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@donvi", SqlDbType.Int);
            sqlParameters[0].Value = donvi;
            sqlParameters[1] = new SqlParameter("@tuan", SqlDbType.Int);
            sqlParameters[1].Value = tuan;
            sqlParameters[2] = new SqlParameter("@nam", SqlDbType.Int);
            sqlParameters[2].Value = nam;

            return _Provider.ExecuteQuery("sp_OTIF_KQTongHop", sqlParameters);
        }

        public DataTable Otif_ChiTiet(int tuan, int nam)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@tuan", SqlDbType.Int);
            sqlParameters[0].Value = tuan;
            sqlParameters[1] = new SqlParameter("@nam", SqlDbType.Int);
            sqlParameters[1].Value = nam;

            return _Provider.ExecuteQuery("sp_OTIF_XemChiTiet", sqlParameters);
        }
    }
}
