using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuponySlevomat.Business {
    class ConfigOperator {

        private string filePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\KuponySlevomatConfig.txt";

        public ConfigOperator() {
            if (!File.Exists(filePath)) {
                var myFile = File.Create(filePath);
                myFile.Close();
            }
        }

        internal void WriteText(string text) {
            File.WriteAllText(filePath, text);
        }

        internal string ReadText() {
            return File.ReadAllText(filePath);
        }
    }
}
