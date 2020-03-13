using AccessData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBS_QuanTri.Class
{
    public class cls_Menu
    {
        Provider _Provider;
        public cls_Menu()
        {
            _Provider = new Provider(clsBienHeThong._ConnectionMAIN);
        }
        public static byte[] ConvertImageToByte(string strPath)
        {
            if (string.IsNullOrEmpty(strPath))
            {
                return null;
            }
            else
            {
                FileStream FS = new FileStream(strPath, FileMode.Open, FileAccess.Read);
                byte[] img = new byte[FS.Length];
                FS.Read(img, 0, Convert.ToInt32(FS.Length));
                return img;
            }
        }
        #region "Nhóm chương trình"
        public bool Insert_NhomChuongTrinh(string tenNhom, string dienGiai)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@TenNhom", SqlDbType.NVarChar);
            sqlParameters[0].Value = tenNhom;
            sqlParameters[1] = new SqlParameter("@DienGiai", SqlDbType.NVarChar);
            sqlParameters[1].Value = dienGiai;
            return _Provider.ExecuteNonQuery("proc_Insert_NhomChuongTrinh", sqlParameters);
        }

        public DataTable Get_NhomChuongTrinh()
        {
            return _Provider.ExecuteQuery("proc_Get_NhomChuongTrinh", null);
        }
        #endregion

        #region "Chương trình"
        public bool Insert_ChuongTrinh(string TenChTr, int NhomChTr)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@TenChTr", SqlDbType.NVarChar);
            sqlParameters[0].Value = TenChTr;
            sqlParameters[1] = new SqlParameter("@NhomChTrID", SqlDbType.Int);
            sqlParameters[1].Value = NhomChTr;
            return _Provider.ExecuteNonQuery("proc_Insert_ChuongTrinh", sqlParameters);
        }
        public DataTable Get_ChuongTrinh()
        {
            return _Provider.ExecuteQuery("proc_Get_ChuongTrinh", null);
        }
        #endregion

        #region "Nhóm menu"
        public DataTable Get_NhomMenu()
        {
            return _Provider.ExecuteQuery("proc_Get_NhomMenu", null);
        }
        public DataTable Get_NhomMenu(int ChTrID)
        {
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@ChTrID", SqlDbType.Int);
            sqlParameters[0].Value = ChTrID;
            return _Provider.ExecuteQuery("proc_Get_NhomMenu_ByChuongTrinh", sqlParameters);
        }

        public bool Insert_NhomMenu(string tenNhom, int ChTrID)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@TenNhom", SqlDbType.NVarChar);
            sqlParameters[0].Value = tenNhom;
            sqlParameters[1] = new SqlParameter("@ChTrID", SqlDbType.Int);
            sqlParameters[1].Value = ChTrID;
            return _Provider.ExecuteNonQuery("proc_Insert_NhomMenu", sqlParameters);
        }
        #endregion

        #region "Danh mục menu"
        public bool Insert_Menu(string tenMenu, string tenForm, string tenModule, int nhomMenuID, string iconPath)
        {
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@TenMenu", SqlDbType.NVarChar);
            sqlParameters[0].Value = tenMenu;
            sqlParameters[1] = new SqlParameter("@TenForm", SqlDbType.NVarChar);
            sqlParameters[1].Value = tenForm;
            sqlParameters[2] = new SqlParameter("@TenModule", SqlDbType.NVarChar);
            sqlParameters[2].Value = tenModule;
            sqlParameters[3] = new SqlParameter("@NhomMenuID", SqlDbType.Int);
            sqlParameters[3].Value = nhomMenuID;
            sqlParameters[4] = new SqlParameter("@Icon", SqlDbType.Image);
            sqlParameters[4].Value = ConvertImageToByte(iconPath);
            return _Provider.ExecuteNonQuery("proc_Insert_Menu", sqlParameters);
        }
        public bool Update_Menu(int menuID, string tenMenu, string tenForm, string tenModule, string iconPath)
        {
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@MenuID", SqlDbType.Int);
            sqlParameters[0].Value = menuID;
            sqlParameters[1] = new SqlParameter("@TenMenu", SqlDbType.NVarChar);
            sqlParameters[1].Value = tenMenu;
            sqlParameters[2] = new SqlParameter("@TenForm", SqlDbType.NVarChar);
            sqlParameters[2].Value = tenForm;
            sqlParameters[3] = new SqlParameter("@TenModule", SqlDbType.NVarChar);
            sqlParameters[3].Value = tenModule;
            sqlParameters[4] = new SqlParameter("@Icon", SqlDbType.Image);
            sqlParameters[4].Value = ConvertImageToByte(iconPath);
            return _Provider.ExecuteNonQuery("proc_Update_Menu", sqlParameters);
        }
        public DataTable Get_Menu()
        {
            return _Provider.ExecuteQuery("proc_Get_Menu", null);
        }
        #endregion

        #region "Phân quyền menu chi tiết"
        public DataTable Get_MenuChiTiet(string maNV, int nhomID)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@manv", SqlDbType.VarChar);
            sqlParameters[0].Value = maNV;
            sqlParameters[1] = new SqlParameter("@nhomid", SqlDbType.VarChar);
            sqlParameters[1].Value = nhomID;
            return _Provider.ExecuteQuery("proc_Get_Menu_ChiTiet", sqlParameters);
        }

        public bool Insert_Quyen_ChiTiet(string maNV, int menuID)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@maNV", SqlDbType.VarChar);
            sqlParameters[0].Value = maNV;
            sqlParameters[1] = new SqlParameter("@menuID", SqlDbType.VarChar);
            sqlParameters[1].Value = menuID;
            return _Provider.ExecuteNonQuery("proc_ThemQuyenMenu_ChiTiet", sqlParameters);
        }

        public bool Delete_Quyen_ChiTiet(string maNV, int menuID)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@maNV", SqlDbType.VarChar);
            sqlParameters[0].Value = maNV;
            sqlParameters[1] = new SqlParameter("@menuID", SqlDbType.VarChar);
            sqlParameters[1].Value = menuID;
            return _Provider.ExecuteNonQuery("proc_XoaQuyenMenu_ChiTiet", sqlParameters);
        }
        
        public bool Insert_PhanQuyenNhom(string maNV, int nhomID)
        {
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@maNV", SqlDbType.VarChar);
            sqlParameters[0].Value = maNV;
            sqlParameters[1] = new SqlParameter("@NhomID", SqlDbType.VarChar);
            sqlParameters[1].Value = nhomID;
            return _Provider.ExecuteNonQuery("proc_proc_PhanQuyenMenu_Nhom", sqlParameters);
        }

        public DataTable Get_DanhSachPhanQuyen()
        {
            return _Provider.ExecuteQuery("proc_DanhSachPhanQuyen", null);
        }
        #endregion
    }
}
