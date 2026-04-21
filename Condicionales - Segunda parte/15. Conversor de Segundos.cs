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

            Console.Write("Ingrese una cantidad de segundos: ");
            int tiempo = Convert.ToInt32(Console.ReadLine());

            if (tiempo >= 60)
            {
                int minutos = tiempo / 60;
                int segundos = tiempo % 60;
                Console.WriteLine("Minutos: " + minutos);
                Console.WriteLine("Segundos: " + segundos);
            }
            else
            {
                
                Console.WriteLine("Segundos: " + tiempo);
            }

        }
    }
}
