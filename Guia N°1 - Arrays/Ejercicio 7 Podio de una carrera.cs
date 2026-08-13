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

            double[] tiempos = new double[6];
            double peorTiempo = 0;
            double peorTiempoIndice = 0;
            double mejorTiempo = 0;
            double mejorTiempoIndice = 0;

            for (int i = 0; i < tiempos.Length; i++)
            {
                Console.Write("Ingrese el tiempo el corredor " + (i + 1) + ": ");
                tiempos[i] = Convert.ToDouble(Console.ReadLine());
                if (i == 0)
                {
                    peorTiempo = tiempos[i];
                    peorTiempoIndice = i;
                    mejorTiempo = tiempos[i];
                    mejorTiempoIndice = i;
                }
                if (i > 0)
                {
                    if (tiempos[i] > peorTiempo)
                    {
                        peorTiempo = tiempos[i];
                        peorTiempoIndice = i;
                    }
                    if (tiempos[i] < mejorTiempo)
                    {
                        mejorTiempo = tiempos[i];
                        mejorTiempoIndice = i;
                    }
                }
            }

            Console.WriteLine("\nMejor tiempo: " + mejorTiempo);
            Console.WriteLine("Corredor N°" + mejorTiempoIndice);

            Console.WriteLine("\nPeor tiempo: " + peorTiempo);
            Console.WriteLine("Corredor N°" + peorTiempoIndice);

        }
    }
}
