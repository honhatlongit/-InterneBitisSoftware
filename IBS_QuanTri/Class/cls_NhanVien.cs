using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessData;
namespace IBS_QuanTri.Class
{
    public class cls_NhanVien
    {
        Provider _Provider;
        public cls_NhanVien()
        {
            _Provider = new Provider(clsBienHeThong._ConnectionMAIN);
        }

        public DataTable Get_DonVi()
        {
            return _Provider.ExecuteQuery("proc_Get_DonVi", null);
        }

        public DataTable Get_NhanVien()
        {
            return _Provider.ExecuteQuery("proc_Get_NhanVien", null);
        }

        public bool Insert_NhanVien(string maNV, string matKhau, string hoTen, string msDV)
        {
            SqlParameter[] sqlParameters =  new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@MaNV", SqlDbType.VarChar);
            sqlParameters[0].Value = maNV;
            sqlParameters[1] = new SqlParameter("@MatKhau", SqlDbType.VarChar);
            sqlParameters[1].Value = matKhau;
            sqlParameters[2] = new SqlParameter("@HoTen", SqlDbType.NVarChar);
            sqlParameters[2].Value = hoTen;
            sqlParameters[3] = new SqlParameter("@DonVi", SqlDbType.VarChar);
            sqlParameters[3].Value = msDV;
            return _Provider.ExecuteNonQuery("proc_Insert_NhanVien", sqlParameters);
        }
    }
}
