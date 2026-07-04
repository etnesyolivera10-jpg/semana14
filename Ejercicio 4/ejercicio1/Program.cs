using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class Program
    {

        static bool CodigoValido(string ingresado, string esperado)
        {
            string codigoIngresadoNormalizado = ingresado.Trim().ToUpper();

            string codigoEsperadoNormalizado = esperado.Trim().ToUpper();

            return codigoIngresadoNormalizado.CompareTo(codigoEsperadoNormalizado) == 0;
        }

        static void Main()
        {
            Console.Write("Código esperado: ");
            string esperado = Console.ReadLine();

            Console.Write("Código ingresado: ");
            string ingresado = Console.ReadLine();

            if (CodigoValido(ingresado, esperado))
            {
                Console.WriteLine("Código aceptado.");
            }
            else
            {
                Console.WriteLine("Código no coincide.");
            }
        }
    }
}


