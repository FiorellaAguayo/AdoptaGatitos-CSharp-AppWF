using PatitasSuaves;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace EntitiesManager
{
    public class PdfExporter<T> : IExporter<T>
    {
        public Task ExportData(List<T> data, string path)
        {
            return Task.Run(() =>
            {
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    var pdfDoc = new Document();
                    PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    var type = typeof(T);
                    var properties = type.GetProperties();

                    var table = new PdfPTable(properties.Length);
                    foreach (var property in properties)
                    {
                        var cell = new PdfPCell(new Phrase(property.Name));
                        table.AddCell(cell);
                    }

                    foreach (var item in data)
                    {
                        foreach (var property in properties)
                        {
                            var cell = new PdfPCell(new Phrase(property.GetValue(item)?.ToString() ?? string.Empty));
                            table.AddCell(cell);
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();
                }
            });
        }
    }
}