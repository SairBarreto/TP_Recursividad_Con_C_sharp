using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que encuentre la suma de los enteros
            //positivos pares desde N hasta 2.Chequear que si N es impar se
            //imprima un mensaje de error

            Console.Write("Ingrese un número entero positivo (N): ");

            if (int.TryParse(Console.ReadLine(), out int N))
            {
                if (N >= 2)
                {
                    if (N % 2 == 1)
                    {
                        Console.WriteLine("\nError: N es impar. Debe ingresar un número entero positivo par.");
                    }
                    else
                    {
                        int suma = SumaEnterosParesRecursiva(N);
                        Console.WriteLine($"\nLa suma de los enteros positivos pares desde {N} hasta 2 es: {suma}");
                    }
                }
                else
                {
                    Console.WriteLine("\nError: N debe ser un número entero positivo mayor o igual a 2.");
                }
            }
            else
            {
                Console.WriteLine("\nError: Ingrese un número entero válido.");
            }

            Console.ReadKey();
        }

        static int SumaEnterosParesRecursiva(int n)
        {
            if (n == 2)
            {
                return 2;
            }

            return n + SumaEnterosParesRecursiva(n - 2);
        }
    }
}
