using MigraDoc.Rendering;
using SharpReports.Lib.Elements;
using SharpReports.Lib.Export.Interfaces;
using PdfSharp.Drawing;

namespace SharpReports.Lib.Export
{
    public class PDFExporter : IExporter
    {
        public string? WatermarkText { get; set; }
        public double WatermarkFontSize { get; set; } = 48;
        public double WatermarkAngle { get; set; } = -40;
        public int WatermarkAlpha { get; set; } = 60;

        public void Export(Report report, string filePath)
        {
            var document = report.Render(); // Or report.Root.Render(), depending on your design
            var renderer = new PdfDocumentRenderer();
            renderer.Document = document;
            renderer.RenderDocument();

            // Add watermark if set
            if (!string.IsNullOrEmpty(WatermarkText))
            {
                foreach (var page in renderer.PdfDocument.Pages)
                {
                    using (var gfx = XGraphics.FromPdfPage(page, XGraphicsPdfPageOptions.Prepend))
                    {
                        var font = new XFont("Arial", WatermarkFontSize);
                        var format = new XStringFormat
                        {
                            Alignment = XStringAlignment.Center,
                            LineAlignment = XLineAlignment.Center
                        };
                        var state = gfx.Save();
                        gfx.TranslateTransform(page.Width.Point / 2, page.Height.Point / 2);
                        gfx.RotateTransform(WatermarkAngle);
                        gfx.DrawString(WatermarkText, font, new XSolidBrush(XColor.FromArgb(WatermarkAlpha, 0, 0, 0)), 0, 0, format);
                        gfx.Restore(state);
                    }
                }
            }
            renderer.PdfDocument.Save(filePath);
        }
    }
}