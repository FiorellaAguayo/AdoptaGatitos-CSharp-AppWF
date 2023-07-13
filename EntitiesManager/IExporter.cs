using Entities;

namespace PatitasSuaves
{
    public interface IExporter <T>
    {
        Task ExportData(List<T> data, string path); 
    }
}