using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuponySlevomat.Busines {
    class WriterReaderTxt {

        private string filePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\KuponySlevomatConfig.txt";

        public WriterReaderTxt() {
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
