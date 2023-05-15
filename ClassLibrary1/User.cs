using System.Diagnostics.Metrics;

namespace ClassLibrary1
{
    public class User
    {
        private static int lastId = 1000;

        private int _id;
        private string _fullName;
        private string _phone;
        private string _email;
        private string _user;
        private string _password;
        private string _role;

        public int Id { get { return _id; } set { _id = value; } }
        public string FullName { get { return _user; } set { _user = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string UserName { get { return _user; } set { _user = value; } } 
        public string Password { get { return _password; } set { _password = value; } }
        public string Role { get { return _role; } set { _role = value; } }

        public User(string email, string userName, string password)
        {
            this.Email = email;
            this.UserName = userName;
            this.Password = password;
        }

        public User(int id, string email, string userName, string password, string role)
        {
            UserName = userName;
            Password = password;
            Email = email;
            Id = id;
            Role = role;
        }

        public User(int id, string fullName, string phone, string email, string userName, string password, string role) 
        {
            Id = id;
            FullName = fullName;
            Phone = phone;
            Email = email;
            UserName = userName;
            Password = password;
            Role = role;
        }
    }
}