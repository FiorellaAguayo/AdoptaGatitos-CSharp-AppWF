namespace PrimerParcial
{
    public partial class Access : Form
    {
        public Access()
        {
            InitializeComponent();
        }

        private void Access_Load(object sender, EventArgs e)
        {
            Login accessChoice = new Login();

            accessChoice.MdiParent = this;
            accessChoice.Show();
        }
    }
}