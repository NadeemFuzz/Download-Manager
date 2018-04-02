using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Net;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
namespace WebBrowser
{
    public class ClassWebFinder:ClassFilterSuport
    {
       

        public StringCollection FileList()
        {
            StringCollection sCol = new StringCollection();
            string webPage = GetWebPage();

            string ahref = string.Empty;
            string title = string.Empty;
            string value = string.Empty;
            string fileName = string.Empty;
            string  UrlHead = string.Empty;

            Regex regEx = new Regex(fileTypes, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Regex regEx2 = new Regex(typeFilter, RegexOptions.Compiled | RegexOptions.IgnoreCase);

            MatchCollection matches = regEx.Matches(webPage);
            //------------------------------------------
          
            if (webUrl.Equals(string.Empty))
            {
                 
            }
            else
            {
                UrlHead = webUrl.Substring(0, webUrl.LastIndexOf("/"));
            }

            //-----------------------------------------

            foreach (Match match in matches)
            {
                int iCount = match.Groups.Count;
                ahref = match.Groups[0].Value;
                value = match.Groups[2].Value;
                title = match.Groups[3].Value;

                if (regEx2.IsMatch(value))
                {
                    sCol.Add(UrlHead + "/" + value);
                   
                }
            }
            return sCol;
        }

        //---------------------------------------------------------
        public ClassWebFinder(string url, string sFilters)
        {
            webUrl = url;
            string[] filters = sFilters.Split(';');
            string pattern = string.Empty;
            for (int i = 0; i < filters.Length; i++ )
            {
                pattern = "\\" + filters[i].Replace("*", string.Empty) + "$" + "|";
                typeFilter += pattern;
            }
            typeFilter = typeFilter.Substring(0, typeFilter.Length - 1);
        }

    }
     

}
