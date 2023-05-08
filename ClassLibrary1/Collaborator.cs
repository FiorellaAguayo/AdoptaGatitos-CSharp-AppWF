using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Collaborator : User
    {
        private DateTime _dateAdmission;

        public Collaborator(int id, string fullName, string phone, string email, string userName, string password, string role, DateTime dateAdmission, string area) : base(id, fullName, phone, email, userName, password, role)
        { 
            DateAdmission = dateAdmission;
        }

        public DateTime DateAdmission { get { return _dateAdmission; } set { _dateAdmission = value; } }
    }
}