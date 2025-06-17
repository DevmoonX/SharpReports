using SharpReports.Lib.Elements;
namespace SharpReports.Lib.Builders.Interfaces;

public interface IReportBuilder
{
    ISectionBuilder AddSection();

    IHeaderBuilder AddHeader(string text);

    IFooterBuilder AddFooter(string text);
    Report Build(bool Export = false, string filePath = "");
}