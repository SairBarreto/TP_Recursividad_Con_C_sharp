using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir una función recursiva que devuelva la suma de los primerosN enteros.
            int numMax;

            Console.Write("Ingrese un valor: ");
            string text = Console.ReadLine();
            numMax = int.Parse(text);

            Console.WriteLine($"\nLa suma de los {numMax} valores naturales consecutivos es: {sumatoriaRecursiva(numMax)}");
            Console.ReadKey();
        }

        static int sumatoriaRecursiva(int max)
        {
            int retornar;

            if (max == 0)
            {
                retornar = 0;
            }
            else
            {
                retornar = max + sumatoriaRecursiva(max - 1);
            }

            return retornar;
        }
    }
}
