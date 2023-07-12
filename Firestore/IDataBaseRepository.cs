using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firestore
{
    public interface IDataBaseRepository<T> where T : class
    {
        Task Create(T entity, string id);
        Task Delete(string id);
        Task Update(T entity, string id);
        Task<T> Get(string id);
        Task<List<T>> GetAll();
        Task<bool> FieldExists(string field, string value);
        Task<List<T>> GetByFieldValueAsync(string field, string value);
    }
}
