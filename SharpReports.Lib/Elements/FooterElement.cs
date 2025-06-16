using MigraDoc.DocumentObjectModel;
using SharpReports.Lib.Elements.Interfaces;

namespace SharpReports.Lib.Elements;

public class FooterElement : ReportElement, IReportElements
{
    public string text { get; set; } = "";

    public double FontSize { get; set; } = 12;

    public ParagraphAlignment Alignment { get; set; } = ParagraphAlignment.Left;

    // This method is for the report to call directly for header rendering
    public void Render(HeaderFooter footer)
    {
        var para = footer.AddParagraph();
        para.AddText(text);
        para.Format.Font.Size = FontSize;
        para.Format.Alignment = Alignment switch
        {
            ParagraphAlignment.Left => MigraDoc.DocumentObjectModel.ParagraphAlignment.Left,
            ParagraphAlignment.Center => MigraDoc.DocumentObjectModel.ParagraphAlignment.Center,
            ParagraphAlignment.Right => MigraDoc.DocumentObjectModel.ParagraphAlignment.Right,
            ParagraphAlignment.Justify => MigraDoc.DocumentObjectModel.ParagraphAlignment.Justify,
            _ => MigraDoc.DocumentObjectModel.ParagraphAlignment.Left
        };
    }

    // This override is required for IReportElements/ReportElement
    public override void Render(Document document, Section? section = null)
    {
        if (section == null)
            throw new ArgumentNullException(nameof(section), "Section cannot be null");
        Render(section.Footers.Primary);
    }
}
