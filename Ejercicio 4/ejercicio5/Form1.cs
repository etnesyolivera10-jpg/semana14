using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5
{
    public partial class Form1 : Form
    {
 
        private string[] nombresConsulta = { "Ana Torres" , "Luis Ramos" , "María Díaz" };
        private double[] notasConsulta = { 18, 14, 11 };
        public Form1()
        {
            InitializeComponent();
        }

        public void label2_Click(object sender, EventArgs e)
        {


        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string buscado = txtBuscar.Text.Trim().ToLower();

            if (buscado == "")
            {
                lblResultado.Text = "Escribe un nombre para buscar.";
                txtBuscar.Focus();
                return;
            }

            int posicion = -1;

            for (int i = 0; i < nombresConsulta.Length; i++)
            {
                string nombreActual = nombresConsulta[i].ToLower();

                if (nombreActual.Contains(buscado))
                {
                    posicion = i;

                    break;
                }
            }

            if (posicion != -1)
            {
                lblResultado.Text = $"Nota: {notasConsulta[posicion]:F2}";
            }
            else
            {
                lblResultado.Text = "Estudiante no encontrado.";
            }
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            lblResultado.Text = "Resultado: -";
            txtBuscar.Focus();
        }

        private void MostrarDatosConsulta()
        {
            lstDatos.Items.Clear();

            for (int i = 0; i < nombresConsulta.Length; i++)
            {
                lstDatos.Items.Add($"{nombresConsulta[i]} - Nota: {notasConsulta[i]:F2}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatosConsulta();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
