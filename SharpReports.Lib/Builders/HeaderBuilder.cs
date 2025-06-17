using SharpReports.Lib.Builders;
using SharpReports.Lib.Builders.Interfaces;
using SharpReports.Lib.Elements;

public class HeaderBuilder : IHeaderBuilder
{
    public readonly HeaderElement _header;
    private readonly ReportBuilder _parentBuilder;

    public HeaderBuilder(ReportBuilder parentBuilder)
    {
        _parentBuilder = parentBuilder;
        _header = new HeaderElement();
    }

    public IHeaderBuilder AddText(string text)
    {
        _header.text = text;
        return this;
    }


    public IHeaderBuilder SetAllignment(ParagraphAlignment alignment)
    {
        _header.Alignment = alignment;
        return this;
    }

    public IHeaderBuilder SetFontSize(int size)
    {
        _header.FontSize = size;
        return this;
    }

    public IReportBuilder EndHeader()
    {
        _parentBuilder._report.Root.Elements.Add(_header);
        return _parentBuilder;
    }

    public IReportElements Build()
    {
        return _header;
    }
}
