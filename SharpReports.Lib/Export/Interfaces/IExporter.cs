using SharpReports.Lib.Elements; // Add this if Report is defined in this namespace
namespace SharpReports.Lib.Export.Interfaces
{

    public interface IExporter
    {
        void Export(Report report, string filePath);
    }
}