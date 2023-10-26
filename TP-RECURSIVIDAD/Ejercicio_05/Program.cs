using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir una función recursiva SumaHasta(n, desde)->
            //numero.Debe retornar la suma de los números desde el valor
            //“desde” hasta los N consecutivos a él. Por ejemplo.
            //SumaHasta(5, 10) = 10 + 11 + 12 + 13 + 14 => 60.
            int numMax;

            Console.Write("Ingrese un valor maximo a repetir: ");
            string text = Console.ReadLine();
            numMax = int.Parse(text);

            Console.Write("Ingrese el valor a sumarRecursivamente: ");
            text = Console.ReadLine();
            int num = int.Parse(text);

            Console.WriteLine($"\nLa suma de los {num} valores naturales {numMax} consecutivos es: {sumatoriaRecursiva(numMax, num)}");
            Console.ReadKey();
        }

        static int sumatoriaRecursiva(int max, int num)
        {
            int retornar;

            if (max == 0)
            {
                retornar = 0;
            }
            else
            {
                retornar = num + sumatoriaRecursiva(max - 1, num + 1);
            }

            return retornar;
        }
    }
}
