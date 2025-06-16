using SharpReports.Lib.Elements;

public class HeaderBuilder
{
    private readonly HeaderElement _header = new();

    public HeaderBuilder AddParagraph(string text)
    {
        _header.text = text;
        return this;
    }

    public HeaderElement Build() => _header;
}
