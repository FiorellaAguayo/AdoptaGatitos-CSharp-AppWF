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

        /// <summary>
        /// Carga la ventana de donaciones y los datos de los usuarios.
        /// </summary>
        private async void Donate_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            users = await _manager.GetUsers();
            Activated += Donate_Activated;
            LoadData(users);
        }

        /// <summary>
        /// Carga los datos de los usuarios en un DataTable y muestra la información en un control DataGridView.
        /// </summary>
        /// <param name="users"></param>
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

        /// <summary>
        /// Valida los datos ingresados, actualiza los datos del usuario y muestra un mensaje de confirmación.
        /// </summary>
        private async void btnDonate_Click(object sender, EventArgs e)
        {
            string paymentMethod = GetSelectedPaymentMethod();
            string email = txbEmail.Text;
            string userName = txbUser.Text;
            string lastDonation = numAmount.Value.ToString();
            string message = txbMessage.Text;

            if (!DonateValidation.ValidateDonation(_actualUser, email, userName, lastDonation))
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
                existingUser.PaymentMethod = paymentMethod;
                existingUser.LastDonation = lastDonation;
                existingUser.Message = message;

                await _manager.UpdateUser(existingUser, existingUser.UserName);
                LoadData(users);

                MessageBox.Show("Hemos recibido su donación. Gracias por colaborar!!!", "Donación recibida");
                Log.WriteLog($"El usuario {existingUser.UserName} ha donado.");
            }
        }

        private string GetSelectedPaymentMethod()
        {
            if (rbMastercard.Checked)
            {
                return rbMastercard.Text;
            }
            else if(rbMp.Checked)
            {
                return rbMp.Text;
            }
            else if(rbPayPal.Checked)
            {
                return rbPayPal.Text;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// Carga nuevamente los datos de los usuarios y muestra un mensaje si no hay registros.        
        /// /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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