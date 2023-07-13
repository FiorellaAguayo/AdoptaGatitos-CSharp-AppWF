using PatitasSuaves;
using CsvHelper;
using System.Globalization;

namespace EntitiesManager
{
    /// <summary>
    /// Clase encargada de exportar datos a un archivo CSV.
    /// Implementa la interfaz IExporter<T>.
    /// </summary>
    public class CsvExporter<T> : IExporter<T>
    {
        /// <summary>
        /// Exporta los datos a un archivo CSV en la ubicación especificada.
        /// </summary>
        /// <param name="data">La lista de datos a exportar.</param>
        /// <param name="path">La ubicación del archivo CSV.</param>
        /// <returns>Una tarea que representa la finalización de la exportación.</returns>
        public Task ExportData(List<T> data, string path)
        {
            using (var sw = new StreamWriter(path)) 
            using (var csv = new CsvWriter(sw, CultureInfo.InvariantCulture))
            {
                csv.WriteRecordsAsync(data);
            }
            return Task.CompletedTask;
        }
    }
}