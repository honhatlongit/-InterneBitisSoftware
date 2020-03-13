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
    public partial class uc_NhomChuongTrinh : UserControl
    {
        cls_Menu _CLS;
        public uc_NhomChuongTrinh()
        {
            InitializeComponent();
        }

        private void uc_NhomChuongTrinh_Load(object sender, EventArgs e)
        {
            _CLS = new cls_Menu();
            LoadNhomChuongTrinh();
        }

        private void LoadNhomChuongTrinh()
        {
            gridControl.DataSource = _CLS.Get_NhomChuongTrinh();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNhom.EditValue!=null && txtDienGiai.EditValue!=null)
            {
                string tenNhom, dienGiai;
                tenNhom = txtTenNhom.EditValue.ToString();
                dienGiai = txtDienGiai.EditValue.ToString();
                if (!string.IsNullOrEmpty(tenNhom) && !string.IsNullOrEmpty(dienGiai))
                {
                    if (_CLS.Insert_NhomChuongTrinh(tenNhom, dienGiai))
                    {
                        MessageBox.Show("Thêm nhóm chương trình thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình thêm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
