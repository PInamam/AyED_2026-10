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

            int numeroIngresado = 0;
            do
            {
                Console.Write("Ingrese un número entero positivo: ");
                numeroIngresado = Convert.ToInt32(Console.ReadLine());

            } while (numeroIngresado < 0);

            if (EsPerfecto(numeroIngresado))
            {
                Console.WriteLine("El " + numeroIngresado + " es un numero perfecto");
            } else
            {
                Console.WriteLine("El " + numeroIngresado + " no es un numero perfecto");
            }

        }

        static bool EsPerfecto(int numero)
        {
            bool esPerfecto = false;
            int acumulador = 0;

            for (int i = 1; i < numero; i++)
            {
                if (numero%i == 0)
                {
                    acumulador += i;
                }
            }

            if (numero == acumulador)
            {
                esPerfecto = true;
            }

            return esPerfecto;
        }

    }
}
