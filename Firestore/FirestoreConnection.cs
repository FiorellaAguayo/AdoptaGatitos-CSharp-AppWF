using Google.Cloud.Firestore;

namespace Firestore
{
    public class FirestoreConnection
    {
        private static FirestoreDb _firestoreDb;

        public static FirestoreDb getFirestoreInstance()
        {
            if (_firestoreDb == null)
            {
                string path = $"{AppDomain.CurrentDomain.BaseDirectory}recuparciallabo2-firebase-adminsdk-8ec5c-516c5acf69.json";
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
                _firestoreDb = FirestoreDb.Create("recuparciallabo2");
            }
            return _firestoreDb;
        }
    }
}