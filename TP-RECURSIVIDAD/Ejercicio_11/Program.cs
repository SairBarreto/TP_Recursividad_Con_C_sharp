using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implemente una función recursiva que nos diga si una cadena es palíndromo.

            Console.Write("Ingrese una cadena: ");
            string cadena = Console.ReadLine();

            if (EsPalindromo(cadena))
            {
                Console.WriteLine($"\n'{cadena}' es un palíndromo.");
            }
            else
            {
                Console.WriteLine($"\n'{cadena}' no es un palíndromo.");
            }
            Console.ReadKey();
        }

        static bool EsPalindromo(string cadena)
        {
            // Elimina espacios en blanco y convierte la cadena a minúsculas para hacer la comparación.
            cadena = cadena.Replace(" ", "").ToLower();
            return EsPalindromoRecursivo(cadena, 0, cadena.Length - 1);
        }

        static bool EsPalindromoRecursivo(string cadena, int inicio, int fin)
        {
            // Caso base: cuando solo queda un carácter o ninguno en la cadena, es un palíndromo.
            if (inicio >= fin)
            {
                return true;
            }

            // Compara el primer y último carácter de la cadena.
            if (cadena[inicio] != cadena[fin])
            {
                return false;
            }

            // Llamada recursiva con los índices actualizados.
            return EsPalindromoRecursivo(cadena, inicio + 1, fin - 1);
        }
    }
}
