namespace SharpReports.Lib.Builders.Interfaces;

public interface IFooterBuilder : IReportElementBuilder
{
    IFooterBuilder AddText(string text);
    IFooterBuilder SetFontSize(int size);
    IFooterBuilder SetAllignment(ParagraphAlignment alignment);

    IFooterBuilder EnablePageNumber(bool enable = true);
    IReportBuilder EndFooter();

}