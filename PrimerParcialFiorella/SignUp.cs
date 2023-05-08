using ClassLibrary1;

namespace PrimerParcial
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void pb_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txb_Email_Enter(object sender, EventArgs e)
        {
            if (txb_Email.Text == "EMAIL")
            {
                txb_Email.Text = string.Empty;
                txb_Email.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void txb_Email_Leave(object sender, EventArgs e)
        {
            if (txb_Email.Text == string.Empty)
            {
                txb_Email.Text = "EMAIL";
                txb_Email.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void txb_Usser_Enter(object sender, EventArgs e)
        {
            if (txb_Usser.Text == "USUARIO")
            {
                txb_Usser.Text = string.Empty;
                txb_Usser.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void txb_Usser_Leave(object sender, EventArgs e)
        {
            if (txb_Usser.Text == string.Empty)
            {
                txb_Usser.Text = "USUARIO";
                txb_Usser.ForeColor = SystemColors.WindowFrame;
            }
        }

        private void txb_Password_Enter(object sender, EventArgs e)
        {
            if (txb_Password.Text == "CONTRASEÑA")
            {
                txb_Password.Text = string.Empty;
                txb_Password.ForeColor = SystemColors.WindowFrame;
                txb_Password.UseSystemPasswordChar = true;
            }
        }

        private void txb_Password_Leave(object sender, EventArgs e)
        {
            if (txb_Password.Text == string.Empty)
            {
                txb_Password.Text = "CONTRASEÑA";
                txb_Password.ForeColor = SystemColors.WindowFrame;
                txb_Password.UseSystemPasswordChar = false;
            }
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            User user = UserDAL.CreateUser(txb_Email.Text, txb_Usser.Text, txb_Password.Text);

            if(UserDAL.AddUser(user))
            {
                MessageBox.Show("Usuario registrado con exito");
            }
            else
            {
                MessageBox.Show("No se pudo registrar el usuario");
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}