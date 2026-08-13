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

            double[] sucursalUno = new double[5];
            double[] sucursalDos = new double[5];

            double recaudacionSucursalUno = 0;
            double recaudacionSucursalDos = 0;

            Console.WriteLine("SUCURSAL 1");
            for (int i = 0; i < sucursalUno.Length; i++)
            {
                Console.Write("Ventas del dia " + (i + 1) + ": $");
                sucursalUno[i] = Convert.ToDouble(Console.ReadLine());
                recaudacionSucursalUno += sucursalUno[i];
            }

            Console.WriteLine("\nSUCURSAL 2");
            for (int i = 0; i < sucursalDos.Length; i++)
            {
                Console.Write("Ventas del dia " + (i + 1) + ": $");
                sucursalDos[i] = Convert.ToDouble(Console.ReadLine());
                recaudacionSucursalDos += sucursalDos[i];
            }

            Console.WriteLine("");

            for(int i = 0; i < sucursalUno.Length; i++)
            {
                if (sucursalUno[i] > sucursalDos[i])
                {
                    Console.WriteLine("Sucursal que vendio mas el dia " + (i + 1) + ": Sucursal 1");

                } else
                {
                    Console.WriteLine("Sucursal que vendio mas el dia " + (i + 1) + ": Sucursal 2");
                }
            }

            if (recaudacionSucursalUno > recaudacionSucursalDos)
            {
                Console.WriteLine("\nSucursal que mas recaudo en total: Sucursal 1");
            } else
            {
                Console.WriteLine("\nSucursal que mas recaudo en total: Sucursal 2");
            }

        }
    }
}
