using System.Text.RegularExpressions;

using Entities;

namespace Validations
{
    public class UserValidation
    {
        public static bool ValidateEmail(string email)
        {
            if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidateRequiredFields(User user)
        {
            return !string.IsNullOrEmpty(user.Id) && 
                !string.IsNullOrEmpty(user.Role) && 
                !string.IsNullOrEmpty(user.UserName) && 
                !string.IsNullOrEmpty(user.Email) && 
                !string.IsNullOrEmpty(user.Password);
        }

        public static bool ValidateUserFields(string id, string role, string username, string email, string password)
        {
            return !string.IsNullOrEmpty(id) &&
                   !string.IsNullOrEmpty(role) &&
                   !string.IsNullOrEmpty(username) &&
                   !string.IsNullOrEmpty(email) &&
                   !string.IsNullOrEmpty(password);
        }
    }
}