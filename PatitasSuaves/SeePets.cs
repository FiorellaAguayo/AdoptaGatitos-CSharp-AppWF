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

        private async void SeePets_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            FillListBoxFurColor();
            FillListBoxRace();
            FillListBoxIsSterelized();
            cats = await _catManager.GetCats();
            LoadData(cats);
        }

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
            // Recargar los datos en el DataGridView
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

        private async void btnJSON_Click(object sender, EventArgs e)
        {
            var cats = await _catManager.GetCats();

            _exporter = new JsonExporter<Cat>();
            await _exporter.ExportData(cats, "ListCats.json");
            Log.WriteLog("Se exportó una lista de gatos a json.");
        }

        private async void btnCSV_Click(object sender, EventArgs e)
        {
            var cats = await _catManager.GetCats();

            _exporter = new CsvExporter<Cat>();
            await _exporter.ExportData(cats, "ListCats.csv");
            Log.WriteLog("Se exportó una lista de gatos a csv.");
        }

        private async void btnPDF_Click(object sender, EventArgs e)
        {
            var cats = await _catManager.GetCats();
            
            _exporter = new PdfExporter<Cat>();
            await _exporter.ExportData(cats, "ListCats.pdf");
            Log.WriteLog("Se exportó una lista de gatos a pdf.");
        }
    }
}