using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatitasSuaves
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        /// <summary>
        /// Carga el form y muestra una imagen.
        /// </summary>
        private void MainPage_Load(object sender, EventArgs e)
        {
            pictureBox1.Load("https://ohmaigat.com.co/sites/default/files/inline-images/banner-tiposdegatos.jpg");
        }
    }
}
