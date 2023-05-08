namespace PrimerParcial
{
    public partial class Profiles : Form
    {
        private const int FORM_HEIGHT = 1000;
        private const int VISIBLE_HEIGHT = 500;
        public Profiles()
        {
            InitializeComponent();
        }

        private void Profiles_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
