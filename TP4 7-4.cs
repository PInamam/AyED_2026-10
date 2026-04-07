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
            int a, b;
            Console.Write("Ingrese un numero entero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write(("Ingrese otro numero entero: "));
            b = Convert.ToInt32(Console.ReadLine());

            int rsuma = a + b;
            Console.WriteLine(a + " mas " + b + " es igual a " + rsuma);

            int rresta = a - b;
            Console.WriteLine(a + " menos " + b + " es igual a " + rresta);

            int rmulti = a * b;
            Console.WriteLine(a + " por " + b + " es igual a " + rmulti);

            double a2, b2, rdiv;
            a2 = a;
            b2 = b;
            rdiv = a2 / b2;
            Console.WriteLine(a + " dividido por  " + b + " es igual a " + rdiv);

        }
    }
}
