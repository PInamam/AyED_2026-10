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

            Console.Write("Ingrese su sueldo: ");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese sus años de antiguedad: ");
            double añosAntiguedad = Convert.ToDouble(Console.ReadLine());

            double aumento, sueldoNuevo;

            if (añosAntiguedad > 10)
            {
                aumento = sueldo * 20 / 100;
                sueldoNuevo = sueldo + aumento;
                Console.WriteLine("Sueldo nuevo: $" + sueldoNuevo);
            }
            else
            {
                aumento = sueldo * 5 / 100;
                sueldoNuevo = sueldo + aumento;
                Console.WriteLine("Sueldo nuevo: $" + sueldoNuevo);
            }
        }
    }
}
