using SharpReports.Lib.Builders.Interfaces;
using SharpReports.Lib.Elements;
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

    public Report Build()
    {
        return _report;
    }


}