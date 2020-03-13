using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Main.Class;
using AccessData;
using Main.Properties;

namespace Main
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        cls_Login _CLS;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtuser.Text = Settings.Default.MaNV;
            txtpass.Text = Settings.Default.MatKhau;
            chkremember.Checked = Settings.Default.Remember;
            _CLS = new cls_Login();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;
            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(pass))
            {
                DataTable dtLogin = _CLS.Check_Login(user, pass, clsBienHeThong._ChuongTrinhID);
                if (dtLogin.Rows.Count>0)
                {
                    if ((bool)dtLogin.Rows[0]["TrangThai"])
                    {
                        bool remember = chkremember.Checked;
                        Settings.Default.MaNV = remember ? txtuser.Text : string.Empty;
                        Settings.Default.MatKhau = remember ? txtpass.Text : string.Empty;
                        Settings.Default.Remember = remember;
                        Settings.Default.Save();
                        clsBienHeThong._MaNV = user;
                        this.Hide();
                        frmMain frm = new frmMain();
                        frm.Show();
                        frm.FormClosed += Frm_FormClosed;
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản của bạn đã bị khóa. \n Vui lòng liên hệ P.CNTT.", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. \n Hoặc bạn không có quyền truy cập vào đây.", "Thông báo");
                }
            }
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            if (!Settings.Default.Remember)
            {
                txtuser.Text = string.Empty;
                txtpass.Text = string.Empty;
            }
        }
    }
}