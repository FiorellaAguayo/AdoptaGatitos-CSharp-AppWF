using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firestore
{
    public class FirestoreManager<T> : FirestoreDataManager, IDataBaseRepository<T> where T : class
    {
        public FirestoreManager(string collectionName) : base(collectionName)
        {

        }

        public async Task Update(T entity, string id) => await UpdateObjectAsync(entity, id);

        public async Task Create(T entity, string id) => await CreateObjectAsync(entity, id);

        public async Task Delete(string id) => await DeleteObjectAsync(id);

        public async Task<T> Get(string id) => await GetObjectAsync<T>(id);

        public async Task<List<T>> GetAll() => await GetAllObjectsAsync<T>();

        public async Task<bool> FieldExists(string field, string value)
        {
            return await FieldExistsAsync(field, value);
        }

        public async Task<List<T>> GetByFieldValueAsync(string field, string value)
        {
            return await GetByFieldValueAsync<T>(field, value);
        }
    }
}