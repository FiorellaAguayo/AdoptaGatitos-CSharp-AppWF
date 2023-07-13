using Firestore;
using Entities;
using Validations;

namespace EntitiesManager
{
    public class UserManager : FirestoreManager<User>
    {
        public UserManager() : base("users")
        {

        }

        public async Task UpdateUser(User user, string id) => await Update(user, id);

        public async Task DeleteUser(string id) => await Delete(id);

        public async Task<User> GetUser(string id) => await Get(id);

        public async Task<List<User>> GetUsers() => await GetAll();

        private async Task<bool> UserExists(string id)
        {
            var user = await Get(id);
            return user != null ? true : false;
        }

        public async Task<bool> FieldExists(string field, string value)
        {
            return await FieldExistsAsync(field, value);
        }

        public enum UserAddError
        {
            NoError,
            Error,
            EmailExists,
            UserNameExists,
            IdExists,
            BothExist,
            AllExists
        }

        public async Task<UserAddError> CreateUser(User user)
        {
            if (UserValidation.ValidateEmail(user.Email))
            {
                if (await UserExists(user.UserName) && await FieldExists("Email", user.Email))
                {
                    return UserAddError.BothExist;
                }
                else if(await UserExists(user.UserName))
                {
                    return UserAddError.UserNameExists;
                }
                else if (await FieldExists("Email", user.Email))
                {
                    return UserAddError.EmailExists;
                }
                else
                {
                    await Create(user, user.UserName);
                    return UserAddError.NoError;
                }
            }
            else
            {
                return UserAddError.Error;
            }
        }

        public async Task<UserAddError> CreateNewUser(User user)
        {
            if (UserValidation.ValidateRequiredFields(user))
            {
                if(await FieldExists("Email", user.Email) && await FieldExists("Id", user.Id) && await FieldExists("UserName", user.UserName))
                {
                    return UserAddError.AllExists;
                }
                else if (await FieldExists("Email", user.Email))
                {
                    return UserAddError.EmailExists;
                }
                else if (await FieldExists("Id", user.Id))
                {
                    return UserAddError.IdExists;
                }
                else if (await FieldExists("UserName", user.UserName))
                {
                    return UserAddError.UserNameExists;
                }
                else
                {
                    await Create(user, user.UserName);
                    return UserAddError.NoError;
                }
            }
            else
            {
                return UserAddError.Error;
            }
        }

        public enum UserUpdateError
        {
            NoError,
            Error,
            NoChanges
        }

        public async Task<UserUpdateError> UpdateNewUser(User user)
        {
            // usuraio original
            User userToUpdate = await GetUser(user.UserName);

            if (userToUpdate != null)
            {
                bool changesMade = (userToUpdate.Id != user.Id) || (userToUpdate.Role != user.Role) || (userToUpdate.Email != user.Email) || (userToUpdate.Password != user.Password) || (userToUpdate.Amount != user.Amount) || (userToUpdate.Phone != user.Phone);

                if (changesMade)
                {
                    userToUpdate.Id = user.Id;
                    userToUpdate.Role = user.Role;
                    userToUpdate.Email = user.Email;
                    userToUpdate.Password = user.Password;
                    userToUpdate.Amount = user.Amount;
                    userToUpdate.Phone = user.Phone;

                    await UpdateUser(userToUpdate, userToUpdate.UserName);
                    return UserUpdateError.NoError;
                }
                else
                {
                    return UserUpdateError.NoChanges;
                }
            }
            else
            {
                return UserUpdateError.Error;
            }
        }

        public enum UserLoginError
        {
            NoError,
            Error,
            UserNameDoesNotExists,
            PasswordDoesNotExists
        }

        public async Task<UserLoginError> CheckCorrectsKeysAsync(User incomingUser)
        {
            if (string.IsNullOrEmpty(incomingUser.UserName) || string.IsNullOrEmpty(incomingUser.Password))
            {
                return UserLoginError.Error;
            }

            User user = await Get(incomingUser.UserName);

            if (user == null)
            {
                return UserLoginError.UserNameDoesNotExists;
            }
            else if (user.Password != incomingUser.Password)
            {
                return UserLoginError.PasswordDoesNotExists;
            }
            else
            {
                return UserLoginError.NoError;
            }
        }
    }
}