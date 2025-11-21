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
            char[] a1 = { 'a', 'b', 'c' };

            char[] a2 = new char[] { 'a', 'b', 'c' };

            char[] a3 = new char[3];
            a3[0] = 'a';
            a3[1] = 'b';
            a3[2] = 'c';

            Console.WriteLine("Tamaño de a1: " + a1.Length);
            Console.WriteLine("Tamaño de a2: " + a2.Length);
            Console.WriteLine("Tamaño de a3: " + a3.Length);

            Console.ReadLine();
        }
    }
}
