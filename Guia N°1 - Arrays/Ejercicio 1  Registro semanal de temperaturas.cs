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

            double[] temperaturas = new double[7];

            double temperaturaMasAlta = temperaturas[0];
            double temperaturaMasBaja = temperaturas[0];
            double acumuladorTemperatura = 0;
            double temperaturaPromedio;

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.Write("Ingrese la temperatura " + (i + 1) + ": ");
                temperaturas[i] = Convert.ToDouble(Console.ReadLine());
                acumuladorTemperatura += temperaturas[i];
                if (i == 0)
                {
                    temperaturaMasAlta = temperaturas[0];
                    temperaturaMasBaja = temperaturas[0];
                } else
                {
                    if (temperaturas[i] > temperaturaMasAlta)
                    {
                        temperaturaMasAlta = temperaturas[i];
                    }
                    if (temperaturas[i] < temperaturaMasBaja)
                    {
                        temperaturaMasBaja = temperaturas[i];
                    }
                }
               
            }

            temperaturaPromedio = acumuladorTemperatura / temperaturas.Length;

            Console.WriteLine("Temperatura mas alta de la semana: " + temperaturaMasAlta + "°C");
            Console.WriteLine("Temperatura mas baja de la semana: " + temperaturaMasBaja + "°C");
            Console.WriteLine("Temperatura promedio: " + temperaturaPromedio + "°C");

        }
    }
}
