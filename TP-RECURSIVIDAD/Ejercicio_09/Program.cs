using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programe un método recursivo que transforme un número entero positivo a notación binaria.

            Console.Write("Ingrese un número entero positivo: ");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero >= 0)
            {
                string binario = EnteroABinario(numero);
                Console.WriteLine($"\nEl número {numero} en notación binaria es: {binario}");
            }
            else
            {
                Console.WriteLine("\nEntrada no válida. Debe ingresar un número entero positivo.");
            }

            Console.ReadKey();
        }

        static string EnteroABinario(int numero)
        {
            // Caso base: cuando el número es 0, el resultado es "0".
            if (numero == 0)
            {
                return "0";
            }

            // Llamada recursiva para dividir el número por 2 y obtener el cociente y el residuo.
            int cociente = numero / 2;
            int residuo = numero % 2;

            // Concatena el residuo a la llamada recursiva con el cociente.
            return EnteroABinario(cociente) + residuo;
        }
    }
}
