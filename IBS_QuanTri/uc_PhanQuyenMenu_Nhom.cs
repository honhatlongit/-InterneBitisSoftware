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
    public partial class uc_PhanQuyenMenu_Nhom : UserControl
    {
        public uc_PhanQuyenMenu_Nhom()
        {
            InitializeComponent();
        }
        cls_NhanVien _clsNV;
        cls_Menu _clsMenu;
        private void uc_PhanQuyenMenu_Nhom_Load(object sender, EventArgs e)
        {
            _clsNV = new cls_NhanVien();
            _clsMenu = new cls_Menu();

            gridView3.BestFitColumns();

            LoadNhanVien();
            LoadChuongTrinh();
            LoadDanhSachQuyen();
        }

        private void LoadNhanVien()
        {
            glueNhanVien.Properties.DataSource = _clsNV.Get_NhanVien();
            glueNhanVien.Properties.DisplayMember = "HoTen";
            glueNhanVien.Properties.ValueMember = "MaNV";
            glueNhanVien.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            glueNhanVien.Properties.ImmediatePopup = true;
            glueNhanVien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private void LoadChuongTrinh()
        {
            glueChuongTrinh.Properties.DataSource = _clsMenu.Get_ChuongTrinh();
            glueChuongTrinh.Properties.DisplayMember = "TenChuongTrinh";
            glueChuongTrinh.Properties.ValueMember = "ID";
            glueChuongTrinh.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            glueChuongTrinh.Properties.ImmediatePopup = true;
            glueChuongTrinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private void LoadDanhSachQuyen()
        {
            gridControl.DataSource = _clsMenu.Get_DanhSachPhanQuyen();
        }

        private void LoadNhomMenu(int ChTrID)
        {
            glueNhomMenu.Properties.DataSource = _clsMenu.Get_NhomMenu(ChTrID);
            glueNhomMenu.Properties.DisplayMember = "TenNhom";
            glueNhomMenu.Properties.ValueMember = "ID";
            glueNhomMenu.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            glueNhomMenu.Properties.ImmediatePopup = true;
            glueNhomMenu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private void glueChuongTrinh_EditValueChanged(object sender, EventArgs e)
        {
            if (glueChuongTrinh.EditValue!=null)
            {
                LoadNhomMenu(clsXuLyChung.GetSafeInt(glueChuongTrinh.EditValue));
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (glueNhanVien.EditValue == null || glueChuongTrinh.EditValue == null || glueNhomMenu.EditValue == null) return;

            string maNV = glueNhanVien.EditValue.ToString();
            int nhomID = clsXuLyChung.GetSafeInt(glueNhomMenu.EditValue);
            if (_clsMenu.Insert_PhanQuyenNhom(maNV,nhomID))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                LoadDanhSachQuyen();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật.", "Opps");
            }
        }
    }
}
