using ClassLibrary1;

using static ClassLibrary1.UserDAL;

namespace PrimerParcial
{
    public partial class BePart : Form
    {
        private static User currentUser;

        public BePart(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void BePart_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btn_BePart_Click(object sender, EventArgs e)
        {
            string email = txb_Email.Text;
            string fullName = txb_FullName.Text;
            string phone = txb_Phone.Text;
            string direction = txb_Direction.Text;
            string modality = string.Empty;
            string reason = txb_Reason.Text;

            if (rb_FaceToFace.Checked)
            {
                modality = "Presencial";
            }
            else if (rb_Virtual.Checked)
            {
                modality = "Virtual";
            }

            MessageBox.Show($"{email}, {fullName}, {phone}, {direction}, {modality}, {reason}");

            Collaborator collaborator = UserDAL.CreateCollaborator(email, fullName, phone, direction, modality, reason);

            MessageBox.Show($"{collaborator.Email}, {collaborator.FullName}, {collaborator.Phone}, {collaborator.Direction}, {collaborator.Modality}, {collaborator.Reason}");

            switch (UserDAL.AddCollaborator(collaborator, currentUser))
            {
                case CollaboratorAddError.Error:
                    MessageBox.Show("Complete los campos correctamente");
                    break;
                case CollaboratorAddError.NoError:
                    MessageBox.Show("Te has registrado como colaborador. En breve, te llegará la confirmación del administrador.");
                    break;
                case CollaboratorAddError.NotSameEmail:
                    MessageBox.Show("El correo electrónico no son iguales al del usuario registrado");
                    break;
                case CollaboratorAddError.NotSamePassword:
                    MessageBox.Show("La contraseña no son iguales al del usuario registrado");
                    break;
                case CollaboratorAddError.BothAreNotSame:
                    MessageBox.Show("El correo electrónico y la contraseña no son iguales al del usuario registrado");
                    break;
            }
        }
    }
}
