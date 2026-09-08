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
            int inicioIngresado = 0;

            Console.Write("Inicio (numero entero): ");
            inicioIngresado = Convert.ToInt32(Console.ReadLine());

            int finIngresado = 0;

            do
            {
                Console.Write("Fin (numero entero): ");
                finIngresado = Convert.ToInt32(Console.ReadLine());
                if (finIngresado <= inicioIngresado)
                {
                    Console.WriteLine("Deberia ingresar un numero mayor a " + inicioIngresado);
                }
            } while (finIngresado <= inicioIngresado);
            int numero = Convert.ToInt32(Console.ReadLine());
        }

        static bool EsPrimo(int numero)
        {
            if (numero < 2)
            {
                return false;
            }
            if (numero == 2)
            {
                return true;
            }

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void FactoresPrimos(int min, int max)
        {
            int contador = 0;
            for (int i = min; i <= max; i++)
            {
                if (EsPrimo(i))
                {
                    Console.WriteLine(i);
                    contador++;
                }
            }
        }
    }
}
