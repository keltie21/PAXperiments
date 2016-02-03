using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;


namespace WindowsFormsApplication3
{
    class FTPobj
    {
        private string host = null;
        private string user = null;
        private string pass = null;
        private FtpWebRequest ftpRequest = null;
        private FtpWebResponse ftpResponse = null;
        private NetworkCredential netCreds = null;

        public FTPobj(string hostIP, string userName, string password)
        {
            host = hostIP;
            user = userName;
            pass = password;
            netCreds = new NetworkCredential(user, pass);
        }

        public bool testConnection()
        {
            ftpRequest = (FtpWebRequest)WebRequest.Create(host);
            ftpRequest.Method = WebRequestMethods.Ftp.PrintWorkingDirectory;
            ftpRequest.Credentials = netCreds;
            if (ftpRequest.GetResponse() != null)
            {
                return true;
            }
            return false;
        }
        public void copyToServer(string remote, string local)
        {
            try
            {
                ftpRequest = (FtpWebRequest)WebRequest.Create(host + remote);
                ftpRequest.Method = WebRequestMethods.Ftp.UploadFile;
                ftpRequest.Credentials = netCreds;

                byte[] b = File.ReadAllBytes(local);

                ftpRequest.ContentLength = b.Length;
                using (Stream s = ftpRequest.GetRequestStream())
                {
                    s.Write(b, 0, b.Length);
                }

                ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();
                logResult(remote, host, user);
                //Console.WriteLine("Uploaded {0}  \n -- stat {1}", remote, ftpResponse.StatusDescription);
                ftpResponse.Close();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        private void logResult(string fName, string hName, string uName)
        {
            string path = @"c:\temp\log\log.txt";
            

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("");
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("{0},{1},{2}", fName, hName, uName);
            }
        }
    }
}
