using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese un numero entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero%2 == 0)
            {
                Console.WriteLine("El numero " + numero + " es par.");
            }
            else
            {
                Console.WriteLine("El numero " + numero + " no es par.");
            }
        }
    }
}