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

            Console.Write("Ingrese la temperatura actual: ");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            if (temperatura > 15)
            {
                Console.WriteLine("Clima agradable.");
            }
            else if (temperatura >= 0)
            {
                Console.WriteLine("Mucho frio.");
            }
            else
            {
                Console.WriteLine("Peligro de congelamiento.");
            }
        }
    }
}