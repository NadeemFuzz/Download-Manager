using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WebBrowser
{
    public partial class FormFleDownLoader : Form
    {
        ArrayList a_thread = new ArrayList();
        ArrayList a_intent = new ArrayList();
        private int  downloadCount = 0;
        object ObjObject = new object();
    //    delegate void AsyncMethodCaller();
        public FormFleDownLoader()
        {
            InitializeComponent();
        }
       
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            try
            {
                string URL = textBoxUrl.Text;
                webBrowser1.Navigate(URL);
            }
            catch
            {
                MessageBox.Show("Invalid URL ");
            }

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxFilter.Text !="" )
                {
                    GetAllFiles();
                }
               
                else
                {
                    MessageBox.Show("File Type Connot Be Blank"); 
                }
            }
            catch
            {
                MessageBox.Show("Error"); 
            }
        }
        private void GetAllFiles()
        {
            listViewgetFiles.Items.Clear();
            ClassWebFinder obj = new ClassWebFinder(textBoxUrl.Text, textBoxFilter.Text);
            StringCollection collection = obj.FileList();
            foreach (string Dx in collection)
          {
              ListViewItem Listitem = new ListViewItem();
              Listitem.SubItems.Add("Get Ready");
              Listitem.Text = Dx.Replace("%20", " ");
              listViewgetFiles.Items.Add(Listitem);
          }

             
        }

        private void FormFleDownLoader_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxException_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxFilter.Text = "*." + comboBoxException.Text;
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            a_intent = new ArrayList();
            a_thread = new ArrayList();
            downloadCount = 0;

            if (listViewgetFiles.CheckedItems.Count == 0)
            {
             MessageBox.Show("No items Select");
            }
            else
            {
                ClassDownLoad download = null;
                progressBarPrograss.Minimum = 0;
                progressBarPrograss.Maximum = listViewgetFiles.CheckedItems.Count;
                progressBarPrograss.Value = 0;

                foreach (ListViewItem Listitem in listViewgetFiles.CheckedItems)
                  {
                      Listitem.SubItems[1].Text = "Not started";
                      download = new ClassDownLoad(Listitem.SubItems[0].Text, textBoxFileLocation.Text);
                      Listitem.Tag = download;
                    try
                    {
                        ThreadStart tsDelegate = new ThreadStart(download.StartDownload);
                        download.DownloadStarting += new ClassDownLoad._delDownloadStarting(Start_download);
                        download.DownloadCompleted += new ClassDownLoad._delDownloadCompleted(End_DownLoad);
                        Thread t = new Thread(tsDelegate);
                        t.Name = Listitem.SubItems[0].Text;
                        a_thread.Add(t);
                        a_intent.Add(download);
                }
                    catch
                    {

                        Listitem.SubItems[1].Text = "Error";
                   }
             }
                Downloading();
             }
        }
        void End_DownLoad(ClassDownLoad thread, bool isSuccess)
        {

            lock (ObjObject)
            {
                downloadCount--;
            }
            SetStatus("Completed", thread);
            SetProgressBar();
            Downloading();

        }
        private void SetProgressBar()
        {
            if (progressBarPrograss.InvokeRequired)
            {
                SetProgressBarCallback p = new SetProgressBarCallback(SetProgressBar);
                this.Invoke(p);
            }
            else
            {
                lock (ObjObject)
                {
                    progressBarPrograss.Value++;
                }
            }
        }
        delegate void SetProgressBarCallback();
        
     
        private void Downloading()
        {
            try
            {
                int j = 0;
                int limit = int.Parse(textBoxDownloadCounter.Text);
                int iCount = 0;
                lock (ObjObject)
                {
                    iCount = a_intent.Count;
                }
                if (iCount != 0)
                {
                    foreach (Thread thread in a_thread)
                    {
                        ClassDownLoad file = ((ClassDownLoad)a_intent[j]);
                        if (file._IsStarted == false)
                        {
                            lock (ObjObject)
                            {
                                thread.Start();
                                downloadCount++;
                            }
                        }
                        if (downloadCount == limit)
                        {
                            break;
                        }
                        j++;
                    }
                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("Enter the number of Threads");
            }
        }

        void Start_download(ClassDownLoad thread)
        {
            SetStatus("Downloading", thread);
        }
        //----------------------------------------------
        private void SetStatus(string Status, ClassDownLoad f)
        {
            if (listViewgetFiles.InvokeRequired)
            {
                delSetStatus s = new delSetStatus(SetStatus);
                this.Invoke(s, new object[] { Status, f });
            }
            else
            {
                foreach (ListViewItem item in listViewgetFiles.Items)
                {
                    if (item.Tag == f)
                    {

                        lock (ObjObject)
                        {
                            item.SubItems[1].Text = Status;
                        }
                        break;
                    }
                }
            }
        }

        delegate void delSetStatus(string Status, ClassDownLoad f);

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            StopThreads();
         
        }
        private void StopThreads()
        {
            foreach (Thread t in a_thread)
            {
                if (t.IsAlive)
                {
                    t.Abort();
                }
            }
            a_thread = new ArrayList();
            a_thread = new ArrayList();

            foreach (ListViewItem item in listViewgetFiles.CheckedItems)
            {
                if (item.SubItems[1].Text.Equals("Downloading"))
                {
                    item.SubItems[1].Text = "Cancelled";
                }
            }


        }

        private void progressBarPrograss_Click(object sender, EventArgs e)
        {

        }
    }
}
