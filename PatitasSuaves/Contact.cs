using Entities;
using EntitiesManager;
using LogData;
using Validations;

namespace PatitasSuaves
{
    public partial class Contact : Form
    {
        private UserManager userManager;
        private User user;

        public Contact(User actualUser)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            userManager = new UserManager();
            user = actualUser;
        }

        /// <summary>
        /// Valida los campos del formulario de contacto y muestra mensajes segun el resultado de la validación.
        /// </summary>
        private void btnSend_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string email = txbEmail.Text;
            string message = txbMessage.Text;

            ContactValidation.ContactSendError validationError = ContactValidation.ValidateFields(name, email, message, user);

            switch (validationError)
            {
                case ContactValidation.ContactSendError.Incomplete:
                    MessageBox.Show("Complete los campos obligatorios.");
                    break;
                case ContactValidation.ContactSendError.EmailNoValid:
                    MessageBox.Show("Ingrese un email válido.");
                    break;
                case ContactValidation.ContactSendError.NameError:
                    MessageBox.Show("El nombre no puede contener números.");
                    break;
                case ContactValidation.ContactSendError.NoSameName:
                    MessageBox.Show("El email no coincide con el usuario actual.");
                    break;
                case ContactValidation.ContactSendError.Error:
                    MessageBox.Show("Mensaje enviado.");
                    Log.WriteLog($"El usuario {name} ha enviado un mensaje al administrador.");
                    break;
                default:
                    MessageBox.Show("Error desconocido.");
                    break;
            }
        }

        /// <summary>
        /// Muestra un mensaje indicando que se ha enviado la petición y registra un log.
        /// </summary>
        private void btnBePart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hemos enviado la petición. El administrador se comunicará pronto.");
            Log.WriteLog($"El usuario {user.UserName} ha enviado una petición de Ser Parte.");
        }

        /// <summary>
        /// Muestra un mensaje indicando que se ha cancelado la petición y registra un log.
        /// </summary>
        private void btnCancelBePart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelaste la petición.");
            Log.WriteLog($"El usuario {user.UserName} ha cancelado la petición de Ser Parte.");
        }
    }
}