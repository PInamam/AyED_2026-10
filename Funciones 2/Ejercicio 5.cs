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

            int[] numeros = new int[5];

            Console.WriteLine("Ingrese 10 numeros enteros");
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese el numero n°" + (i + 1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int mayor = NumeroMayor(numeros);

            Console.WriteLine("Segundo mayor: " + SegundoMayor(numeros, mayor));
        }


        static int NumeroMayor(int[] numeros)
        {
            int mayor = numeros[0];

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
            }

            return mayor;
        }

        static int SegundoMayor(int[] numeros, int mayor)
        {
            int segundoMayor = 0;
            bool check = false;

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] != mayor)
                {
                    segundoMayor = numeros[i];
                    check = true;
                    if (numeros[i] != mayor)
                    {

                        if (segundoMayor < numeros[i])
                        {
                            segundoMayor = numeros[i];
                        }
                }
            }

            return segundoMayor;
       }



    }
}
