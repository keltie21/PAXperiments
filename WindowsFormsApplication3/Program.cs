using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text;

namespace WindowsFormsApplication3
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

            // FTP setup
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(@"ftp://70.32.92.206/test/newfile.txt");
            request.Method = WebRequestMethods.Ftp.UploadFile;

            request.Credentials = new NetworkCredential("paxftp", @"$\/]=2m%[<9%]4B");

            // later this will be the images...
            StreamReader sourceStream = new StreamReader(@"C:\Users\Tunde\Desktop\makelab\WindowsFormsApplication3\WindowsFormsApplication3\testfile.txt");
            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            sourceStream.Close();
            request.ContentLength = fileContents.Length;

            try
            {
                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Console.WriteLine("Upload'd  --- stat {0}", response.StatusDescription);

                response.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("FAIL {0}", e.Message);
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSynch());
        }
    }
}
