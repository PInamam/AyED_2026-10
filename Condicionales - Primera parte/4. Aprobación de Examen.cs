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

            Console.Write("Ingrese el monto de su compra: ");
            double compra = Convert.ToDouble(Console.ReadLine());

            if (compra > 5000)
            {
                double descuento = (20 * compra / 100);
                double montoFinal = compra - descuento;

                Console.WriteLine("Descuento: $" + descuento);
                Console.WriteLine("Total a pagar: $" + montoFinal);
            }
            else
            {
                Console.WriteLine("Total: $" + compra);
            }
        }
    }
}