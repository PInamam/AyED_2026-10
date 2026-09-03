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

            int[] numeros = new int[10];

            Console.WriteLine("Ingrese 10 numeros enteros\n");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese el numero n°" + (i + 1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int cantidadPositivos = CantidadPositivos(numeros);
            int cantidadNegativos = CantidadNegativos(numeros);
            int igualesACero = IgualesCero(numeros);

            Console.WriteLine("\nPositivos: " + cantidadPositivos);
            Console.WriteLine("Negativos: " + cantidadNegativos);
            Console.WriteLine("Iguales a cero: " + igualesACero);
            Console.WriteLine("Promedio positivos: " + PromedioPositivos(numeros, cantidadPositivos));
            Console.WriteLine("Promedio negativos: " + PromedioNegativos(numeros, cantidadNegativos));

        }

        static int CantidadNegativos(int[] numeros)
        {
            int negativos = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    negativos++;
                }
            }

            return negativos;
        }

        static double PromedioNegativos(int[] numeros, int cantNegativos)
        {
            double acumulador = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    acumulador += numeros[i];
                }
            }

            double promedio = acumulador / cantNegativos;

            return promedio;
        }

        static int CantidadPositivos(int[] numeros)
        {
            int positivos = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    positivos++;
                }
            }

            return positivos;
        }

        static double PromedioPositivos(int[] numeros, int cantPositivos)
        {
            double acumulador = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0)
                {
                    acumulador += numeros[i];
                }
            }

            double promedio = acumulador / cantPositivos;

            return promedio;
        }

        static int IgualesCero(int[] numeros)
        {
            int igualesCero = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == 0)
                {
                    igualesCero++;
                }
            }

            return igualesCero;
        }

    }
}
