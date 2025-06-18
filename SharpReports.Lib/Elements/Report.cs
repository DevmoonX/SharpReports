using MigraDoc.DocumentObjectModel;

namespace SharpReports.Lib.Elements;

public class Report
{
    public HeaderElement? Header { get; set; }
    public DocumentElement Root { get; }

    public Report()
    {
        Root = new DocumentElement();
    }

    public Document Render()
    {
        var document = Root.CreateDocument(); // separate creation from rendering
        var section = document.Sections[0];   // first and main section

        Header?.Render(section.Headers.Primary);

        Root.RenderContent(document, section);

        return document;
    }
}
