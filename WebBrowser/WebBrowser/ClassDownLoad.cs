using System;
using System.Collections.Generic;
using System.IO;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Text;
using System.Web.Services.Protocols;
using System.Net;

namespace WebBrowser
{
   public  class ClassDownLoad:ClassDownLoadResources
    {
        
        public delegate void _delDownloadStarting(ClassDownLoad thread);
        public delegate void _delDownloadCompleted(ClassDownLoad thread, bool isSuccess);

        public event _delDownloadStarting DownloadStarting;
        public event _delDownloadCompleted DownloadCompleted;

        public ClassDownLoad(string documentUrl, string directory)
        {
            _DocumentUrl = documentUrl;
            _DirectoryPath = directory;
        }
        
        public void StartDownload()
        {
            if (_DocumentUrl.Equals(string.Empty))
            {
                System.Windows.Forms.MessageBox.Show("Please Enter a document url");
               
            }
            if (_DirectoryPath.Equals(string.Empty))
            {
                System.Windows.Forms.MessageBox.Show("Please Enter Save Location");
               
            }
            _IsStarted = true;
             DownloadStarting(this);
            _IsDownloading = true;
            _IsDownloadSuccessful = false;
            Stream stream = null;
            FileStream fstream = null;

            try
            {
                string destFileName = _DirectoryPath + "\\" + CreateFileName;
                destFileName = destFileName.Replace("/", " ").Replace("%20", " ");

                if (File.Exists(destFileName) == false)
                {
                    IWebProxy proxy = null;
                    if (ProxyUri != null && ProxyUri != string.Empty)
                    {
                        proxy = new WebProxy(ProxyUri, true);
                        proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                    }
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_DocumentUrl);
                    if (proxy != null)
                    {
                        request.Proxy = proxy;
                    }
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    stream = response.GetResponseStream();

                    byte[] inBuffer = ReadFully(stream, 32768);

                    fstream = new FileStream(destFileName, FileMode.OpenOrCreate, FileAccess.Write);
                    fstream.Write(inBuffer, 0, inBuffer.Length);


                    fstream.Close();
                    stream.Close();
                }
                _IsDownloadSuccessful = true;
                _IsDownloading = false;
                 DownloadCompleted(this, _IsDownloadSuccessful);
            }
            catch
            {
                _IsDownloadSuccessful = false;
            }
            finally
            {
                if (fstream != null)
                {
                    fstream.Close();
                }
                if (stream != null)
                {
                    stream.Close();
                }
            }
        }

      
        private string proxyUri = string.Empty;
        public string ProxyUri
        {
            get { return proxyUri; }
            set { proxyUri = value; }
        }
   }
}
