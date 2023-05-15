using ClassLibrary1;
using PrimerParcial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialFiorella
{
    public partial class Account : Form
    {
        private static User currentUser;

        public Account(User user)
        {
            InitializeComponent();
            currentUser = user;

            lblId.Text = currentUser.Id.ToString();
            lblRole.Text = currentUser.Role;
            lblEmail.Text = currentUser.Email;
            lblUserName.Text = currentUser.UserName;
            lblPassword.Text = currentUser.Password;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.MdiParent.Close();

            Login formLogin = new Login();
            formLogin.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}