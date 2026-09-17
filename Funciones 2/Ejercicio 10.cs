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
            SumaNumerosConsecutivos(numeroIngresado);

        }

        static void SumaNumerosConsecutivos(int numero)
        {
            bool esValido = false;
            for(int i = 1; i <= numero/2; i++)
            {
                int acumulador = 0;
                for (int j = i; acumulador < numero; j++)
                {
                    acumulador = acumulador + j;
                    if (acumulador == numero)
                    {
                        MostrarSuma(numero, i);
                        esValido = true;
                    }
                }
            }
            if (esValido == false)
            {
                Console.WriteLine("El numero " + numero + " no se puede representar como la suma de numeros consecutivos");
            }
        }
    
        static void MostrarSuma(int numero, int inicio)
        {
            int contador = inicio;
            Console.Write(numero + " = " + inicio);
            for (int i = inicio + 1; contador < numero; i++)
            {
                contador += i;
                Console.Write(" + " + i);
            }
            Console.WriteLine("");
        }


    }
}