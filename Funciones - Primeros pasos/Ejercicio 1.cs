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
                Console.Write("Ingrese un numero entero positivo para la cuenta regresiva: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            while (num <= 0);
            ContarRegresivo(num);

        }
        static void ContarRegresivo(int a)
        {
            Console.WriteLine("Cuenta regresiva");
            for (int i = a; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
