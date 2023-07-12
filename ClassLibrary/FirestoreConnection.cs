using Google.Cloud.Firestore;

namespace Firestore
{
    public class FirestoreConnection
    {
        public FirestoreDb Database { get; }

        public FirestoreConnection()
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", @"C:\Users\fiore\source\repos\ParcialLabo2\ParcialLabo2\bin\Debug\net6.0-windows\parciallabo2-firebase-adminsdk-x4z6o-4e61bebed2.json");
            Database = FirestoreDb.Create("parciallabo2");
        }
    }
}