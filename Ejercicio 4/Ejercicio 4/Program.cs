using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {

            static string NormalizarCodigo(string codigo)
            {
                codigo = codigo.Trim();

                codigo = codigo.Replace("-", "");

                codigo = codigo.ToUpper();

                return codigo;
            }

            static bool TieneLongitudValida(string codigo)
            {
                return codigo.Length == 8;
            }

            static void Main()
            {
                Console.Write("Ingrese código de comprobante: ");

                string codigoIngresado = Console.ReadLine();

                string codigoNormalizado = NormalizarCodigo(codigoIngresado);

                Console.WriteLine($"Código normalizado: {codigoNormalizado}");

                if (TieneLongitudValida(codigoNormalizado))
                {
                    Console.WriteLine("Código válido.");
                }
                else
                {
                    Console.WriteLine("Código inválido. Debe tener 8 caracteres.");
                }
            }

        }

    }

