using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia6Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1() //constructor de clase Form1
        {
            InitializeComponent();

            
        }

        //Declara a 2 listas/colecciones, basadas en objetos de ambas clases derivadas
        List<clsDoctor> doctores;
        List<clsVendedor> vendedores;

        //prepara objeto para generar cuadro de dialogo de seleccion de archivo
        OpenFileDialog cuadroseleccion = new OpenFileDialog();

        //METODOS de la clase Form1

        //Metodo para generar las secuencias de dias, meses y años en combobox
        private void llenarcombobox()
        {
            int c; //contador usos varios
            //primeros dias
            for (c = 1; c <= 31; c++)
                cmbDia.Items.Add(c);
            cmbDia.Text = DateTime.Now.Day.ToString();
            for (c = 1; c <= 12; c++) cmbMes.Items.Add(c);
            cmbMes.Text = DateTime.Now.Month.ToString();
            for (c = 1950; c <= DateTime.Now.Year; c++) cmbAnno.Items.Add(c);
            cmbAnno.Text = DateTime.Now.Year.ToString();
        }//fin llenarcombobox

        void PrepararNuevoDoctor()
        {
            //Deja los controles listos para el proximo doctor a ingresar
            txtNom.Clear();
            picFotoDoc.ImageLocation = Application.StartupPath + "\\Desconocido.jpg";
            cmbDia.SelectedIndex = 0;
            cmbMes.SelectedIndex = 0;
            cmbAnno.SelectedIndex = 0;
            nudSueldo.Value = 1.00M;
            mtbCodDoctor.Clear();

            txtNom.Focus();
        }

        void PrepararNuevoVendedor()
        {
            //Deja los controles listos para el proximo vendedor a ingresar
            picFotoVen.ImageLocation = Application.StartupPath + "\\Desconocido.jpg";
            dtpFechaNac.Value = DateTime.Now;
            dtpFechaC.Value = DateTime.Now;
            txtNomV.Focus();
        }

        public void MostrarLista_Doctores()
        {
            dataGridView1.Columns[4].HeaderText = "Codigo";
            dataGridView1.Rows.Clear();

            int cm = 0;

            foreach (clsDoctor doctor in doctores)
            {
                dataGridView1.Rows.Add();
                DataGridViewRow fila = dataGridView1.Rows[dataGridView1.Rows.Count - 1];

                fila.Cells[0].Value = cm + 1;
                fila.Cells[1].Value = doctor.nombreempleado;
                fila.Cells[2].Value = Image.FromFile(doctor.URLfoto);
                fila.Cells[3].Value = doctor.fecha_nacimiento;
                fila.Cells[4].Value = doctor.codigodoctor;

                cm++;

            }

        }
        public void MostrarLista_Vendedores()
        {
            dataGridView1.Columns[4].HeaderText = "Fecha Contrato";
            dataGridView1.Rows.Clear();

            int cm = 0;

            foreach (clsVendedor vendedor in vendedores)
            {
                dataGridView1.Rows.Add();
                DataGridViewRow fila = dataGridView1.Rows[dataGridView1.Rows.Count - 1];

                fila.Cells[0].Value = cm + 1;
                fila.Cells[1].Value = vendedor.nombreempleado;
                fila.Cells[2].Value = Image.FromFile(vendedor.URLfoto);
                fila.Cells[3].Value = vendedor.fecha_nacimiento;
                fila.Cells[4].Value = vendedor.FechaContrato;

                cm++;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            llenarcombobox(); //llenar los 3 combos (que definen a una fecha)

            //crear lista de doctores y vendedores
            doctores = new List<clsDoctor>();
            vendedores = new List<clsVendedor>();

            //Define filtros para el cuadro de seleccion, que mostrara solo imagenes JPG
            cuadroseleccion.Filter = "Imagenes de tipo  JPG | *.jpg";

            //Inicia los controles para ingresar un nuevo Doctor o nuevo Vendedor
            PrepararNuevoDoctor();
            PrepararNuevoVendedor();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Se invoca un objeto de clase OpenFileDialog, para que usuario seleccione archivo
            //de imagen y asi, se cargue en el cuadro de imagen
            if (cuadroseleccion.ShowDialog() == DialogResult.OK)
            {
                picFotoDoc.ImageLocation = cuadroseleccion.FileName;
            }
        }

        private void btnAgregarDoc_Click(object sender, EventArgs e)
        {
            clsDoctor Doctor = new clsDoctor(); //objeto de la clase derivada

            //toma los datos de los controles del form para definir objeto Doctor
            Doctor.nombreempleado = txtNom.Text;
            Doctor.asignarfechanac(cmbAnno.Text, cmbMes.Text, cmbDia.Text);
            Doctor.sueldobase = Convert.ToSingle(nudSueldo.Value);
            Doctor.codigodoctor = mtbCodDoctor.Text;

            //envia url de foto seleccionada por usuario 
            Doctor.URLfoto = picFotoDoc.ImageLocation;

            //intenta agregar nuevo doctor a coleccion de Doctores 
            if (Doctor.DatossonCorrectos())
            {
                doctores.Add(Doctor);
                MessageBox.Show("Doctor " + Doctor.nombreempleado + " se ha agregado a la lista", "Excelente!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Inicia los controles para ingresar un nuevo doctor
                PrepararNuevoDoctor();
            }
            else
            {
                MessageBox.Show("Datos incompletos");
            }
        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            //Selecciona un archivo de imagen para el vendedor
            if (cuadroseleccion.ShowDialog() == DialogResult.OK)
            {
                picFotoVen.ImageLocation = cuadroseleccion.FileName;
            }
        }

        private void btnAgregarVen_Click(object sender, EventArgs e)
        {
            clsVendedor Vendedor = new clsVendedor(); //objeto de la clase derivada
            //Define valores brindados por usuario hacia el objeto vendedor
            Vendedor.nombreempleado = txtNomV.Text;
            Vendedor.sueldobase = 2000; //asigna un sueldo fijo de $20000
            Vendedor.asignarfechanac(dtpFechaNac.Value);
            Vendedor.FechaContrato = dtpFechaC.Value;

            //envia url de foto seleccionada por el usuario 
            Vendedor.URLfoto = picFotoVen.ImageLocation;

            //agrega vendedor actual hacia list de vendedores
            vendedores.Add(Vendedor);

            //deja controles listos para el proximo vendedor a registrar
            PrepararNuevoVendedor();
        }

        private void rbDoctores_CheckedChanged(object sender, EventArgs e)
        {
            //invoca metodo para llenar el Datagrid con datos de los doctores registrados
            MostrarLista_Doctores();
        }

        private void rbVendedores_CheckedChanged(object sender, EventArgs e)
        {
            //invoca metodo para llenar al Datagrid con datos de los vendedores registrados
            MostrarLista_Vendedores();
        }


    }


}
