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

            Console.Write("Cuantas horas dejo su auto: ");
            int tiempoEstacionamiento = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Con cuanto dinero va a pagar?: ");
            double dinero = Convert.ToDouble(Console.ReadLine());

            double totalPagar;
            if (tiempoEstacionamiento > 1)
            {
                totalPagar = 4000 + ((tiempoEstacionamiento - 1) * 1600);
            }
            else
            {
                totalPagar = 4000;
            }

            Console.WriteLine("Total a pagar: $" + totalPagar);

            if (dinero >= totalPagar)
            {
                double vuelto = dinero - totalPagar;
                Console.WriteLine("Vuelto: $" + vuelto);
            }
            else
            {
                double dineroFaltante = totalPagar - dinero;
                Console.WriteLine("Falta $" + dineroFaltante + " para poder retirar el auto.");
            }

        }
    }
}
