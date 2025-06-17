using SharpReports.Lib.Builders;
using SharpReports.Lib.Builders.Interfaces;
using SharpReports.Lib.Elements;

public class FooterBuilder : IFooterBuilder
{
    public readonly FooterElement _footer;
    private readonly ReportBuilder _parentBuilder;

    public FooterBuilder(ReportBuilder parentBuilder)
    {
        _parentBuilder = parentBuilder;
        _footer = new FooterElement();
    }

    public IFooterBuilder AddText(string text)
    {
        _footer.text = text;
        return this;
    }

    public IFooterBuilder SetAllignment(ParagraphAlignment alignment)
    {
        _footer.Alignment = alignment;
        return this;
    }

    public IFooterBuilder SetFontSize(int size)
    {
        _footer.FontSize = size;
        return this;
    }

    public IFooterBuilder EnablePageNumber(bool enable = true)
    {
        _footer.enablePageNumber = enable;
        return this;
    }

    public IReportBuilder EndFooter()
    {
        _parentBuilder._report.Root.Elements.Add(_footer);
        return _parentBuilder;
    }

    public IReportElements Build()
    {
        return _footer;
    }
}
