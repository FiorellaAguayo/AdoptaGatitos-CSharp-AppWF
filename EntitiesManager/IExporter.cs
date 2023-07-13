namespace PatitasSuaves
{
    /// <summary>
    /// Interfaz para exportar datos a un archivo.
    /// </summary>
    public interface IExporter <T>
    {
        /// <summary>
        /// Exporta los datos a un archivo en la ubicación especificada.
        /// </summary>
        /// <param name="data">La lista de datos a exportar.</param>
        /// <param name="path">La ubicación del archivo de destino.</param>
        /// <returns>Una tarea que representa la finalización de la exportación.</returns>
        Task ExportData(List<T> data, string path); 
    }
}