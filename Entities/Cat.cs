using Google.Cloud.Firestore;

namespace Entities
{
    [FirestoreData]
    public class Cat
    {
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public int Age { get; set; }
        [FirestoreProperty]
        public string Race { get; set; }
        [FirestoreProperty]
        public string CoatColor { get; set; }
        [FirestoreProperty]
        public double weight { get; set; }
        [FirestoreProperty]
        public bool isSterilized { get; set; }

        public Cat() 
        { 
        
        }
    }
}