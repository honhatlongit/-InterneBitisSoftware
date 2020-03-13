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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using AccessData;

namespace IBS_OTIF
{
    public partial class uc_KQTongHopTheoTuan : UserControl
    {
        public uc_KQTongHopTheoTuan()
        {
            InitializeComponent();
        }
        cls_DonVi _clsDV;
        cls_Otif _clsOtif;
        private void uc_KQTongHopTheoTuan_Load(object sender, EventArgs e)
        {
            _clsDV = new cls_DonVi();
            _clsOtif = new cls_Otif();
            LoadData();
        }

        private void LoadData()
        {
            DataTable dtDonVi = new DataTable();
            dtDonVi = _clsDV.Get_AllDonVi();
            foreach (DataRow dv in dtDonVi.Rows)
            {
                DataTable dtOTIF = _clsOtif.KetQuaTongHop(clsXuLyChung.GetSafeInt(dv["ID"]),8,2020);
                //Group
                GroupControl group = new GroupControl();
                group.Size = new Size(320, 165);
                group.Text = dv["VIET_TAT"].ToString();
                group.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                group.AppearanceCaption.Font = new Font("Times New Roman", 11);
                //List view
                ListView listView = new ListView();
                listView.Font = new Font("Times New Roman", 10);
                listView.Dock = DockStyle.Fill;
                listView.View = View.Details;
                listView.MultiSelect = false;
                listView.FullRowSelect = true;
                listView.GridLines = true;
                //Create column
                foreach (DataColumn column in dtOTIF.Columns)
                {
                    listView.Columns.Add(column.ColumnName, 100);
                }
                //Add row
                foreach (DataRow row in dtOTIF.Rows)
                {
                    //Nếu chỉ có 1 tuần. column count = 2
                    if (dtOTIF.Columns.Count==2)
                    {
                        ListViewItem lvi = new ListViewItem(row[0].ToString());
                        lvi.SubItems.Add(row[1].ToString());
                        listView.Items.Add(lvi);
                    }
                    else if (dtOTIF.Columns.Count == 3)
                    {
                        ListViewItem lvi = new ListViewItem(row[0].ToString());
                        lvi.SubItems.Add(row[1].ToString());
                        lvi.SubItems.Add(row[2].ToString());
                        listView.Items.Add(lvi);
                    }
                }

                group.Controls.Add(listView);
                flowLayoutPanel.Controls.Add(group);
            }
        }
    }
}
