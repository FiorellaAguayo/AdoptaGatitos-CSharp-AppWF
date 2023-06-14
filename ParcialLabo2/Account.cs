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
        private static User user;

        public Account(User currentUser)
        {
            InitializeComponent();
            user = currentUser;

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
            FirestoreABM.
        }
    }
}
