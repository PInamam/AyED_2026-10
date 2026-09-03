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

            Console.WriteLine("Ingrese 10 numeros enteros");
            for (int i  = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese el numero n°" + (i + 1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nMayor: " + NumeroMayor(numeros));
            Console.WriteLine("Menor: " + NumeroMenor(numeros));
            Console.WriteLine("Promedio: " + Promedio(numeros));
            Console.WriteLine("Pares: " + CantidadPares(numeros));
            Console.WriteLine("Impares: " + (numeros.Length - CantidadPares(numeros)));

        }

        static int NumeroMayor(int[] numeros)
        {
            int mayor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (mayor < numeros[i])
                {
                    mayor = numeros[i];
                }
            }

            return mayor;
        }


        static int NumeroMenor(int[] numeros)
        {
            int menor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (menor > numeros[i])
                {
                    menor = numeros[i];
                }
            }

            return menor;
        }



        static double Promedio(int[] numeros)
        {
            double total = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                total += numeros[i];
            }

            double promedio = total / numeros.Length;

            return promedio;
        }


        static int CantidadPares(int[] numeros)
        {
            int pares = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if(numeros[i]%2 == 0)
                {
                    pares++;
                }
            }

            return pares;
        }

    }
}
