using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
namespace WebBrowser
{
   public class ClassFilterSuport
    {

        public string webUrl = string.Empty;
        public const string fileTypes = "(?<HTML><a[^>]*href\\s*=\\s*[\\\"\\']?(?<HRef>[^\"'>\\s]*)[\\\"\\']?[^>]*>(?<Title>[^<]+|.*?)?</a\\s*>)";
        //_findAllHrefsPattern
        public string typeFilter = string.Empty;
        //_filters

        public string GetWebPage()
        {
            if (webUrl.Equals(string.Empty))
            {
              System.Windows.Forms .MessageBox .Show ("Please supply a url first.");
            }

            string webPage = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(webUrl);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();

            StreamReader sr = new StreamReader(stream);
            webPage = sr.ReadToEnd();

            stream.Close();
            return webPage;
        }
    }

}
