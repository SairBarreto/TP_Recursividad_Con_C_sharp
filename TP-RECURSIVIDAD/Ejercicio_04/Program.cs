using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir una función recursiva que retorne los primeros N números de la serie de Fibonacci.
            int numMax;

            Console.Write("Ingrese cuantos valores de la serie de Fibonacci quiere ver: ");
            string text = Console.ReadLine();
            numMax = int.Parse(text);

            Console.WriteLine($"\nLos {numMax} numeros de la serie de Fibonacci son:");
            for (int i = 0; i < numMax; i++)
            {
                Console.WriteLine(FibonacciRecursivo(i));
            }
            Console.ReadKey();
        }

        static int FibonacciRecursivo(int max)
        {
            int resultado;
            if (max < 2)
            {
                resultado = max;
            }
            else
            {
                resultado = FibonacciRecursivo(max - 1) + FibonacciRecursivo(max - 2);
            }

            return resultado;
        }
    }
}
