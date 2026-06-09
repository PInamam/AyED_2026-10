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
            int numero = 1000000;
            int minNumero = 1000000;

            do
            {
                if (numero < minNumero)
                {
                    minNumero = numero;
                }
                Console.Write("Ingrese un numero entero positivo: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            while (numero >= 0) ;

            Console.WriteLine("");
            Console.WriteLine("Numero mas chico: " + minNumero);

        }
    }
}
