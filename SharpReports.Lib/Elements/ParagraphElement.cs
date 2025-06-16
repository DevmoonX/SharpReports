using System;
using MigraDoc.DocumentObjectModel;
namespace SharpReports.Lib.Elements;

public class ParagraphElement : ReportElement
{
    public string? Content { get; set; }
    public double FontSize { get; set; } = 12;
    public string FontName { get; set; } = "Arial";
    public bool Bold { get; set; } = false;
    public bool Italic { get; set; } = false;

    public ReportColor Color { get; set; } = ReportColor.Black;

    public ParagraphAlignment Alignment { get; set; } = ParagraphAlignment.Left;

    public bool Underline { get; set; } = false;

    public override void Render(Document document, Section? section = null)
    {
        var currentSection = section ?? document.AddSection();
        var paragraph = currentSection.AddParagraph(Content ?? string.Empty);
        paragraph.Format.Font.Size = FontSize;
        paragraph.Format.Font.Bold = Bold;
        paragraph.Format.Font.Italic = Italic;
        paragraph.Format.Font.Underline = Underline ? MigraDoc.DocumentObjectModel.Underline.Single : MigraDoc.DocumentObjectModel.Underline.None;
        paragraph.Format.Alignment = Alignment switch
        {
            ParagraphAlignment.Left => MigraDoc.DocumentObjectModel.ParagraphAlignment.Left,
            ParagraphAlignment.Center => MigraDoc.DocumentObjectModel.ParagraphAlignment.Center,
            ParagraphAlignment.Right => MigraDoc.DocumentObjectModel.ParagraphAlignment.Right,
            ParagraphAlignment.Justify => MigraDoc.DocumentObjectModel.ParagraphAlignment.Justify,
            _ => MigraDoc.DocumentObjectModel.ParagraphAlignment.Left
        };
        paragraph.Format.Font.Color = Color switch
        {
            ReportColor.Black => MigraDoc.DocumentObjectModel.Color.FromRgb(0, 0, 0),
            ReportColor.Red => MigraDoc.DocumentObjectModel.Color.FromRgb(255, 0, 0),
            ReportColor.Blue => MigraDoc.DocumentObjectModel.Color.FromRgb(0, 0, 255),
            _ => MigraDoc.DocumentObjectModel.Color.FromRgb(0, 0, 0)
        };
    }

}
