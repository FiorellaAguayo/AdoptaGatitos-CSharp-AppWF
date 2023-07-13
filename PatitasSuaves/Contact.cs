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

        private async void Contact_Load(object sender, EventArgs e)
        {

        }

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
    }
}