using SharpReports.Lib.Elements;
namespace SharpReports.Lib.Builders.Interfaces;

public interface ISectionBuilder : IReportElementBuilder
{
    IParagraphBuilder AddParagraph(string text, bool isBold = false,
        bool isItalic = false, bool isUnderline = false, ParagraphAlignment alignment = ParagraphAlignment.Left,
        int fontSize = 12, ReportColor color = ReportColor.Black);
    ITitleBuilder AddTitle(string title);

}