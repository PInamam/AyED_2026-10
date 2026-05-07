using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese un numero a verificar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int resto = 0;
            int contador = 0;
            bool primerDivisorEncontrado = false;
            int divisor = 0;

            for (int i = 2; i < numero; i++)
            {
                resto = numero % i;

                if (resto == 0)
                {
                    contador++;
                    if (primerDivisorEncontrado == false)
                    {
                        divisor = i;
                        primerDivisorEncontrado = true;
                    }
                }
            }

            if (contador > 0)
            {
                Console.WriteLine("El numero " + numero + " no es primo");
                Console.WriteLine("El primer divisor es " + divisor);
            }
            else
            {
                Console.WriteLine("El numero " + numero + " es primo");
            }
            
        }
    }
}