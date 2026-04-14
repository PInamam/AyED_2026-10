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
            int numero = Convert.ToInt32(Console.ReadLine);

            if (numero % 5 == 0)
            {
                Console.WriteLine("Si es divisible por 5");
            }
            else
            {
                Console.WriteLine("No es divisible por 5.");
            }
        }
    }
}