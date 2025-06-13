using SharpReports.Lib.Elements;
namespace SharpReports.Lib.Builders.Interfaces;

public interface IReportBuilder
{
    ISectionBuilder AddSection();
    Report Build();
}