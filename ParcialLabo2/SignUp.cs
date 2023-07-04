using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassLibrary;

using Google.Cloud.Firestore;

using static ClassLibrary.UserManager;

namespace ParcialLabo2
{
    public partial class SignUp : Form
    {
        private FirestoreConnection _connection = new FirestoreConnection();
        private FirestoreABM _firestoreabm;

        public SignUp()
        {
            InitializeComponent();
            _firestoreabm = new FirestoreABM(_connection);
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

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            string email = txbEmail.Text;
            string username = txbUser.Text;
            string password = txbPassword.Text;

            User user = new User(email, username, password);

            switch (await UserManager.AddUserAsync(user, _connection, _firestoreabm))
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

        private void SeePassword_Click(object sender, EventArgs e)
        {
            txbPassword.UseSystemPasswordChar = !txbPassword.UseSystemPasswordChar;
        }
    }
}