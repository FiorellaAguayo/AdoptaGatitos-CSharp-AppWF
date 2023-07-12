using Google.Cloud.Firestore;

namespace Entities
{
    [FirestoreData]
    public class User
    {
        private string _id;
        private string _fullName;
        private string _phone;
        private string _email;
        private string _user;
        private string _password;
        private string _role;
        private string _direction;
        private string _message;
        private string _paymentMethod;
        private string _cardNumber;
        private double _amount;

        [FirestoreProperty]
        public double[] ArrayAmounts { get; set; }

        [FirestoreProperty]
        public string Id { get { return _id; } set { _id = value; } }

        [FirestoreProperty]
        public string FullName { get { return _fullName; } set { _fullName = value; } }

        [FirestoreProperty]
        public string Phone { get { return _phone; } set { _phone = value; } }

        [FirestoreProperty]
        public string Email { get { return _email; } set { _email = value; } }

        [FirestoreProperty]
        public string UserName { get { return _user; } set { _user = value; } }

        [FirestoreProperty]
        public string Password { get { return _password; } set { _password = value; } }

        [FirestoreProperty]
        public string Role { get { return _role; } set { _role = value; } }

        [FirestoreProperty]
        public string Direction { get { return _direction; } set { _direction = value; } }

        [FirestoreProperty]
        public string Message { get { return _message; } set { _message = value; } }

        [FirestoreProperty]
        public string PaymentMethod { get { return _paymentMethod; } set { _paymentMethod = value; } }

        [FirestoreProperty]
        public string CardNumber { get { return _cardNumber; } set { _cardNumber = value; } }

        [FirestoreProperty]
        public double Amount { get { return _amount; } set { _amount = value; } }

        public User()
        {

        }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public User(string email, string userName, string password)
        {
            Email = email;
            UserName = userName;
            Password = password;
        }

        public User(string id, string role, string email, string userName, string password)
        {
            Id = id;
            Role = role;
            Email = email;
            UserName = userName;
            Password = password;
        }

        public User(string id, string email, string userName, string role)
        {
            Id = id;
            Role = role;
            Email = email;
            UserName = userName;
        }

        public User(string id, string username, string role, string email, double amount, string password, string phone)
        {
            Id = id;
            UserName= username;
            Role = role;
            Email = email;
            Password = password;
            Amount = amount;
            Phone = phone;
        }

        public User(string fullName, string direction, string email, string phone, string message, string paymentMethod, string cardNumber, double amount)
        {
            FullName = fullName;
            Direction = direction;
            Email = email;
            Phone = phone;
            Message = message;
            PaymentMethod = paymentMethod;
            CardNumber = cardNumber;
            Amount = amount;
        }
    }
}