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
        private FirestoreConnection _connection;
        private FirestoreABM _firestoreABM;

        public Principal(User user, FirestoreConnection connection, FirestoreABM firestoreABM)
        {
            InitializeComponent();
            random = new Random();
            currentUser = user;
            _connection = connection;
            _firestoreABM = firestoreABM;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            MainScreen formMainScreen = new MainScreen();
            formMainScreen.MdiParent = this;
            formMainScreen.Show();

            if (currentUser.Role == "Administrador")
            {
                btnSeeUsers.Visible = true;
            }
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
            Profiles formProfiles = new Profiles(currentUser);
            formProfiles.MdiParent = this;
            formProfiles.Show();
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Donar";
            Donation formDonation = new Donation(currentUser, _connection, _firestoreABM);
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
            Account formAccount = new Account(currentUser, _connection, _firestoreABM);
            formAccount.MdiParent = this;
            formAccount.Show();
        }

        private void btnSeeUsers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Ver usuarios";
            SeeUsers formSeeUsers = new SeeUsers(_connection);
            formSeeUsers.MdiParent = this;
            formSeeUsers.Show();
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