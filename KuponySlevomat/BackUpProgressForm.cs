using KuponySlevomat.Business;
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

        public BackUpProgressForm()
        {
            InitializeComponent();
            InitializeData();
            //BackUpDatabase();
            Copy();
        }

        private void InitializeData()
        {
            PathToDB = new ConfigOperator().ReadText();
            PathToBackUp = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\OxanaBackUp.db3";
        }

        public void Copy()
        {
            byte[] buffer = new byte[1024 * 1024]; // 1MB buffer
            bool cancelFlag = false;

            using (FileStream source = new FileStream(PathToDB, FileMode.Open, FileAccess.Read))
            {
                long fileLength = source.Length;
                using (FileStream dest = new FileStream(PathToBackUp, FileMode.Create, FileAccess.Write))
                {
                    long totalBytes = 0;
                    int currentBlockSize = 0;

                    while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                    {
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






        //private void BackUpDatabase()
        //{
        //    OnProgressChanged += delegate { };
        //    OnComplete += delegate { };

        //    for (int i = 0; i < 100; i++)
        //    {
        //        pgBackUpDB.Value = i;
        //        Thread.Sleep(150);
        //    }

        //    // zaloha databaze po každém spuštění
        //    try
        //    {
        //        //TODO: ProgressBar nebo animace při BackUpu s hláškou: "Probíhá záloha databáze. Pokud záloha trvá příliš dlouho, vytvořte prosím v Natavení novou databázi!"
        //        new DatababseBackUp(PathToDB).BackupDatabase();
        //        //MessageBox.Show("Byla provedena záloha databáze.");
        //    }
        //    catch (Exception ex)
        //    {
        //        //MessageBox.Show("Soubor s databází buď neexistuje, nebo aplikace k němu nemá přístup! \nZáloha databáze proto nemohla být provedena. \n\nZkontrolujte v nastavení cestu k databázi, nebo dostupnost databáze v zadaném umístění.");
        //        MessageBox.Show(ex.Message);
        //    }
        //}    
    }
}
