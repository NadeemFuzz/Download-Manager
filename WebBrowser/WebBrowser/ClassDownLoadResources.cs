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
    public class ClassDownLoadResources
    {
        public string _DocumentUrl = string.Empty;
        public string _DirectoryPath = string.Empty;
        public bool _IsDownloading = false;
        public bool _IsDownloadSuccessful = false;
        public bool _IsStarted = false;

        public string CreateFileName
        {
            get
            {
                if (_DocumentUrl.Equals(string.Empty))
                {
                    throw new ArgumentException("Please supply a document url.");
                }
                int location = _DocumentUrl.LastIndexOf("/") + 1;
                int length = _DocumentUrl.Length - location;
                string filename = _DocumentUrl.Substring(location, length);
                return filename;
            }
        }

        public byte[] ReadFully(Stream objstream, int  Length)
        {

            if (Length < 1)
            {
                Length = 32768;
            }

            byte[] buffer = new byte[Length];
            int read = 0;

            int chunk;
            while ((chunk = objstream.Read(buffer, read, buffer.Length - read)) > 0)
            {
                read += chunk;

                if (read == buffer.Length)
                {
                    int nextByte = objstream.ReadByte();
                    if (nextByte == -1)
                    {
                        return buffer;
                    }
                    byte[] newBuffer = new byte[buffer.Length * 2];
                    Array.Copy(buffer, newBuffer, buffer.Length);
                    newBuffer[read] = (byte)nextByte;
                    buffer = newBuffer;
                    read++;
                }
            }
            byte[] ret = new byte[read];
            Array.Copy(buffer, ret, read);
            return ret;
        }

     }
}
