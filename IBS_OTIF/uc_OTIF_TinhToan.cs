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
    public partial class uc_OTIF_TinhToan : UserControl
    {
        public uc_OTIF_TinhToan()
        {
            InitializeComponent();
        }

        private void btnThayDoiTuan_Click(object sender, EventArgs e)
        {
            Otif_DungChung._Tuan = Otif_DungChung.GetWeek((DateTime)dtpTuanNam.EditValue);
            Otif_DungChung._Nam = ((DateTime)dtpTuanNam.EditValue).Year;
            lblTuanHienTai.Text = string.Format("Tuần hiện tại: {0}/{1}", Otif_DungChung._Tuan, Otif_DungChung._Nam);
            MessageBox.Show("Thay đổi tuần làm việc thành công!", "Thông báo.");
        }

        private void uc_CaiDatChung_Load(object sender, EventArgs e)
        {
            lblTuanHienTai.Text = string.Format("Tuần hiện tại: {0}/{1}", Otif_DungChung._Tuan, Otif_DungChung._Nam);
        }
    }
}
