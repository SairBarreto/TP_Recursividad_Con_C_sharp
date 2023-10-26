using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir una función recursiva que devuelva los primeros N números pares.
            int numMax;

            Console.Write("Ingrese un valor: ");
            string text = Console.ReadLine();
            numMax = int.Parse(text);

            Console.WriteLine($"\nLos pares que hay hasta el numero {numMax} son:");
            pares(numMax);
            Console.ReadKey();
        }

        static void pares(int max)
        {
            if (max == 0)
            {
                Console.WriteLine(max);
            }
            else if (max % 2 == 0)
            {
                Console.WriteLine(max);
                pares(max - 1);
            }
            else
            {
                pares(max - 1);
            }
        }
    }
}
