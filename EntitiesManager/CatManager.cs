using Entities;
using Firestore;
using Validations;

namespace EntitiesManager
{
    /// <summary>
    /// Clase encargada de gestionar las operaciones relacionadas con los gatos en Firestore.
    /// Hereda de la clase base FirestoreManager.
    /// </summary>
    public class CatManager : FirestoreManager<Cat>
    {
        /// <summary>
        /// Crea una nueva instancia de la clase CatManager.
        /// </summary>
        public CatManager() : base("cats")
        {

        }

        /// <summary>
        /// Crea un nuevo gato en Firestore.
        /// </summary>
        /// <param name="cat">El objeto Cat a agregar.</param>
        /// <returns>Un valor de la enumeración CatAddError que indica el resultado de la operación.</returns>
        public async Task<CatAddError> CreateNewCat(Cat cat)
        {
            CatValidation.CatValidationSuccess += HandleCatValidationSuccess;

            if (CatValidation.ValidateRequiredFields(cat))
            {
                if (await FieldExists("Nombre", cat.Name))
                {
                    return CatAddError.NameExists;
                }
                else
                {
                    await Create(cat, cat.Name);
                    return CatAddError.NoError;
                }
            }
            else
            {
                return CatAddError.Error;
            }
        }

        /// <summary>
        /// Actualiza los datos de un gato existente en Firestore.
        /// </summary>
        /// <param name="cat">El objeto Cat actualizado.</param>
        /// <returns>Un valor de la enumeración CatUpdateError que indica el resultado de la operación.</returns>
        public async Task<CatUpdateError> UpdateNewCat(Cat cat)
        {
            // usuraio original
            Cat catToUpdate = await GetCat(cat.Name);

            if (catToUpdate != null)
            {
                bool changesMade = (catToUpdate.Name != cat.Name) || (catToUpdate.Age != cat.Age) || (catToUpdate.Weight != cat.Weight) || (catToUpdate.FurColor != cat.FurColor) || (catToUpdate.Race != cat.Race) || (catToUpdate.IsSterilized != cat.IsSterilized) || (catToUpdate.URLImage != cat.URLImage);

                if (changesMade)
                {
                    catToUpdate.Name = cat.Name;
                    catToUpdate.Age = cat.Age;
                    catToUpdate.Weight = cat.Weight;
                    catToUpdate.FurColor = cat.FurColor;
                    catToUpdate.Race = cat.Race;
                    catToUpdate.IsSterilized = cat.IsSterilized;
                    catToUpdate.URLImage = cat.URLImage;

                    await UpdateCat(catToUpdate, catToUpdate.Name);
                    return CatUpdateError.NoError;
                }
                else
                {
                    return CatUpdateError.NoChanges;
                }
            }
            else
            {
                return CatUpdateError.Error;
            }
        }

        /// <summary>
        /// Actualiza los datos de un gato en Firestore.
        /// </summary>
        /// <param name="cat">El objeto Cat actualizado.</param>
        /// <param name="id">El ID del gato a actualizar.</param>
        public async Task UpdateCat(Cat cat, string id) => await Update(cat, id);

        /// <summary>
        /// Elimina un gato de Firestore.
        /// </summary>
        /// <param name="id">El ID del gato a eliminar.</param>
        public async Task DeleteCat(string id) => await Delete(id);

        /// <summary>
        /// Obtiene los datos de un gato específico desde Firestore.
        /// </summary>
        /// <param name="id">El ID del gato a obtener.</param>
        /// <returns>El objeto Cat correspondiente al ID especificado.</returns>
        public async Task<Cat> GetCat(string id) => await Get(id);

        /// <summary>
        /// Obtiene una lista de todos los gatos almacenados en Firestore.
        /// </summary>
        /// <returns>Una lista de objetos Cat.</returns>
        public async Task<List<Cat>> GetCats() => await GetAll();

        /// <summary>
        /// Verifica si existe un campo con un valor específico en Firestore.
        /// </summary>
        /// <param name="field">El nombre del campo a buscar.</param>
        /// <param name="value">El valor del campo a buscar.</param>
        /// <returns>Un valor booleano que indica si el campo existe.</returns>
        public async Task<bool> FieldExists(string field, string value)
        {
            return await FieldExistsAsync(field, value);
        }

        /// <summary>
        /// Maneja el evento de éxito de la validación del gato.
        /// </summary>
        private static void HandleCatValidationSuccess()
        {
            string filePath = "Eventos.txt";
            string logMessage = $"{DateTime.Now}: La validación del Gato fue exitosa.";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.AutoFlush = true;
                writer.WriteLine(logMessage);
            }
        }

        /// <summary>
        /// Enumeración que representa los posibles errores al agregar un gato.
        /// </summary>
        public enum CatAddError
        {
            NoError,
            Error,
            NameExists
        }

        /// <summary>
        /// Enumeración que representa los posibles errores al actualizar un gato.
        /// </summary>
        public enum CatUpdateError
        {
            NoError,
            Error,
            NoChanges
        }


    }
}