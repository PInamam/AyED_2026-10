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

            double[] notas = new double[10];

            double aprobados = 0;
            double desaprobados = 0;
            double acumuladorNotas = 0;
            double promedioNotas;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write("Ingrese la nota " + (i + 1) + ": ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                acumuladorNotas += notas[i];

                if (notas[i] >= 6)
                {
                    aprobados++;
                } else
                {
                    desaprobados++;
                }
               
            }

            promedioNotas = acumuladorNotas / notas.Length;

            Console.WriteLine("");
            Console.WriteLine("Aprobados: " + aprobados);
            Console.WriteLine("Desaprobados: " + desaprobados);
            Console.WriteLine("Promedio de Notas: "+ promedioNotas);

        }
    }
}
