using PrimerParcialFiorella;

namespace PrimerParcial
{
    public partial class Donation : Form
    {
        public Donation()
        {
            InitializeComponent();
        }

        private void Donation_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btn_TransferForm_Click(object sender, EventArgs e)
        {
            DonationCompleteData donationCompleteData = new DonationCompleteData();
            donationCompleteData.MdiParent = this.MdiParent;
            donationCompleteData.Show();
        }
    }
}