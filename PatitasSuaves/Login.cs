using EntitiesManager;
using Entities;
using static EntitiesManager.UserManager;
using LogData;

namespace PatitasSuaves
{
    public partial class Login : Form
    {
        private readonly UserManager _userManager;

        public delegate void LoginSuccessDelegate(string username);
        public event LoginSuccessDelegate LoginSuccess;

        public Login()
        {
            InitializeComponent();
            _userManager = new UserManager();
            LoginSuccess += LoginSuccessHandler;
        }

        /// <summary>
        /// Inicia sesión si las claves ingresadas son correctas y muestra un mensaje en cada caso.
        /// </summary>
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
                        LoginSuccess?.Invoke(user.UserName);
                        Log.WriteLog($"El usuario {user.UserName} ha iniciado sesión");
                        OpenTheApp(user);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante el inicio de sesión: " + ex.Message);
                Log.WriteLog($"Hubo un error al intentar iniciar sesión.");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        private void LoginSuccessHandler(string username)
        {
            MessageBox.Show("¡Bienvenido/a a Patitas Suaves, " + username + "!");
        }

        /// <summary>
        /// LLeva al usuario al form principal de la App.
        /// </summary>
        /// <param name="user"></param> Objeto usuario validado.
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

        /// <summary>
        /// LLeva al usuario al form de Registro.
        /// </summary>
        private void llSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();

            signUp.Location = this.Location;
            signUp.Show();
        }

        /// <summary>
        /// Cambia la visibilidad de la contraseña de oculta a visible y visceversa.
        /// </summary>
        private void SeePassword_Click(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !txbPassword.UseSystemPasswordChar;
        }

        /// <summary>
        /// Deja el espacio libre para escribir.
        /// </summary>
        private void txbUser_Enter(object sender, EventArgs e)
        {
            if (txbUser.Text == "USUARIO")
            {
                txbUser.Text = string.Empty;
                txbUser.ForeColor = SystemColors.WindowFrame;
            }
        }

        /// <summary>
        /// Si no hay nada escrito, muestra "USUARIO".
        /// </summary>
        private void txbUser_Leave(object sender, EventArgs e)
        {
            if (txbUser.Text == string.Empty)
            {
                txbUser.Text = "USUARIO";
                txbUser.ForeColor = SystemColors.WindowFrame;
            }
        }

        /// <summary>
        /// Deja el espacio libre para escribir.
        /// </summary>
        private void txbPassword_Enter(object sender, EventArgs e)
        {
            if (txbPassword.Text == "CONTRASEÑA")
            {
                txbPassword.Text = string.Empty;
                txbPassword.ForeColor = SystemColors.WindowFrame;
                txbPassword.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// Si no hay nada escrito, muestra "CONTRASEÑA".
        /// </summary>
        private void txbPassword_Leave(object sender, EventArgs e)
        {
            if (txbPassword.Text == string.Empty)
            {
                txbPassword.Text = "CONTRASEÑA";
                txbPassword.ForeColor = SystemColors.WindowFrame;
                txbPassword.UseSystemPasswordChar = false;
            }
        }
    }
}