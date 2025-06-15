using MigraDoc.Rendering;
using SharpReports.Lib.Elements;
using SharpReports.Lib.Export.Interfaces;

namespace SharpReports.Lib.Export
{
    public class PDFExporter : IExporter
    {

        public void Export(Report report, string filePath)
        {
            var document = report.Render(); // Or report.Root.Render(), depending on your design
            var renderer = new PdfDocumentRenderer();
            renderer.Document = document;
            renderer.RenderDocument();
            renderer.PdfDocument.Save(filePath);
        }
    }
}