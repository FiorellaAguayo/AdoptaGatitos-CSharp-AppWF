using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Reports
{
    /// <summary>
    /// Clase que exporta los datos a un archivo PDF.
    /// </summary>
    /// <typeparam name="T">Tipo de datos a exportar.</typeparam>
    public class PdfExporter<T> : IExporter<T>
    {
        /// <summary>
        /// Exporta los datos a un archivo PDF en la ubicación especificada.
        /// </summary>
        /// <param name="data">La lista de datos a exportar.</param>
        /// <param name="path">La ubicación del archivo PDF de destino.</param>
        /// <returns>Una tareaterminada.</returns>
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