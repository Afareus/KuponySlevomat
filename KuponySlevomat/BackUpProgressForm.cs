using KuponySlevomat.Business;
using KuponySlevomat.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuponySlevomat
{
    public partial class BackUpProgressForm : Form
    {
        private string PathToDB;
        private string PathToBackUp;
        private DatabaseQueries _queries;

        public BackUpProgressForm()
        {
            InitializeComponent();

            PathToDB = new ConfigOperator().ReadText();
            PathToBackUp = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\Oxana_Database_BackUp.db3";
            _queries = new DatabaseQueries(PathToDB);
            button1.Visible = false;
            lblDone.Visible = false;

            BackupDatabase();
        }

        public void BackupDatabase()
        {
            if (!String.IsNullOrEmpty(PathToDB))
            {
                if (_queries.IsDbReadAble())
                {
                    backgroundWorker.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Databáze v daném umístění nebyla nalezena nebo databáze není čitelná");
                }
            }
            else
            {
                MessageBox.Show("Není nastavena cesta k databázi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar.Value >= 100)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Vydržte dokud záloha databáze nebude dokončena");
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lblBackUp.Text = string.Format("Záloha databáze {0}%", e.ProgressPercentage);
            if (e.ProgressPercentage >= 100)
            {
                lblBackUp.Text = "Databáze byla zálohována";
                lblBackUp.Visible = false;
                button1.Visible = true;
                lblDone.Visible = true;
            }
            progressBar.Update();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            byte[] buffer = new byte[1024 * 1024]; // 1MB buffer
            bool cancelFlag = false;

            using (FileStream source = new FileStream(PathToDB, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                long fileLength = source.Length;
                using (FileStream dest = new FileStream(PathToBackUp, FileMode.Create, FileAccess.Write))
                {
                    long totalBytes = 0;
                    int currentBlockSize = 0;

                    while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        //Thread.Sleep(100);
                        totalBytes += currentBlockSize;
                        double percentage = (double)totalBytes * 100.0 / fileLength;
                        backgroundWorker.ReportProgress((int)percentage);

                        dest.Write(buffer, 0, currentBlockSize);

                        cancelFlag = false;

                        if (cancelFlag == true)
                        {
                            // Delete dest file here
                            break;
                        }
                    }
                }
            }

        }

        private void BackUpProgressForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (progressBar.Value < 100)
            {
                MessageBox.Show("Záloha nebyla dokončena! \n V případě, že záloha trvá příliš dlouho, \n zvažte založení nového souboru s databází.", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
