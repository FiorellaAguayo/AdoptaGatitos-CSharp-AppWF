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

using Google.Cloud.Firestore;

using static ClassLibrary.UserManager;

namespace ParcialLabo2
{
    public partial class Donation : Form
    {
        private User _currentUser;
        private FirestoreConnection _connection;
        private FirestoreABM _firestoreabm;

        public Donation(User currentUser, FirestoreConnection connection, FirestoreABM firestoreABM)
        {
            InitializeComponent();
            _currentUser = currentUser;
            _connection = connection;
            _firestoreabm = firestoreABM;
        }

        private void Donation_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private async void btnDonate_Click(object sender, EventArgs e)
        {
            string fullname = txbFullName.Text;
            string direction = txbDirection.Text;
            string email = txbEmail.Text;
            string phone = txbPhone.Text;
            string message = txbMessage.Text;
            string paymentMethod;
            string cardNumber = txbCardNumber.Text;
            double amount = (double)numAmount.Value;

            if (chkBancoPatagonia.Checked)
            {
                paymentMethod = "Tarjeta";
            }
            else if (chkMercadoPago.Checked)
            {
                paymentMethod = "Mercado Pago";
            }
            else
            {
                paymentMethod = string.Empty;
            }

            User user = new User(fullname, direction, email, phone, message, paymentMethod, cardNumber, amount);

            switch (await UserManager.Donate(user, _currentUser, _connection, _firestoreabm))
            {
                case UserDonateError.Error:
                    MessageBox.Show("Complete los campos correctamente.");
                    break;
                case UserDonateError.EmailIsNotTheSame:
                    MessageBox.Show("El email ingresado no coincide con el original.");
                    break;
                case UserDonateError.NoError:
                    MessageBox.Show("Hemos recibido tu donación. Gracias por la colaboración!");
                    break;
            }
        }

        private void btn_Autocomplete_Click(object sender, EventArgs e)
        {
            txbFullName.Text = "pepito";
            txbDirection.Text = "yatay 1075";
            txbEmail.Text = _currentUser.Email;
            txbPhone.Text = "42320550";
            chkBancoPatagonia.Checked = true;
            txbCardNumber.Text = "5434366";
            numAmount.Value = 500;
            txbMessage.Text = "holisss";
        }
    }
}