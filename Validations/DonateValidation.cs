using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using Entities;

namespace Validations
{
    public class DonateValidation
    {
        public static bool ValidateDonation(User currentUser, string email, string userName, string lastDonation)
        {
            if (currentUser == null || currentUser.Email != email || currentUser.UserName != userName)
            {
                return false;
            }

            if (int.Parse(lastDonation) <= 0)
            {
                return false;
            }

            return true;
        }

        public static bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public static bool ValidateNumericAmount(string amount)
        {
            decimal parsedAmount;
            return decimal.TryParse(amount, out parsedAmount);
        }
    }
}