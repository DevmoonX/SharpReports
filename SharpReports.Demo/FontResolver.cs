using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using PdfSharp.Fonts;

namespace SharpReports.Demo
{
    public class FontResolver : IFontResolver
    {
        public static readonly FontResolver Instance = new();

        public string DefaultFontName => "Arial";

        public byte[] GetFont(string faceName)
        {
            string resourceName = faceName switch
            {
                "Arial#Regular" => "SharpReports.Demo.Fonts.arial.ttf",
                _ => throw new ArgumentException("Unknown font: " + faceName)
            };

            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName)
                               ?? throw new Exception($"Font resource '{resourceName}' not found.");

            using var ms = new MemoryStream();
            stream.CopyTo(ms);
            return ms.ToArray();
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            if (familyName.Equals("Arial", StringComparison.OrdinalIgnoreCase))
            {
                return new FontResolverInfo(isBold ? "Arial#Bold" : "Arial#Regular");
            }

            return new FontResolverInfo("Arial#Regular");
        }
    }
}
