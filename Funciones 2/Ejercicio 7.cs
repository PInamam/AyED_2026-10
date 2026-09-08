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
            Console.Write("Ingrese un numero entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            FactoresPrimos(numero);
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

        static void FactoresPrimos(int numero)
        {
            int resto = numero;
            int contador = 0;
            int variable = 2;

            Console.WriteLine("\nFactores primos encontrados:");

            while (resto > 1)
            {
                if (EsPrimo(variable) && resto % variable == 0)
                {
                    resto = resto / variable;
                    Console.WriteLine(variable);
                    contador++;
                }
                else
                {
                    variable++;
                }
            }

            Console.WriteLine("\nCantidad total de factores primos: " + contador);
        }
    }
}
