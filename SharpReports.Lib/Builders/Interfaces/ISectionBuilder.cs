using SharpReports.Lib.Elements;
namespace SharpReports.Lib.Builders.Interfaces;

public interface ISectionBuilder : IReportElementBuilder
{
    IParagraphBuilder AddParagraph(string text);
    ITitleBuilder AddTitle(string title);

}