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
    public class UserDAL
    {
        private static readonly string path = @"C:\Users\fiore\OneDrive\Escritorio\TP1_LABO1\PrimerParcialFiorella\bin\Debug\net6.0-windows\UsersGuardados.txt";

        public static User CreateUser(string email, string userName, string password)
        {
            User user = null;
            if(ValidateEmail(email) && !string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(email))
            {
                user = new User(email, userName, password);
            }
            return user;
        }

        public static bool AddUser(User incomingUser)
        {
            List<User> users = FileController.ReadUser(path);
            bool userFound = false;

            foreach (User user in users)
            {
                if (user.Email == incomingUser.Email || user.UserName == incomingUser.UserName)
                {
                    userFound = true;
                    break;
                }
            }

            if (!userFound && ValidateEmail(incomingUser.Email) && !string.IsNullOrEmpty(incomingUser.UserName) && !string.IsNullOrEmpty(incomingUser.Password))
            {
                int newId = users.Count > 0 ? users.Max(u => u.Id) + 1 : 1000; // Genera un nuevo ID único
                User newUser = new User(newId.ToString(), incomingUser.Email, incomingUser.UserName, incomingUser.Password);
                users.Add(newUser);
                FileController.WriteUser(users, path);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ModifyUser(User user)
        {
            List<User> users = new List<User>();

            User userToUpdate = users.FirstOrDefault(u => u.Id == user.Id);

            if (userToUpdate != null)
            {
                userToUpdate.UserName = user.UserName;
                userToUpdate.Email = user.Email;

                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    foreach (User u in users)
                    {
                        sw.WriteLine($"{u.Id},{u.UserName},{u.Email}");
                    }
                }
            }
        }

        //public void EliminarUsuario(string userId)
        //{
        //    List<User> users = FileController.ReadUser(path);

        //    User userToDelete = users.FirstOrDefault(u => u.Id == userId);

        //    if (userToDelete != null)
        //    {
        //        users.Remove(userToDelete);

        //        using (StreamWriter sw = new StreamWriter(filePath, false))
        //        {
        //            foreach (User u in users)
        //            {
        //                sw.WriteLine($"{u.Id},{u.Nombre},{u.Email}");
        //            }
        //        }
        //    }
        //}

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

        //public static bool ValidateSignUp(string email, string username, string password)
        //{
        //    string path = "UsersGuardados.txt";
        //    List<User> users = FileController.ReadUser(path);
            
        //    bool userFound = false;

        //    foreach (User user in users) 
        //    { 
        //        if(user.Email == email || user.UserName == username)
        //        {
        //            userFound = true;
        //            break;
        //        }
        //    }

        //    if(!userFound && ValidateEmail(email)) 
        //    { 
        //        User newUser = new User(email, username, password);
        //        FileController.WriteUser(newUser, path);
        //        return true;
        //    }
        //    else 
        //    { 
        //        return false; 
        //    }
        //}

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