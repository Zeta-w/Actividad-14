using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio 5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa una frase: ");
            string frase = Console.ReadLine();

            char[] arreglo = frase.ToCharArray();

            int contadorVocales = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {
                char c = Char.ToLower(arreglo[i]); 
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    contadorVocales++;
                }
            }
            Console.WriteLine("\nTotal de vocales: " + contadorVocales);

            Console.ReadKey();
        }
    }
}
