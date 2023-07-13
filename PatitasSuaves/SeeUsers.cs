using EntitiesManager;
using Entities;
using Validations;
using System.Data;
using static EntitiesManager.UserManager;
using LogData;

namespace PatitasSuaves
{
    public partial class SeeUsers : Form
    {
        private UserManager _userManager;
        List<User> users;
        private IExporter<User> _exporter;

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
            table.Columns.Add("Ultima donación");
            table.Columns.Add("Teléfono");

            foreach (User user in users)
            {
                table.Rows.Add(user.Id, user.Role, user.UserName, user.Email, user.Password, user.LastDonation, user.Phone);
            }

            DataView dataView = table.DefaultView;
            dataView.Sort = "Usuario ASC";
            dgvUsers.DataSource = table;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            User user = new User(txbId.Text, txbUser.Text, txbRole.Text, txbEmail.Text, txbDonation.Text, txbPassword.Text, txbPhone.Text);
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
            User user = new User(txbId.Text, txbUser.Text, txbRole.Text, txbEmail.Text, txbDonation.Text, txbPassword.Text, txbPhone.Text);

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
            User user = new User(txbId.Text, txbUser.Text, txbRole.Text, txbEmail.Text, txbDonation.Text, txbPassword.Text, txbPassword.Text);
            DialogResult result = MessageBox.Show("¿Estás seguro de eliminar este usuario?", "Eliminar usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvUsers.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvUsers.SelectedRows[0];
                    string username = selectedRow.Cells["Usuario"].Value.ToString();
                    await _userManager.DeleteUser(username);

                    dgvUsers.Rows.Remove(selectedRow);
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
                DataGridViewRow selectedRow = dgvUsers.Rows[e.RowIndex];
                txbId.Text = selectedRow.Cells["Id"].Value.ToString();
                txbRole.Text = selectedRow.Cells["Rol"].Value.ToString();
                txbUser.Text = selectedRow.Cells["Usuario"].Value.ToString();
                txbEmail.Text = selectedRow.Cells["Email"].Value.ToString();
                txbPassword.Text = selectedRow.Cells["Contraseña"].Value.ToString();
                txbDonation.Text = selectedRow.Cells["Ultima donación"].Value.ToString();
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
            if (dgvUsers.SelectedRows.Count > 0)
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

        private async void btnJSON_Click(object sender, EventArgs e)
        {
            var users = await _userManager.GetUsers();

            try
            {
                _exporter = new JsonExporter<User>();
                await _exporter.ExportData(users, "ListUsers.json");
                Log.WriteLog($"Se exportó una lista de usuarios a json.");
                MessageBox.Show("Se exportó una lista de usuarios a json.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante la exportación a json: " + ex.Message);
            }
        }

        private async void btnCSV_Click(object sender, EventArgs e)
        {
            var users = await _userManager.GetUsers();

            try
            {
                _exporter = new CsvExporter<User>();
                await _exporter.ExportData(users, "ListUsers.csv");
                Log.WriteLog($"Se exportó una lista de usuarios a csv.");
                MessageBox.Show("Se exportó una lista de usuarios a csv.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante la exportación a csv: " + ex.Message);
            }
        }

        private async void btnPDF_Click(object sender, EventArgs e)
        {
            var users = await _userManager.GetUsers();

            try
            {
                _exporter = new PdfExporter<User>();
                await _exporter.ExportData(users, "ListUsers.pdf");
                Log.WriteLog($"Se exportó una lista de usuarios a pdf.");
                MessageBox.Show("Se exportó una lista de usuarios a pdf.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante la exportación a pdf: " + ex.Message);
            }
        }
    }
}