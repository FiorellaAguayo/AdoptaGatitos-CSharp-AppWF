using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Collaborator : User
    {
        private DateTime _dateAdmission;
        private string _direction = "";
        private string _modality = "";
        private string _reason = "";

        public Collaborator(string email, string fullName, string phone, string direction, string modality, string reason) : base(email, fullName, phone)
        { 
            Direction = direction;
            Modality = modality;
            Reason = reason;
        }

        public DateTime DateAdmission { get { return _dateAdmission; } set { _dateAdmission = value; } }
        public string Direction { get { return _direction; } set { _direction = value; } }
        public string Modality { get { return _modality; } set { _modality = value; } }
        public string Reason { get { return _reason; } set { _reason = value; } }

        public Collaborator(int id, string email, string password, string userName, string fullName, string phone, string direction, string modality, string reason, DateTime dateAdmission, string role) : base(id, fullName, phone, email, userName, password, role)
        {
            DateAdmission = dateAdmission;
            Direction = direction;
            Modality = modality;
            Reason = reason;
        }
    }
}