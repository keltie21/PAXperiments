using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Microsoft.Win32;

namespace WindowsFormsApplication3
{
    public partial class frmSynch : Form
    {
        public frmSynch()
        {
            InitializeComponent();
            txtsrc1.Text = Properties.Settings.Default["src1"].ToString();
            txtdest1.Text = Properties.Settings.Default["dst1"].ToString();
            txtftp_host.Text = Properties.Settings.Default["ftp_host"].ToString();
            txtftp_name.Text = Properties.Settings.Default["ftp_name"].ToString();
            txtftp_pass.Text = Properties.Settings.Default["ftp_pass"].ToString();

            //notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            //notifyIcon1.BalloonTipTitle = "Graffiti FTP";
            //notifyIcon1.BalloonTipText = "Graffiti FTP is running";

            //notifyIcon1.ShowBalloonTip(2000);
            
        }

   
        private void tmrCopy_Tick(object sender, EventArgs e)
        {
            Properties.Settings.Default["src1"] = txtsrc1.Text;
            Properties.Settings.Default["dst1"] = txtdest1.Text;
            Properties.Settings.Default["ftp_host"] = txtftp_host.Text;
            Properties.Settings.Default["ftp_name"] = txtftp_name.Text;
            Properties.Settings.Default["ftp_pass"] = txtftp_pass.Text;
            Properties.Settings.Default.Save();
            if (copy.Checked == false )
                return;

            string sourceDIR = txtsrc1.Text;
            string dests = txtdest1.Text;
            string ftpHost = txtftp_host.Text;
            string ftpName = txtftp_name.Text;
            string ftpPass = txtftp_pass.Text;

            try
            {
                DirectoryInfo src;
                try
                {
                    if (!Directory.Exists(sourceDIR))
                    {
                        Directory.CreateDirectory(sourceDIR);
                    }
                    if (!Directory.Exists(dests))
                    {
                        Directory.CreateDirectory(dests);
                    }
                }
                catch (Exception z)
                {
                    DisableCopy(z.Message);
                }

                src = new DirectoryInfo(sourceDIR);
           
                //Console.WriteLine("{0} {1} {2} {3}", nowtime, ftpHost, ftpName, ftpPass);
                // create ftp object
                FTPconnection ftp = new FTPconnection(ftpHost, ftpName, ftpPass);
                bool connected = false;
                bool sent = false;

                try
                {
                    connected = ftp.testConnection();
                }
                catch (Exception z)
                {
                    DisableCopy(z.Message);
                }

                // upload if ftp is good
                if (connected)
                {
                    foreach (FileInfo file in src.GetFiles())
                    {
                        try
                        {
                            sent = false;
                            try
                            {
                                sent = ftp.copyToServer(file.Name, file.FullName, dests);
                            }
                            catch (Exception z)
                            {
                                DisableCopy(z.Message);
                                sent = false;
                            }
                            if (sent)
                            {
                                file.CopyTo(Path.Combine(dests, file.Name), true);
                                file.Delete();
                            }
                        }
                        catch (Exception z)
                        {
                            DisableCopy(z.Message);
                        }
                    }
                }
            }
            catch (Exception z)
            {
                DisableCopy(z.Message);
            }
        }

        public void DisableCopy(string message)
        {
            copy.Checked = false;
            System.Windows.Forms.MessageBox.Show(message);
        }

        private void frmSynch_Load(object sender, EventArgs e)
        {
            if (GetRegisteredInStartup())
            {
                chkStartup.Checked = true;
                copy.Checked = true;
            }
        }

        public bool GetRegisteredInStartup()
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            string value = registryKey.GetValue("ApplicationName") as string;

            if (value != null && value.Length > 0)
                return true;
            return false;
        }

        private void RegisterInStartup(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                    ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isChecked)
            {
                registryKey.SetValue("ApplicationName", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("ApplicationName");
            }
        }
        private void txtdest1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsrc1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtftp_host_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void copy_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chkStartup_CheckedChanged(object sender, EventArgs e)
        {
            RegisterInStartup(chkStartup.Checked);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
