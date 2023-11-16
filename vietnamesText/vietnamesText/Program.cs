using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

class Program
{
    static void Main()
    {
        var outputPath = "output.pdf";

        using (FileStream fs = new FileStream(outputPath, FileMode.Create))
        {
            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, fs);
            document.Open();

            // Load a font with Unicode support
            BaseFont baseFont = BaseFont.CreateFont("arialuni.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font font = new Font(baseFont, 12);

            // Create a Phrase with Vietnamese text
            Phrase phrase = new Phrase("Xin chào, đây là nội dung tiếng Việt.", font);

            // Add the phrase to the document
            document.Add(phrase);

            document.Close();
        }
    }
}
