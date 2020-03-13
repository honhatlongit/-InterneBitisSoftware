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
    public class cls_CapNhatLoi
    {
        Provider _Provider;
        public cls_CapNhatLoi()
        {
            _Provider = new Provider(Otif_DungChung._ConnectionString);
            Otif_DungChung.GetDonVi();
        }

        public DataTable View_CapNhatLoi(int donVi, int tuan, int nam)
        {
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@DVID", SqlDbType.Int);
            sqlParameters[0].Value = donVi;
            sqlParameters[1] = new SqlParameter("@Tuan", SqlDbType.Int);
            sqlParameters[1].Value = tuan;
            sqlParameters[2] = new SqlParameter("@Nam", SqlDbType.Int);
            sqlParameters[2].Value = nam;
            return _Provider.ExecuteQuery("sp_View_CapNhatLoi", sqlParameters);
        }

        public DataTable View_NguyenNhan()
        {
            return _Provider.ExecuteQuery("sp_View_DanhMucNguyenNhan", null);
        }

        public bool Update_NguyenNhan(string id, string mann)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.NVarChar);
            sqlParameters[0].Value = id;
            sqlParameters[1] = new SqlParameter("@MaNN", SqlDbType.VarChar);
            sqlParameters[1].Value = mann;
            return _Provider.ExecuteNonQuery("sp_OTIF_Update_NguyenNhan", sqlParameters);
        }

        public bool Update_DonViGayRa(string id, string dvGayRa)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@ID", SqlDbType.NVarChar);
            sqlParameters[0].Value = id;
            sqlParameters[1] = new SqlParameter("@DonViGayRa", SqlDbType.VarChar);
            sqlParameters[1].Value = dvGayRa;
            return _Provider.ExecuteNonQuery("sp_OTIF_Update_DonViGayRa", sqlParameters);
        }
    }
}
