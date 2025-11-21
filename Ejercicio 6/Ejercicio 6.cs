using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un carácter: ");
            string entrada = Console.ReadLine();

            // Validar que solo se ingrese 1 carácter
            if (entrada.Length != 1)
            {
                Console.WriteLine("Por favor ingresa solo un único carácter.");
                Console.ReadKey();
                return;
            }
            char c = entrada[0];
            if (Char.IsLetter(c))
            {
                Console.WriteLine("El carácter ingresado es una LETRA.");
            }
            else if (Char.IsDigit(c))
            {
                Console.WriteLine("El carácter ingresado es un NÚMERO.");
            }
            else
            {
                Console.WriteLine("El carácter ingresado es un SÍMBOLO.");
            }
            Console.ReadKey();
        }
    }
}
