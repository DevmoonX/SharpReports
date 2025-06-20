using System;
using MigraDoc.DocumentObjectModel;
namespace SharpReports.Lib.Elements;

public class TitleElement : ReportElement
{
    public string? Content { get; set; }
    public double FontSize { get; set; } = 16;
    public string FontName { get; set; } = "Arial";
    public bool Bold { get; set; } = true;
    public bool Italic { get; set; } = false;

    public override void Render(Document document, Section? section = null)
    {
        var currentSection = section ?? document.AddSection();
        var paragraph = currentSection.AddParagraph(Content ?? string.Empty);
        paragraph.Format.Font.Size = FontSize;
        paragraph.Format.Font.Bold = Bold;
        paragraph.Format.Font.Italic = Italic;
    }

}
