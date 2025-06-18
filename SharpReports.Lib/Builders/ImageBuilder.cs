using SharpReports.Lib.Builders.Interfaces;
using SharpReports.Lib.Elements;
namespace SharpReports.Lib.Builders;

public class ImageBuilder : IImageBuilder
{
    private readonly ImageElement _image;
    private readonly SectionBuilder _parentBuilder;

    public ImageBuilder(SectionBuilder parentBuilder)
    {
        _image = new ImageElement();
        _parentBuilder = parentBuilder;
    }

    public IImageBuilder SetImagePath(string path)
    {
        _image.ImagePath = path;
        return this;
    }

    public IImageBuilder SetWidth(double width)
    {
        _image.Width = width;
        return this;
    }

    public IImageBuilder SetHeight(double height)
    {
        _image.Height = height;
        return this;
    }

    public SectionBuilder EndImage()
    {
        _parentBuilder._section.Elements.Add(_image);
        return _parentBuilder;
    }

    public IReportElements Build()
    {
        return _image;
    }
}

