using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;


namespace WindowsFormsApplication3
{
    class FTPconnection
    {
        private string host = null;
        private string user = null;
        private string pass = null;
        private FtpWebRequest ftpRequest = null;
        private FtpWebResponse ftpResponse = null;
        private NetworkCredential netCreds = null;

        public FTPconnection(string hostIP, string userName, string password)
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
        public bool copyToServer(string remote, string local, string logPath)
        {
            bool success = false;
//            try
//            {
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
                // check was successful
                if (ftpResponse.StatusCode == FtpStatusCode.ClosingData)
                {
                    success = true;
                    logResult(remote, host, user, logPath);
                }
                ftpResponse.Close();
                
/*            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }*/
            return success;
        }

        private void logResult(string fName, string hName, string uName, string path)
        {
            if (!File.Exists(path + @"\ftp_log.csv"))
            {
                using (StreamWriter sw = File.CreateText(path + @"\ftp_log.csv"))
                {
                    sw.WriteLine("{0},{1},{2},{3}", "filename", "host", "user", "time");
                    
                }
            }
            using (StreamWriter sw = File.AppendText(path + @"\ftp_log.csv"))
            {
                string nowtime = DateTime.Now.ToString();
                sw.WriteLine("{0},{1},{2},{3}", fName, hName, uName, nowtime);
            }
        }
    }
}
