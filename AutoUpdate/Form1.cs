
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoUpdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Upt();
        }

        public void Upt()
        {
            string pathServer = "";
            string UpdateServer = "";
            string ExeServer = "";
            string ExeClient = "";
            string QuanTriServer = "";
            string QuanTriClient = "";
            string OTIFServer = "";
            string OTIFClient = "";
            string DashboardL2Server = "";
            string DashboardL2Client = "";
            //string TDKSTNServer = "";
            //string TDKSTNClient = "";
            string ReportServer = "";
            string ReportClient = "";
            string AccessDataClient = "";
            string AccessDataServer = "";

            var client = new IniFile(Application.StartupPath + "\\Extention\\Main.ini");
            ExeClient = client.Read("EXE", "Update");
            QuanTriClient = client.Read("QuanTri", "Update");
            OTIFClient = client.Read("OTIF", "Update");
            DashboardL2Client = client.Read("DashboardL2", "Update");
            ReportClient = client.Read("Report", "Update");
            AccessDataClient = client.Read("AccessData", "Update");

            pathServer = client.Read("Path", "Source");
            var server = new IniFile(pathServer + "\\Extention\\Main.ini");
            ExeServer = server.Read("EXE", "Update");
            QuanTriServer = server.Read("QuanTri", "Update");
            OTIFServer = server.Read("OTIF", "Update");
            DashboardL2Server = server.Read("DashboardL2", "Update");
            ReportServer = server.Read("Report", "Update");
            AccessDataServer = client.Read("AccessData", "Update");

            //if (UpdateClient != UpdateServer)
            //{
            //    File.Copy(pathServer + "\\AutoUpdate.exe", Application.StartupPath + "\\AutoUpdate.exe", true);
            //    client.Write("Update", UpdateServer, "Update");
            //}
            if (ExeClient != ExeServer)
            {
                File.Copy(pathServer + "\\Main.exe", Application.StartupPath + "\\Main.exe", true);
                client.Write("EXE", ExeServer, "Update");
            }
            if (ReportClient != ReportServer)
            {
                DirectoryCopy(pathServer + "\\Reports", Application.StartupPath + "\\Reports", true);
                client.Write("Report", ReportServer, "Update");
            }
            //Access data
            if (QuanTriClient != QuanTriServer)
            {
                File.Copy(pathServer + "\\AccessData.dll", Application.StartupPath + "\\AccessData.dll", true);
                client.Write("AccessData", QuanTriServer, "Update");
            }
            //Quản trị
            if (QuanTriClient != QuanTriServer)
            {
                File.Copy(pathServer + "\\IBS_QuanTri.dll", Application.StartupPath + "\\IBS_QuanTri.dll", true);
                client.Write("QuanTri", QuanTriServer, "Update");
            }
            //Otif
            if (OTIFClient != OTIFServer)
            {
                File.Copy(pathServer + "\\IBS_OTIF.dll", Application.StartupPath + "\\IBS_OTIF.dll", true);
                client.Write("OTIF", OTIFServer, "Update");
            }
            //DashboardL2
            if (DashboardL2Client != DashboardL2Server)
            {
                File.Copy(pathServer + "\\IBS_DashboardL2.dll", Application.StartupPath + "\\IBS_DashboardL2.dll", true);
                client.Write("DashboardL2", DashboardL2Server, "Update");
            }
            System.Diagnostics.Process.Start("Main.exe");
            //MessageBox.Show("Update thành công");
            
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
