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
    public partial class uc_NhomMenu : UserControl
    {
        public uc_NhomMenu()
        {
            InitializeComponent();
        }
        cls_Menu _CLS;
        private void uc_NhomMenu_Load(object sender, EventArgs e)
        {
            _CLS = new cls_Menu();
            Load_NhomMenu();
            Load_ChuongTrinh();
        }

        private void Load_NhomMenu()
        {
            gridControl.DataSource = _CLS.Get_NhomMenu();
        }

        private void Load_ChuongTrinh()
        {
            glueChuongTrinh.Properties.DataSource = _CLS.Get_ChuongTrinh();
            glueChuongTrinh.Properties.DisplayMember = "TenChuongTrinh";
            glueChuongTrinh.Properties.ValueMember = "ID";
            glueChuongTrinh.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            glueChuongTrinh.Properties.ImmediatePopup = true;
            glueChuongTrinh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenNhomMenu.EditValue!=null && glueChuongTrinh.EditValue!=null)
            {
                string tenNhomMenu = txtTenNhomMenu.EditValue.ToString();
                int ChTrID = clsXuLyChung.GetSafeInt(glueChuongTrinh.EditValue);
                if (_CLS.Insert_NhomMenu(tenNhomMenu,ChTrID))
                {
                    MessageBox.Show("Thêm nhóm menu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Load_NhomMenu();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm nhóm menu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
