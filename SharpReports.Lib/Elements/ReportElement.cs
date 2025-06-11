using MigraDoc.DocumentObjectModel;

namespace SharpReports.Lib.Elements;

public abstract class ReportElement : IReportElements
{
    public abstract void Render(Document document, Section? section = null);
}
