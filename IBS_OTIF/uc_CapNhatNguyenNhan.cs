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
    public partial class uc_CapNhatNguyenNhan : UserControl
    {
        cls_CapNhatLoi _clsCNL;
        public uc_CapNhatNguyenNhan()
        {
            InitializeComponent();
        }

        private void uc_CapNhatNguyenNhan_Load(object sender, EventArgs e)
        {
            _clsCNL = new cls_CapNhatLoi();
            View_CapNhatLoi();
            LoadNguyenNhan();
            gridView.BestFitColumns();
        }

        private void View_CapNhatLoi()
        {
            int tuan, nam;
            DateTime date = DateTime.Now.AddDays(-7);
            tuan = date.GetWeek();
            nam = date.Year;
            //Test 8, 2020
            tuan = 8;
            nam = 2020;
            gridControl.DataSource = _clsCNL.View_CapNhatLoi(Otif_DungChung._DonViID, tuan, nam);
        }

        private void LoadNguyenNhan()
        {
            riglueNguyenNhan.DataSource = _clsCNL.View_NguyenNhan();
            riglueNguyenNhan.ValueMember = "MaNN";
            riglueNguyenNhan.DisplayMember = "NguyenNhan";
            riglueNguyenNhan.NullText = "Vui lòng chọn nguyên nhân";
            gcNguyenNhan.ColumnEdit = riglueNguyenNhan;

        }

        private void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //Cập nhật nguyên nhân
            if (e.Column.FieldName== "MaNN")
            {
                string maNguyenNhan = gridView.GetRowCellValue(e.RowHandle, e.Column).ToString();
                string id = gridView.GetFocusedRowCellValue("ID").ToString();
                if (!_clsCNL.Update_NguyenNhan(id,maNguyenNhan))
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý.", "Opps!");
                }
            }
            //Cập nhật đơn vị gây ra
            if (e.Column.FieldName== "DonViGayRa")
            {
                string dvGayRa = gridView.GetRowCellValue(e.RowHandle, e.Column).ToString();
                string id = gridView.GetFocusedRowCellValue("ID").ToString();
                if (!_clsCNL.Update_DonViGayRa(id,dvGayRa))
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý.", "Opps!");
                }
            }
        }
    }
}
