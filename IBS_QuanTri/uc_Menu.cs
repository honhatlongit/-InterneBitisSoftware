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
using System.IO;

namespace IBS_QuanTri
{
    public partial class uc_Menu : UserControl
    {
        public uc_Menu()
        {
            InitializeComponent();
        }
        cls_Menu _CLS;


        private void uc_Menu_Load(object sender, EventArgs e)
        {
            _CLS = new cls_Menu();
            Load_Menu();
            Load_ChuongTrinh();
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

        private void Load_NhomMenu(int ChTrID)
        {
            glueNhomMenu.Properties.DataSource = _CLS.Get_NhomMenu(ChTrID);
            glueNhomMenu.Properties.DisplayMember = "TenNhom";
            glueNhomMenu.Properties.ValueMember = "ID";
            glueNhomMenu.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            glueNhomMenu.Properties.ImmediatePopup = true;
            glueNhomMenu.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private void glueChuongTrinh_EditValueChanged(object sender, EventArgs e)
        {
            if (glueChuongTrinh.EditValue == null) return;
            int ChTrID = clsXuLyChung.GetSafeInt(glueChuongTrinh.EditValue);
            Load_NhomMenu(ChTrID);
        }

        private void ClearControl()
        {
            txtTenMenu.EditValue = string.Empty;
            txtTenForm.EditValue = string.Empty;
            txtModule.EditValue = string.Empty;
            txtIconPath.Text = string.Empty;
            picIcon.Image = null;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void Load_Menu()
        {
            gridControl.DataSource = _CLS.Get_Menu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenMenu.EditValue == null || txtTenForm.EditValue == null || txtModule.EditValue == null || glueChuongTrinh.EditValue == null || glueNhomMenu.EditValue == null) return;
            string tenMenu, tenForm, tenModule, iconPath;
            int NhomID;
            tenMenu = txtTenMenu.EditValue.ToString();
            tenForm = txtTenForm.EditValue.ToString();
            tenModule = txtModule.EditValue.ToString();
            iconPath = txtIconPath.Text;
            NhomID = clsXuLyChung.GetSafeInt(glueNhomMenu.EditValue);
            if (string.IsNullOrEmpty(tenMenu) || string.IsNullOrEmpty(tenForm) || string.IsNullOrEmpty(tenModule)) return;
            if (_CLS.Insert_Menu(tenMenu, tenForm,tenModule,NhomID, iconPath))
            {
                ClearControl();
                Load_Menu();
                MessageBox.Show("Tạo menu thành công.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình tạo menu.", "Thông báo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChooseIcon_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr==DialogResult.OK)
            {
                txtIconPath.Text = Path.GetFullPath(openFileDialog.FileName).Trim();
                picIcon.Image = Image.FromFile(txtIconPath.Text);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            picIcon.Image = null;
            glueChuongTrinh.Enabled = true;
            glueNhomMenu.Enabled = true;
            txtTenMenu.EditValue = "";
            txtTenForm.EditValue = "";
            txtModule.EditValue = "";
            txtIconPath.Text = "";
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void gridView2_Click(object sender, EventArgs e)
        {
            if (gridView2.GetFocusedDataRow()!=null)
            {
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                glueChuongTrinh.Enabled = false;
                glueNhomMenu.Enabled = false;
                txtTenMenu.EditValue = gridView2.GetFocusedDataRow()["TenMenu"].ToString();
                txtTenForm.EditValue = gridView2.GetFocusedDataRow()["TenForm"].ToString();
                txtModule.EditValue = gridView2.GetFocusedDataRow()["TenModule"].ToString();
                if (gridView2.GetFocusedDataRow()["Icon"].ToString()!="")
                {
                    picIcon.Image = clsXuLyChung.ConvertByteToImage((byte[])gridView2.GetFocusedDataRow()["Icon"]);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenMenu.EditValue == null || txtTenForm.EditValue == null || txtModule.EditValue == null ) return;
            string tenMenu, tenForm, tenModule, iconPath;
            int menuID = int.Parse(gridView2.GetFocusedDataRow()["MenuID"].ToString());
            Image icon = picIcon.Image;
            tenMenu = txtTenMenu.EditValue.ToString();
            tenForm = txtTenForm.EditValue.ToString();
            tenModule = txtModule.EditValue.ToString();
            iconPath = txtIconPath.Text;

            if (_CLS.Update_Menu(menuID,tenMenu, tenForm, tenModule, txtIconPath.Text))
            {
                MessageBox.Show("Cập nhật thành công");
                Load_Menu();
                ClearControl();
            }
            else
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật", "Opps");
            }
        }
    }
}
