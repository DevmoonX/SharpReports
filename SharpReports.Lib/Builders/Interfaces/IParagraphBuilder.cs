namespace SharpReports.Lib.Builders.Interfaces;

public interface IParagraphBuilder : IReportElementBuilder
{
    IParagraphBuilder AddText(string text);
    IParagraphBuilder SetFontSize(int size);
    IParagraphBuilder SetBold(bool bold);
    IParagraphBuilder SetItalic(bool italic);

    IParagraphBuilder SetAllignment(string alignment);

    IParagraphBuilder SetColor(string color);

    IParagraphBuilder SetUnderline(bool underline);

    SectionBuilder EndParagraph();

}