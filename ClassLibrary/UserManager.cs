using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

using Google.Cloud.Firestore;

namespace ClassLibrary
{
    public class UserManager
    {
        public enum UserAddError
        {
            NoError,
            Error,
            EmailExists,
            UserNameExists,
            BothExist
        }

        public static async Task<UserAddError> AddUserAsync(User incomingUser, FirestoreConnection connection, FirestoreABM firestoreAbm)
        {
            if (incomingUser == null || !Validation.ValidateEmail(incomingUser.Email) || string.IsNullOrEmpty(incomingUser.Email) || string.IsNullOrEmpty(incomingUser.UserName) || string.IsNullOrEmpty(incomingUser.Password))
            {
                return UserAddError.Error;
            }

            bool emailExists = await CheckEmailExistsAsync(incomingUser.Email, connection);
            bool userNameExists = await CheckUserNameExistsAsync(incomingUser.UserName, connection);

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
                Random random = new Random();
                int idRandom;

                do
                {
                   idRandom = random.Next(1001, 9999);
                } while (await CheckUserIdExistsAsync(idRandom.ToString(), connection));

                Dictionary<string, object> userData = new Dictionary<string, object>
                {
                    { "role", "Visitante"},
                    { "id", idRandom},
                    { "username", incomingUser.UserName },
                    { "email", incomingUser.Email },
                    { "password", incomingUser.Password }
                };

                await firestoreAbm.AddDataAsync("users", idRandom.ToString(), userData);

                return UserAddError.NoError;
            }
        }

        public enum UserLoginError
        {
            NoError,
            Error,
            UserNameDoesNotExists,
            PasswordDoesNotExists
        }

        public static async Task<UserLoginError> ValidateExistingUser(User incomingUser, FirestoreConnection connection, FirestoreABM firestoreAbm)
        {
            if (incomingUser == null || string.IsNullOrEmpty(incomingUser.UserName) || string.IsNullOrEmpty(incomingUser.Password))
            {
                return UserLoginError.Error;
            }

            bool userNameExists = await CheckUserNameExistsAsync(incomingUser.UserName, connection);
            bool passwordExists = await CheckUserPasswordExistsAsync(incomingUser.Password, connection);

            if (userNameExists && passwordExists)
            {
                User existingUser = await GetUserByUsernameAsync(incomingUser.UserName, connection);
                incomingUser.Id = existingUser.Id;
                incomingUser.Role = existingUser.Role;
                incomingUser.Email = existingUser.Email;
                incomingUser.Password = existingUser.Password;
                return UserLoginError.NoError;
            }
            else if(!userNameExists)
            {
                return UserLoginError.UserNameDoesNotExists;
            }
            else if(!passwordExists)
            {
                return UserLoginError.PasswordDoesNotExists;
            }
            else
            {
                return UserLoginError.Error;
            }
        }

        private static async Task<bool> CheckEmailExistsAsync(string email, FirestoreConnection connection)
        {
            CollectionReference usersRef = connection.Database.Collection("users");
            Query query = usersRef.WhereEqualTo("email", email).Limit(1);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            return snapshot.Count > 0; // true = existe
        }

        private static async Task<bool> CheckUserNameExistsAsync(string userName, FirestoreConnection connection)
        {
            CollectionReference usersRef = connection.Database.Collection("users");
            Query query = usersRef.WhereEqualTo("username", userName).Limit(1);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            return snapshot.Count > 0; // true = existe
        }

        private static async Task<bool> CheckUserIdExistsAsync(string id, FirestoreConnection connection)
        {
            CollectionReference usersRef = connection.Database.Collection("users");
            Query query = usersRef.WhereEqualTo("id", id).Limit(1);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            return snapshot.Count > 0; // true = existe
        }

        private static async Task<bool> CheckUserPasswordExistsAsync(string password, FirestoreConnection connection)
        {
            CollectionReference usersRef = connection.Database.Collection("users");
            Query query = usersRef.WhereEqualTo("password", password).Limit(1);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            return snapshot.Count > 0; // true = existe
        }

        public static async Task<User> GetUserByUsernameAsync(string username, FirestoreConnection connection)
        {
            CollectionReference collectionRef = connection.Database.Collection("users");
            QuerySnapshot snapshot = await collectionRef.WhereEqualTo("username", username).GetSnapshotAsync();

            if (snapshot.Documents.Count > 0)
            {
                DocumentSnapshot documentSnapshot = snapshot.Documents[0];

                int idDoc = documentSnapshot.GetValue<int>("id");
                string roleDoc = documentSnapshot.GetValue<string>("role");
                string emailDoc = documentSnapshot.GetValue<string>("email");
                string usernameDoc = documentSnapshot.GetValue<string>("username");
                string passwordDoc = documentSnapshot.GetValue<string>("password");

                User user = new User(idDoc, roleDoc, emailDoc, usernameDoc, passwordDoc);

                return user;
            }
            else
            {
                return null; //El el usuario no existe
            }
        }
    }
}