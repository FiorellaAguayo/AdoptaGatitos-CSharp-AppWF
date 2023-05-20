using ClassLibrary1;
using PrimerParcialFiorella;

namespace PrimerParcial
{
    public partial class Principal : Form
    {
        private static User currentUser;

        //fields
        private Button currentButton;
        private Random random;
        private int temporalIndex;
        //private Form ActiveForm;

        //constructor
        public Principal(User user)
        {
            InitializeComponent();
            random = new Random();
            currentUser = user;
        }

        //methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (temporalIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            temporalIndex = index;
            string color = ThemeColor.ColorList[temporalIndex];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object buttonSender)
        {
            if (buttonSender != null)
            {
                if (currentButton != (Button)buttonSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)buttonSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
                    pan_ButtonSelected.BackColor = color;
                    pan_Logo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousButton in pan_Buttons.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.IndianRed;
                    previousButton.ForeColor = Color.White;
                    previousButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void btn_Adopt_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Adoption formAdoption = new Adoption();
            formAdoption.MdiParent = this;
            formAdoption.Show();
        }

        private void btn_Profiles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Profiles formProfiles = new Profiles();
            formProfiles.MdiParent = this;
            formProfiles.Show();
        }

        private void btn_Donate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Donation formDonation = new Donation();
            formDonation.MdiParent = this;
            formDonation.Show();
        }

        private void btn_BePart_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            BePart formBePart = new BePart(currentUser);
            formBePart.MdiParent = this;
            formBePart.Show();
        }

        private void btn_Contact_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Contact formContact = new Contact();
            formContact.MdiParent = this;
            formContact.Show();
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            Account formAccount = new Account(currentUser);
            formAccount.MdiParent = this;
            formAccount.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            MainScreen formMainScreen = new MainScreen();
            formMainScreen.MdiParent = this;
            formMainScreen.Show();
        }

        private void Reset()
        {
            DisableButton();
            lbl_Title.Text = "Inicio";
            pan_ButtonSelected.BackColor = Color.DarkGray;
            pan_Logo.BackColor = Color.Salmon;
            currentButton = null;
        }
    }
}