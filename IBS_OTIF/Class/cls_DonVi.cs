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
    public class cls_DonVi
    {
        Provider _Provider;
        public cls_DonVi()
        {
            _Provider = new Provider(Otif_DungChung._ConnectionString);
        }

        public int Get_DonViID(string user)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@user", System.Data.SqlDbType.VarChar);
            sqlParameters[0].Value = user;

            DataTable dt = _Provider.ExecuteQuery("proc_Get_DonViByUser", sqlParameters);
            return clsXuLyChung.GetSafeInt(dt.Rows[0]["DonViID"]);
        }

        public DataTable Get_AllDonVi()
        {
            return _Provider.ExecuteQuery("proc_GetAllDonVi", null);
        }
    }
}
