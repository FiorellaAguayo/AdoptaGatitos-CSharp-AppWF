using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UserController
    {
        public static bool ValidateLogin(string username, string password)
        {
            string path = "UsersGuardados.txt";
            List<User> users = FileController.ReadUser(path);

            foreach (User user in users) 
            {
                if (user.UserName == username && user.Password == password)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool ValidateSignUp(string email, string username, string password)
        {
            string path = "UsersGuardados.txt";
            List<User> users = FileController.ReadUser(path);
            
            bool userFound = false;

            foreach (User user in users) 
            { 
                if(user.Email == email || user.UserName == username)
                {
                    userFound = true;
                    break;
                }
            }

            if(!userFound && ValidateEmail(email)) 
            { 
                User newUser = new User(email, username, password);
                FileController.WriteUser(newUser, path);
                return true;
            }
            else 
            { 
                return false; 
            }
        }

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

        public static User GetUserByUsername(string username)
        {
            string path = "UsersGuardados.txt";
            List<User> users = FileController.ReadUser(path);
            User userFound = null;

            foreach (User user in users)
            {
                if(user.UserName == username)
                {
                    userFound = user;
                    break;
                }
            }

            return userFound;
        }
    }
}