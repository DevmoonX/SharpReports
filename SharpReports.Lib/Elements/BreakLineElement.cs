using System;
using MigraDoc.DocumentObjectModel;
namespace SharpReports.Lib.Elements;

public class BreakLineElement : ReportElement
{
    public override void Render(Document document, Section? section = null)
    {
        var currentSection = section ?? document.AddSection();
        var paragraph = currentSection.AddParagraph("" ?? string.Empty);

    }

}
