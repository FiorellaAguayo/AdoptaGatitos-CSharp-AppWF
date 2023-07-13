using Entities;
using Firestore;

namespace PatitasSuaves
{
    public partial class Profiles : Form
    {
        private FirestoreManager<Cat> _catManager;

        public Profiles()
        {
            InitializeComponent();
            _catManager = new FirestoreManager<Cat>("cats");
        }

        /// <summary>
        /// Carga los perfiles de gatos al formulario.
        /// </summary>
        private async void Profiles_Load(object sender, EventArgs e)
        {
            var cats = await _catManager.GetAll();
            ShowCatList(cats);
        }

        /// <summary>
        /// Muestra una lista de gatos en el control flpCats.
        /// </summary>
        /// <param name="cats"></param> lista de gatos.
        public void ShowCatList(List<Cat> cats)
        {
            flpCats.Controls.Clear();

            foreach (var cat in cats)
            {
                var panel = CreatePanelCats(cat);
                flpCats.Controls.Add(panel);
            }
        }

        /// <summary>
        /// Crea un panel para un gato específico.
        /// </summary>
        /// <param name="cat"></param>
        /// <returns></returns> Objeto cat.
        private Panel CreatePanelCats(Cat cat)
        {
            var panel = new Panel
            {
                Width = 190,
                Height = 280,
                Margin = new Padding(5),
                BackColor = Color.White
            };

            var picture = CreatePictureBoxCat(cat);
            var labelNombre = CreateLabelNameGato(cat);
            var button = CreateButtonAdopt(cat);

            panel.Controls.Add(picture);
            panel.Controls.Add(labelNombre);
            panel.Controls.Add(button);

            return panel;
        }

        /// <summary>
        /// Crea la iamgen del gato desde una dirección de google.
        /// </summary>
        /// <param name="cat"></param>
        /// <returns></returns>
        private PictureBox CreatePictureBoxCat(Cat cat)
        {
            var picture = new PictureBox
            {
                Width = 150,
                Height = 150,
                Location = new Point(20, 15),
                BackgroundImageLayout = ImageLayout.Zoom,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            string imageUrl;

            if (!string.IsNullOrEmpty(cat.URLImage))
            {
                imageUrl = cat.URLImage;
            }
            else
            {
                // Manejar el caso en que "URLImage" no está en el producto
                imageUrl = Path.Combine(Application.StartupPath, "gatito.jpg");
            }

            try
            {
                picture.Load(imageUrl);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Argumento no válido al cargar la imagen: " + ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Archivo de imagen no encontrado: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }

            picture.Paint += (sender, e) =>
            {
                var image = ((PictureBox)sender).Image;
                if (image != null)
                {
                    // Calcula las coordenadas para centrar la imagen verticalmente
                    int x = ((PictureBox)sender).Width / 2 - image.Width / 2;
                    int y = ((PictureBox)sender).Height / 2 - image.Height / 2;
                    e.Graphics.DrawImage(image, new Point(x, y));
                }
            };

            return picture;
        }

        /// <summary>
        /// Crea un label con el nombre del gato.
        /// </summary>
        /// <param name="cat"></param>
        /// <returns></returns>Label creado.
        private Label CreateLabelNameGato(Cat cat)
        {
            var nombre = cat.Name;
            var colorTexto = Color.FromArgb(20, 25, 25);

            var labelNombre = new Label
            {
                Text = nombre,
                ForeColor = colorTexto,
                Location = new Point(20, 175),
                Width = 150,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter
            };

            return labelNombre;
        }

        /// <summary>
        /// Crea un boton de adopción.
        /// </summary>
        /// <param name="cat"></param> Objeto gato seleccionado.
        /// <returns></returns> Boton creado.
        private Button CreateButtonAdopt(Cat cat)
        {
            var button = new Button
            {
                Text = "Adoptar",
                BackColor = Color.Wheat,
                ForeColor = Color.Black,
                Location = new Point(20, 215),
                Width = 148,
                Height = 33,
                Font = new Font("Segoe UI Emoji", 10, FontStyle.Italic)
            };

            button.Click += async (s, e) =>
            {
                await RemoveCatFromAdoptionList(cat);
            };

            return button;
        }

        /// <summary>
        /// Elimina al gato de la lista de gatos.
        /// </summary>
        /// <param name="cat"></param> Objeto gato adoptado.
        private async Task RemoveCatFromAdoptionList(Cat cat)
        {
            try
            {
                await _catManager.Delete(cat.Name);
                MessageBox.Show("El gato ha sido adoptado, gracias y cuidelo bien!.");
                var updatedCats = await _catManager.GetAll();
                ShowCatList(updatedCats);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al adoptar al gato: " + ex.Message);
            }
        }
    }
}