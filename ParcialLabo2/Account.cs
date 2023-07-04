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

namespace ParcialLabo2
{
    public partial class Account : Form
    {
        private User user;
        private FirestoreConnection _connection;
        private FirestoreABM _firestoreabm;

        public Account(User currentUser, FirestoreConnection connection, FirestoreABM firestoreABM)
        {
            InitializeComponent();
            user = currentUser;
            _connection = connection;
            _firestoreabm = firestoreABM;

            lblId.Text = currentUser.Id.ToString();
            lblUserName.Text = currentUser.UserName;
            lblPassword.Text = currentUser.Password;
            lblRole.Text = currentUser.Role;
            lblEmail.Text = currentUser.Email;
        }

        private void Account_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.MdiParent.Hide();
            MessageBox.Show("Se ha cerrado sesión correctamente");
            login.Show();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tu cuenta se borrará de forma permanente. ¿Desea continuar?", "Eliminar cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                await UserManager.DeleteUserAsync(user, _connection, _firestoreabm);
                MessageBox.Show("La cuenta se ha borrado.");
                this.MdiParent.Hide();
                Login login = new Login();
                login.Show();
            }
        }
    }
}