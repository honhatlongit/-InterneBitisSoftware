using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBS_QuanTri.Class;
using AccessData;

namespace IBS_QuanTri
{
    public partial class uc_PhanQuyenMenu : UserControl
    {
        public uc_PhanQuyenMenu()
        {
            InitializeComponent();
        }
        cls_NhanVien _clsNhanVien;
        cls_Menu _clsMenu;
        private void uc_PhanQuyenMenu_Load(object sender, EventArgs e)
        {
            _clsNhanVien = new cls_NhanVien();
            _clsMenu = new cls_Menu();

            gvNhanVien.BestFitColumns();
            gvChuongTrinh.BestFitColumns();
            gvNhomMenu.BestFitColumns();
            gvMenu.BestFitColumns();

            Load_NhanVien();
            Load_ChuongTrinh();
        }

        private void Load_NhanVien()
        {
            gridNhanVien.DataSource = _clsNhanVien.Get_NhanVien();
        }

        private void Load_ChuongTrinh()
        {
            gridChuongTrinh.DataSource = _clsMenu.Get_ChuongTrinh();
        }

        private void Load_NhomMenu(int ChTrID)
        {
            gridNhomMenu.DataSource = _clsMenu.Get_NhomMenu(ChTrID);
        }

        private void Load_Menu(string maNV, int nhomID)
        {
            gridMenu.DataSource = _clsMenu.Get_MenuChiTiet(maNV, nhomID);
        }

        private void gvNhanVien_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (gvNhanVien.IsRowSelected(e.RowHandle))
            {
                e.Appearance.BackColor = Color.WhiteSmoke;
                e.Appearance.BackColor2 = Color.Orange;
            }
        }

        private void gvChuongTrinh_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (gvChuongTrinh.IsRowSelected(e.RowHandle))
            {
                e.Appearance.BackColor = Color.WhiteSmoke;
                e.Appearance.BackColor2 = Color.Orange;
            }
        }
        private void gvNhomMenu_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (gvNhomMenu.IsRowSelected(e.RowHandle))
            {
                e.Appearance.BackColor = Color.WhiteSmoke;
                e.Appearance.BackColor2 = Color.Orange;
            }
        }

        private void gridChuongTrinh_Click(object sender, EventArgs e)
        {
            gridNhomMenu.DataSource = null;
            gridMenu.DataSource = null;
            if (gvChuongTrinh.GetFocusedRow()!=null)
            {
                Load_NhomMenu(clsXuLyChung.GetSafeInt(gvChuongTrinh.GetFocusedDataRow()["ID"]));
            }
        }

        private void gridNhomMenu_Click(object sender, EventArgs e)
        {
            gridMenu.DataSource = null;
            if (gvNhomMenu.GetFocusedRow()!=null)
            {
                Load_Menu(clsXuLyChung.GetSafeString(gvNhanVien.GetFocusedDataRow()["MaNV"]), clsXuLyChung.GetSafeInt(gvNhomMenu.GetFocusedDataRow()["ID"]));
            }
        }

        private void gridNhanVien_Click(object sender, EventArgs e)
        {
            gridNhomMenu.DataSource = null;
            gridMenu.DataSource = null;

            if (gvNhomMenu.GetFocusedRow()!=null)
            {
                Load_ChuongTrinh();
            }
        }

        private void gvMenu_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            string msNV = clsXuLyChung.GetSafeString(gvNhanVien.GetFocusedDataRow()["MaNV"]);
            int menuID = clsXuLyChung.GetSafeInt(gvMenu.GetFocusedDataRow()["MenuID"]);
            bool check = clsXuLyChung.GetSafeBool(gvMenu.GetFocusedDataRow()["SuDung"]);
            //MessageBox.Show(clsXuLyChung.GetSafeString(gvMenu.GetFocusedDataRow()["TenMenu"]));
            if (check)
            {
                if (!_clsMenu.Insert_Quyen_ChiTiet(msNV, menuID))
                {
                    MessageBox.Show("Có lỗi trong quá trình cập nhật.", "Thông báo");
                }
            }
            else
            {
                if (!_clsMenu.Delete_Quyen_ChiTiet(msNV, menuID))
                {
                    MessageBox.Show("Có lỗi trong quá trình cập nhật.", "Thông báo");
                }
            }
        }
    }
}
