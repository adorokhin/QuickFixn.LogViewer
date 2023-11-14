using System.Collections.Generic;
using System.IO;
using System.Windows.Media;

namespace QuickFixn.LogViewer.WPF
{
    public class ColorsTester
    {
        public static void GenerateHtml(Dictionary<int, Brush> data)
        {
            // Start of the HTML content
            string htmlContent = @"
            <html>
            <head>
                <title>Key-Color Table</title>
            </head>
            <body>
                <table border=""1"">
                    <tr>
                        <th>Key</th>
                        <th>Color</th>
                    </tr>
            ";

            // Generate rows based on data
            foreach (var pair in data)
            {
                htmlContent += $@"
                <tr>
                    <td>{pair.Key}</td>
                    <td style=""background-color: {pair.Value};"">{pair.Value}</td>
                </tr>
                ";
            }

            // End of the HTML content
            htmlContent += @"
                </table>
            </body>
            </html>
            ";
            // Write the HTML content to a file
            File.WriteAllText("output.html", htmlContent);
        }
    }
}
