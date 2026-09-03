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

            MostrarNumeros(inicioIngresado, finIngresado);

            Console.WriteLine("\nPares: " + CantidadPares(inicioIngresado, finIngresado));
            Console.WriteLine("Impares: " + CantidadImpares(inicioIngresado, finIngresado));
            Console.WriteLine("Suma de todos los valores: " + SumaDeValores(inicioIngresado, finIngresado));

        }

        static int CantidadPares(int inicio, int fin)
        {
            int pares = 0;

            for (int i = inicio; i <= fin; i++)
            {
                if (i%2 == 0)
                {
                    pares++;
                }
            }

            return pares;
        }

        static int CantidadImpares(int inicio, int fin)
        {
            int impares = 0;

            for (int i = inicio; i <= fin; i++)
            {
                if (i % 2 != 0)
                {
                    impares++;
                }
            }

            return impares;
        }

        static void MostrarNumeros(int inicio, int fin)
        {
            Console.WriteLine("\nNumeros del " + inicio + " al " + fin);
            for (int i = inicio; i <= fin; i++)
            {
                Console.WriteLine(i);
            }
        }

        static int SumaDeValores(int inicio, int fin)
        {
            int acumulador = 0;

            for (int i = inicio; i <= fin; i++)
            {
                acumulador += i;
            }

            return acumulador;
        }

    }
}
