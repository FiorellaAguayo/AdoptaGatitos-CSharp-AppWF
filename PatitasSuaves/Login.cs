using EntitiesManager;
using Entities;
using static EntitiesManager.UserManager;

namespace PatitasSuaves
{
    public partial class Login : Form
    {
        private readonly UserManager _userManager;
        public Login()
        {
            InitializeComponent();
            _userManager = new UserManager();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User(txbUser.Text, txbPassword.Text);
                UserLoginError result = await _userManager.CheckCorrectsKeysAsync(user);

                switch (result)
                {
                    case UserLoginError.Error:
                        MessageBox.Show("Complete los campos correctamente");
                        break;
                    case UserLoginError.UserNameDoesNotExists:
                        MessageBox.Show("No existe usuario con ese nombre");
                        break;
                    case UserLoginError.PasswordDoesNotExists:
                        MessageBox.Show("La contraseña es incorrecta");
                        break;
                    case UserLoginError.NoError:
                        MessageBox.Show("Bienvenido/a a Patitas Suaves");
                        OpenTheApp(user);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante el inicio de sesión: " + ex.Message);
            }
        }

        private void llSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();

            signUp.Location = this.Location;
            signUp.Show();
        }

        private void SeePassword_Click(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !txbPassword.UseSystemPasswordChar;
        }

        private void txbUser_Enter(object sender, EventArgs e)
        {
            if (txbUser.Text == "USUARIO")
            {
                txbUser.Text = string.Empty;
                txbUser.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void txbUser_Leave(object sender, EventArgs e)
        {
            if (txbUser.Text == string.Empty)
            {
                txbUser.Text = "USUARIO";
                txbUser.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void txbPassword_Enter(object sender, EventArgs e)
        {
            if (txbPassword.Text == "CONTRASEÑA")
            {
                txbPassword.Text = string.Empty;
                txbPassword.ForeColor = SystemColors.WindowFrame;
                txbPassword.UseSystemPasswordChar = true;
            }
        }

        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == string.Empty)
            {
                txbPassword.Text = "CONTRASEÑA";
                txbPassword.ForeColor = SystemColors.WindowFrame;
                txbPassword.UseSystemPasswordChar = false;
            }
        }

        private void OpenTheApp(User user)
        {
            try
            {
                Principal formPrincipal = new Principal(user);
                formPrincipal.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error al iniciar la aplicación.");
            }
        }


    }
}