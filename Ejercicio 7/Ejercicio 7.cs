using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio 7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos números deseas ingresar?: ");
            int tamaño = int.Parse(Console.ReadLine());

            int[] numeros = IngresarDatos(tamaño);

            Console.WriteLine("\nDatos del Array:");
            ImprimirArray(numeros);

            Console.ReadKey();
        }
        // Función para ingresar datos al array
        static int[] IngresarDatos(int tamaño)
        {
            int[] arreglo = new int[tamaño];

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write("Ingresa el número {0}: ", i + 1);
                arreglo[i] = int.Parse(Console.ReadLine());
            }
            return arreglo;
        }
        // Función para imprimir los datos del array
        static void ImprimirArray(int[] arreglo)
        {
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Elemento {0}: {1}", i, arreglo[i]);
            }
        }
    }
}
