using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //¿Cuál es el resultado de esta función para distintos valores de X?
            //Static int f(int x)
            //{
            //    if (x > 100) { return (x - 10); }
            //    else { return (f(f(x + 11))); }
            //}
            //La funcion lo que hace es que entra recursivamente a si misma, si el numero es menor que 100 entonces entrara en la funcion las veces necesarios hasta superar
            //el valor de 100 y luego se le restara a ese numero 10 asi hasta resolver el ultimo caso que tenga

            Console.Write("Ingrese un valor para X: ");

            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine($"\nEl valor de X despues de pasar por la funcion f es: {f(numero)}");
            }
            else
            {
                Console.WriteLine("\nIngrese un numero valido!!!");
            }

            Console.ReadKey();
        }

        static int f(int x)
        {
            if (x > 100) 
            { 
                return (x - 10); 
            }
            else 
            { 
                return (f(f(x + 11))); 
            }
        }
    }
}
