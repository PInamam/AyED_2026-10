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

            int[] edades = new int[12];
            int menoresDeEdad = 0;
            int adultosMayores = 0;
            int rangoIntermedio = 0;

            for (int i = 0; i < edades.Length; i++)
            {
                do
                {
                    Console.Write("Edad de la persona " + (i + 1) + ": ");
                    edades[i] = Convert.ToInt32(Console.ReadLine());
                    if (edades[i] < 0)
                    {
                        Console.WriteLine("Edad no valida");
                    }
                    else
                    {
                        if (edades[i] < 18)
                        {
                            menoresDeEdad++;
                        }
                        else if (edades[i] < 65)
                        {
                            rangoIntermedio++;
                        }
                        else
                        {
                            adultosMayores++;
                        }
                    }

                }
                while (edades[i] < 0);
            }

            Console.WriteLine("\nMenores de edad(0-17): " + menoresDeEdad);
            Console.WriteLine("Rango intermedio(18-64): " + rangoIntermedio);
            Console.WriteLine("Mayores de edad(65+): " + adultosMayores);

        }
    }
}