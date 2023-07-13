using System.Data;
using System.Numerics;
using Google.Cloud.Firestore;

using static Google.Cloud.Firestore.V1.StructuredAggregationQuery.Types.Aggregation.Types;

namespace Entities
{
    [FirestoreData]
    public class Cat
    {
        [FirestoreProperty]
        public string Name { get; set; }
        [FirestoreProperty]
        public string Age { get; set; }
        [FirestoreProperty]
        public string URLImage { get; set; }
        [FirestoreProperty]
        public string Race { get; set; }
        [FirestoreProperty]
        public string FurColor { get; set; }
        [FirestoreProperty]
        public string Weight { get; set; }
        [FirestoreProperty]
        public string IsSterilized { get; set; }

        public Cat() 
        { 
        
        }

        public Cat(string name, string age, string weight, string urlImage, string furColor, string race, string isSterilized)
        {
            Name = name;
            Age = age;
            Weight = weight;
            URLImage = urlImage;
            FurColor = furColor;
            Race = race;
            IsSterilized = isSterilized;
        }
    }
}