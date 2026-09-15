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

            Console.Write("Cuantos numeros enteros desea ingresar?: ");
            int cantidadNumerosIngresados = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[cantidadNumerosIngresados];

            for(int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Ingrese el numero N°" + (i + 1) + ": ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int maxApariciones = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                int apariciones = 0;
                for(int j = 0; j < numeros.Length; j++)
                {
                    if (numeros[i] == numeros[j])
                    {
                        apariciones++;
                    }
                }
                if (apariciones >= maxApariciones)
                {
                    maxApariciones = apariciones;
                }
            }


            for (int i = 0; i < numeros.Length; i++)
            {
                bool primeraAparicion = true;
                int cont = 0;

                for (int k = 0; k < i; k++)
                {
                    if (numeros[k] == numeros[i])
                    {
                        primeraAparicion = false;
                    }
                }

                if (primeraAparicion)
                {
                    for (int j = 0; j < numeros.Length; j++)
                    {
                        if (numeros[i] == numeros[j])
                        {
                            cont++;
                            if (cont == maxApariciones)
                            {
                                Console.WriteLine("El numero " + (numeros[i]) + " aparece " + maxApariciones + " veces");
                            }
                        }

                    }
                }
            }
        }
    }
}
