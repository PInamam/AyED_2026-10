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

            Console.Write("Ingrese su saldo: ");
            double saldo = Convert.ToDouble(Console.ReadLine());

            Console.Write("¿Cuanto dinero desea retirar?:  ");
            double retiro = Convert.ToDouble(Console.ReadLine());

            if (retiro > saldo)
            {
                Console.WriteLine("Fondos insuficientes.");
            }
            else if (retiro%1000 == 0) {
                Console.WriteLine("Extrayendo dinero...");
            }
            else
            {
                Console.WriteLine("Solo billetes de 1000.");
            }
        }
    }
}
