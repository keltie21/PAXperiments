using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace SurfaceSync
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            string[] args = Environment.GetCommandLineArgs();
            
            if (args.Length >= 2)
            {
                try
                {
                    string dst_str = Properties.Settings.Default["browser_dst"].ToString();
                    DirectoryInfo dst;
                    if (!Directory.Exists(dst_str))
                        Directory.CreateDirectory(dst_str);
                    dst = new DirectoryInfo(dst_str);
                    FileInfo file = new FileInfo(args[1]);
                    file.CopyTo(Path.Combine(dst.FullName, file.Name), true);
                    return;
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Could not recover file " + args[1]);
                }
            
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new frmSynch());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
