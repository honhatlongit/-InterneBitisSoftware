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
using Telerik.WinControls.UI;
using Telerik.WinControls.Data;
using AccessData;
using System.IO;

namespace Main
{
    public partial class frmScreen : DevExpress.XtraEditors.XtraForm
    {
        //Test1b
        cls_Menu _cls;
        public frmScreen()
        {
            InitializeComponent();
            _cls = new cls_Menu();
        }
        
        private void frmScreen_Load(object sender, EventArgs e)
        {
            //Cập nhật chương trình nếu Update có thay đổi
            Update();
            khoitaolistview();
            loaddulieu();
        }
        private void khoitaolistview()
        {
            this.radListView1.EnableGrouping = true;
            this.radListView1.ShowGroups = true;
            this.radListView1.ViewType = ListViewType.IconsView;
            this.radListView1.ItemSize = new Size(200, 50);
            this.radListView1.GroupItemSize = new Size(675, 40);
            this.radListView1.ItemSpacing = 3;
            this.radListView1.GroupIndent = 0;
            this.radListView1.HorizontalScrollState = ScrollState.AlwaysHide;
            this.radListView1.EnableKineticScrolling = true;
            this.radListView1.VerticalScrollState = ScrollState.AlwaysHide;
            this.radListView1.FullRowSelect = false;
            this.radListView1.AllowEdit = false;
            this.radListView1.AllowRemove = false;
        }

        private void loaddulieu()
        {
            this.radListView1.DataSource = _cls.Load_Module();
            this.radListView1.DisplayMember = "TenChuongTrinh";
            this.radListView1.ValueMember = "ID";
            this.radListView1.GroupDescriptors.Clear();
            this.radListView1.GroupDescriptors.Add(new GroupDescriptor(new SortDescriptor[] { new SortDescriptor("TenNhom", ListSortDirection.Ascending) }));
        }

        private void radListView1_VisualItemFormatting(object sender, ListViewVisualItemEventArgs e)
        {
            if (e.VisualItem is BaseListViewGroupVisualItem)
            {
                return;
            }

            if (this.radListView1.ViewType == ListViewType.IconsView)
            {
                e.VisualItem.Text = "<html>" +
                  "<span style=\"color:#0066FF;\"> " + "  " + e.VisualItem.Data["TenChuongTrinh"] + "</span>";
                e.VisualItem.ImageLayout = ImageLayout.Stretch;
                e.VisualItem.ImageAlignment = ContentAlignment.MiddleLeft;
                e.VisualItem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            }
        }

        private void radListView1_ItemMouseClick(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.Value != null)
            {
                clsBienHeThong._ChuongTrinhID = (int)e.Item.Value;
                this.Hide();
                frmLogin frm = new frmLogin();
                frm.Show();
                frm.FormClosed += Frm_FormClosed;
            }
        }

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        #region "Update"
        private void Update()
        {
            try
            {
                string pathServer = "";
                string UpdateServer = "";
                string UpdateClient = "";

                var client = new IniFile(Application.StartupPath + "\\Extention\\Main.ini");
                UpdateClient = client.Read("Update", "Update");
                pathServer = client.Read("Path", "Source");
                var server = new IniFile(pathServer + "\\Extention\\Main.ini");
                UpdateServer = server.Read("Update", "Update");

                //Copy file AutoUpdate mới về máy.
                if (UpdateClient != UpdateServer)
                {
                    File.Copy(pathServer + "\\AutoUpdate.exe", Application.StartupPath + "\\AutoUpdate.exe", true);
                    client.Write("Update", UpdateServer, "Update");
                    //Copy file Main.ini
                    File.Copy(pathServer + "\\Extention\\Main.ini", Application.StartupPath + "\\Extention\\Main.ini", true);
                    MessageBox.Show("Cập nhật chương trình mới thành công. \n Vui lòng vào lại chương trình.", "Thông báo cập nhật chương trình");
                    Application.ExitThread();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
            
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            //// If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                // Create the path to the new copy of the file.
                string temppath = Path.Combine(destDirName, file.Name);

                // Copy the file.
                file.CopyTo(temppath, true);
            }

            // If copySubDirs is true, copy the subdirectories.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    // Create the subdirectory.
                    string temppath = Path.Combine(destDirName, subdir.Name);

                    // Copy the subdirectories.
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }
        #endregion
    }
}