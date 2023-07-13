using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace Firestore
{
    public abstract class FirestoreDataManager
    {
        private readonly FirestoreDb _firestoreDb;
        protected readonly CollectionReference _collection;

        private FirestoreDb FirestoreDb { get { return _firestoreDb; } }
        protected CollectionReference Collection { get { return _collection; } }

        public FirestoreDataManager(string collectionName)
        {
            _firestoreDb = FirestoreConnection.getFirestoreInstance();
            _collection = FirestoreDb.Collection(collectionName);
        }

        // objects


        /// <summary>
        /// Crea un objeto en Firestore.
        /// </summary>
        protected async Task<bool> CreateObjectAsync<T>(T entity, string idDoc)
        {
            await CreateDocumentAsync(entity, idDoc);
            return true;
        }

        /// <summary>
        /// Actualiza un objeto en Firestore.
        /// </summary>
        protected virtual async Task<bool> UpdateObjectAsync<T>(T entity, string id)
        {
            if (!await ExistsAsync(id))
            {
                return false;
            }
            await UpdateDocumentAsync(id.ToString(), entity!);
            return true;
        }

        /// <summary>
        /// Elimina un objeto en Firestore.
        /// </summary>
        protected virtual async Task<bool> DeleteObjectAsync(string id)
        {
            if (!await ExistsAsync(id))
            {
                return false;
            }
            await DeleteDocumentAsync(id.ToString());
            return true;
        }

        /// <summary>
        /// obtiene un objeto de Firestore por su id.
        /// </summary>
        protected async Task<T> GetObjectAsync<T>(string id) where T : class
        {
            var docSnapshot = await GetDocumentAsync(id);
            if (docSnapshot.Exists)
            {
                return docSnapshot.ConvertTo<T>();
            }
            else
            {
                return null!;
            }
        }

        /// <summary>
        /// Obtiene todos los objetos de una colección en Firestore.
        /// </summary>
        protected virtual async Task<List<T>> GetAllObjectsAsync<T>()
        {
            var EntitySnapshot = await Collection.GetSnapshotAsync();
            var entityList = new List<T>();

            foreach (var entidad in EntitySnapshot)
            {
                var entidadDict = entidad.ToDictionary();
                var json = JsonConvert.SerializeObject(entidadDict);
                var entidadObj = JsonConvert.DeserializeObject<T>(json);
                entityList.Add(entidadObj!);
            }

            return entityList;
        }

        /// <summary>
        /// Verifica si existe un campo con un determinado valor en Firestore.
        /// </summary>
        public async Task<bool> FieldExistsAsync(string field, string value)
        {
            var query = Collection.WhereEqualTo(field, value).Limit(1);
            var querySnapshot = await query.GetSnapshotAsync();
            return querySnapshot.Documents.Count > 0;
        }

        // documents

        /// <summary>
        /// Crea un documumento en Firestore.
        /// </summary>
        protected async Task<string> CreateDocumentAsync<T>(T entity, string docId)
        {
            DocumentReference docRef;

            if (string.IsNullOrEmpty(docId))
            {
                docRef = await Collection.AddAsync(entity);
            }
            else
            {
                docRef = Collection.Document(docId);
                await docRef.SetAsync(entity);
            }

            return docRef.Id;
        }

        /// <summary>
        /// Actualiza un documumento en Firestore.
        /// </summary>
        protected async Task UpdateDocumentAsync(string id, object entity)
        {
            var docRef = Collection.Document(id);
            await docRef.SetAsync(entity);
        }

        /// <summary>
        /// Actualiza un documumento en Firestore.

        /// </summary>
        protected async Task DeleteDocumentAsync(string id)
        {
            var docRef = Collection.Document(id);
            await docRef.DeleteAsync();
        }

        /// <summary>
        /// Obtiene un documumento de Firestore.
        /// </summary>
        protected async Task<DocumentSnapshot> GetDocumentAsync(string id)
        {
            var docRef = Collection.Document(id);
            return await docRef.GetSnapshotAsync();
        }

        /// <summary>
        /// Verifica si existe el documumento en Firestore mediante su ID.
        /// </summary>
        public async Task<bool> ExistsAsync(string id)
        {
            var document = await GetDocumentAsync(id);
            return document.Exists;
        }
    }
}
