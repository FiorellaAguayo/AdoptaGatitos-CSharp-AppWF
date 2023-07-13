using System.Data;
using Entities;
using EntitiesManager;
using static EntitiesManager.CatManager;

using Validations;
using LogData;

namespace PatitasSuaves
{
    public partial class SeePets : Form
    {
        private CatManager _catManager;
        List<Cat> cats;
        private IExporter<Cat> _exporter;

        public SeePets()
        {
            InitializeComponent();
            _catManager = new CatManager();
        }

        /// <summary>
        /// Carga el formulario de ver mascotas, llena las listas de opciones, obtiene la lista de gatos 
        /// y carga los datos en el DataGridView.
        /// </summary>
        private async void SeePets_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            FillListBoxFurColor();
            FillListBoxRace();
            FillListBoxIsSterelized();
            cats = await _catManager.GetCats();
            LoadData(cats);
        }

        /// <summary>
        ///  Carga los datos de los gatos en un DataTable y los muestra en el DataGridView.
        /// </summary>
        /// <param name="cats"></param>
        private void LoadData(List<Cat> cats)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Nombre");
            table.Columns.Add("Edad");
            table.Columns.Add("Peso");
            table.Columns.Add("Color de pelo");
            table.Columns.Add("Raza");
            table.Columns.Add("Esterilizado");
            table.Columns.Add("URL imagen");

            foreach (Cat cat in cats)
            {
                table.Rows.Add(cat.Name, cat.Age, cat.Weight, cat.FurColor, cat.Race, cat.IsSterilized, cat.URLImage);
            }

            DataView dataView = table.DefaultView;
            dataView.Sort = "Nombre ASC";
            dgvCats.DataSource = table;
        }

        /// <summary>
        /// Crea un nuevo objeto Cat con los datos ingresados, lo añade a la lista de gatos y muestra un mensaje segun
        /// el resultado.
        /// </summary>
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat(txbName.Text, txbAge.Text, txbWeight.Text, txbURLImage.Text, lbxFurColor.Text, lbxRace.Text, lbxIsSterelized.Text);
            CatAddError result = await _catManager.CreateNewCat(cat);

            switch (result)
            {
                case CatAddError.Error:
                    MessageBox.Show("Completa los campos obligatorios.");
                    break;
                case CatAddError.NameExists:
                    MessageBox.Show("Ya existe un gato con ese nombre.");
                    break;
                case CatAddError.NoError:
                    MessageBox.Show("Gato agregado exitosamente");
                    Log.WriteLog($"Se agregó un gato.");
                    LoadData(cats);
                    break;
            }
        }

        /// <summary>
        /// Crea un nuevo objeto Cat con los datos ingresados, valida los campos requeridos y actualiza 
        /// el gato existente con los nuevos datos, muestra un mensaje según ek resultado.
        /// </summary>
        private async void btnModify_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat(txbName.Text, txbAge.Text, txbWeight.Text, txbURLImage.Text, lbxFurColor.Text, lbxRace.Text, lbxIsSterelized.Text);

            if (!CatValidation.ValidateRequiredFields(cat))
            {
                MessageBox.Show("Completa los campos obligatorios.");
                return;
            }

            CatUpdateError result = await _catManager.UpdateNewCat(cat);

            switch (result)
            {
                case CatUpdateError.Error:
                    MessageBox.Show("El gato no existe.");
                    break;
                case CatUpdateError.NoChanges:
                    MessageBox.Show("No se realizaron cambios.");
                    break;
                case CatUpdateError.NoError:
                    MessageBox.Show("El gato se modificó correctamente.");
                    LoadData(await _catManager.GetCats());
                    Log.WriteLog($"Se modificó un gato.");
                    break;
            }
        }

        /// <summary>
        ///  Solicita confirmación al usuario y si confirma, elimina el gato seleccionado de la lista 
        ///  y muestra un mensaje. Registra un log de la acción.
        /// </summary
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            Cat cat = new Cat(txbName.Text, txbAge.Text, txbWeight.Text, txbURLImage.Text, lbxFurColor.Text, lbxRace.Text, lbxIsSterelized.Text);
            DialogResult result = MessageBox.Show("La mascota desaparecerá del sistema. ¿Estás seguro?", "Eliminar mascota", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (dgvCats.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvCats.SelectedRows[0];
                    string name = selectedRow.Cells["Nombre"].Value.ToString();
                    await _catManager.DeleteCat(name);

                    dgvCats.Rows.Remove(selectedRow);
                    btnDelete.Enabled = false;
                    Log.WriteLog($"Se eliminó un gato del sistema.");
                    MessageBox.Show("El gato se ha eliminado del sistema correctamente.");
                }
                else
                {
                    MessageBox.Show("Selecciona una fila para eliminar.");
                }
            }
        }

        /// <summary>
        /// Exporta la lista de gatos a un archivo JSON y muestra un mensaje según el caso. 
        /// Registra un log.
        /// </summary>
        private async void btnJSON_Click(object sender, EventArgs e)
        {
            var cats = await _catManager.GetCats();
            try
            {
                _exporter = new JsonExporter<Cat>();
                await _exporter.ExportData(cats, "ListCats.json");
                MessageBox.Show("Se exportó una lista de gatos a json.");
                Log.WriteLog("Se exportó una lista de gatos a json.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante la exportación a json: " + ex.Message);
            }
        }

        /// <summary>
        /// Exporta la lista de gatos a un archivo CSV y muestra un mensaje según el caso. 
        /// Registra un log.
        /// </summary>
        private async void btnCSV_Click(object sender, EventArgs e)
        {
            var cats = await _catManager.GetCats();

            try
            {
                _exporter = new CsvExporter<Cat>();
                await _exporter.ExportData(cats, "ListCats.csv");
                Log.WriteLog("Se exportó una lista de gatos a csv.");
                MessageBox.Show("Se exportó una lista de gatos a csv.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante la exportación a csv: " + ex.Message);
            }
        }

        /// <summary>
        /// Exporta la lista de gatos a un archivo PDF y muestra un mensaje según el caso. 
        /// Registra un log.
        /// </summary>
        private async void btnPDF_Click(object sender, EventArgs e)
        {
            var cats = await _catManager.GetCats();

            try
            {
                _exporter = new PdfExporter<Cat>();
                await _exporter.ExportData(cats, "ListCats.pdf");
                Log.WriteLog("Se exportó una lista de gatos a pdf.");
                MessageBox.Show("Se exportó una lista de gatos a pdf.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante la exportación a pdf: " + ex.Message);
            }
        }

        /// <summary>
        /// Llena la lista de opciones con colores de pelo.
        /// </summary>
        private void FillListBoxFurColor()
        {
            List<string> colores = new List<string>();
            colores.Add("Negro");
            colores.Add("Blanco");
            colores.Add("Gris");
            colores.Add("Naranja");
            colores.Add("Atigrado");
            colores.Add("Marrón");
            colores.Add("Carey");
            colores.Add("Crema");
            colores.Add("Blanco y negro");
            colores.Add("Calicó");
            colores.Add("Otro");

            foreach (string color in colores)
            {
                lbxFurColor.Items.Add(color);
            }
        }

        /// <summary>
        /// Llena la lista de opciones con razas.
        /// </summary>
        private void FillListBoxRace()
        {
            List<string> races = new List<string>();
            races.Add("No tiene");
            races.Add("Siamés");
            races.Add("Persa");
            races.Add("Maine Coon");
            races.Add("Bengala");
            races.Add("Ragdoll");
            races.Add("Sphynx");
            races.Add("Abisinio");
            races.Add("Birmano");
            races.Add("Burmés");
            races.Add("Scottish Fold");
            races.Add("Savannah");
            races.Add("British Shorthair");
            races.Add("Siambalés");
            races.Add("Angora Turco");
            races.Add("Devon Rex");
            races.Add("Otro");

            foreach (string race in races)
            {
                lbxRace.Items.Add(race);
            }
        }

        /// <summary>
        /// Añade al ListBox las opciones Sí y No.
        /// </summary>
        private void FillListBoxIsSterelized()
        {
            List<string> options = new List<string>();
            options.Add("Sí");
            options.Add("No");

            foreach (string option in options)
            {
                lbxIsSterelized.Items.Add(option);
            }
        }

        /// <summary>
        /// Añade el valor de las celdas del DataGridView a los TextBox.
        /// </summary>
        private void dgvCats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCats.Rows[e.RowIndex];
                txbName.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txbAge.Text = selectedRow.Cells["Edad"].Value.ToString();
                txbWeight.Text = selectedRow.Cells["Peso"].Value.ToString();
                lbxFurColor.Text = selectedRow.Cells["Color de pelo"].Value.ToString();
                lbxRace.Text = selectedRow.Cells["Raza"].Value.ToString();
                lbxIsSterelized.Text = selectedRow.Cells["Esterilizado"].Value.ToString();
                txbURLImage.Text = selectedRow.Cells["URL imagen"].Value.ToString();
            }
        }

        private async void SeePets_Activated(object sender, EventArgs e)
        {
            var cats = await _catManager.GetCats();
            LoadData(cats);
        }

        private void dgvCats_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCats.SelectedRows.Count > 0)
            {
                btnDelete.Enabled = true;
                btnModify.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
                btnModify.Enabled = false;
            }
        }

        private SeePets(SeePets other)
        {

        }

        private void btnAutocomplete_Click(object sender, EventArgs e)
        {
            txbName.Text = "Minino";
            txbAge.Text = "1";
            txbWeight.Text = "2";
            txbURLImage.Text = "https://s1.ppllstatics.com/lasprovincias/www/multimedia/202112/12/media/cortadas/gatos-kb2-U160232243326NVC-1248x770@Las%20Provincias.jpg";
            lbxFurColor.Text = "Marrón";
            lbxRace.Text = "No tiene";
            lbxIsSterelized.Text = "No";
        }
    }
}