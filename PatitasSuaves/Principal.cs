using EntitiesManager;
using Entities;
using Graphics;
using Microsoft.VisualBasic.ApplicationServices;
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

        public Principal(User user)
        {
            InitializeComponent();
            _userManager = new UserManager();
            _random = new Random();
            _currentUser = user;
        }


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
            //OpenForm<Profiles>("Ver perfiles");

            lblTitle.Text = "Ver perfiles";
            Profiles form = new Profiles();
            form.MdiParent = this;
            form.Show();
            Log.WriteLog($"El usuario {_currentUser.UserName} está mirando perfiles.");
        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenForm<Donate>("Donaciones");
            lblTitle.Text = "Ver usuarios";

            Donate form = new Donate(_currentUser);
            form.MdiParent = this;
            form.Show();
            Log.WriteLog($"El usuario {_currentUser.UserName} está mirando donaciones.");
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenForm<Contact>("Contacto");
            lblTitle.Text = "Contacto";

            Contact form = new Contact(_currentUser);
            form.MdiParent = this;
            form.Show();
            Log.WriteLog($"El usuario {_currentUser.UserName} está mirando contacto.");
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            // OpenForm<Account>("Cuenta");
            lblTitle.Text = "Cuenta";

            Account form = new Account(_currentUser);
            form.MdiParent = this;
            form.Show();
            Log.WriteLog($"El usuario {_currentUser.UserName} está mirando cuenta.");
        }

        private void btnSeeUsers_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            //OpenForm<SeeUsers>("Ver usuarios");

            lblTitle.Text = "Ver usuarios";

            SeeUsers form = new SeeUsers();
            form.MdiParent = this;
            form.Show();
            Log.WriteLog($"El usuario {_currentUser.UserName} está mirando administracion de usuarios.");
        }

        private void btnSeePets_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            // OpenForm<SeePets>("Ver mascotas");

            lblTitle.Text = "Ver gatos";

            SeePets form = new SeePets();
            form.MdiParent = this;
            form.Show();
            Log.WriteLog($"El usuario {_currentUser.UserName} está mirando administracion de gatos.");
            // OpenChildForm<SeePets>("Ver gatos", typeof(SeePets));
        }

        private void OpenForm<T>(string title) where T : Form, new()
        {
            lblTitle.Text = title;

            T form = new T();
            form.MdiParent = this;
            form.Show();
        }

        //private void OpenChildForm<T>(string title, Type formType) where T : Form, new()
        //{
        //    lblTitle.Text = title;

        //    Form existingForm = MdiChildren.FirstOrDefault(f => f.GetType() == formType);
        //    if (existingForm == null)
        //    {
        //        T form = new T();
        //        form.MdiParent = this;
        //        form.Show();
        //    }
        //    else
        //    {
        //        existingForm.BringToFront();
        //    }
        //}

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