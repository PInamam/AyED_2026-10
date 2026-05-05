using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            double acumuladorTemperatura = 0;
            double temperatura = 0;
            int contador = 0;

            for (int i = 1; i < 8; i++)
            {
                Console.Write("Ingrese la temperatura del dia " + i + ": ");
                temperatura = Convert.ToDouble(Console.ReadLine());
                acumuladorTemperatura = acumuladorTemperatura + temperatura;

                if (temperatura < 0)
                {
                    contador++;
                }
            }

            Console.WriteLine("La temperatura fue menor a 0°C " + contador + " veces en la semana");
        }
    }
}
