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


            Console.Write("Ingrese una temperatura inicial: ");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            while (temperatura > 24)
            {
                temperatura = temperatura - 2;
                Console.WriteLine("Enfriando... Temperatura actual: " + temperatura + "°C");
            }

            Console.WriteLine("Temperatura ideal alcanzada");
            
        }
    }
}
