using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio 4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            char[] arregloNombre = nombre.ToCharArray();

            Console.Write("Bienvenidos ");

            for (int i = 0; i < arregloNombre.Length; i++)
            {
                Console.Write(arregloNombre[i]);
            }

            Console.ReadKey();
        }
    }
}
