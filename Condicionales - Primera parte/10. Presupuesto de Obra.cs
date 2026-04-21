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

            Console.Write("Ingrese el presupuesto disponible: ");
            double presupuesto = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el costo de los materiales: ");
            double costoMateriales = Convert.ToDouble(Console.ReadLine());

            if (costoMateriales > presupuesto)
            {
                double dineroFaltante = costoMateriales - presupuesto;
                Console.WriteLine("Falta pedir prestado $" + dineroFaltante + " para los materiales");
            }

        }
    }
}
