using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

using Google.Cloud.Firestore;

using Newtonsoft.Json;

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
                    { "Role", "Visitante"},
                    { "Id", idRandom},
                    { "UserName", incomingUser.UserName },
                    { "Email", incomingUser.Email },
                    { "Password", incomingUser.Password }
                };

                await firestoreAbm.AddDataAsync("users", idRandom.ToString(), userData);

                return UserAddError.NoError;
            }
        }

        public static async Task DeleteUserAsync(User incomingUser, FirestoreConnection connection, FirestoreABM firestoreAbm)
        {
            await firestoreAbm.DeleteDataAsync("users", incomingUser.Id.ToString());
        }

        public enum UserDonateError
        {
            NoError,
            Error,
            EmailIsNotTheSame
        }

        public static async Task<UserDonateError> Donate(User incomingUser, User currentUser, FirestoreConnection connection, FirestoreABM firestoreAbm)
        {
            if (incomingUser == null || !Validation.ValidateEmail(incomingUser.Email)
                || string.IsNullOrEmpty(incomingUser.Email) || string.IsNullOrEmpty(incomingUser.PaymentMethod)
                || string.IsNullOrEmpty(incomingUser.CardNumber) || !int.TryParse(incomingUser.CardNumber, out _)
                || !int.TryParse(incomingUser.Phone, out _) || incomingUser.Amount == 0)
            {
                return UserDonateError.Error;
            }

            bool isTheCurrentEmail = false;

            if (string.Equals(incomingUser.Email, currentUser.Email))
            {
                isTheCurrentEmail = true;
            }

            if (!isTheCurrentEmail)
            {
                return UserDonateError.EmailIsNotTheSame;
            }
            else
            {
                currentUser.PaymentMethod = incomingUser.PaymentMethod;
                currentUser.CardNumber = incomingUser.CardNumber;
                currentUser.Phone = incomingUser.Phone;
                currentUser.Direction = incomingUser.Direction;
                currentUser.FullName = incomingUser.FullName;
                currentUser.Message = incomingUser.Message;
                //por aca deberia asignar el incomingUser.Amount a currentUser.ArrayAmounts

                if (currentUser.ArrayAmounts == null)
                {
                    currentUser.ArrayAmounts = new double[] { incomingUser.Amount };
                }
                else
                {
                    // Convertir el arreglo en una cadena separada por comas
                    string arrayAmountsString = string.Join(",", currentUser.ArrayAmounts);

                    // Agregar el nuevo valor a la cadena
                    arrayAmountsString += "," + incomingUser.Amount.ToString();

                    // Convertir la cadena de nuevo a un arreglo de números
                    currentUser.ArrayAmounts = arrayAmountsString.Split(',').Select(double.Parse).ToArray();
                }

                var currentUserData = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonConvert.SerializeObject(currentUser));
                await firestoreAbm.AddDataAsync("users", currentUser.Id.ToString(), currentUserData);

                return UserDonateError.NoError;
            }
        }

        public enum UserLoginError
        {
            NoError,
            Error,
            UserNameDoesNotExists,
            PasswordDoesNotExists
        }

        public static async Task<UserLoginError> ValidateExistingUser(User incomingUser, FirestoreConnection connection)
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
            else if (!userNameExists)
            {
                return UserLoginError.UserNameDoesNotExists;
            }
            else if (!passwordExists)
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
            Query query = usersRef.WhereEqualTo("Email", email).Limit(1);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            return snapshot.Count > 0; // true = existe
        }

        private static async Task<bool> CheckUserNameExistsAsync(string userName, FirestoreConnection connection)
        {
            CollectionReference usersRef = connection.Database.Collection("users");
            Query query = usersRef.WhereEqualTo("UserName", userName).Limit(1);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            return snapshot.Count > 0; // true = existe
        }

        private static async Task<bool> CheckUserIdExistsAsync(string id, FirestoreConnection connection)
        {
            CollectionReference usersRef = connection.Database.Collection("users");
            Query query = usersRef.WhereEqualTo("Id", id).Limit(1);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            return snapshot.Count > 0; // true = existe
        }

        private static async Task<bool> CheckUserPasswordExistsAsync(string password, FirestoreConnection connection)
        {
            CollectionReference usersRef = connection.Database.Collection("users");
            Query query = usersRef.WhereEqualTo("Password", password).Limit(1);
            QuerySnapshot snapshot = await query.GetSnapshotAsync();

            return snapshot.Count > 0; // true = existe
        }

        public static async Task<User> GetUserByUsernameAsync(string username, FirestoreConnection connection)
        {
            CollectionReference collectionRef = connection.Database.Collection("users");
            QuerySnapshot snapshot = await collectionRef.WhereEqualTo("UserName", username).GetSnapshotAsync();

            if (snapshot.Documents.Count > 0)
            {
                DocumentSnapshot documentSnapshot = snapshot.Documents[0];

                int idDoc = documentSnapshot.GetValue<int>("Id");
                string roleDoc = documentSnapshot.GetValue<string>("Role");
                string emailDoc = documentSnapshot.GetValue<string>("Email");
                string usernameDoc = documentSnapshot.GetValue<string>("UserName");
                string passwordDoc = documentSnapshot.GetValue<string>("Password");

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