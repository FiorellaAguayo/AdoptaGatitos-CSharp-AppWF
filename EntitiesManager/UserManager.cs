using Firestore;
using Entities;
using Validations;

namespace EntitiesManager
{
    /// <summary>
    /// Clase que gestiona las operaciones relacionadas con los usuarios en Firestore.
    /// </summary>
    public class UserManager : FirestoreManager<User>
    {
        /// <summary>
        /// Crea una nueva instancia de UserManager.
        /// </summary>
        public UserManager() : base("users")
        {

        }

        /// <summary>
        /// Actualiza un usuario existente en Firestore.
        /// </summary>
        /// <param name="user">El usuario actualizado.</param>
        /// <param name="id">El ID del usuario.</param>
        public async Task UpdateUser(User user, string id) => await Update(user, id);

        /// <summary>
        /// Elimina un usuario de Firestore.
        /// </summary>
        /// <param name="id">El ID del usuario.</param>
        public async Task DeleteUser(string id) => await Delete(id);

        /// <summary>
        /// Obtiene un usuario de Firestore.
        /// </summary>
        /// <param name="id">El ID del usuario.</param>
        /// <returns>El usuario encontrado, o null si no se encontró.</returns>
        public async Task<User> GetUser(string id) => await Get(id);

        /// <summary>
        /// Obtiene todos los usuarios de Firestore.
        /// </summary>
        /// <returns>Una lista de usuarios.</returns>
        public async Task<List<User>> GetUsers() => await GetAll();

        /// <summary>
        /// Verifica si un usuario existe en Firestore.
        /// </summary>
        /// <param name="id">El ID del usuario.</param>
        /// <returns>true si el usuario existe, false si no.</returns>
        private async Task<bool> UserExists(string id)
        {
            var user = await Get(id);
            return user != null ? true : false;
        }

        /// <summary>
        /// Verifica si un campo específico y su valor existen en Firestore.
        /// </summary>
        /// <param name="field">El nombre del campo.</param>
        /// <param name="value">El valor a verificar.</param>
        /// <returns>true si el campo y su valor existen, false en caso contrario.</returns>
        public async Task<bool> FieldExists(string field, string value)
        {
            return await FieldExistsAsync(field, value);
        }

        /// <summary>
        /// Crea un nuevo usuario en Firestore.
        /// </summary>
        /// <param name="user">El usuario a crear.</param>
        /// <returns>El resultado de la operación de creación.</returns>
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

        /// <summary>
        /// Crea un nuevo usuario en Firestore.
        /// </summary>
        /// <param name="user">El usuario a crear.</param>
        /// <returns>El resultado de la operación de creación.</returns>
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

        /// <summary>
        /// Actualiza un usuario existente en Firestore.
        /// </summary>
        /// <param name="user">El usuario actualizado.</param>
        /// <returns>El resultado de la operación de actualización.</returns>
        public async Task<UserUpdateError> UpdateNewUser(User user)
        {
            // usuraio original
            User userToUpdate = await GetUser(user.UserName);

            if (userToUpdate != null)
            {
                bool changesMade = (userToUpdate.Id != user.Id) || (userToUpdate.Role != user.Role) || (userToUpdate.Email != user.Email) || (userToUpdate.Password != user.Password) || (userToUpdate.LastDonation != user.LastDonation) || (userToUpdate.Phone != user.Phone);

                if (changesMade)
                {
                    userToUpdate.Id = user.Id;
                    userToUpdate.Role = user.Role;
                    userToUpdate.Email = user.Email;
                    userToUpdate.Password = user.Password;
                    userToUpdate.LastDonation = user.LastDonation;
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

        /// <summary>
        /// Verifica si las credenciales de inicio de sesión son correctas.
        /// </summary>
        /// <param name="incomingUser">El usuario entrante con las credenciales.</param>
        /// <returns>El resultado de la verificación de las credenciales.</returns>
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

        /// <summary>
        /// Enumeración que representa los posibles errores al agregar un usuario.
        /// </summary>
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

        /// <summary>
        /// Enumeración que representa los posibles errores al iniciar sesión.
        /// </summary>
        public enum UserLoginError
        {
            NoError,
            Error,
            UserNameDoesNotExists,
            PasswordDoesNotExists
        }

        /// <summary>
        /// Enumeración que representa los posibles errores al actualizar un usuario.
        /// </summary>
        public enum UserUpdateError
        {
            NoError,
            Error,
            NoChanges
        }
    }
}