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
                Console.Write("Ingrese un número entero mayor o igual a 0: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            while (num < 0);
            int factorial = Factorial(num);
            Console.WriteLine(num + "! = " + factorial);
        }
        static int Factorial(int a)
        {
            int suma = a;
            for (int i = a-1; i > 0; i--)
            {
                suma = suma * i;
            }

            return suma;
        }
    }
}
