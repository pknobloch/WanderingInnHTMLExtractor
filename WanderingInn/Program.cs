using System;
using System.Linq;
using System.IO;
using AngleSharp.Html.Parser;

namespace WanderingInn
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles($"C:\\Dev\\ExtractFromHTML\\wanderinginnvol5");
            foreach(var file in files)
            {
                var output = $"C:\\Dev\\ExtractFromHTML\\output\\{Path.GetFileName(file)}";
                StripHTML(file, output);
            }
        }
        private static void StripHTML(string file, string output)
        {
            var parser = new HtmlParser();
            var document = parser.ParseDocument(File.ReadAllText(file));
            var title = document.QuerySelector("h1.entry-title");
            var content = document.QuerySelector("div.entry-content");
            var elements = content.Children.Take(content.Children.Count() - 1).ToList();
            elements.Insert(0, title);
            var html = string.Join(Environment.NewLine, elements.Select(c => c.OuterHtml));
            Console.WriteLine($"Writing {title.TextContent}...");
            File.WriteAllText(output, html);
        }
    }
}
