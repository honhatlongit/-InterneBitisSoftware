using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Main.Class;
using AccessData;
using System.Reflection;
using DevExpress.LookAndFeel;

namespace Main
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        cls_Menu _CLS;
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            InitSkins("Summer 2008");
            //
            _CLS = new cls_Menu();
            KhoiTaoMenu();
        }
        private void InitSkins(string skins)
        {
            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle(skins);
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn đăng nhập lại không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.No)
            {
                Application.ExitThread();
            }
            else if (res == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void KhoiTaoMenu()
        {
            //create all page
            ribbon.Pages.Clear();
            DataTable dtNhomMenu = _CLS.Load_NhomMenu(clsBienHeThong._MaNV, clsBienHeThong._ChuongTrinhID);
            //Tạo ribbonPage
            foreach (DataRow nhom in dtNhomMenu.Rows)
            {
                RibbonPage ribbonPage = new RibbonPage();
                ribbonPage.Text = nhom["TenNhom"].ToString();
                //Tạo ribbonpageGroup mặc định
                RibbonPageGroup pageGroup = new RibbonPageGroup();
                pageGroup.Text = nhom["TenNhom"].ToString();
                //Tạo menu trong pageGroup
                DataTable dtMenu = _CLS.Load_Menu(clsBienHeThong._MaNV, (int)nhom["ID"]);
                int countMenu = dtMenu.Rows.Count;
                foreach (DataRow menu in dtMenu.Rows)
                {
                    BarButtonItem buttonMenu = new BarButtonItem();
                    buttonMenu.Caption = menu["TenMenu"].ToString(); //Tên hiện thị
                    buttonMenu.Tag = menu["TenForm"].ToString(); //Tên form
                    buttonMenu.Name = menu["TenModule"].ToString(); //Tên module

                    if (menu["Icon"].ToString() != "")
                    {
                        if (countMenu<=10)
                        {
                            buttonMenu.ImageOptions.LargeImage = clsXuLyChung.ConvertByteToImage((byte[])menu["Icon"]);
                        }
                        else
                        {
                            buttonMenu.ImageOptions.Image = clsXuLyChung.ConvertByteToImage((byte[])menu["Icon"]);
                        }
                    }
                    buttonMenu.ItemAppearance.Disabled.Font = new Font("Times New Roman", 11);
                    buttonMenu.ItemAppearance.Hovered.Font = new Font("Times New Roman", 11);
                    buttonMenu.ItemAppearance.Normal.Font = new Font("Times New Roman", 11);
                    buttonMenu.ItemAppearance.Pressed.Font = new Font("Times New Roman", 11);
                    buttonMenu.ItemClick += ButtonMenu_ItemClick;
                    pageGroup.ItemLinks.Add(buttonMenu);
                }
                ribbonPage.Groups.Add(pageGroup);
                ribbon.Pages.Add(ribbonPage);
            }
        }

        private void ButtonMenu_ItemClick(object sender, ItemClickEventArgs e)
        {
            //MessageBox.Show(e.Item.Tag.ToString(), e.Item.Name.ToString());
            ShowUC(e.Item.Tag.ToString(), e.Item.Name.ToString());
        }

        public void ShowUC(string tenmenu, string module)
        {
            Type tmp;
            pnBody.Controls.Clear();
            try
            {
                if (tenmenu.Substring(0, 2).ToUpper() == "UC")
                {
                    Assembly assemblyProject = Assembly.LoadFile(string.Format(@"{0}\{1}.dll", Application.StartupPath, module));
                    tmp = assemblyProject.GetType(module + "." + tenmenu, false, true);
                    UserControl uctmp = new UserControl();
                    uctmp = (UserControl)Activator.CreateInstance(tmp);
                    uctmp.Dock = DockStyle.Fill;
                    pnBody.Controls.Add(uctmp);
                    //splitContainerControl1.Panel2.Dock = DockStyle.Fill;
                }
                else
                {
                    Assembly assemblyProject = Assembly.LoadFile(string.Format(@"{0}\{1}.dll", Application.StartupPath, module));
                    tmp = assemblyProject.GetType(module + "." + tenmenu, false, true);
                    //CLEAR PANNEL 2
                    Form frm = (Form)Activator.CreateInstance(tmp);
                    frm.TopLevel = false;
                    //REMOVE BORDER
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;

                    pnBody.Controls.Add(frm);
                    frm.Show();
                }
            }
            catch
            {
                if (tenmenu.Substring(0, 2).ToUpper() == "UC")
                {
                    tmp = Type.GetType(module + "." + tenmenu, false, true);
                    UserControl uctmp = new UserControl();
                    uctmp = (UserControl)Activator.CreateInstance(tmp);
                    pnBody.Controls.Add(uctmp);
                }
                else
                {
                    tmp = Type.GetType(module + "." + tenmenu, false, true);
                    Form frm = (Form)Activator.CreateInstance(tmp);
                    frm.TopLevel = false;
                    //REMOVE BORDER
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;

                    pnBody.Controls.Add(frm);
                    frm.Show();
                }
            }
        }
    }
}