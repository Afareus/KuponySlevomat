using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PdfSharpCore;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;

namespace KuponySlevomat.Business {
    public class PrintOperator {

        public string Text { get; set; }
        public string Path { get; set; }

        public PrintOperator() { }
        public PrintOperator(string text, string path) {
            Text = text;
            Path = path;
        }

        internal void SaveTextToDocument() {
            var document = new PdfDocument();
            var page1 = document.AddPage();
            var page2 = document.AddPage();

            var gfx1 = XGraphics.FromPdfPage(page1);
            var gfx2 = XGraphics.FromPdfPage(page2);

            var fontH1 = new XFont("Lucida Console", 14);
            var font = new XFont("Lucida Console", 9);

            string text = Text.Replace("\t", "    ");

            var textByLines = text.Split(Environment.NewLine);

            gfx1.DrawString("Slevomat - Přijaté poukázky", fontH1, XBrushes.DarkTurquoise, new XPoint(178, 60));

            for (int i = 0; i < textByLines.Length; i++) {
                if (i <= 80) {
                    gfx1.DrawString(textByLines[i], font, XBrushes.Black, new XPoint(65, (i * 8) + 100));
                } else if (i > 80 && i <= 250) {
                    gfx2.DrawString(textByLines[i], font, XBrushes.Black, new XPoint(65, ((i - 80) * 8) + 100));
                }
            }

            document.Save(Path);
        }


    }
}
