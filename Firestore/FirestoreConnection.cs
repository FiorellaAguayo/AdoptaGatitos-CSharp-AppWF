using Google.Cloud.Firestore;

namespace Firestore
{
    public class FirestoreConnection
    {
        /// <summary>
        /// Objeto de FirestoreDb para establecer la conexión con Firestore.
        /// </summary>
        private static FirestoreDb _firestoreDb;

        /// <summary>
        /// Obtiene una instancia de FirestoreDb para interactuar con Firestore.
        /// </summary>
        /// <returns></returns>
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