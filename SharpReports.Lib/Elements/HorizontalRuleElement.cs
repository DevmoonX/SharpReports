using MigraDoc.DocumentObjectModel;
using SharpReports.Lib.Elements.Interfaces;

namespace SharpReports.Lib.Elements;

public class HorizontalRuleElement : ReportElement
{
    public override void Render(Document document, Section? section = null)
    {
        if (section == null)
            throw new ArgumentNullException(nameof(section));

        var paragraph = section.AddParagraph();
        paragraph.Format.SpaceBefore = "5pt";
        paragraph.Format.SpaceAfter = "5pt";
        paragraph.Format.Borders.Bottom.Width = 1;
        paragraph.Format.Borders.Bottom.Color = Colors.Black;
        paragraph.AddText(" "); // Required to make the border visible
    }
}
