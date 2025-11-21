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
            char[] c;

            Console.Write("* Ingresa mensaje: ");
            c = Console.ReadLine().ToCharArray();

            Console.WriteLine();
            Console.WriteLine("* Mensaje ingresado.");
            Console.WriteLine("Tamaño del array: c[{0}]", c.Length);

            Console.Write("c = ");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write("[{0}]", c[i]);
            }

            Console.ReadKey();
        }
    }
}
