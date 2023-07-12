using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;

using Google.Cloud.Firestore;
using Newtonsoft.Json;

namespace Firestore
{
    public abstract class FirestoreBaseManager
    {
        private readonly FirestoreDb _firestoreDb;
        protected readonly CollectionReference _collection;

        private FirestoreDb FirestoreDb { get { return _firestoreDb; } }
        protected CollectionReference Collection { get { return _collection; } }

        public FirestoreBaseManager(string collectionName)
        {
            _firestoreDb = FirestoreConnection.getFirestoreInstance();
            _collection = FirestoreDb.Collection(collectionName);
        }

        // objects

        protected async Task<bool> CreateObjectAsync<T>(T entity, string idDoc)
        {
            await CreateDocumentAsync(entity, idDoc);
            return true;
        }

        protected virtual async Task<bool> UpdateObjectAsync<T>(T entity, string id)
        {
            if (!await ExistsAsync(id))
            {
                return false;
            }
            await UpdateDocumentAsync(id.ToString(), entity!);
            return true;
        }

        protected virtual async Task<bool> DeleteObjectAsync(string id)
        {
            if (!await ExistsAsync(id))
            {
                return false;
            }
            await DeleteDocumentAsync(id.ToString());
            return true;
        }

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

        public async Task<bool> FieldExistsAsync(string field, string value)
        {
            var query = Collection.WhereEqualTo(field, value).Limit(1);
            var querySnapshot = await query.GetSnapshotAsync();
            return querySnapshot.Documents.Count > 0;
        }

        protected async Task<List<T>> GetByFieldValueAsync<T>(string field, string value) where T : class
        {
            QuerySnapshot snapshot = await Collection.WhereEqualTo(field, value).GetSnapshotAsync();
            return snapshot.Documents.Select(document =>
            {
                var diccionario = document.ToDictionary();
                var json = JsonConvert.SerializeObject(diccionario);
                var prod = JsonConvert.DeserializeObject<T>(json);
                return prod;
            }).ToList();
        }

        // documents

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

        protected async Task UpdateDocumentAsync(string id, object entity)
        {
            var docRef = Collection.Document(id);
            await docRef.SetAsync(entity);
        }

        protected async Task DeleteDocumentAsync(string id)
        {
            var docRef = Collection.Document(id);
            await docRef.DeleteAsync();
        }

        protected async Task<DocumentSnapshot> GetDocumentAsync(string id)
        {
            var docRef = Collection.Document(id);
            return await docRef.GetSnapshotAsync();
        }

        public async Task<bool> ExistsAsync(string id)
        {
            var document = await GetDocumentAsync(id);
            return document.Exists;
        }
    }
}
