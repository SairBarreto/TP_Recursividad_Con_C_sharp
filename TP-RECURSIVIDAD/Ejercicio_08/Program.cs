using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir una función recursiva Mayúsculas(unString)->otro string
            //igual pero en mayusculas.Tratar el strings como un vector de
            //caracteres.Ejemplo Mayúscula(“hola”) -> Hola.

            Console.Write("Ingrese un texto pasarlo a MAYUSCULA: ");
            string texto = Console.ReadLine();

            Console.WriteLine($"\nEl texto ingresado en MAYUSCULA es: {Mayuscula(texto)}");
            Console.ReadKey();
        }

        static string Mayuscula(string texto)
        {
            int longitud = texto.Length;

            if (string.IsNullOrEmpty(texto))
            {
                return texto;
            }
            else
            {
                char devolver = char.ToUpper(texto.First());
                //Mayuscula(texto.Substring(1));
                return devolver + Mayuscula(texto.Remove(0, 1));
            }
        }
    }
}
