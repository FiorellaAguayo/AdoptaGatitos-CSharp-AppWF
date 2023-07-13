using Entities;

using EntitiesManager;

using LogData;

using static EntitiesManager.UserManager;

namespace PatitasSuaves
{
    public partial class SignUp : Form
    {
        private readonly UserManager _userManager;

        public SignUp()
        {
            InitializeComponent();
            _userManager = new UserManager();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                string randomNumber = random.Next(1000, 10000).ToString();

                User user = new User();
                user.Role = "Visitante";
                user.UserName = txbUser.Text;
                user.Email = txbEmail.Text;
                user.Password = txbPassword.Text;
                user.Id = randomNumber;

                UserAddError result = await _userManager.CreateUser(user);

                switch (result)
                {
                    case UserAddError.Error:
                        MessageBox.Show("Complete los campos correctamente.");
                        break;
                    case UserAddError.BothExist:
                        MessageBox.Show("El email y el usuario ya existen.");
                        break;
                    case UserAddError.UserNameExists:
                        MessageBox.Show("El usuario ya existe.");
                        break;
                    case UserAddError.EmailExists:
                        MessageBox.Show("El email ya existe.");
                        break;
                    case UserAddError.NoError:
                        MessageBox.Show("Usuario registrado con éxito.");
                        Log.WriteLog($"El usuario {user.UserName} se ha registrado con éxito.");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante el registro: " + ex.Message);
            }
        }

        private void SeePassword_Click(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !txbPassword.UseSystemPasswordChar;
        }

        private void txbEmail_Enter(object sender, EventArgs e)
        {
            if (txbEmail.Text == "EMAIL")
            {
                txbEmail.Text = string.Empty;
                txbEmail.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void txbEmail_Leave(object sender, EventArgs e)
        {
            if (txbEmail.Text == string.Empty)
            {
                txbEmail.Text = "EMAIL";
                txbEmail.ForeColor = SystemColors.WindowFrame;
            }
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
    }
}