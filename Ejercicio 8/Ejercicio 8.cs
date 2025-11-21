using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar frase
            Console.Write("Ingresa una frase: ");
            string frase = Console.ReadLine();

            // Convertir a array de caracteres
            char[] arreglo = frase.ToCharArray();

            // Invertir el array
            Array.Reverse(arreglo);

            // Imprimir array invertido
            Console.WriteLine("\nFrase invertida:");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(arreglo[i]);
            }
            Console.ReadKey();
        }
    }
}
