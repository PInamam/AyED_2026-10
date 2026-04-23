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

            Console.Write("Ingrese la edad del hermano 1: ");
            int hermano1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la edad del hermano 2: ");
            int hermano2 = Convert.ToInt32(Console.ReadLine());

            int diferenciaEdad;

            if (hermano1 > hermano2) {
                diferenciaEdad = hermano1 - hermano2;
                Console.WriteLine("El hermano 1 es el mayor,  le pasa por " + diferenciaEdad + " años al hermano2.");
            }
            else {
                diferenciaEdad = hermano2 - hermano1;
                Console.WriteLine("El hermano 2 es el mayor,  le pasa por " + diferenciaEdad + " años al hermano1.");
            }
            
        }
    }
}
