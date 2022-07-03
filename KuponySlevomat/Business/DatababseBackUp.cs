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
            if (PathToActuaDB != "" && IsDbReadAble())
            {
                System.IO.File.Copy(PathToActuaDB, PathToLocalBackUp, true);
            }
            else
            {
                // TODO: upřesnit exceptionu
                throw new Exception();
            }
        }

        private bool IsDbReadAble()
        {
            if (new DatabaseQueries().IsDbReadAble(PathToActuaDB))
            {
                return true;
            }
            return false;
        }
    }
}
