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

            Console.Write("Ingrese un numero limite entero y positivo: ");
            int limite = Convert.ToInt32(Console.ReadLine());

            int contador = 2;
            Console.WriteLine("Numeros Pares:");
            while (contador <= limite)
            {
                if (contador%2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador++;
            }

        }
    }
}
