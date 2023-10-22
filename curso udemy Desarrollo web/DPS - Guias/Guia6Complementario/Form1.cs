using System.Drawing;

namespace Guia6Complementario
{
    public partial class Form1 : Form
    {
        private List<Mamifero> mamiferos = new List<Mamifero>();
        private List<Reptil> reptiles = new List<Reptil>();
        private List<Pez> peces = new List<Pez>();
        private List<Artropodo> artropodos = new List<Artropodo>();

        private string rutaFotoSeleccionada = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeUI()
        {
            // Etiquetas
            TextBox txtNombreComun = new TextBox();
            txtNombreComun.Location = new System.Drawing.Point(160, 20);
            txtNombreComun.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(txtNombreComun);

            // TextBox para ingresar el nombre científico
            TextBox txtNombreCientifico = new TextBox();
            txtNombreCientifico.Location = new System.Drawing.Point(160, 60);
            txtNombreCientifico.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(txtNombreCientifico);

            // Button para registrar el animal
            Button btnRegistrarAnimal = new Button();
            btnRegistrarAnimal.Text = "Registrar Animal";
            btnRegistrarAnimal.Location = new System.Drawing.Point(20, 100);
            btnRegistrarAnimal.Click += new EventHandler(btnRegistrarAnimal_Click);
            this.Controls.Add(btnRegistrarAnimal);

            // Button para seleccionar una foto
            Button btnSeleccionarFoto = new Button();
            btnSeleccionarFoto.Text = "Seleccionar Foto";
            btnSeleccionarFoto.Location = new System.Drawing.Point(20, 140);
            btnSeleccionarFoto.Click += new EventHandler(btnSeleccionarFoto_Click);
            this.Controls.Add(btnSeleccionarFoto);

            // TextBox para ingresar el hábitat
            TextBox txtHabitat = new TextBox();
            txtHabitat.Location = new System.Drawing.Point(160, 140);
            txtHabitat.Size = new System.Drawing.Size(200, 20);
            this.Controls.Add(txtHabitat);

            // DateTimePicker para seleccionar la fecha de registro
            DateTimePicker dtpFechaRegistro = new DateTimePicker();
            dtpFechaRegistro.Location = new System.Drawing.Point(160, 180);
            dtpFechaRegistro.Format = DateTimePickerFormat.Short;
            this.Controls.Add(dtpFechaRegistro);

            // TextBox para ingresar la familia
            ComboBox comboBoxTipoAnimal = new ComboBox();
            comboBoxTipoAnimal.Location = new System.Drawing.Point(160, 220);
            comboBoxTipoAnimal.Size = new System.Drawing.Size(200, 21);
            comboBoxTipoAnimal.Items.AddRange(new string[] { "Familia 1", "Familia 2", "Familia 3" }); // Agrega las opciones de familia aquí
            this.Controls.Add(comboBoxTipoAnimal);

            // DataGridView para mostrar los animales registrados
            DataGridView dgvAnimales = new DataGridView();
            dgvAnimales.Location = new System.Drawing.Point(20, 260);
            dgvAnimales.Size = new System.Drawing.Size(600, 200);
            dgvAnimales.AllowUserToAddRows = false;
            this.Controls.Add(dgvAnimales);

            // PictureBox para mostrar la foto del animal
            PictureBox pictureBoxFoto = new PictureBox();
            pictureBoxFoto.Location = new System.Drawing.Point(400, 20);
            pictureBoxFoto.Size = new System.Drawing.Size(200, 200);
            this.Controls.Add(pictureBoxFoto);
        }

        private void btnSeleccionarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                rutaFotoSeleccionada = openFileDialog.FileName;

                // Mostrar la foto en el PictureBox (asumiendo que tienes un PictureBox llamado pictureBoxFoto)
                pictureBoxFoto.Image = Image.FromFile(rutaFotoSeleccionada);
            }

        }

        private void btnRegistrarAnimal_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados por el usuario desde los controles
            string nombreComun = txtNombreComun.Text;
            string nombreCientifico = txtNombreCientifico.Text;
            string habitat = txtHabitat.Text;
            string familia = comboBoxTipoAnimal.Text;
            DateTime fechaRegistro = dtpFechaRegistro.Value;
            string rutaFoto = rutaFotoSeleccionada;

            if (string.IsNullOrEmpty(rutaFoto))
            {
                MessageBox.Show("Por favor, seleccione una foto.");
                return;
            }


            int fechaRegistroInt = (int)fechaRegistro.Ticks;

            // Validar que se hayan ingresado datos
            if (string.IsNullOrEmpty(nombreComun) || string.IsNullOrEmpty(nombreCientifico) ||
                string.IsNullOrEmpty(habitat) || string.IsNullOrEmpty(familia))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            // Asumiendo que tienes un ComboBox o RadioButtons para seleccionar el tipo de animal
            string tipoAnimal = comboBoxTipoAnimal.SelectedItem.ToString();

            switch (tipoAnimal)
            {
                case "Mamífero":
                    // Agregar lógica para capturar más datos específicos de mamíferos si es necesario
                    Mamifero nuevoMamifero = new Mamifero(nombreComun, nombreCientifico, rutaFoto, familia, habitat, fechaRegistro.ToString("yyyy-MM-dd"));
                    mamiferos.Add(nuevoMamifero);
                    break;

                case "Reptil":
                    // Agregar lógica para capturar más datos específicos de reptiles si es necesario
                    Reptil nuevoReptil = new Reptil(nombreComun, nombreCientifico, rutaFoto, familia, habitat, fechaRegistro.ToString("yyyy-MM-dd"), "");
                    reptiles.Add(nuevoReptil);
                    break;

                case "Pez":
                    // Agregar lógica para capturar más datos específicos de peces si es necesario
                    Pez nuevoPez = new Pez(nombreComun, nombreCientifico, rutaFoto, familia, habitat, fechaRegistro.ToString("yyyy-MM-dd"), "");
                    peces.Add(nuevoPez);
                    break;

                case "Artrópodo":
                    // Agregar lógica para capturar más datos específicos de artrópodos si es necesario
                    Artropodo nuevoArtropodo = new Artropodo(nombreComun, nombreCientifico, rutaFoto, familia, habitat, fechaRegistro.ToString("yyyy-MM-dd"), "", 0, 0);
                    artropodos.Add(nuevoArtropodo);
                    break;
                default:
                    MessageBox.Show("Tipo de animal no válido.");
                    return;
            }

            // Limpiar los cuadros de texto después de registrar

            txtNombreComun.Clear();
            txtNombreCientifico.Clear();
            txtHabitat.Clear();


            // Actualizar el DataGridView con los datos registrados
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            // Borrar las filas existentes en el DataGridView
            dgvAnimales.Rows.Clear();
            dgvAnimales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;



            // Agregar columnas si aún no se han agregado
            if (dgvAnimales.Columns.Count == 0)
            {
                dgvAnimales.Columns.Add("Tipo", "Tipo");
                dgvAnimales.Columns.Add("NombreComun", "Nombre Común");
                dgvAnimales.Columns.Add("NombreCientifico", "Nombre Científico");
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn.HeaderText = "Foto";
                dgvAnimales.Columns.Add(imageColumn); // Esta columna será para mostrar la imagen
                dgvAnimales.Columns.Add("Familia", "Familia");
                dgvAnimales.Columns.Add("Habitat", "Habitat");
                dgvAnimales.Columns.Add("FechaRegistro", "Fecha de Registro");

                //Autosize
                dgvAnimales.AllowUserToResizeColumns = true;
                dgvAnimales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                imageColumn.MinimumWidth = 50; // Ancho mínimo
                imageColumn.Width = 100;

                // Configura la columna de imagen para que se ajuste al contenido de la celda
                imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                imageColumn.DefaultCellStyle.NullValue = null; // Esto evita que se muestre el icono de imagen predeterminado en celdas vacías
                imageColumn.DefaultCellStyle.Padding = new Padding(0);

            }

            // Mostrar los datos de los mamíferos
            foreach (var mamifero in mamiferos)
            {
                // Cargar la imagen desde un archivo (asegúrate de que la ruta de la imagen sea correcta)
                Image imagen = Image.FromFile(mamifero.Foto);

                // Agregar la fila al DataGridView
                dgvAnimales.Rows.Add("Mamífero", mamifero.NombreComun, mamifero.NombreCientifico, imagen, mamifero.Familia, mamifero.Habitat, mamifero.FechaRegistro);
            }

            // Mostrar los datos de los reptiles
            foreach (var reptil in reptiles)
            {
                // Cargar la imagen desde un archivo (asegúrate de que la ruta de la imagen sea correcta)
                Image imagen = Image.FromFile(reptil.Foto);

                // Agregar la fila al DataGridView
                dgvAnimales.Rows.Add("Reptil", reptil.NombreComun, reptil.NombreCientifico, imagen, reptil.Familia, reptil.Habitat, reptil.FechaRegistro);
            }

            // Mostrar los datos de los peces
            foreach (var pez in peces)
            {
                // Cargar la imagen desde un archivo (asegúrate de que la ruta de la imagen sea correcta)
                Image imagen = Image.FromFile(pez.Foto);

                // Agregar la fila al DataGridView
                dgvAnimales.Rows.Add("Pez", pez.NombreComun, pez.NombreCientifico, imagen, pez.Familia, pez.Habitat, pez.FechaRegistro);
            }

            // Mostrar los datos de los artrópodos
            foreach (var artropodo in artropodos)
            {
                // Cargar la imagen desde un archivo (asegúrate de que la ruta de la imagen sea correcta)
                Image imagen = Image.FromFile(artropodo.Foto);

                // Agregar la fila al DataGridView
                dgvAnimales.Rows.Add("Artrópodo", artropodo.NombreComun, artropodo.NombreCientifico, imagen, artropodo.Familia, artropodo.Habitat, artropodo.FechaRegistro);
            }


        }



        public abstract class Animales
        {
            public string NombreComun { get; set; }
            public string NombreCientifico { get; set; }
            public string Foto { get; set; }
            public string Familia { get; set; }
            public string Habitat { get; set; }
            public string FechaRegistro { get; set; }

            protected Animales(string nombreComun, string nombreCientifico, string foto, string familia, string habitat, string fechaRegistro)
            {
                NombreComun = nombreComun;
                NombreCientifico = nombreCientifico;
                Foto = foto;
                Familia = familia;
                Habitat = habitat;
                FechaRegistro = fechaRegistro;
            }
        }

        public class Mamifero : Animales
        {
            public Mamifero(string nombreComun, string nombreCientifico, string foto, string familia, string habitat, string fechaRegistro)
                : base(nombreComun, nombreCientifico, foto, familia, habitat, fechaRegistro)
            {
            }
        }

        public class Pez : Animales
        {
            public Pez(string nombreComun, string nombreCientifico, string foto, string familia, string habitat, string fechaRegistro, string v)
                : base(nombreComun, nombreCientifico, foto, familia, habitat, fechaRegistro)
            {
            }
        }



        public class Reptil : Animales
        {
            public Reptil(string nombreComun, string nombreCientifico, string foto, string familia, string habitat, string fechaRegistro, string v)
                : base(nombreComun, nombreCientifico, foto, familia, habitat, fechaRegistro)
            {
            }
        }


        public class Artropodo : Animales
        {
            public Artropodo(string nombreComun, string nombreCientifico, string foto, string familia, string habitat, string fechaRegistro, string v, int v1, int v2)
                : base(nombreComun, nombreCientifico, foto, familia, habitat, fechaRegistro)
            {
            }
        }
    }
}