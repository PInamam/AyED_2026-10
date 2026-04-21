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

            Console.Write("Ingrese su promedio: ");
            double promedio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la distancia de su casa a la facultad(km): ");
            double distancia = Convert.ToDouble(Console.ReadLine());

            if (promedio > 8 || distancia > 50)
            {
                Console.WriteLine("Beca concedida.");
            }


        }
    }
}
