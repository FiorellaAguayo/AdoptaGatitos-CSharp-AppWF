using Entities;
using PatitasSuaves;
using Newtonsoft.Json;

namespace EntitiesManager
{
    public class JsonExporter<T> : IExporter <T>
    {
        public async Task ExportData(List<T> data, string path) 
        {
            string json = JsonConvert.SerializeObject(data);
            await File.WriteAllTextAsync(path ,json);
        }
    }
}