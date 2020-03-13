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
    public partial class uc_ChuongTrinh : UserControl
    {
        public uc_ChuongTrinh()
        {
            InitializeComponent();
        }
        cls_Menu _CLS;
        private void uc_ChuongTrinh_Load(object sender, EventArgs e)
        {
            _CLS = new cls_Menu();
            Load_ChuongTrinh();
            Load_NhomChuongTrinh();
        }

        private void Load_ChuongTrinh()
        {
            gridControl.DataSource = _CLS.Get_ChuongTrinh();
        }

        private void Load_NhomChuongTrinh()
        {
            glueNhomChuongTrinh.Properties.DataSource = _CLS.Get_NhomChuongTrinh();
            glueNhomChuongTrinh.Properties.DisplayMember = "TenNhom";
            glueNhomChuongTrinh.Properties.ValueMember = "ID";
            glueNhomChuongTrinh.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            glueNhomChuongTrinh.Properties.ImmediatePopup = true;
            glueNhomChuongTrinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenChuongTrinh.EditValue != null && glueNhomChuongTrinh.EditValue != null)
            {
                string tenChTr = txtTenChuongTrinh.EditValue.ToString();
                int nhomChTr = clsXuLyChung.GetSafeInt(glueNhomChuongTrinh.EditValue);
                if (_CLS.Insert_ChuongTrinh(tenChTr, nhomChTr))
                {
                    MessageBox.Show("Thêm chương trình thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Load_ChuongTrinh();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm chương trình.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
