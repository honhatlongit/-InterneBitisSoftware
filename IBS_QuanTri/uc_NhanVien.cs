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

namespace IBS_QuanTri
{
    public partial class uc_NhanVien : UserControl
    {
        public uc_NhanVien()
        {
            InitializeComponent();
        }
        cls_NhanVien _CLS;
        private void uc_NhanVien_Load(object sender, EventArgs e)
        {
            _CLS = new cls_NhanVien();

            Load_NhanVien();
            Load_DonVi();
        }

        private void Load_NhanVien()
        {
            gridControl.DataSource = _CLS.Get_NhanVien();
        }

        private void btnTaoNguoiDung_Click(object sender, EventArgs e)
        {
            if (txtHoTen.EditValue == null || txtMaNV.EditValue == null || txtMatKhau.EditValue == null || glueDonVi.EditValue == null) return;
            string hoTen, maNV, matKhau, msDV;
            hoTen = txtHoTen.EditValue.ToString();
            maNV = txtMaNV.EditValue.ToString();
            matKhau = txtMatKhau.EditValue.ToString();
            msDV = glueDonVi.EditValue.ToString();
            if (_CLS.Insert_NhanVien(maNV,matKhau,hoTen,msDV))
            {
                MessageBox.Show("Tạo nhân viên thành công.", "Thông báo");
                ClearControl();
                Load_NhanVien();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình tạo nhân viên.", "Thông báo");
            }
        }

        private void Load_DonVi()
        {
            glueDonVi.Properties.DataSource = _CLS.Get_DonVi();
            glueDonVi.Properties.DisplayMember = "TenDonVi";
            glueDonVi.Properties.ValueMember = "MS_DV";
            glueDonVi.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            glueDonVi.Properties.ImmediatePopup = true;
            glueDonVi.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private void ClearControl()
        {
            txtHoTen.EditValue = string.Empty;
            txtMaNV.EditValue = string.Empty;
            txtMatKhau.EditValue = "ibs";
        }
    }
}
