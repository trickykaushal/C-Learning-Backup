using System;
using System.IO;
using System.Reflection.Metadata;

namespace Itext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    private void createPDF(string html)
    {
        //MemoryStream msOutput = new MemoryStream();
        TextReader reader = new StringReader(html);// step 1: creation of a document-object
        Document document = new Document(PageSize.A4, 30, 30, 30, 30);

        // step 2:
        // we create a writer that listens to the document
        // and directs a XML-stream to a file
        PdfWriter writer = PdfWriter.GetInstance(document, new FileStream("Test.pdf", FileMode.Create));

        // step 3: we create a worker parse the document
        HTMLWorker worker = new HTMLWorker(document);

        // step 4: we open document and start the worker on the document
        document.Open();

        // step 4.1: register a unicode font and assign it an allias
        FontFactory.Register("C:\\Windows\\Fonts\\ARIALUNI.TTF", "arial unicode ms");

        // step 4.2: create a style sheet and set the encoding to Identity-H
        iTextSharp.text.html.simpleparser.StyleSheet ST = New iTextSharp.text.html.simpleparser.StyleSheet();
        ST.LoadTagStyle("body", "encoding", "Identity-H");

        // step 4.3: assign the style sheet to the html parser
        worker.Style = ST;

        worker.StartDocument();

        // step 5: parse the html into the document
        worker.Parse(reader);

        // step 6: close the document and the worker
        worker.EndDocument();
        worker.Close();
        document.Close();
    }
}
