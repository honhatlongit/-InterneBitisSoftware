using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBS_OTIF
{
    public partial class uc_LeadTimeSX : UserControl
    {
        public uc_LeadTimeSX()
        {
            InitializeComponent();
        }

        private void uc_LeadTimeSX_Load(object sender, EventArgs e)
        {
            dtpTuNgay.EditValue = DateTime.Now.AddDays(-1);
            dtpDenNgay.EditValue = DateTime.Now;
        }
    }
}
