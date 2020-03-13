using AccessData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Class
{
    public class cls_Login
    {
        Provider _Provider;
        public cls_Login()
        {
            _Provider = new Provider(clsBienHeThong._ConnectionMAIN);
        }
        
        public DataTable Check_Login(string MaNV, string MatKhau, int ChTrID)
        {
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@MaNV", SqlDbType.VarChar);
            sqlParameters[0].Value = MaNV;
            sqlParameters[1] = new SqlParameter("@MatKhau", SqlDbType.VarChar);
            sqlParameters[1].Value = MatKhau;
            sqlParameters[2] = new SqlParameter("@ChTrID", SqlDbType.Int);
            sqlParameters[2].Value = ChTrID;
            return _Provider.ExecuteQuery("proc_Login", sqlParameters);
        }
    }
}
