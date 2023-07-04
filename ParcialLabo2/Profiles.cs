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
    public partial class Profiles : Form
    {
        private User user;

        public Profiles(User currentUser)
        {
            InitializeComponent();
            user = currentUser;
        }

        private void Profiles_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}