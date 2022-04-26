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

            for (int i = 0; i < 8; i++) {
                pages.Add(document.AddPage());
                graphics.Add(XGraphics.FromPdfPage(pages[i]));
            }

            var fontH1 = new XFont("Lucida Console", 14);
            var font = new XFont("Lucida Console", 9);

            string text = Text.Replace("\t", "    ");

            var textByLines = text.Split(Environment.NewLine);

            graphics[0].DrawString("Slevomat - Přijaté poukázky", fontH1, XBrushes.DarkTurquoise, new XPoint(178, 60));

            for (int i = 0; i < textByLines.Length; i++) {

                if (i <= 80) {
                    graphics[0].DrawString(textByLines[i], font, XBrushes.Black, new XPoint(65, (i * 8) + 100));
                } else if (i > 80 && i <= 160) {
                    graphics[1].DrawString(textByLines[i], font, XBrushes.Black, new XPoint(65, ((i - 80) * 8) + 100));
                } else if (i > 160 && i <= 240) {
                    graphics[2].DrawString(textByLines[i], font, XBrushes.Black, new XPoint(65, ((i - 160) * 8) + 100));
                } else if (i > 240 && i <= 320) {
                    graphics[3].DrawString(textByLines[i], font, XBrushes.Black, new XPoint(65, ((i - 240) * 8) + 100));
                } else if (i > 320 && i <= 400) {
                    graphics[4].DrawString(textByLines[i], font, XBrushes.Black, new XPoint(65, ((i - 320) * 8) + 100));
                } else if (i > 400 && i <= 480) {
                    graphics[5].DrawString(textByLines[i], font, XBrushes.Black, new XPoint(65, ((i - 400) * 8) + 100));
                } else if (i > 480 && i <= 560) {
                    graphics[6].DrawString(textByLines[i], font, XBrushes.Black, new XPoint(65, ((i - 480) * 8) + 100));
                } else if (i > 560 && i <= 640) {
                    graphics[7].DrawString(textByLines[i], font, XBrushes.Black, new XPoint(65, ((i - 560) * 8) + 100));
                }
            }

            document.Save(Path);
        }


    }
}
