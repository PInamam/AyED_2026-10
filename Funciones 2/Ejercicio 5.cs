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
            int numeroIngresado = Convert.ToInt32(Console.ReadLine());

            int auxiliar = numeroIngresado;
            int numeroInv = 0;
            int ultimoDigito = 0;
            int contador = 0;

            while(auxiliar > 0)
            {
                ultimoDigito = auxiliar % 10;
                numeroInv = (numeroInv * 10) + ultimoDigito;
                contador++;
                auxiliar = auxiliar / 10;
            }

            Console.WriteLine("Cantitad de digitos: " + contador);
            if (numeroIngresado == numeroInv)
            {
                Console.WriteLine("El numero " + numeroIngresado + " si es capicua");
            }
            else
            {
                Console.WriteLine("El numero " + numeroIngresado + " no es capicua");
            }


        }


    }
}
