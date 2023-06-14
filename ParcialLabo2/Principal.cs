using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassLibrary;

namespace ParcialLabo2
{
    public partial class Principal : Form
    {
        //fields
        private Button currentButton;
        private Random random;
        private int temporalIndex;
        private static User currentUser;
        private FirestoreABM _firestoreABM;
        private FirestoreConnection _connection;

        public Principal(User user, FirestoreConnection connection, FirestoreABM firestoreAbm)
        {
            InitializeComponent();
            random = new Random();
            currentUser = user;
            _firestoreABM = firestoreAbm;
            _connection = connection;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            MainScreen formMainScreen = new MainScreen();
            formMainScreen.MdiParent = this;
            formMainScreen.Show();
        }

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
                    panButtonSelected.BackColor = color;
                    panLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousButton in panButtons.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.IndianRed;
                    previousButton.ForeColor = Color.White;
                    previousButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void btnProfiles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Perfiles";
            Profiles formProfiles = new Profiles();
            formProfiles.MdiParent = this;
            formProfiles.Show();
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Donar";
            Donation formDonation = new Donation();
            formDonation.MdiParent = this;
            formDonation.Show();
        }

        private void btnBePart_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "¿Querés ser parte?";
            BePart formBePart = new BePart();
            formBePart.MdiParent = this;
            formBePart.Show();
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Contacto";
            Contact formContact = new Contact();
            formContact.MdiParent = this;
            formContact.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Cuenta";
            Account formAccount = new Account(currentUser);
            formAccount.MdiParent = this;
            formAccount.Show();
        }

        private void Principal_StyleChanged(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.WindowState != this.WindowState)
                {
                    childForm.WindowState = this.WindowState;
                }
            }
        }

        private void Principal_Resize(object sender, EventArgs e)
        {
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.WindowState != this.WindowState)
                {
                    childForm.WindowState = this.WindowState;
                }
            }
        }
    }
}