using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un función recursiva Aparear(unaLista, otra)->lista de
            //pares(x, y): tal que "x" pertence a "unaLista", e y pertenece a
            //"otra".Ejemplo: Aparear([1, 2, 3], ['a', 'b', 'c'])-> [(1, 'a'), (2, 'b'), (3, 'c')].

            int[] vector1 = { 1, 2, 3 };
            char[] vector2 = { 'a', 'b', 'c' };

            Console.WriteLine($"El vector1 ingresado es: {vector1}");
            Console.WriteLine($"El vector2 ingresado es: {vector2}");

            List<(int, char)> resultado = Aparear(vector1, vector2);

            Console.WriteLine($"\nResultado: ");

            foreach (var par in resultado)
            {
                Console.WriteLine($"({par.Item1}, '{par.Item2}')");
            }

            Console.ReadKey();
        }

        static List<(int, char)> Aparear(int[] vector1, char[] vector2)
        {
            List<(int, char)> resultado = new List<(int, char)>();

            AparearRecursivo(vector1, vector2, 0, 0, resultado);

            return resultado;
        }

        static void AparearRecursivo(int[] vector1, char[] vector2, int indice1, int indice2, List<(int, char)> resultado)
        {
            if (indice1 < vector1.Length && indice2 < vector2.Length)
            {
                resultado.Add((vector1[indice1], vector2[indice2]));
                AparearRecursivo(vector1, vector2, indice1 + 1, indice2 + 1, resultado);
            }
        }
    }
}
