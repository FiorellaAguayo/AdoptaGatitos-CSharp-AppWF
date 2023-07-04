using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassLibrary;

using Google.Cloud.Firestore;

namespace ParcialLabo2
{
    public partial class SeeUsers : Form
    {
        private FirestoreConnection _connection;

        public SeeUsers(FirestoreConnection connection)
        {
            InitializeComponent();
            _connection = connection;
        }

        private async void SeeUsers_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;

            // Realiza la consulta a Firestore para obtener los usuarios
            CollectionReference usersRef = _connection.Database.Collection("users");
            QuerySnapshot snapshot = await usersRef.GetSnapshotAsync();

            // Crea una tabla para almacenar los datos de los usuarios
            DataTable table = new DataTable();
            table.Columns.Add("Id");
            table.Columns.Add("Rol");
            table.Columns.Add("Nombre");
            table.Columns.Add("Email");
            table.Columns.Add("Contraseña");

            // Recorre los documentos en el snapshot y agrega los datos a la tabla
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                if (document.Exists)
                {
                    Dictionary<string, object> userData = document.ToDictionary();
                    string id = userData.ContainsKey("id") ? userData["id"].ToString() : "";
                    string role = userData.ContainsKey("role") ? userData["role"].ToString() : "";
                    string username = userData.ContainsKey("username") ? userData["username"].ToString() : "";
                    string email = userData.ContainsKey("email") ? userData["email"].ToString() : "";
                    string password = userData.ContainsKey("password") ? userData["password"].ToString() : "";

                    table.Rows.Add(id, role, username, email, password);
                }
            }

            // Ordena la tabla por el campo "Nombre" en orden ascendente
            DataView dataView = table.DefaultView;
            dataView.Sort = "Nombre ASC";

            // Asigna la tabla como origen de datos del DataGridView
            dgvUsers.DataSource = table;
        }
    }
}