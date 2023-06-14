using Google.Cloud.Firestore;

namespace ClassLibrary
{
    public class FirestoreABM
    {
        private readonly FirestoreConnection _firestoreConnection;

        public object Database { get; internal set; }

        public FirestoreABM(FirestoreConnection firestoreConnection)
        {
            _firestoreConnection = firestoreConnection;
        }

        public async Task AddDataAsync(string collectionName, string documentId, Dictionary<string, object> data)
        {
            DocumentReference documentRef = _firestoreConnection.Database.Collection(collectionName).Document(documentId);
            await documentRef.SetAsync(data);
        }

        public async Task<DocumentSnapshot> GetDataAsync(string collectionName, string documentId)
        {
            DocumentReference docRef = _firestoreConnection.Database.Collection(collectionName).Document(documentId);
            return await docRef.GetSnapshotAsync();
        }

        public async Task UpdateDataAsync(string collectionName, string documentId, Dictionary<string, object> updatedData)
        {
            DocumentReference docRef = _firestoreConnection.Database.Collection(collectionName).Document(documentId);
            await docRef.UpdateAsync(updatedData);
        }

        public async Task DeleteDataAsync(string collectionName, string documentId)
        {
            DocumentReference docRef = _firestoreConnection.Database.Collection(collectionName).Document(documentId);
            await docRef.DeleteAsync();
        }
    }
}