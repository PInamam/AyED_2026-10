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
            double alcanzia = 0;
            double dinero;

            do
            {
                Console.Write("Ingrese el monto a guardar: ");
                dinero = Convert.ToDouble(Console.ReadLine());
                alcanzia = alcanzia + dinero;
            }
            while (dinero != 0);

            Console.WriteLine("Total acumlulado: " + alcanzia);
            

        }
    }
}
