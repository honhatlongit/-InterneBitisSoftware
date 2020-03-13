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
    public class cls_Menu
    {
        Provider _Provider;
        public cls_Menu()
        {
            _Provider = new Provider(AccessData.clsBienHeThong._ConnectionMAIN);
        }

        public DataTable Load_Module()
        {
            return _Provider.ExecuteQuery("proc_LoadModule", null);
        }

        public DataTable Load_NhomMenu(string MaNV, int ChTrID)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaNV", SqlDbType.VarChar);
            sqlParameters[0].Value = MaNV;
            sqlParameters[1] = new SqlParameter("@ChTrID", SqlDbType.Int);
            sqlParameters[1].Value = ChTrID;
            return _Provider.ExecuteQuery("proc_LoadNhomMenu", sqlParameters);
        }

        public DataTable Load_Menu(string MaNV, int NhomID)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@MaNV", SqlDbType.VarChar);
            sqlParameters[0].Value = MaNV;
            sqlParameters[1] = new SqlParameter("@NhomID", SqlDbType.Int);
            sqlParameters[1].Value = NhomID;
            return _Provider.ExecuteQuery("proc_LoadMenu", sqlParameters);
        }
    }
}
