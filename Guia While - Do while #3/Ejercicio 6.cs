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

            double precioProducto = 1;
            double montoAcumulado = 0;

            while (precioProducto != 0)
            {
                Console.Write("Precio producto: $");
                precioProducto = Convert.ToDouble(Console.ReadLine());
                montoAcumulado = montoAcumulado + precioProducto;
            }

            if (montoAcumulado > 15000)
            {
                double descuento = montoAcumulado * 0.10;
                double montoFinal = montoAcumulado - descuento;
                Console.WriteLine("Subtotal: $" + montoAcumulado);
                Console.WriteLine("Descuento aplicado: $" + descuento);
                Console.WriteLine("Total final a pagar: $" + montoFinal);
            }
            else
            {
                Console.WriteLine("Total final a pagar: $" + montoAcumulado);
            }
   
        }
    }
}
