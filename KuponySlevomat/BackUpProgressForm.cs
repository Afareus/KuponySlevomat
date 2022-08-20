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
    public delegate void ProgressChangeDelegate(double Percentage, ref bool Cancel);
    public delegate void Completedelegate();

    public partial class BackUpProgressForm : Form
    {
        private string PathToDB;
        private string PathToBackUp;
        private DatabaseQueries _queries;
        private bool isEnd;     // nějaký delegát z jiného vlákna?
        private string text;    // nějaký delegát z jiného vlákna?

        public BackUpProgressForm()
        {
            InitializeComponent();

            isEnd = true;              // toto by mělo být nastavené v jiném vlákně při startu a konci metody DoBackUp()
            text = "Záloha databáze";  // toto by mělo být nastavené v jiném vlákně při startu a konci metody DoBackUp()
            label1.Text = text;

            PathToDB = new ConfigOperator().ReadText();
            PathToBackUp = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\OxanaBackUp.db3";
            _queries = new DatabaseQueries(PathToDB);

            BackupDatabase();
        }

        public void BackupDatabase()
        {
            if (!String.IsNullOrEmpty(PathToDB))
            {
                if (_queries.IsDbReadAble())
                {
                    DoBackUp();
                    
                    button1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Databáze v daném umístění nebyla nalezena nebo databáze není čitelná");
                    //throw new Exception("Databáze v daném umístění nebyla nalezena nebo databáze není čitelná");
                }
            }
            else
            {
                MessageBox.Show("Není nastavena cesta k databázi");
                //throw new Exception("Není nastavena cesta k databázi");
            }
        }

        public void DoBackUp()
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
                        Thread.Sleep(100);
                        totalBytes += currentBlockSize;
                        double percentage = (double)totalBytes * 100.0 / fileLength;
                        pgBackUpDB.Value = (int)percentage;

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (isEnd)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Vydržte dokud záloha databáze nebude dokončena");
            }
        }
    
    
    }
}
