using SharpReports.Lib.Builders;
using MigraDoc.Rendering;
using MigraDoc.DocumentObjectModel;
using PdfSharp.Fonts;
using SharpReports.Demo;
using SharpReports.Lib.Extenstions;

class Program
{
    static void Main()
    {
        GlobalFontSettings.FontResolver = FontResolver.Instance;


        var report = new ReportBuilder()
        .AddSection()

        .AddParagraph("Hello World 2",
            isUnderline: true, fontSize: 35,
            color: ReportColor.Blue, alignment: ParagraphAlignment.Center)
            .EndParagraph()
                    .AddBreakLine()
                    .AddBreakLine()
                    .AddBreakLine()
                    .AddBreakLine()
                    .AddBreakLine()
                    .AddBreakLine()
                    .AddHorizontalLine()
            .AddParagraph("This is a demo of SharpReports",
            isBold: false, isItalic: true, fontSize: 20).EndParagraph()
        .EndSection()
        .Build(true, "report.pdf");


    }
}
