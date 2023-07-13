using EntitiesManager;
using Entities;
using Graphics;
using LogData;

namespace PatitasSuaves
{
    public partial class Principal : Form
    {
        private UserManager _userManager;
        private User _currentUser;
        private Random _random;
        private int _temporalIndex;
        private Button _currentButton;
        private Profiles formProfiles;
        private Donate formDonate;
        private Contact formContact;
        private Account formAccount;
        private SeeUsers formSeeUsers;
        private SeePets formSeePets;

        public Principal(User user)
        {
            InitializeComponent();
            _userManager = new UserManager();
            _random = new Random();
            _currentUser = user;
        }

        /// <summary>
        /// LLeva al usuario al form principal y si el usuaio es ADMINISTRADOR se muestran unos botones.
        /// </summary>
        private async void Principal_Load(object sender, EventArgs e)
        {
            MainPage formMainPage = new MainPage();
            formMainPage.MdiParent = this;
            formMainPage.Show();

            _currentUser = await _userManager.Get(_currentUser.UserName);

            if (_currentUser.Role == "Administrador")
            {
                btnSeeUsers.Visible = true;
                btnSeePets.Visible = true;
            }
        }

        /// <summary>
        /// LLeva al usuario al form de perfiles y registra la acción.
        /// </summary>
        private void btnProfiles_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Ver perfiles";

            if (formProfiles == null)
            {
                formProfiles = new Profiles();
                formProfiles.MdiParent = this;
                formProfiles.Dock = DockStyle.Fill;
            }
            formProfiles.Show();
            formProfiles.BringToFront();

            Log.WriteLog($"El usuario {_currentUser.UserName} está mirando perfiles.");
        }

        /// <summary>
        /// LLeva al usuario al form de donaciones y registra la acción.
        /// </summary>
        private void btnDonate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Ver usuarios";

            if (formDonate == null)
            {
                formDonate = new Donate(_currentUser);
                formDonate.MdiParent = this;
                formDonate.Dock = DockStyle.Fill;
            }
            formDonate.Show();
            formDonate.BringToFront();

            Log.WriteLog($"El usuario {_currentUser.UserName} está mirando donaciones.");
        }

        /// <summary>
        /// LLeva al usuario al form de contacto y registra la acción.
        /// </summary>
        private void btnContact_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Contacto";

            if (formContact == null)
            {
                formContact = new Contact(_currentUser);
                formContact.MdiParent = this;
                formContact.Dock = DockStyle.Fill;
            }
            formContact.Show();
            formContact.BringToFront();

            Log.WriteLog($"El usuario {_currentUser.UserName} está mirando contacto.");
        }

        /// <summary>
        /// LLeva al usuario al form de cuenta y registra la acción.
        /// </summary>
        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            lblTitle.Text = "Cuenta";

            if (formAccount == null)
            {
                formAccount = new Account(_currentUser);
                formAccount.MdiParent = this;
                formAccount.Dock = DockStyle.Fill;
            }
            formAccount.Show();
            formAccount.BringToFront();

            Log.WriteLog($"El usuario {_currentUser.UserName} está mirando cuenta.");
        }

        /// <summary>
        /// LLeva al usuario al form de ver usuarios y registra la acción.
        /// </summary>
        private void btnSeeUsers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            lblTitle.Text = "Ver usuarios";

            if (formSeeUsers == null)
            {
                formSeeUsers = new SeeUsers();
                formSeeUsers.MdiParent = this;
                formSeeUsers.Dock = DockStyle.Fill;
            }
            formSeeUsers.Show();
            formSeeUsers.BringToFront();

            Log.WriteLog($"El usuario {_currentUser.UserName} está mirando administracion de usuarios.");
        }

        /// <summary>
        /// LLeva al usuario al form de ver gatos y registra la acción.
        /// </summary>
        private void btnSeePets_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            lblTitle.Text = "Ver gatos";

            if (formSeePets == null)
            {
                formSeePets = new SeePets();
                formSeePets.MdiParent = this;
                formSeePets.Dock = DockStyle.Fill;
            }
            formSeePets.Show();
            formSeePets.BringToFront();

            Log.WriteLog($"El usuario {_currentUser.UserName} está mirando administracion de gatos.");
        }

        /// <summary>
        /// Selecciona el tema del color.
        /// </summary>
        /// <returns></returns>
        private Color SelectThemeColor()
        {
            int index = _random.Next(ThemeColor.ColorList.Count);
            while (_temporalIndex == index)
            {
                index = _random.Next(ThemeColor.ColorList.Count);
            }
            _temporalIndex = index;
            string color = ThemeColor.ColorList[_temporalIndex];
            return ColorTranslator.FromHtml(color);
        }

        /// <summary>
        /// Activa el boton de la categoría y cambia su color.
        /// </summary>
        private void ActivateButton(object buttonSender)
        {
            if (buttonSender != null)
            {
                if (_currentButton != (Button)buttonSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    _currentButton = (Button)buttonSender;
                    _currentButton.BackColor = color;
                    _currentButton.ForeColor = Color.White;
                    _currentButton.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
                    panButtonSelected.BackColor = color;
                    panLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        /// <summary>
        /// Guarda el color previo.
        /// </summary>
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