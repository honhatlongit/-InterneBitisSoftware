using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.DataAccess.Excel;
using System.Net;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using IBS_OTIF.Entity;
using AccessData;
using IBS_OTIF.Class;

namespace IBS_OTIF
{
    public partial class uc_TienDoKeo : UserControl
    {
        public uc_TienDoKeo()
        {
            InitializeComponent();
        }
        cls_TienDoKeo _clsTDK;
        cls_DonVi _clsDV;
        private void uc_TienDoKeo_Load(object sender, EventArgs e)
        {
            Otif_DungChung.GetDonVi();
            dtpTuanNam.EditValue = DateTime.Now;

            _clsTDK = new cls_TienDoKeo();
            _clsDV = new cls_DonVi();

            gvTienDoKeo.BestFitColumns();

            Load_KhauSanXuat();

            groupControl3.Text = string.Format("Tiến độ kéo tuần {0} năm {1}", Otif_DungChung.GetWeek(DateTime.Now), DateTime.Now.Year);
        }

        private void LoadFileExcelToGrid(string path)
        {
            ExcelDataSource excelDataSource = new ExcelDataSource();
            excelDataSource.Name = "Excel Data Source";
            excelDataSource.FileName = path;
            ExcelWorksheetSettings worksheetSettings = new ExcelWorksheetSettings("SheetTienDoKeo", "A1:N2000");
            excelDataSource.SourceOptions = new ExcelSourceOptions(worksheetSettings);
            excelDataSource.Fill();

            gridTienDoKeo.DataSource = excelDataSource;
        }

        private void Load_KhauSanXuat()
        {
            glueKhau.Properties.DataSource = _clsDV.Get_AllDonVi();
            glueKhau.Properties.DisplayMember = "TEN_DV";
            glueKhau.Properties.ValueMember = "ID";
            glueKhau.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            glueKhau.Properties.ImmediatePopup = true;
            glueKhau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
        }

        private void lblDownloadFile_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                WebClient webClient = new WebClient();
                Uri uri = new Uri(@"file://192.1.1.20/otif$/BieuMau/Otif_TienDoKeo.xlsx");
                webClient.DownloadFileAsync(uri, saveFileDialog.FileName);
                XtraMessageBox.Show("Tải biểu mẫu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                txtPath.EditValue = openFileDialog.FileName;
            }
        }

        private void btnViewFile_Click(object sender, EventArgs e)
        {
            if (txtPath.EditValue != null)
            {
                LoadFileExcelToGrid(txtPath.EditValue.ToString());
            }
        }

        private DataTable GetDataTable(GridView view)
        {
            DataTable dt = new DataTable();
            try
            {
                foreach (GridColumn c in view.Columns)
                    dt.Columns.Add(c.FieldName, c.ColumnType);
                for (int r = 0; r < view.RowCount; r++)
                {
                    object[] rowValues = new object[dt.Columns.Count];
                    for (int c = 0; c < dt.Columns.Count; c++)
                        rowValues[c] = view.GetRowCellValue(r, dt.Columns[c].ColumnName);
                    dt.Rows.Add(rowValues);
                }

                //Convert data
                for (int r = 0; r < dt.Rows.Count; r++)
                {
                    if (string.IsNullOrEmpty(dt.Rows[r][5].ToString()))
                        dt.Rows[r][5] = -1;
                    if (string.IsNullOrEmpty(dt.Rows[r][7].ToString()))
                        dt.Rows[r][7] = -1;
                    if (string.IsNullOrEmpty(dt.Rows[r][8].ToString()))
                        dt.Rows[r][8] = -1;
                    if (string.IsNullOrEmpty(dt.Rows[r][9].ToString()))
                        dt.Rows[r][9] = -1;
                    if (string.IsNullOrEmpty(dt.Rows[r][10].ToString()))
                        dt.Rows[r][10] = -1;
                    if (string.IsNullOrEmpty(dt.Rows[r][11].ToString()))
                        dt.Rows[r][11] = -1;
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Có lỗi trong quá trình xử lý.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DataTable data = GetDataTable(gvTienDoKeo);
            if (data.Rows.Count <= 0)
            {
                XtraMessageBox.Show("Vui lòng view file trước khi import.", "Có lỗi trong quá trình upload excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Tạo bảng header
            //Đối với user admin được quyền chọn thời gian, đơn vị để up tiến độ kéo
            tbl_BangTienDoKeo_H header = new tbl_BangTienDoKeo_H();
            if (glueKhau.EditValue!=null && (clsBienHeThong._MaNV=="admin" || Otif_DungChung._DonViID==34) )
            {
                header = _clsTDK.CreateHeader(new tbl_BangTienDoKeo_H()
                {
                    Tuan = Otif_DungChung.GetWeek((DateTime)dtpTuanNam.EditValue),
                    Nam = ((DateTime)dtpTuanNam.EditValue).Year,
                    DonViID = clsXuLyChung.GetSafeInt(glueKhau.EditValue),
                    NgayCapNhat = DateTime.Now
                });
            }
            else
            {
                header = _clsTDK.CreateHeader(new tbl_BangTienDoKeo_H()
                {
                    Tuan = Otif_DungChung.GetWeek(DateTime.Now),
                    Nam = DateTime.Now.Year,
                    DonViID = Otif_DungChung._DonViID,
                    NgayCapNhat = DateTime.Now
                });
            }
            //Xử lý data thành List<tbl_BangTienDoKeo_L>
            List<tbl_BangTienDoKeo_L> tienDoKeos = new List<tbl_BangTienDoKeo_L>();
            foreach (DataRow row in data.Rows)
            {
                tbl_BangTienDoKeo_L tienDoKeo_L = new tbl_BangTienDoKeo_L();
                tienDoKeo_L.ID_Header = header.ID;
                tienDoKeo_L.NGH = (DateTime)row[0];
                tienDoKeo_L.KHACHHANG = row[1].ToString();
                tienDoKeo_L.SOLSX = row[2].ToString();
                tienDoKeo_L.MASP = row[3].ToString();
                tienDoKeo_L.MAMAU = row[4].ToString();
                tienDoKeo_L.COSO = Convert.ToInt32(row[5]);
                tienDoKeo_L.SLKH = Convert.ToInt32(row[6]);
                tienDoKeo_L.NSU = Convert.ToInt32(row[7]);
                tienDoKeo_L.DMHC = Convert.ToDouble(row[8]);
                tienDoKeo_L.NANGSUAT = Convert.ToDouble(row[9]);
                tienDoKeo_L.CONGCAN = Convert.ToDouble(row[10]);
                tienDoKeo_L.LINE = Convert.ToInt32(row[11]);
                tienDoKeo_L.NGAYBATDAU = (DateTime)row[12];
                tienDoKeo_L.NGAYKETTHUC = (DateTime)row[13];

                tienDoKeos.Add(tienDoKeo_L);
            }

            //MessageBox.Show(tienDoKeos.Count.ToString());
            if (_clsTDK.CreateLine(tienDoKeos))
            {
                XtraMessageBox.Show("Import excel thành công.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                XtraMessageBox.Show("Import không thành công.", "Có lỗi trong quá trình upload excel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpTuanNam_EditValueChanged(object sender, EventArgs e)
        {
            groupControl3.Text = string.Format("Tiến độ kéo tuần {0} năm {1}", Otif_DungChung.GetWeek((DateTime)dtpTuanNam.EditValue), ((DateTime)dtpTuanNam.EditValue).Year);
        }
    }
}
