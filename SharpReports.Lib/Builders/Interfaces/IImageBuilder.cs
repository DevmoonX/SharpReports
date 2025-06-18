namespace SharpReports.Lib.Builders.Interfaces;

public interface IImageBuilder : IReportElementBuilder
{
    IImageBuilder SetImagePath(string path);
    IImageBuilder SetWidth(double width);
    IImageBuilder SetHeight(double height);
    SectionBuilder EndImage();
}