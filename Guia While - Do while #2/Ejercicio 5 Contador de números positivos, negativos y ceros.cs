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

            string ingreso;
            int numeroIngresado;
            bool detenerBucle = false;
            int contadorPositivos = 0;
            int contadorCeros = 0;
            int contadorNegativos = 0;

            while (detenerBucle == false)
            {
                Console.Write("Numero: ");
                ingreso = Console.ReadLine();

                if (ingreso == "r" || ingreso == "R" || ingreso == "n" || ingreso == "N")
                {
                    detenerBucle = true;
                }
                else
                {
                    numeroIngresado = Convert.ToInt32(ingreso);

                    if (numeroIngresado > 0)
                    {
                        contadorPositivos++;
                    }
                    else if(numeroIngresado == 0)
                    {
                        contadorCeros++;
                    }
                    else
                    {
                        contadorNegativos++;
                    }
                }
            }

            Console.WriteLine("Positivos: " + contadorPositivos);
            Console.WriteLine("Ceros: " + contadorCeros);
            Console.WriteLine("Negativos: " + contadorNegativos);

        }
    }
}
