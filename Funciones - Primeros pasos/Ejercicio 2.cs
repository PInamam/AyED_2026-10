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
            int num;
            do
            {
                Console.Write("Ingrese un numero entero positivo: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            while (num <= 0);
            ContarHasta(num);

        }
        static void ContarHasta(int a)
        {
            Console.WriteLine("\nContando hasta " + a);
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
