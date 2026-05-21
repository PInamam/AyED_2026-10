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
            double ventaMasAlta = -100;
            double montoVenta;
            double totalRecaudado = 0;
            int ventasRealizadas = 0;
            string opcion;
            bool cerrarPrograma = false;

            while (cerrarPrograma == false)
            {
                Console.WriteLine("");
                Console.Write("Ingrese el monto de la venta: $");
                montoVenta = Convert.ToDouble(Console.ReadLine());
                ventasRealizadas++;
                totalRecaudado = totalRecaudado + montoVenta;
                

                if (montoVenta > ventaMasAlta)
                {
                    ventaMasAlta = montoVenta;
                }

                bool opcionValida = false;
                while (opcionValida == false)
                {
                    Console.Write("Desea continuar ingresando más ventas?(S/N): ");
                    opcion = Console.ReadLine();

                    if (opcion == "N" || opcion == "n")
                    {
                        cerrarPrograma = true;
                        Console.WriteLine("Usted ha salido del programa");
                        opcionValida = true;
                    }
                    else if (opcion == "S" || opcion == "s")
                    {
                        opcionValida = true;
                    }
                    else
                    {
                        opcionValida = false;
                    }
                }


            }

            Console.WriteLine("");
            Console.WriteLine("Total recaudado: $" + totalRecaudado);
            Console.WriteLine("Ventas realizadas: " + ventasRealizadas);
            Console.WriteLine("Monto de la venta más alta registrada: $" + ventaMasAlta);

        }
    }
}
