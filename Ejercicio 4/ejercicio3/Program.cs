using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    internal class Program
    {
        static bool ContieneClave(string comentario, string clave)
        {
            string texto = comentario.Trim().ToLower();

            string buscar = clave.Trim().ToLower();

            return texto.Contains(buscar);
        }

        static void Main()
        {
            Console.Write("Ingrese el comentario del estudiante: ");

            string comentario = Console.ReadLine();

            Console.Write("Ingrese la palabra clave a buscar: ");

            string clave = Console.ReadLine();

            if (ContieneClave(comentario, clave))
            {
                Console.WriteLine("El comentario contiene la palabra clave.");
            }
            else
            {
                Console.WriteLine("El comentario no contiene la palabra clave.");
            }
        }
    }
}