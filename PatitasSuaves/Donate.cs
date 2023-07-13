using System.Data;
using Entities;
using EntitiesManager;

using LogData;

using Validations;

namespace PatitasSuaves
{
    public partial class Donate : Form
    {
        private User _actualUser;
        private UserManager _manager;
        List<User> users;

        public Donate(User actualUser)
        {
            InitializeComponent();
            _actualUser = actualUser;
            _manager = new UserManager();

        }

        private async void Donate_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            users = await _manager.GetUsers();
            Activated += Donate_Activated;
            LoadData(users);
        }

        private void LoadData(List<User> users)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Usuario");
            table.Columns.Add("Donación");
            table.Columns.Add("Mensaje");

            foreach (User user in users)
            {
                table.Rows.InsertAt(table.NewRow(), 0);  // Insertar una nueva fila al inicio de la tabla
                table.Rows[0]["Usuario"] = user.UserName;
               table.Rows[0]["Donación"] = user.LastDonation;
               table.Rows[0]["Mensaje"] = user.Message;
            }

            if (table.Rows.Count == 0)
            {
                DataRow emptyRow = table.NewRow();
                emptyRow["Mensaje"] = "No se ha ingresado mensajes";
                table.Rows.Add(emptyRow);
            }

            dgvDonations.DataSource = table;
        }

        private async void btnDonate_Click(object sender, EventArgs e)
        {
            string paymentMethod = " ";
            if (rbMastercard.Checked)
            {
                paymentMethod = rbMastercard.Text;
            }
            else if (rbMp.Checked)
            {
                paymentMethod = rbMp.Text;
            }
            else
            {
                paymentMethod = rbPayPal.Text;
            }

            string email = txbEmail.Text;
            string userName = txbUser.Text;
            decimal amount = numAmount.Value;
            string message = txbMessage.Text;

            if (!DonateValidation.ValidateDonation(_actualUser, email, userName, amount))
            {
                MessageBox.Show("Verifique los datos ingresados.");
                return;
            }

            User existingUser = await _manager.GetUser(_actualUser.UserName);

            if (existingUser == null)
            {
                MessageBox.Show("No se encontró el usuario en la base de datos.");
                return;
            }
            else
            {
                // Actualizar los datos del usuario
                existingUser.PaymentMethod = paymentMethod;
                existingUser.LastDonation = amount.ToString();
                existingUser.Message = message;

                // Guardar los cambios en Firestore
                await _manager.UpdateUser(existingUser, existingUser.UserName);
                LoadData(users);
                Log.WriteLog($"El usuario {existingUser.UserName} ha donado.");
            }
        }

        private async void Donate_Activated(object sender, EventArgs e)
        {
            var users = await _manager.GetUsers();
            LoadData(users);

            if (dgvDonations.Rows.Count == 0)
            {
                dgvDonations.Rows.Add("No se ha ingresado mensajes");
            }
        }
    }
}