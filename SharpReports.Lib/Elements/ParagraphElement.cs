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

    public string? Color { get; set; } = "black";

    public string? Alignment { get; set; } = "left"; // left, right, center, justify

    public bool Underline { get; set; } = false;

    public override void Render(Document document, Section? section = null)
    {
        var currentSection = section ?? document.AddSection();
        var paragraph = currentSection.AddParagraph(Content ?? string.Empty);
        paragraph.Format.Font.Size = FontSize;
        paragraph.Format.Font.Bold = Bold;
        paragraph.Format.Font.Italic = Italic;
        paragraph.Format.Font.Underline = Underline ? MigraDoc.DocumentObjectModel.Underline.Single : MigraDoc.DocumentObjectModel.Underline.None;
        paragraph.Format.Alignment = Alignment.ToLower() switch
        {
            "left" => ParagraphAlignment.Left,
            "right" => ParagraphAlignment.Right,
            "center" => ParagraphAlignment.Center,
            _ => ParagraphAlignment.Justify
        };
        paragraph.Format.Font.Color = Color.ToLower() switch
        {
            "black" => MigraDoc.DocumentObjectModel.Color.FromRgb(0, 0, 0),
            "red" => MigraDoc.DocumentObjectModel.Color.FromRgb(255, 0, 0),
            "blue" => MigraDoc.DocumentObjectModel.Color.FromRgb(0, 0, 255),
            _ => MigraDoc.DocumentObjectModel.Color.FromRgb(0, 0, 0)
        };
    }

}
