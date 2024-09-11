using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            string texto = " Hola vacas";
            Console.WriteLine(texto.Length);
            Console.WriteLine(texto.Trim());
            Console.WriteLine(texto.ToUpper().Trim());
            Console.WriteLine(texto.ToLower());

            double num1 = 4, num2 = 5;
            Console.WriteLine(Math.Max(num1, num2));
            Console.WriteLine(Math.Min(num1, num2));
            Console.WriteLine("==========");

            double valor = 3.1415;
            Console.WriteLine(Math.Round(valor, 3));

            Console.WriteLine(Math.Sqrt(4));
            Console.ReadKey();
        }
    }
}
