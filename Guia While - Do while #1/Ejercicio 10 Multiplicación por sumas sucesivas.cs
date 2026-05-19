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

            Console.Write("Ingrese un numero entero positivo: ");
            int numeroA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese otro numero entero positivo: ");
            int numeroB = Convert.ToInt32(Console.ReadLine());


            int acumulador = 0;
            int contador = 1;

            while (contador <= numeroB)
            {
                acumulador = acumulador + numeroA;
                contador++;
            }
            Console.WriteLine("Resultado final: ");
            Console.WriteLine(numeroA + " x " + numeroB + " = " + acumulador);

        }
    }
}
