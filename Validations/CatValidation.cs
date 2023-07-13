using Entities;

namespace Validations
{
    public class CatValidation
    {
        public delegate void CatValidationSuccessHandler();
        public static event CatValidationSuccessHandler CatValidationSuccess;

        /// <summary>
        /// Valida los campos requeridos de un objeto Cat. 
        /// Si todos los campos requeridos están bien, llama al evento CatValidationSuccess.
        /// </summary>
        /// <param name="cat"></param>
        /// <returns></returns>
        public static bool ValidateRequiredFields(Cat cat)
        {
            bool isValid = !string.IsNullOrEmpty(cat.Name)
                && !string.IsNullOrEmpty(cat.Age)
                && !string.IsNullOrEmpty(cat.Weight)
                && !string.IsNullOrEmpty(cat.Race)
                && !string.IsNullOrEmpty(cat.FurColor)
                && !string.IsNullOrEmpty(cat.IsSterilized)
                && !string.IsNullOrEmpty(cat.URLImage);

            if (isValid)
            {
                OnCatValidationSuccess();
            }

            return isValid;
        }

        /// <summary>
        /// Llama al evento CatValidationSuccess cuando se valida con éxito un objeto Cat.
        /// </summary>
        protected static void OnCatValidationSuccess()
        {
            CatValidationSuccess?.Invoke();
        }
    }
}