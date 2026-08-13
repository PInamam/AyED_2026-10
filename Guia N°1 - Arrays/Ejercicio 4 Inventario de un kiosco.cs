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

            double[] precios = new double[8];

            for (int i = 0; i < precios.Length; i++)
            {
                Console.Write("Ingrese el precio del producto " + (i + 1) + ": $");
                precios[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("\nIngrese su presupuesto: $");
            double presupuestoUsuario = Convert.ToDouble(Console.ReadLine());

            int productosAccesibles = 0;

            for (int i = 0; i < precios.Length; i++)
            {
                if (precios[i] <= presupuestoUsuario)
                {
                    productosAccesibles++;
                } 
            }

            Console.WriteLine("\nProductos Accesibles: " + productosAccesibles);

        }
    }
}
