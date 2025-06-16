using System.Reflection.PortableExecutable;
using SharpReports.Lib.Builders.Interfaces;
using SharpReports.Lib.Elements;
using SharpReports.Lib.Export;
namespace SharpReports.Lib.Builders;

public class ReportBuilder : IReportBuilder
{
    internal readonly Report _report;

    public ReportBuilder()
    {
        _report = new Report();
    }


    public ISectionBuilder AddSection()
    {
        var sectionBuilder = new SectionBuilder(this);
        return sectionBuilder;
    }

    public ReportBuilder AddHeader(string text, double fontSize = 12, ParagraphAlignment alignment = ParagraphAlignment.Left)
    {
        var header = new HeaderElement
        {
            text = text,
            FontSize = fontSize,
            Alignment = alignment
        };
        _report.Root.Elements.Add(header);
        return this;
    }

    public ReportBuilder AddFooter(string text, double fontSize = 12, ParagraphAlignment alignment = ParagraphAlignment.Left)
    {
        var footer = new FooterElement
        {
            text = text,
            FontSize = fontSize,
            Alignment = alignment
        };
        _report.Root.Elements.Add(footer);
        return this;
    }

    public Report Build(bool Export = false, string filePath = "")
    {
        if (Export)
        {
            _report.Render();
            var exporter = new PDFExporter();
            exporter.Export(_report, filePath);
            return _report;
        }
        return _report;
    }

}