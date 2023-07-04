using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassLibrary;

using static ClassLibrary.UserManager;

namespace ParcialLabo2
{
    public partial class Login : Form
    {
        private FirestoreConnection _connection = new FirestoreConnection();
        private FirestoreABM _firestoreabm;

        public Login()
        {
            InitializeComponent();
            _firestoreabm = new FirestoreABM(_connection);
        }

        private async void Login_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
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

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUser.Text;
            string password = txbPassword.Text;
            User user = new User(username, password);

            switch (await UserManager.ValidateExistingUser(user, _connection))
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
                    MessageBox.Show("Bienvenido");
                    Principal principal = new Principal(user, _connection, _firestoreabm);
                    this.Hide();
                    principal.Show();
                    break;
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
    }
}