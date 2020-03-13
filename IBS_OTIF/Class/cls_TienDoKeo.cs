using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessData;
using IBS_OTIF.Entity;

namespace IBS_OTIF.Class
{
    public class cls_TienDoKeo
    {
        Provider _Provider;
        public cls_TienDoKeo()
        {
            _Provider = new Provider(Otif_DungChung._ConnectionString);
        }

        public tbl_BangTienDoKeo_H CreateHeader(tbl_BangTienDoKeo_H header)
        {
            tbl_BangTienDoKeo_H tienDoKeo_H = new tbl_BangTienDoKeo_H();
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@NgayCapNhat", SqlDbType.DateTime);
            sqlParameters[0].Value = header.NgayCapNhat;
            sqlParameters[1] = new SqlParameter("@Tuan", SqlDbType.Int);
            sqlParameters[1].Value = header.Tuan;
            sqlParameters[2] = new SqlParameter("@Nam", SqlDbType.Int);
            sqlParameters[2].Value = header.Nam;
            sqlParameters[3] = new SqlParameter("@DonViID", SqlDbType.Int);
            sqlParameters[3].Value = header.DonViID;
            DataTable data = _Provider.ExecuteQuery("sp_Insert_BangTienDoKeo_H", sqlParameters);
            if (data.Rows.Count > 0)
            {
                tienDoKeo_H.ID = (int)data.Rows[0]["ID"];
                tienDoKeo_H.NgayCapNhat = (DateTime)data.Rows[0]["NgayCapNhat"];
                tienDoKeo_H.Tuan = (int)data.Rows[0]["Tuan"];
                tienDoKeo_H.Nam = (int)data.Rows[0]["Nam"];
                tienDoKeo_H.DonViID = (int)data.Rows[0]["DonViID"];
            }
            return tienDoKeo_H;
        }

        public bool CreateLine(List<tbl_BangTienDoKeo_L> lines)
        {
            //với x là số dòng trong file excel
            //với y là số field cần thêm cho mỗi dòng
            int x = 0;
            int y = 15;

            SqlParameter[,] parameters = new SqlParameter[lines.Count, y];
            foreach (tbl_BangTienDoKeo_L item in lines)
            {
                parameters[x, 0] = new SqlParameter("@ID_Header", SqlDbType.Int);
                parameters[x, 0].Value = item.ID_Header;

                parameters[x, 1] = new SqlParameter("@NGH", SqlDbType.DateTime);
                parameters[x, 1].Value = item.NGH;

                parameters[x, 2] = new SqlParameter("@KHACHHANG", SqlDbType.NVarChar);
                parameters[x, 2].Value = item.KHACHHANG;

                parameters[x, 3] = new SqlParameter("@SOLSX", SqlDbType.VarChar);
                parameters[x, 3].Value = item.SOLSX;

                parameters[x, 4] = new SqlParameter("@MASP", SqlDbType.NVarChar);
                parameters[x, 4].Value = item.MASP;

                parameters[x, 5] = new SqlParameter("@MAMAU", SqlDbType.VarChar);
                parameters[x, 5].Value = item.MAMAU;

                parameters[x, 6] = new SqlParameter("@SLKH", SqlDbType.Int);
                parameters[x, 6].Value = item.SLKH;

                parameters[x, 7] = new SqlParameter("@NSU", SqlDbType.Int);
                parameters[x, 7].Value = item.NSU;

                parameters[x, 8] = new SqlParameter("@DMHC", SqlDbType.Float);
                parameters[x, 8].Value = item.DMHC;

                parameters[x, 9] = new SqlParameter("@NANGSUAT", SqlDbType.Float);
                parameters[x, 9].Value = item.NANGSUAT;

                parameters[x, 10] = new SqlParameter("@CONGCAN", SqlDbType.Float);
                parameters[x, 10].Value = item.CONGCAN;

                parameters[x, 11] = new SqlParameter("@NGAYBATDAU", SqlDbType.DateTime);
                parameters[x, 11].Value = item.NGAYBATDAU;

                parameters[x, 12] = new SqlParameter("@NGAYKETTHUC", SqlDbType.DateTime);
                parameters[x, 12].Value = item.NGAYKETTHUC;

                parameters[x, 13] = new SqlParameter("@COSO", SqlDbType.Int);
                parameters[x, 13].Value = item.COSO;

                parameters[x, 14] = new SqlParameter("@LINE", SqlDbType.Int);
                parameters[x, 14].Value = item.LINE;

                x++;
            }
            return _Provider.ImportExcelToDb("sp_Insert_BangTienDoKeo_L", parameters);
        }
    }
}
