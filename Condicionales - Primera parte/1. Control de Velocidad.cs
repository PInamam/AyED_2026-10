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

            Console.Write("Ingrese la velocidad de un vehiculo: ");
            double velocidadVehiculo = Convert.ToDouble(Console.ReadLine());

            if (velocidadVehiculo > 120)
            {
                Console.WriteLine("Multa en camino: Exceso de velocidad.");
            }
            else
            {
                Console.WriteLine("Conducción segura.");
            }

        }
    }
}
