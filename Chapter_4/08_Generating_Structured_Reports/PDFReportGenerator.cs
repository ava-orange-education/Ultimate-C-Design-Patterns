using System;
using System.IO;


namespace Chapter_4._08_Generating_Structured_Reports
{
    public class PDFReportGenerator
    {
        public static void Generate(Report report, string filePath)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            document.Open();
            document.Add(new Paragraph(report.Title));
            document.Add(new Paragraph(report.Content));
            document.Add(new Paragraph(report.Footer));

            document.Close();
        }
    }

    internal class PdfWriter
    {
        internal static void GetInstance(Document document, FileStream fileStream)
        {
            throw new NotImplementedException();
        }
    }
}
