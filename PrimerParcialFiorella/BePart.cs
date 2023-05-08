namespace PrimerParcial
{
    public partial class BePart : Form
    {
        public BePart()
        {
            InitializeComponent();
        }

        private void BePart_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void btn_BePart_Click(object sender, EventArgs e)
        {
            string name = txb_FullName.Text;
            string direction = txb_Direction.Text;
            string email = txb_Email.Text;
            string phone = txb_Phone.Text;
            string modality = string.Empty;
            string reason = txb_Reason.Text;

            if (rb_FaceToFace.Checked)
            {
                modality = "Presencial";
            }
            else if (rb_Virtual.Checked)
            {
                modality = "Virtual";
            }
            //MessageBox.Show($"{name}, {direction}, {email}, {phone}, {modality}, {reason}");

            
        }

        private void txb_Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
