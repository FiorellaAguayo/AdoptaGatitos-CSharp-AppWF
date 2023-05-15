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
        private static readonly string path = @"C:\Users\irlid\Desktop\PARCIAL_Fiorella\PrimerParcialFiorella\bin\Debug\net6.0-windows\UsersGuardados.txt";
        private static int _lastId = 1000;
        private static string _role = "Visitante";


        public static User CreateUser(string email, string userName, string password)
        {
            User user = null;
            if(ValidateEmail(email) && !string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(email))
            {
                user = new User(email, userName, password);
            }
            return user;
        }

        public enum UserAddError
        {
            NoError,
            Error,
            EmailExists,
            UserNameExists,
            BothExist
        }

        public static UserAddError AddUser(User incomingUser)
        {
            List<User> users = FileController.ReadUser(path);

            if (incomingUser == null || !ValidateEmail(incomingUser.Email) || string.IsNullOrEmpty(incomingUser.Email) || string.IsNullOrEmpty(incomingUser.UserName) || string.IsNullOrEmpty(incomingUser.Password))
            {
                return UserAddError.Error;
            }

            bool emailExists = false;
            bool userNameExists = false;

            foreach (User user in users)
            {
                if (user.Email == incomingUser.Email)
                {
                    emailExists = true;
                }
                if (user.UserName == incomingUser.UserName)
                {
                    userNameExists = true;
                }
            }

            if (emailExists && userNameExists)
            {
                return UserAddError.BothExist;
            }
            else if (emailExists)
            {
                return UserAddError.EmailExists;
            }
            else if (userNameExists)
            {
                return UserAddError.UserNameExists;
            }
            else
            {
                int newId = ++_lastId;
                User newUser = new User(newId, incomingUser.Email, incomingUser.UserName, incomingUser.Password, _role);
                FileController.WriteUser(newUser, path);
                return UserAddError.NoError;
            }
        }


        public void Modify(User user)
        {
            List<User> users = FileController.ReadUser(path);
            User userToModify = users.FirstOrDefault(u => u.Id == user.Id);
            if (userToModify != null)
            {
                userToModify.Email = user.Email;
                userToModify.UserName = user.UserName;
                userToModify.Password = user.Password;
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    foreach (User u in users)
                    {
                        sw.WriteLine($"{u.Id},{u.Email},{u.UserName},{u.Password},{u.Role}");
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

        public static bool ValidateExistingLogin(string username, string password, out int id)
        {
            List<User> users = FileController.ReadUser(path);
            id = 0;

            foreach (User user in users) 
            {
                if (user.UserName == username && user.Password == password)
                {
                    id = user.Id;
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

        public static User GetUserById(int id)
        {
            List<User> users = FileController.ReadUser(path);
            User userFound = null;

            foreach (User user in users)
            {
                if(user.Id == id)
                {
                    userFound = user;
                    break;
                }
            }
            return userFound;
        }
    }
}