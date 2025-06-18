using System;
using MigraDoc.DocumentObjectModel;
namespace SharpReports.Lib.Elements;

public class ImageElement : ReportElement
{
    public string? ImagePath { get; set; }
    public double Width { get; set; } = 100;
    public double Height { get; set; } = 100;

    public override void Render(Document document, Section? section = null)
    {
        var currentSection = section ?? document.AddSection();
        var image = currentSection.AddImage(ImagePath ?? string.Empty);
        image.Width = Unit.FromPoint(Width);
        image.Height = Unit.FromPoint(Height);
    }
}




