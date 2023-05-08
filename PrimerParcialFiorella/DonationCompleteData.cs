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
    public partial class DonationCompleteData : Form
    {
        public DonationCompleteData()
        {
            InitializeComponent();
        }

        private void DonationCompleteData_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string name = txb_NameComplete.Text;
            string direction = txb_Direction.Text;
            string email = txb_Email.Text;
            string paymentMethod;
            double amount = (double)num_Amount.Value;
            string message = txb_Message.Text;
            string phone = txb_Phone.Text;

            if (chk_Card.Checked)
            {
                paymentMethod = "Tarjeta";
            }
            else if (chk_MercadoPago.Checked)
            {
                paymentMethod = "Mercado Pago";
            }
            else
            {
                paymentMethod = string.Empty;
            }

            //MessageBox.Show($"{name}, {direction}, {email}, {paymentMethod}, {amount}, {message}");

        }
    }
}