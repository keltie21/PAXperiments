using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace SurfaceSync
{
    public partial class frmSynch : Form
    {
        public frmSynch()
        {
            InitializeComponent();
            txtsrc1.Text = Properties.Settings.Default["src1"].ToString();

            txtdest1.Text = Properties.Settings.Default["dst1"].ToString();

        }

        private void tmrCopy_Tick(object sender, EventArgs e)
        {
            Properties.Settings.Default["src1"] = txtsrc1.Text;
            Properties.Settings.Default["dst1"] = txtdest1.Text;
                        
            Properties.Settings.Default.Save();
            if (copy.Enabled == false)
                return;
            Dictionary<int, string> sources = new Dictionary<int, string>();
            Dictionary<int, string> dests = new Dictionary<int, string>();
            sources[0] = txtsrc1.Text;

            dests[0] = txtdest1.Text;

            for (int i = 0; i < 1; i++)
            {
                if (sources[i].Length > 0 && dests[i].Length > 0)
                {
                    try
                    {
                        DirectoryInfo src;
                        if(!Directory.Exists(sources[i]))
                            Directory.CreateDirectory(sources[i]);
                        src = new DirectoryInfo(sources[i]);
                        
                        DirectoryInfo srcBackup;
                        if (!Directory.Exists(sources[i] + "/backup"))
                            Directory.CreateDirectory(sources[i] + "/backup");
                        srcBackup = new DirectoryInfo(sources[i] + "/backup");

                        DirectoryInfo dst;
                        if (!Directory.Exists(dests[i]))
                            Directory.CreateDirectory(dests[i]);
                        dst = new DirectoryInfo(dests[i]);

                        foreach (FileInfo file in src.GetFiles())
                        {
                            try
                            {
                                file.CopyTo(Path.Combine(dst.FullName, file.Name), true);
                                file.CopyTo(Path.Combine(srcBackup.FullName, file.Name), true);
                                file.Delete();
                            }
                            catch (Exception z)
                            {
                                MessageBox.Show(z.Message);
                            }
                        }
                    }
                    catch (Exception ee)
                    {
                        System.Windows.Forms.MessageBox.Show(ee.Message);
                    }

                }

            }

        }

        private void frmSynch_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void copy_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
