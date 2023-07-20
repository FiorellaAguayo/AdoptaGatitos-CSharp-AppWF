using Validations;
using Entities;

namespace Tests
{
    /// <summary>
    /// Clase de pruebas unitarias para la validaci�n de usuarios.
    /// </summary>
    [TestClass]
    public class UserValidationTests
    {
        /// <summary>
        /// Prueba para validar un correo electr�nico v�lido.
        /// </summary>
        [TestMethod]
        public void ValidateEmail_ValidData_ReturnsTrue()
        {
            // Arrange
            string email = "name@gmail.com";

            // Act
            bool result = UserValidation.ValidateEmail(email);

            // Assert
            Assert.IsTrue(result);
        }

        /// <summary>
        /// Prueba para validar un correo electr�nico inv�lido.
        /// </summary>
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

        /// <summary>
        /// Clase de pruebas unitarias para la validaci�n de gatos.
        /// </summary>
        [TestMethod]
        public async Task ValidateRequiredFields_ValidCat_ReturnsTrue()
        {
            // Arrange
            Cat cat = new Cat("pepe", "12", "12", "hide.png", "marr�n", "No tiene", "no");

            // Act
            bool result = CatValidation.ValidateRequiredFields(cat);

            // Assert
             Assert.IsTrue(result);
        }
    }
}