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
            int sumaTotal = SumarHasta(num);
            Console.WriteLine("Suma total desde el 1 hasta el " + num + ": " + sumaTotal);

        }
        static int SumarHasta(int a)
        {
            int suma = 0;
            for (int i = 1; i <= a; i++)
            {
                suma = suma + i;
            }

            return suma;
        }
    }
}
