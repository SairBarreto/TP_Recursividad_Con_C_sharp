using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir una función recursiva que resuelva N^p donde N y p son números positivos.
            int num, potencia;

            Console.Write("Ingrese un valor: ");
            string text = Console.ReadLine();
            num = int.Parse(text);

            Console.Write("Ingrese un valor para la potencia: ");
            text = Console.ReadLine();
            potencia = int.Parse(text);

            Console.WriteLine($"\nEl resultado de {num} elevado a la {potencia} es: {Potencia(num, potencia)}");
            Console.ReadKey();
        }

        static int Potencia(int num, int potencia)
        {
            int resultado;

            if (potencia == 0)
            {
                resultado = 1;
            }
            else
            {
                resultado = num * Potencia(num, potencia - 1);
            }

            return resultado;
        }
    }
}
