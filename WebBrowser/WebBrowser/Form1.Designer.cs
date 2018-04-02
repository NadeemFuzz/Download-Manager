namespace WebBrowser
{
    partial class FormFleDownLoader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFleDownLoader));
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.listViewgetFiles = new System.Windows.Forms.ListView();
            this.file = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.comboBoxException = new System.Windows.Forms.ComboBox();
            this.textBoxDownloadCounter = new System.Windows.Forms.TextBox();
            this.textBoxFileLocation = new System.Windows.Forms.TextBox();
            this.progressBarPrograss = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(1700, 6);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(136, 79);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownload.Location = new System.Drawing.Point(1407, 7);
            this.buttonDownload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(136, 79);
            this.buttonDownload.TabIndex = 1;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(1260, 6);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(136, 79);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheck.Location = new System.Drawing.Point(1113, 6);
            this.buttonCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(136, 79);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "URL";
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUrl.Location = new System.Drawing.Point(80, 14);
            this.textBoxUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(1011, 30);
            this.textBoxUrl.TabIndex = 6;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(16, 149);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1201, 738);
            this.webBrowser1.TabIndex = 7;
            // 
            // listViewgetFiles
            // 
            this.listViewgetFiles.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewgetFiles.CheckBoxes = true;
            this.listViewgetFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.file,
            this.status});
            this.listViewgetFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewgetFiles.GridLines = true;
            this.listViewgetFiles.Location = new System.Drawing.Point(1224, 150);
            this.listViewgetFiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewgetFiles.Name = "listViewgetFiles";
            this.listViewgetFiles.Size = new System.Drawing.Size(607, 738);
            this.listViewgetFiles.TabIndex = 8;
            this.listViewgetFiles.UseCompatibleStateImageBehavior = false;
            this.listViewgetFiles.View = System.Windows.Forms.View.Details;
            // 
            // file
            // 
            this.file.Text = "File";
            this.file.Width = 350;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.status.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filter";
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilter.Location = new System.Drawing.Point(80, 57);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(123, 30);
            this.textBoxFilter.TabIndex = 10;
            // 
            // comboBoxException
            // 
            this.comboBoxException.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxException.FormattingEnabled = true;
            this.comboBoxException.Items.AddRange(new object[] {
            "HTML",
            "HTM",
            "ODT",
            "PDF",
            "XLS",
            "XLSX",
            "ODS",
            "PPT",
            "PPTX",
            "TXT",
            "DOC",
            "DOCX",
            "ZIP"});
            this.comboBoxException.Location = new System.Drawing.Point(212, 57);
            this.comboBoxException.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxException.Name = "comboBoxException";
            this.comboBoxException.Size = new System.Drawing.Size(119, 32);
            this.comboBoxException.TabIndex = 11;
            this.comboBoxException.SelectedIndexChanged += new System.EventHandler(this.comboBoxException_SelectedIndexChanged);
            // 
            // textBoxDownloadCounter
            // 
            this.textBoxDownloadCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDownloadCounter.Location = new System.Drawing.Point(1023, 59);
            this.textBoxDownloadCounter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDownloadCounter.Name = "textBoxDownloadCounter";
            this.textBoxDownloadCounter.Size = new System.Drawing.Size(68, 29);
            this.textBoxDownloadCounter.TabIndex = 13;
            this.textBoxDownloadCounter.Text = "1";
            // 
            // textBoxFileLocation
            // 
            this.textBoxFileLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileLocation.Location = new System.Drawing.Point(519, 57);
            this.textBoxFileLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxFileLocation.Name = "textBoxFileLocation";
            this.textBoxFileLocation.Size = new System.Drawing.Size(361, 29);
            this.textBoxFileLocation.TabIndex = 14;
            this.textBoxFileLocation.Text = "D:\\";
            // 
            // progressBarPrograss
            // 
            this.progressBarPrograss.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBarPrograss.Location = new System.Drawing.Point(16, 96);
            this.progressBarPrograss.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBarPrograss.Name = "progressBarPrograss";
            this.progressBarPrograss.Size = new System.Drawing.Size(1816, 37);
            this.progressBarPrograss.Step = 100;
            this.progressBarPrograss.TabIndex = 15;
            this.progressBarPrograss.Click += new System.EventHandler(this.progressBarPrograss_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Location to Save";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(889, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "DownLoads";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(1553, 6);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(136, 79);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormFleDownLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1816, 912);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBarPrograss);
            this.Controls.Add(this.textBoxFileLocation);
            this.Controls.Add(this.textBoxDownloadCounter);
            this.Controls.Add(this.comboBoxException);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewgetFiles);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormFleDownLoader";
            this.Text = "File Downloader";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormFleDownLoader_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ListView listViewgetFiles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.ColumnHeader file;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ComboBox comboBoxException;
        private System.Windows.Forms.TextBox textBoxDownloadCounter;
        private System.Windows.Forms.TextBox textBoxFileLocation;
        private System.Windows.Forms.ProgressBar progressBarPrograss;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCancel;
    }
}

