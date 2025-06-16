using SharpReports.Lib.Builders.Interfaces;
using SharpReports.Lib.Elements;
namespace SharpReports.Lib.Builders;

public class SectionBuilder : ISectionBuilder
{
    public readonly SectionElement _section;
    private readonly ReportBuilder _parentBuilder;

    public SectionBuilder(ReportBuilder parentBuilder)
    {
        _section = new SectionElement();
        _parentBuilder = parentBuilder;
    }

    public IParagraphBuilder AddParagraph(string text)
    {
        var paragraphBuilder = new ParagraphBuilder(this).AddText(text);
        return paragraphBuilder;
    }

    public ITitleBuilder AddTitle(string title)
    {

        var titleBuilder = new TitleBuilder(this).SetText(title);
        return titleBuilder;
    }

    public ReportBuilder EndSection()
    {
        _parentBuilder._report.Root.Elements.Add(_section);
        return _parentBuilder;
    }

    public ISectionBuilder AddBreakLine()
    {
        var paragraphBuilder = new BreakLineElement();
        _section.Elements.Add(paragraphBuilder);
        return this;
    }

    public ISectionBuilder AddHorizontalLine()
    {
        var horizontalLine = new HorizontalRuleElement();
        _section.Elements.Add(horizontalLine);
        return this;
    }
    public IReportElements Build()
    {
        return _section;
    }
}
