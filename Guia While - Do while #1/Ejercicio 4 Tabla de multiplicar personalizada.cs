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
            int contador = 1;

            Console.Write("Ingrese un numero entero positivo: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            while (contador <= 12)
            {
                Console.WriteLine(numero + " x " + contador + " = " + (numero * contador));
                contador++;
            }

        }
    }
}
