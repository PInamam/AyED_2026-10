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

            int droides, precioDroide;

            precioDroide = 2000;
            Console.Write("Ingrese la cantidad de droides a comprar: ");
            droides = Convert.ToInt32(Console.ReadLine());

            int totalOriginal;
            totalOriginal = precioDroide * droides;

            if (droides >= 3)
            {
                double descuento = (20 * totalOriginal) / 100;
                double precioFinal = totalOriginal - descuento;

                Console.WriteLine("Total original: $" + totalOriginal);
                Console.WriteLine("Descuento: $" + descuento);
                Console.WriteLine("Precio final: $" + precioFinal);
            }
            else
            {
                Console.WriteLine("Total: $" + totalOriginal);
            }

        }
    }
}
