using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Administrator : User
    {
        private DateTime _lastAccess;
        public Administrator(int id, string fullName, string phone, string email, string userName, string password, string role, DateTime lastAccess) : base (id, fullName, phone, email, userName, password, role)
        { 
            LastAccess = lastAccess;
        }

        public DateTime LastAccess { get { return _lastAccess; } set { _lastAccess = value; } } 
    }
}
