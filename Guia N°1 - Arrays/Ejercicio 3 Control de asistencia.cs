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

            string[] asistencias = new string[20];

            int ausentes = 0;

            for (int i = 0; i < asistencias.Length; i++)
            {
                do
                {
                    Console.Write("Clase " + (i + 1) + "(A/P): ");
                    asistencias[i] = Console.ReadLine();
                }
                while (asistencias[i] != "A" && asistencias[i] != "P" && asistencias[i] != "a" && asistencias[i] != "p");

                if (asistencias[i] == "A" || asistencias[i] == "a")
                {
                    ausentes++;
                }
            }

            Console.WriteLine("\nInasistencias: " + ausentes);
            if (ausentes > 6)
            {
                Console.WriteLine("Libre por inasistencias");
            } else
            {
                Console.WriteLine("Regular");
            }

        }
    }
}
