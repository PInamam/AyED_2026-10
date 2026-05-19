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
            int contador = 1;
            double nota;
            double notas = 0;
            double promedioNotas;

            while (contador <= 5)
            {
                Console.Write("Ingrese la nota del alumno n°" + contador + ": ");
                nota = Convert.ToDouble(Console.ReadLine());
                notas = notas + nota;
                contador++;
            }

            promedioNotas = notas / 5;
            Console.WriteLine("Promedio: " + promedioNotas);
            
        }
    }
}
