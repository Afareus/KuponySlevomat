using KuponySlevomat.Business;
using KuponySlevomat.Queries;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuponySlevomat
{
    static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string PathToDB = new ConfigOperator().ReadText();
            var _queries = new DatabaseQueries(PathToDB);

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (String.IsNullOrEmpty(PathToDB))
            {
                // databaze neni zadana
                Application.Run(new InfoForm1());
            }
            else if (!File.Exists(PathToDB))
            {
                // databaze nenalezena
                Application.Run(new InfoForm2());
            }
            else if (!_queries.IsDbReadAble())
            {
                // databaze poskozena
                Application.Run(new InfoForm3());
            }
            else
            {
                // databaze OK - spusteni procesu zalohy databaze
                Application.Run(new BackUpProgressForm());
            }

            // spusti se aplikace
            Application.Run(new Form1());
        }
    }
}
