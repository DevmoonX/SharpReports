using System;
using SharpReports.Lib.Elements.Interfaces;
using MigraDoc.DocumentObjectModel;
namespace SharpReports.Lib.Elements;

public class DocumentElement : ReportElement, IContainerElement
{
    public IList<IReportElements> Elements { get; } = new List<IReportElements>();

    public Document Render()
    {
        var document = new Document();
        var section = document.AddSection();
        Render(document, section);
        return document;
    }

    public Document CreateDocument()
    {
        var document = new Document();
        document.AddSection(); // add one default section
        return document;
    }

    public void RenderContent(Document document, Section section)
    {
        foreach (var element in Elements)
        {
            element.Render(document, section);
        }
    }
    public override void Render(Document document, MigraDoc.DocumentObjectModel.Section? section = null)
    {
        if (section == null)
            throw new ArgumentNullException(nameof(section), "Section cannot be null");

        foreach (var element in Elements)
        {
            element.Render(document, section);
        }
    }
}
