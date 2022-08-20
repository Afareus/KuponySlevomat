using KuponySlevomat.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuponySlevomat.Business
{
    class DatababseBackUp
    {
        public string PathToActuaDB { get; set; }
        public string PathToLocalBackUp { get; set; }
        public DatababseBackUp(string path)
        {
            PathToActuaDB = path;
            PathToLocalBackUp = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\OxanaBackUp.db3";
        }

        public void BackupDatabase()
        {
            if (!String.IsNullOrEmpty(PathToActuaDB))
            {

                if (IsDbReadAble())
                {
                    System.IO.File.Copy(PathToActuaDB, PathToLocalBackUp, true);
                }
                else
                {
                    throw new Exception("Databáze v daném umístění nebyla nalezena nebo databáze není čitelná");
                }
            }
            else
            {
                throw new Exception("Není nastavena cesta k databázi.");
            }
        }

        private bool IsDbReadAble()
        {
            if (new DatabaseQueries(PathToActuaDB).IsDbReadAble())
            {
                return true;
            }
            return false;
        }
    }
}
