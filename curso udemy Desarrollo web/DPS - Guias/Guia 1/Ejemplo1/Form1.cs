namespace Ejemplo1
{
    using System;
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string mensa;
        private static int conta;



        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnContar_Click(object sender, EventArgs e)
        {
            // int conta = 0;
            // Acumulador total de veces que presiona el botón
            // conta = conta + 1;
            //conta+=1; //En forma de operador abreviado

            conta++;

            mensa = "Presiono botón Contar, un total de " + Convert.ToString(conta) + " veces";

            label1.Text = mensa;
        }
        private void btnReinicio_Click(object sender, EventArgs e)
        {
            //Restaura conteo clic realizado a button1
            conta = 0; // ocupamos la variable referenciada al inicio
            mensa = "Presiono botón Contar, un total de " + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void BtnFin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}