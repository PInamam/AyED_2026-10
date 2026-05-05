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

            double gastoAcumulado = 0;
            double gasto = 0;
            int contador = 0;

            for (int i = 1; i < 6; i++)
            {
                Console.Write("Ingrese el gasto N°" + i + " del dia: ");
                gasto = Convert.ToDouble(Console.ReadLine());
                gastoAcumulado = gastoAcumulado + gasto;

                if (gasto > 500)
                {
                    contador++;
                }
            }

            Console.WriteLine("Gasto total: $" + gastoAcumulado);

            Console.WriteLine("Gastos superiores a $500: " + contador);
        }
    }
}
