using SharpReports.Lib.Builders.Interfaces;
using SharpReports.Lib.Elements;
using SharpReports.Lib.Export;
namespace SharpReports.Lib.Builders;

public class ReportBuilder : IReportBuilder
{
    internal readonly Report _report;

    public ReportBuilder()
    {
        _report = new Report();
    }


    public ISectionBuilder AddSection()
    {
        var sectionBuilder = new SectionBuilder(this);
        return sectionBuilder;
    }

    public Report Build(bool Export = false, string filePath = "")
    {
        if (Export)
        {
            _report.Render();
            var exporter = new PDFExporter();
            exporter.Export(_report, filePath);
            return _report;
        }
        return _report;
    }

}