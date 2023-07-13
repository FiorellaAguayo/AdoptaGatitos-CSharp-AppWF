using PatitasSuaves;
using CsvHelper;
using System.Globalization;

namespace EntitiesManager
{
    public class CsvExporter<T> : IExporter<T>
    {
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