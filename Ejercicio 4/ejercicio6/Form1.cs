using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio6
{
    public partial class Form1 : Form
    {
        private string[] nombresRanking = { "Ana", "Luis", "María", "Carlos" };
        private double[] notasRanking = { 18, 14, 19, 11 };
        public Form1()
        {
            InitializeComponent();
        }


        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Ordenamiento burbuja descendente.
            // Descendente significa de mayor a menor.
            for (int i = 0; i < notasRanking.Length - 1; i++)
            {
                for (int j = 0; j < notasRanking.Length - 1 - i; j++)
                {
                    // Ordenar de mayor a menor.
                    if (notasRanking[j] < notasRanking[j + 1])
                    {
                        // Intercambio de notas.
                        double auxNota = notasRanking[j];
                        notasRanking[j] = notasRanking[j + 1];
                        notasRanking[j + 1] = auxNota;

                        // Intercambio de nombres.
                        // Esto mantiene la relación entre nombre y nota.
                        string auxNombre = nombresRanking[j];
                        nombresRanking[j] = nombresRanking[j + 1];
                        nombresRanking[j + 1] = auxNombre;
                    }
                }
            }

            // Muestra el ranking ya ordenado.
            MostrarRankingActual();

            // Después de ordenar, el primer puesto queda en la posición 0.
            lblMayor.Text = $"Primer puesto: {nombresRanking[0]} ({notasRanking[0]:F2})";
        }

        private void btnRestablecerRanking_Click(object sender, EventArgs e)
        {
            // Restablece los datos originales para volver a probar.
            nombresRanking = new string[] { "Ana", "Luis", "María", "Carlos" };
            notasRanking = new double[] { 18, 14, 19, 11 };

            lblMayor.Text = "Primer puesto: -";
            MostrarRankingActual();
        }

        private void MostrarRankingActual()
        {
            // Muestra el ranking actual en el ListBox.
            lstRanking.Items.Clear();

            for (int i = 0; i < nombresRanking.Length; i++)
            {
                lstRanking.Items.Add($"{i + 1}. {nombresRanking[i]} - Nota: {notasRanking[i]:F2}");
            }
        }
    }
}
