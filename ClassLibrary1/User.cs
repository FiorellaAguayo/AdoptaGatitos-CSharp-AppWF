namespace ClassLibrary1
{
    public class User
    {
        private int _id;
        private string _fullName;
        private DateTime _birthday;
        private string _home;
        private int _phone;
        private string _email;
        private string _user;
        private string _password;

        public string UserName { get { return _user; } set { _user = value; } } 
        public string Password { get { return _password; } set { _password = value; } }
        public string Home { get { return _home; } set { _home = value; } }
        public int Phone { get { return _phone; } set { _phone = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public DateTime Birthday { get { return _birthday; } set { _birthday = value; } }

        public User(string email, string userName, string password)
        {
            UserName = userName;
            Password = password;
            Email = email;
        }
    }
}