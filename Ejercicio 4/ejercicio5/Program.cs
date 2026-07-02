using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    internal class Program
    {
        static int BuscarEstudiante(string[] nombres, string texto)
        {
            texto = texto.Trim().ToLower();

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i].ToLower().Contains(texto))
                {
                    return i;
                }
            }

            return -1;
        }

        static void Main()
        {
            string[] nombres = { "Etnesy Olivera", "Maria Lopez", "Andrea Diaz", "Ana Torres" };
            double[] notas = { 18.5, 15.0, 17.2, 19.0 };

            Console.Write("Ingrese parte del nombre del estudiante: ");
            string texto = Console.ReadLine();

            int posicion = BuscarEstudiante(nombres, texto);

            if (posicion != -1)
            {
                Console.WriteLine("Estudiante: " + nombres[posicion]);
                Console.WriteLine("Nota: " + notas[posicion]);
            }
            else
            {
                Console.WriteLine("Estudiante no encontrado.");
            }
        }
    }
}