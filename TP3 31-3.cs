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
            int año;
            int edad;

            Console.WriteLine("Hola usuario");
            Console.Write("¿Cual es su año de nacimiento?: ");
            año = Convert.ToInt32(Console.ReadLine());
            edad = 2026 - año;

            Console.WriteLine("Si naciste en el año " + año + " tu edad al comenzar el año es de " + edad + " años.");
        }
    }
}
