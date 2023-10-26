using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programe un método recursivo que transforme un número expresado en notación binaria a un número entero.

            Console.Write("Ingrese un número en notación binaria: ");
            string binario = Console.ReadLine();

            if (EsBinarioValido(binario))
            {
                int decimalResultado = BinarioAEntero(binario);
                Console.WriteLine($"\nEl número binario {binario} es equivalente a {decimalResultado} en decimal.");
            }
            else
            {
                Console.WriteLine("\nEl número binario ingresado no es válido.");
            }

            Console.ReadKey();
        }

        static bool EsBinarioValido(string binario)
        {
            // Verifica que todos los caracteres del número binario sean '0' o '1'.
            foreach (char digito in binario)
            {
                if (digito != '0' && digito != '1')
                {
                    return false;
                }
            }
            return true;
        }

        static int BinarioAEntero(string binario)
        {
            // Caso base: si la cadena binaria es vacía, el valor decimal es 0.
            if (string.IsNullOrEmpty(binario))
            {
                return 0;
            }

            // Obtiene el último dígito de la cadena.
            char ultimoDigito = binario.Last();

            // Convierte el dígito a entero ('0' -> 0, '1' -> 1).
            int valorDigito = ultimoDigito - '0';

            // Recursivamente, multiplica el valor del dígito por 2 elevado a la posición y suma el resultado.
            return valorDigito + 2 * BinarioAEntero(binario.Substring(0, binario.Length - 1));
        }
    }
}
