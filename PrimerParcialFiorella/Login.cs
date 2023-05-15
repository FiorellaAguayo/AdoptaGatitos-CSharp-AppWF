using ClassLibrary1;

namespace PrimerParcial
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void txb_Usser_Enter(object sender, EventArgs e)
        {
            if (txb_Usser.Text == "USUARIO")
            {
                txb_Usser.Text = string.Empty;
                txb_Usser.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void txb_Usser_Leave(object sender, EventArgs e)
        {
            if (txb_Usser.Text == string.Empty)
            {
                txb_Usser.Text = "USUARIO";
                txb_Usser.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void txb_Password_Enter(object sender, EventArgs e)
        {
            if (txb_Password.Text == "CONTRASEÑA")
            {
                txb_Password.Text = string.Empty;
                txb_Password.ForeColor = SystemColors.WindowFrame;
                txb_Password.UseSystemPasswordChar = true;
            }
        }

        private void txb_Password_Leave(object sender, EventArgs e)
        {
            if (txb_Password.Text == string.Empty)
            {
                txb_Password.Text = "CONTRASEÑA";
                txb_Password.ForeColor = SystemColors.WindowFrame;
                txb_Password.UseSystemPasswordChar = false;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txb_Usser.Text;
            string password = txb_Password.Text;
            int id;

            if (UserDAL.ValidateExistingLogin(username, password, out id))
            {
                Principal principal = new Principal(UserDAL.GetUserById(id));
                MessageBox.Show("Bienvenido");
                this.Hide();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void ll_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();

            signUp.Location = this.Location;
            signUp.Show();
        }
    }
}