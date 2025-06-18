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

    public IHeaderBuilder AddHeader(string text)
    {
        var headerBuilder = new HeaderBuilder(this).AddText(text);

        return headerBuilder;
    }

    public IFooterBuilder AddFooter(string text)
    {
        var footerBuilder = new FooterBuilder(this).AddText(text);
        return footerBuilder;
    }

    private string? _watermarkText;
    private double _watermarkFontSize = 48;
    private double _watermarkAngle = -40;
    private int _watermarkAlpha = 60;
    public ReportBuilder WithWatermark(string text, double fontSize = 48, double angle = -40, int alpha = 60)
    {
        _watermarkText = text;
        _watermarkFontSize = fontSize;
        _watermarkAngle = angle;
        _watermarkAlpha = alpha;
        return this;
    }

    public Report Build(bool Export = false, string filePath = "")
    {
        if (Export)
        {
            _report.Render();
            var exporter = new PDFExporter();
            if (!string.IsNullOrEmpty(_watermarkText))
            {
                exporter.WatermarkText = _watermarkText;
                exporter.WatermarkFontSize = _watermarkFontSize;
                exporter.WatermarkAngle = _watermarkAngle;
                exporter.WatermarkAlpha = _watermarkAlpha;
            }
            exporter.Export(_report, filePath);
            return _report;
        }
        return _report;
    }

}