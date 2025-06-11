using System;
using SharpReports.Lib.Elements.Interfaces;
using MigraDoc.DocumentObjectModel;

namespace SharpReports.Lib.Elements;

public class SectionElement : ReportElement, IContainerElement
{
    public IList<IReportElements> Elements { get; } = new List<IReportElements>();

    public override void Render(Document document, Section? section = null)
    {
        var currentSection = section ?? document.AddSection();

        foreach (var element in Elements)
        {
            element.Render(document, currentSection);
        }
    }

}
