using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Analizar(string texto)
        {
            int vocales = 0;
            int digitos = 0;
            int espacios = 0;

            texto = texto.ToLower();

            for (int i = 0; i < texto.Length; i++)
            {
                char c = texto[i];

                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                    c == 'á' || c == 'é' || c == 'í' || c == 'ó' || c == 'ú')
                {
                    vocales = vocales + 1;
                }

                if (char.IsDigit(c))
                {
                    digitos = digitos + 1;
                }

                if (c == ' ')
                {
                    espacios = espacios + 1;
                }
            }

            Console.WriteLine($"Vocales: {vocales}");
            Console.WriteLine($"Dígitos: {digitos}");
            Console.WriteLine($"Espacios: {espacios}");
        }

        static void Main()
        {
            Console.Write("Observación: ");

            string observacion = Console.ReadLine();

            Analizar(observacion);
        }

    }
}