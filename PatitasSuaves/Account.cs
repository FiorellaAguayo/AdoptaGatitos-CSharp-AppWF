using EntitiesManager;
using Entities;
using LogData;

namespace PatitasSuaves
{
    public partial class Account : Form
    {
        private UserManager userManager;
        private User user;

        public Account(User actualUser)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            userManager = new UserManager();
            user = actualUser;
        }

        private async void Account_Load(object sender, EventArgs e)
        {
            string username = user.UserName;

            var userLogged = await userManager.GetUser(username);

            lblUser.Text = userLogged.UserName;
            lblEmail.Text = userLogged.Email;
            lblPassword.Text = userLogged.Password;
            lblRole.Text = userLogged.Role;
            lblTotalDonations.Text = userLogged.LastDonation;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.MdiParent.Close();
            Login login = new Login();
            login.Show();
            MessageBox.Show("Cerraste sesión.");
            Log.WriteLog($"El usuario {user.UserName} cerró sesión.");
        }

        private async void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar tu cuenta?", "Eliminar cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                await userManager.DeleteUser(user.UserName);
                MessageBox.Show("El usuario se ha eliminado correctamente.");
                Log.WriteLog($"El usuario {user.UserName} ha eliminado su cuenta.");
                this.MdiParent.Close();
                Login login = new Login();
                login.Show();
            }
        }
    }
}