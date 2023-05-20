using ClassLibrary1;
using static ClassLibrary1.UserDAL;

namespace PrimerParcial
{
    public partial class SignUp : Form
    {
        private Color originalColor;

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void pb_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_Email_Enter(object sender, EventArgs e)
        {
            if (txb_Email.Text == "EMAIL")
            {
                txb_Email.Text = "";
                txb_Email.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void txb_Email_Leave(object sender, EventArgs e)
        {
            if (txb_Email.Text == "")
            {
                txb_Email.Text = "EMAIL";
                txb_Email.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void txb_Usser_Enter(object sender, EventArgs e)
        {
            if (txb_Usser.Text == "USUARIO")
            {
                txb_Usser.Text = "";
                txb_Usser.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void txb_Usser_Leave(object sender, EventArgs e)
        {
            if (txb_Usser.Text == "")
            {
                txb_Usser.Text = "USUARIO";
                txb_Usser.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void txb_Password_Enter(object sender, EventArgs e)
        {
            if (txb_Password.Text == "CONTRASEÑA")
            {
                txb_Password.Text = "";
                txb_Password.ForeColor = SystemColors.WindowFrame;
                txb_Password.UseSystemPasswordChar = true;
            }
        }

        private void txb_Password_Leave(object sender, EventArgs e)
        {
            if (txb_Password.Text == "")
            {
                txb_Password.Text = "CONTRASEÑA";
                txb_Password.ForeColor = SystemColors.WindowFrame;
                txb_Password.UseSystemPasswordChar = false;
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string email = txb_Email.Text;
            string username = txb_Usser.Text;
            string password = txb_Password.Text;

            switch (UserDAL.AddUser(UserDAL.CreateUser(email, username, password))) //devuelve tipo enum (userAddError)
            {
                case UserAddError.Error:
                    MessageBox.Show("Complete los campos correctamente");
                    break;
                case UserAddError.NoError:
                    MessageBox.Show("Usuario registrado con éxito");
                    break;
                case UserAddError.EmailExists:
                    MessageBox.Show("El correo electrónico ya está registrado");
                    break;
                case UserAddError.UserNameExists:
                    MessageBox.Show("El nombre de usuario ya está en uso");
                    break;
                case UserAddError.BothExist:
                    MessageBox.Show("El correo electrónico y el nombre de usuario ya están registrados");
                    break;
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
