using Validations;
using Entities;

namespace Tests
{
    [TestClass]
    public class UserValidationTests
    {
        [TestMethod]
        public void ValidateEmail_ValidData_ReturnsTrue()
        {
            // Arrange
            string email = "name@gmail.com";

            // Act
            bool result = UserValidation.ValidateEmail(email);

            // Assert
            Assert.IsTrue(result); // espera
        }

        [TestMethod]
        public void ValidateEmail_InvalidData_ReturnsFalse()
        {
            // Arrange
            string email = "namegmail.com";

            // Act
            bool result = UserValidation.ValidateEmail(email);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public async Task ValidateRequiredFields_ValidCat_ReturnsTrue()
        {
            // Arrange
            Cat cat = new Cat("pepe", "12", "12", "C:\\Users\\fiore\\source\\repos\\PatitasSuaves\\Photos\\hide.png", "marrón", "No tiene", "no");

            // Act
            bool result = CatValidation.ValidateRequiredFields(cat);

            // Assert
             Assert.IsTrue(result);
        }
    }
}