using EntitiesManager;
using Entities;
using Validations;
using System.Data;
using static EntitiesManager.UserManager;

namespace PatitasSuaves
{
    public partial class SeeUsers : Form
    {
        private UserManager _userManager;
        List<User> users;

        public SeeUsers()
        {
            InitializeComponent();
            _userManager = new UserManager();
        }

        private async void SeeUsers_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            users = await _userManager.GetUsers();
            this.Activated += SeeUsers_Activated;
            LoadData(users);
        }

        private void LoadData(List<User> users)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Rol");
            table.Columns.Add("Usuario");
            table.Columns.Add("Email");
            table.Columns.Add("Contraseña");
            table.Columns.Add("Donaciones");
            table.Columns.Add("Teléfono");

            foreach (User user in users)
            {
                table.Rows.Add(user.Id, user.Role, user.UserName, user.Email, user.Password, user.Amount, user.Phone);
            }

            DataView dataView = table.DefaultView;
            dataView.Sort = "Usuario ASC";
            dgvPets.DataSource = table;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User(txbId.Text, txb.Text, txbRole.Text, txbEmail.Text, double.Parse(txbDonation.Text), txbPassword.Text, txbPassword.Text);
            UserAddError result = await _userManager.CreateNewUser(user);

            switch (result)
            {
                case UserAddError.Error:
                    MessageBox.Show("Completa los campos obligatorios: id, role, nombre, email, contraseña.");
                    break;
                case UserAddError.AllExists:
                    MessageBox.Show("Ya existen esos valores.");
                    break;
                case UserAddError.EmailExists:
                    MessageBox.Show("El email ya existe.");
                    break;
                case UserAddError.IdExists:
                    MessageBox.Show("El id ya existe.");
                    break;
                case UserAddError.UserNameExists:
                    MessageBox.Show("El nombre ya existe.");
                    break;
                case UserAddError.NoError:
                    MessageBox.Show("Usuario agregado exitosamente.");
                    List<User> users = await _userManager.GetUsers();
                    LoadData(users);
                    break;
            }
        }

        private async void btnModify_Click(object sender, EventArgs e)
        {
            User user = new User(txbId.Text, txb.Text, txbRole.Text, txbEmail.Text, double.Parse(txbDonation.Text), txbPassword.Text, txbPhone.Text);

            if (!UserValidation.ValidateRequiredFields(user))
            {
                MessageBox.Show("Completa los campos obligatorios: id, role, nombre, email, contraseña.");
                return;
            }

            UserUpdateError result = await _userManager.UpdateNewUser(user);

            switch (result)
            {
                case UserUpdateError.Error:
                    MessageBox.Show("El usuario no existe.");
                    break;
                case UserUpdateError.NoChanges:
                    MessageBox.Show("No se realizaron cambios.");
                    break;
                case UserUpdateError.NoError:
                    MessageBox.Show("El usuario se modificó correctamente.");
                    LoadData(await _userManager.GetUsers());
                    break;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            User user = new User(txbId.Text, txb.Text, txbRole.Text, txbEmail.Text, double.Parse(txbDonation.Text), txbPassword.Text, txbPassword.Text);
            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este usuario?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvPets.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvPets.SelectedRows[0];
                    string username = selectedRow.Cells["Usuario"].Value.ToString();
                    await _userManager.DeleteUser(username);

                    dgvPets.Rows.Remove(selectedRow);
                    btnDelete.Enabled = false;

                    MessageBox.Show("El usuario se ha eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("Selecciona una fila para eliminar.");
                }
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvPets.Rows[e.RowIndex];
                txbId.Text = selectedRow.Cells["Id"].Value.ToString();
                txbRole.Text = selectedRow.Cells["Rol"].Value.ToString();
                txb.Text = selectedRow.Cells["Usuario"].Value.ToString();
                txbEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txbPassword.Text = selectedRow.Cells["Contraseña"].Value.ToString();
                txbDonation.Text = selectedRow.Cells["Donaciones"].Value.ToString();
                txbPhone.Text = selectedRow.Cells["Teléfono"].Value.ToString();
            }
        }

        private async void SeeUsers_Activated(object sender, EventArgs e)
        {
            // Recargar los datos en el DataGridView
            var users = await _userManager.GetUsers();
            LoadData(users);
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPets.SelectedRows.Count > 0)
            {
                btnDelete.Enabled = true;
                btnModify.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnModify.Enabled = false;
            }
        }
    }
}