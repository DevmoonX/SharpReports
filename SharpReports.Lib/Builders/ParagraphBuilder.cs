using SharpReports.Lib.Builders.Interfaces;
using SharpReports.Lib.Elements;
namespace SharpReports.Lib.Builders;

public class ParagraphBuilder : IParagraphBuilder
{
    private readonly ParagraphElement _paragraph;
    private readonly SectionBuilder _parentBuilder;

    public ParagraphBuilder(SectionBuilder parentBuilder)
    {
        _paragraph = new ParagraphElement();
        _parentBuilder = parentBuilder;
    }

    public IParagraphBuilder AddText(string text)
    {
        _paragraph.Content = text;
        return this;
    }

    public IParagraphBuilder SetFontSize(int size)
    {
        _paragraph.FontSize = size;
        return this;
    }

    public IParagraphBuilder SetBold(bool bold)
    {
        _paragraph.Bold = bold;
        return this;
    }

    public IParagraphBuilder SetItalic(bool italic)
    {
        _paragraph.Italic = italic;
        return this;
    }

    public SectionBuilder EndParagraph()
    {
        _parentBuilder._section.Elements.Add(_paragraph);
        return _parentBuilder;
    }

    public IReportElements Build()
    {
        return _paragraph;
    }
}

