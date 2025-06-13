using MigraDoc.DocumentObjectModel;

namespace SharpReports.Lib.Elements;

public class Report
{
    public DocumentElement Root { get; }

    public Report()
    {
        Root = new DocumentElement();
    }

    public Document Render()
    {
        return Root.Render();
    }
}
