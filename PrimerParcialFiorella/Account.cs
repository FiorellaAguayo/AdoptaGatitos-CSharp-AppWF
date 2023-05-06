using ClassLibrary1;

namespace PrimerParcial
{
    public partial class Account : Form
    {
        private User currentUser;

        public Account()
        {
            InitializeComponent();
        }

        public User CurrentUser { get { return currentUser; } set { currentUser = value; } }

        private void Account_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

        }
    }
}