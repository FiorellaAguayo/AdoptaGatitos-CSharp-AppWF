using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;
using Firestore;
using Validations;

namespace EntitiesManager
{
    public class CatManager : FirestoreManager<Cat>
    {
        public CatManager() : base("cats")
        {

        }

        public async Task UpdateCat(Cat cat, string id) => await Update(cat, id);

        public async Task DeleteCat(string id) => await Delete(id);

        public async Task<Cat> GetCat(string id) => await Get(id);

        public async Task<List<Cat>> GetCats() => await GetAll();

        public async Task<bool> FieldExists(string field, string value)
        {
            return await FieldExistsAsync(field, value);
        }

        public enum CatAddError
        {
            NoError,
            Error,
            NameExists
        }

        public async Task<CatAddError> CreateNewCat(Cat cat)
        {
            CatValidation.CatValidationSuccess += HandleCatValidationSuccess;
            //validar
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

        public enum CatUpdateError
        {
            NoError,
            Error,
            NoChanges
        }

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
    }
}