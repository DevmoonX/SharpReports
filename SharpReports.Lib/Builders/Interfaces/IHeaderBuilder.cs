namespace SharpReports.Lib.Builders.Interfaces;

public interface IHeaderBuilder : IReportElementBuilder
{
    IParagraphBuilder AddText(string text);
    IParagraphBuilder SetFontSize(int size);
    IParagraphBuilder SetAllignment(ParagraphAlignment alignment);


    IReportBuilder EndHeader();

}