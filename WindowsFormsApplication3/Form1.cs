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
        }

   
        private void tmrCopy_Tick(object sender, EventArgs e)
        {
            Properties.Settings.Default["src1"] = txtsrc1.Text;
            Properties.Settings.Default["dst1"] = txtdest1.Text;
            Properties.Settings.Default["ftp_host"] = txtftp_host.Text;
            Properties.Settings.Default["ftp_name"] = txtftp_name.Text;
            Properties.Settings.Default["ftp_pass"] = txtftp_pass.Text;
            Properties.Settings.Default.Save();
            if (copy.Enabled == false)
                return;

            string sourceDIR = txtsrc1.Text;
            string dests = txtdest1.Text;
            string ftpHost = txtftp_host.Text;
            string ftpName = txtftp_name.Text;
            string ftpPass = txtftp_pass.Text;

            try
            {
                DirectoryInfo src;
                if (!Directory.Exists(sourceDIR))
                {
                    Directory.CreateDirectory(sourceDIR);
                }
                src = new DirectoryInfo(sourceDIR);
                Console.WriteLine("{0} {1} {2}", ftpHost, ftpName, ftpPass);
                // create ftp object
                FTPobj ftp = new FTPobj(ftpHost, ftpName, ftpPass);

                // upload if ftp is good
                if (ftp.testConnection())
                {
                    Console.WriteLine("Connection is good");
                    foreach (FileInfo file in src.GetFiles())
                    {
                        try
                        {
                            ftp.copyToServer(file.Name, file.FullName);
                        }
                        catch (Exception z)
                        {
                            System.Windows.Forms.MessageBox.Show(z.Message);
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                System.Windows.Forms.MessageBox.Show(ee.Message);
            }
            tmrCopy.Enabled = false;
        }

        private void frmSynch_Load(object sender, EventArgs e)
        {

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
    }
}
