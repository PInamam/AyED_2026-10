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

            Console.Write("Ingrese su peso en kg: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese su altura en metros: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura*altura);

            if (imc > 25)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Rango normal");
            }

        }
    }
}
