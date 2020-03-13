using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBS_OTIF.Class;

namespace IBS_OTIF
{
    public partial class uc_LaySanLuong : UserControl
    {
        public uc_LaySanLuong()
        {
            InitializeComponent();
        }
        cls_SanLuong _clsSL;
        private void uc_LaySanLuong_Load(object sender, EventArgs e)
        {
            _clsSL = new cls_SanLuong();
            Otif_DungChung.GetDonVi();
            dtpTuNgay.EditValue = DateTime.Now;
            dtpDenNgay.EditValue = DateTime.Now;
        }

        private void LaySanLuongKHKD(int dvID, DateTime tuNgay, DateTime denNgay)
        {
            gridControl.DataSource = _clsSL.LaySanLuongKHKD(dvID, tuNgay, denNgay);
        }

        private void XemSanLuong(int dvID, DateTime tuNgay, DateTime denNgay)
        {
            gridControl.DataSource = _clsSL.XemSanLuong(dvID, tuNgay, denNgay);
        }

        private void btnLaySanLuong_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.EditValue == null || dtpDenNgay.EditValue == null) return;
            gridControl.DataSource = null;
            LaySanLuongKHKD(Otif_DungChung._DonViID, (DateTime)dtpTuNgay.EditValue, (DateTime)dtpDenNgay.EditValue);
            XemSanLuong(Otif_DungChung._DonViID, (DateTime)dtpTuNgay.EditValue, (DateTime)dtpDenNgay.EditValue);
        }

        private void btnXemSanLuong_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.EditValue == null || dtpDenNgay.EditValue == null) return;
            gridControl.DataSource = null;
            XemSanLuong(Otif_DungChung._DonViID, (DateTime)dtpTuNgay.EditValue, (DateTime)dtpDenNgay.EditValue);
        }
    }
}
