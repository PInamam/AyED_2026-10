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

            Console.Write("Ingrese la cantidad de facturas producidas: ");
            int facturasProducidas = Convert.ToInt32(Console.ReadLine());

            Console.Write("¿Cuantas docenas completas(12 unidades) se vendieron?: ");
            int docenasVendidas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el precio por docena: ");
            double precioDocena = Convert.ToDouble(Console.ReadLine());

            int facturasVendidas = docenasVendidas * 12;
            int facturasSobrantes = facturasProducidas - facturasVendidas;
            double dineroRecaudado = docenasVendidas * precioDocena;

            if (facturasVendidas > facturasProducidas)
            {
                Console.WriteLine("Error: Mas facturas vendidas que producidas.");
            } else
            {
                Console.WriteLine("Dinero total recaudado: $" + dineroRecaudado);
                Console.WriteLine("Facturas sobrantes: " + facturasSobrantes);
                if (facturasSobrantes > 6)
                {
                    Console.WriteLine("Alerta: Exceso de producción.");
                }
                else
                {
                    Console.WriteLine("Producción eficiente.");
                }
            }

           
        }
    }
}

