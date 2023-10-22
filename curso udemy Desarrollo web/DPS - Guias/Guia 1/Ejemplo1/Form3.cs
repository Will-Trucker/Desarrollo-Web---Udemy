using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private string noms, ape1, ape2;
        private double CUM;
        private int UV;

        //Valida que el dato recibido es un numero

        public static Boolean IsNumeric(string valor)
        {
            double result;
            return double.TryParse(valor, out result);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        //evalua el cum
        private void EvaluarCUM()
        {
            //una vez recibidos los nombres del estudiante, asi como su CUM se detemina las UV solicitadas
            string nombrecompleto;
            nombrecompleto = noms + " " + ape1 + " " + ape2;
            nombrecompleto = nombrecompleto.ToUpper();
            if (CUM < 0 | CUM > 10)
            {
                MessageBox.Show("Valor de CUM fuera de rango (0.0 - 10.0) ", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCUM.Focus();
            }
            else
            {
                //Usa estructura switch
                switch (Convert.ToInt16(CUM))
                {
                    case 8 - 10:
                        UV = 32;
                        break;
                    case 7:
                        UV = 24;
                        break;
                    case 6:
                        UV = 20;
                        break;
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        UV = 16;
                        break;
                    default:
                        UV = 0;
                        break;

                }
                txtResul.Text = nombrecompleto + " Puede cursar " + UV + " UV ";
            }
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtApe1.Text) || string.IsNullOrWhiteSpace(txtApe2.Text) || string.IsNullOrWhiteSpace(txtCUM.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsNumeric(txtCUM.Text))
            {
                MessageBox.Show("El CUM debe ser un valor numérico ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            noms = txtNom.Text;
            ape1 = txtApe1.Text;
            ape2 = txtApe2.Text;
            CUM = Convert.ToDouble(txtCUM.Text);

            EvaluarCUM();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
