
using Entities;

namespace Validations
{
    public class CatValidation
    {
        public delegate void CatValidationSuccessHandler();
        public static event CatValidationSuccessHandler CatValidationSuccess;

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

        protected static void OnCatValidationSuccess()
        {
            CatValidationSuccess?.Invoke();
        }
    }
}