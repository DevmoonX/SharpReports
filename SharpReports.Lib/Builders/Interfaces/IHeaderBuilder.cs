namespace SharpReports.Lib.Builders.Interfaces;

public interface IHeaderBuilder : IReportElementBuilder
{
    IHeaderBuilder AddText(string text);
    IHeaderBuilder SetFontSize(int size);
    IHeaderBuilder SetAllignment(ParagraphAlignment alignment);

    IReportBuilder EndHeader();

}