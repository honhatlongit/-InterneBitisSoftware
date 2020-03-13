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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraCharts;

namespace IBS_OTIF
{
    public partial class uc_TongHopTheoTuan : UserControl
    {
        public uc_TongHopTheoTuan()
        {
            InitializeComponent();
        }
        cls_Otif _clsOtif;
        private void uc_TongHopTheoTuan_Load(object sender, EventArgs e)
        {
            _clsOtif = new cls_Otif();

            TongHopTheoTDK(Otif_DungChung._Tuan, Otif_DungChung._Nam);
            TongHopTheoDP(Otif_DungChung._Tuan, Otif_DungChung._Nam);
            TongHopTheoTuan(Otif_DungChung._Tuan, Otif_DungChung._Nam);
            gvTongHopDP.BestFitColumns();
        }

        private void TongHopTheoTDK(int tuan, int nam)
        {
            if (tuan==1)
            {
                tuan = 52;
                nam = nam - 1;
            }
            else
            {
                tuan = tuan - 1;
            }
            DataTable data = _clsOtif.TongHopTuanTheoTDK(tuan, nam);
            gridTongHopTDK.DataSource = data;
            groupTDK.Text = string.Format("Tính toán OTIF tuần {0} năm {1} (Theo ngày của TĐK)", tuan, nam);
            if (data.Rows.Count>0)
            {
                //Group
                GridColumn colTenDV = gvTongHopTDK.Columns["TEN_DV"];
                gvTongHopTDK.BeginSort();
                try
                {
                    gvTongHopTDK.ClearGrouping();
                    colTenDV.GroupIndex = 0;
                }
                finally
                {
                    gvTongHopTDK.EndSort();
                }
            }
            gvTongHopTDK.BestFitColumns();
        }

        private void TongHopTheoDP(int tuan, int nam)
        {
            if (tuan == 1)
            {
                tuan = 52;
                nam = nam - 1;
            }
            else
            {
                tuan = tuan - 1;
            }
            DataTable data = _clsOtif.TongHopTuanTheoNgayDP(tuan, nam);
            gridTongHopDP.DataSource = data;
            groupNDP.Text = string.Format("Tính toán OTIF tuần {0} năm {1} (Theo ngày điều phối của phòng kế hoạch)", tuan, nam);

            if (data.Rows.Count>0)
            {
                gvTongHopDP.BeginSort();
                GridColumn colTenDV = gvTongHopDP.Columns["DienGiai"];
                try
                {
                    gvTongHopDP.ClearGrouping();
                    colTenDV.GroupIndex = 0;
                }
                finally
                {
                    gvTongHopDP.EndSort();
                }
            }
        }

        private void TongHopTheoTuan(int tuan, int nam)
        {
            if (tuan == 1)
            {
                tuan = 52;
                nam = nam - 1;
            }
            else
            {
                tuan = tuan - 1;
            }
            gridTongHopTuanHT.DataSource = _clsOtif.TongHopTuan(tuan, nam);
            groupTongHop.Text = string.Format("Tổng hợp OTIF tuần {0} năm {1}", tuan, nam);
            //Display chart
            DataTable dtChart = _clsOtif.TongHopTuan_BieuDo(tuan, nam);
            try
            {
                foreach (DataRow row in dtChart.Rows)
                {
                    chartControl1.Series["Otif_Dat"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(row["VIET_TAT"].ToString(), row["Value"]));
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        
    }
}
