using SharpReports.Lib.Elements;
namespace SharpReports.Lib.Builders.Interfaces;

public interface ITitleBuilder : IReportElementBuilder
{
    ITitleBuilder SetText(string text);
    ITitleBuilder SetFontSize(int size);
    ITitleBuilder SetBold(bool bold);
    ITitleBuilder SetItalic(bool italic);

    SectionBuilder EndTitle();
}

