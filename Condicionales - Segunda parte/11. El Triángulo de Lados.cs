using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese el primer lado del triangulo: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo lado del triangulo: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el tercer lado del triangulo: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());

            if (lado1 == lado2)
            {
                if (lado1 == lado3)
                {
                    Console.WriteLine("Equilatero");
                }
                else
                {
                    Console.WriteLine("Isosceles");
                }
            }
            else if (lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Isosceles");
            }
            else
            {
                Console.WriteLine("Escaleno");
            }

        }
    }
}
