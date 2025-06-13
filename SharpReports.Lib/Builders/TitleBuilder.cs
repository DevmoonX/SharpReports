using SharpReports.Lib.Builders.Interfaces;
using SharpReports.Lib.Elements;
namespace SharpReports.Lib.Builders;

public class TitleBuilder : ITitleBuilder
{
    private readonly TitleElement _title;
    private readonly SectionBuilder _parentBuilder;

    public TitleBuilder(SectionBuilder parentBuilder)
    {
        _title = new TitleElement();
        _parentBuilder = parentBuilder;
    }

    public ITitleBuilder SetText(string text)
    {
        _title.Content = text;
        return this;
    }

    public ITitleBuilder SetFontSize(int size)
    {
        _title.FontSize = size;
        return this;
    }

    public ITitleBuilder SetBold(bool bold)
    {
        _title.Bold = bold;
        return this;
    }

    public ITitleBuilder SetItalic(bool italic)
    {
        _title.Italic = italic;
        return this;
    }

    public SectionBuilder EndTitle()
    {
        _parentBuilder._section.Elements.Add(_title);
        return _parentBuilder;
    }

    public IReportElements Build()
    {
        return _title;
    }
}
