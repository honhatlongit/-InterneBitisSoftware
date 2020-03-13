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
    public partial class uc_OTIF_ChiTiet : UserControl
    {
        public uc_OTIF_ChiTiet()
        {
            InitializeComponent();
        }
        cls_Otif _clsOTIF;
        private void uc_OTIF_ChiTiet_Load(object sender, EventArgs e)
        {
            _clsOTIF = new cls_Otif();
            LoadData();
            gridView1.BestFitColumns();
        }

        private void LoadData()
        {
            gridControl.DataSource = _clsOTIF.Otif_ChiTiet(8, 2020);
        }
    }
}
