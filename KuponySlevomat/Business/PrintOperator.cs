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
            List<PdfPage> pages = new List<PdfPage>();
            List<XGraphics> graphics = new List<XGraphics>();

            int linesInSite = 81;
            int currentLines = 0;
            int site = 0;

            string text = Text.Replace("\t", "    ");
            var textByLines = text.Split(Environment.NewLine);

            int pagesCount = (int)Math.Ceiling(Convert.ToDouble(textByLines.Length) / Convert.ToDouble(linesInSite));

            for (int i = 0; i < pagesCount; i++) {
                pages.Add(document.AddPage());
                graphics.Add(XGraphics.FromPdfPage(pages[i]));
            }

            var fontH1 = new XFont("Lucida Console", 14);
            var font = new XFont("Lucida Console", 9);

            graphics[0].DrawString("Slevomat - Přijaté poukázky", fontH1, XBrushes.DarkTurquoise, new XPoint(178, 60));


            for (int i = 0; i < textByLines.Length; i++) {

                graphics[site].DrawString(textByLines[i], font, XBrushes.Black, new XPoint(65, ((i - currentLines) * 8) + 100));

                if ((i + 1) % linesInSite == 0) {
                    site += 1;
                    currentLines += linesInSite;
                }
            }
                document.Save(Path);
        }


    }
}
