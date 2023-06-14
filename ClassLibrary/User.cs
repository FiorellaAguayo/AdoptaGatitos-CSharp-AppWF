using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class User
    {
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

        public User(int id, string role, string email, string userName, string password)
        {
            Id = id;
            Role = role;
            Email = email;
            UserName = userName;
            Password = password;
        }
    }
}