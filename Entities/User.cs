using Google.Cloud.Firestore;

namespace Entities
{
    [FirestoreData]
    public class User
    {

        [FirestoreProperty]
        public double TotalDonation { get; set; }
        [FirestoreProperty]
        public string Id { get; set; }
        [FirestoreProperty]
        public string Phone { get; set; }
        [FirestoreProperty]
        public string Email { get; set; }
        [FirestoreProperty]
        public string UserName { get; set; }
        [FirestoreProperty]
        public string Password { get; set; }
        [FirestoreProperty]
        public string Role { get; set; }
        [FirestoreProperty]
        public string Message { get; set; }
        [FirestoreProperty]
        public string PaymentMethod { get; set; }
        [FirestoreProperty]
        public string LastDonation { get; set; }

        public User()
        {

        }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public User(string email, string userName = "", string password = "")
        {
            Email = email;
            UserName = userName;
            Password = password;
        }

        public User(string id, string role, string email, string userName, string password)
            : this(email, userName, password)
        {
            Id = id;
            Role = role;
        }

        public User(string id, string username, string role, string email, string lastdonation, string password, string phone)
        {
            Id = id;
            UserName = username;
            Role = role;
            Email = email;
            Password = password;
            LastDonation = lastdonation;
            Phone = phone;
        }
    }
}