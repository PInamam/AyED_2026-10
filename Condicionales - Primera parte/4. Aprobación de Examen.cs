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

            Console.Write("Ingrese la nota de un examen: ");
            double notaExamen = Convert.ToDouble(Console.ReadLine());

            if (notaExamen >= 7)
            {
                Console.WriteLine("Promocionado.");
            }
            else if (notaExamen >= 4)
            {
                Console.WriteLine("A finales.");
            }
            else
            {
                Console.WriteLine("Recuperatorio.");
            }

        }
    }
}
