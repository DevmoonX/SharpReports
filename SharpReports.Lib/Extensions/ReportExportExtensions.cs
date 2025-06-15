using SharpReports.Lib.Elements;
using SharpReports.Lib.Export;

namespace SharpReports.Lib.Extenstions
{
    public static class ReportExportExtensions
    {
        public static Report ExportPDF(this Report report, string filePath)
        {
            var exporter = new PDFExporter();
            exporter.Export(report, filePath);
            return report;
        }
    }
}