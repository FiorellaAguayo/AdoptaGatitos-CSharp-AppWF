using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Entities;

namespace Validations
{
    public class ContactValidation
    {
        public enum ContactSendError
        {
            Incomplete,
            EmailNoValid,
            NameError,
            NoSameName,
            Error
        }

        public static ContactSendError ValidateFields(string name, string email, string message, User currentUser)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(message))
            {
                return ContactSendError.Incomplete;
            }

            if (!ValidateEmail(email))
            {
                return ContactSendError.EmailNoValid;
            }

            if (!IsNameValid(name))
            {
                return ContactSendError.NameError;
            }

            if (currentUser != null && currentUser.Email != email)
            {
                return ContactSendError.NoSameName;
            }

            return ContactSendError.Error;
        }

        public static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool IsNameValid(string name)
        {
            return !Regex.IsMatch(name, @"\d");
        }
    }
}

