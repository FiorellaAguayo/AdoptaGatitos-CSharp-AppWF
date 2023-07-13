using Newtonsoft.Json;

namespace Reports
{
    /// <summary>
    /// Clase que implementa la interfaz IExporter<T> para exportar datos en formato JSON.
    /// </summary>
    public class JsonExporter<T> : IExporter <T>
    {
        /// <summary>
        /// Exporta los datos a un archivo JSON en la ubicación especificada.
        /// </summary>
        /// <param name="data">La lista de datos a exportar.</param>
        /// <param name="path">La ubicación del archivo JSON de destino.</param>
        /// <returns>Una tarea que representa la finalización de la exportación.</returns>
        public async Task ExportData(List<T> data, string path) 
        {
            string json = JsonConvert.SerializeObject(data);
            await File.WriteAllTextAsync(path ,json);
        }
    }
}