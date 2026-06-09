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

            int edad = -1;
            int personasRegistradas = -1;
            int sumaDeEdades = 0;
            int menoresDeEdad = 0;
            int mayoresDeEdad = 0;

            do
            {
                personasRegistradas++;
                sumaDeEdades = sumaDeEdades + edad;
                if (edad >= 18)
                {
                    mayoresDeEdad++;
                }
                else if (edad >= 0)
                {
                    menoresDeEdad++;
                }
                Console.Write("Ingrese edad: ");
                edad = Convert.ToInt32(Console.ReadLine());
            }
            while (edad >= 0);

            double promedioEdades = sumaDeEdades / personasRegistradas;

            Console.WriteLine("");
            Console.WriteLine("Personas registradas: " + personasRegistradas);
            Console.WriteLine("Promedio de edad: " + promedioEdades);
            Console.WriteLine("Mayores de edad: " + mayoresDeEdad);
            Console.WriteLine("Menores de edad: " + menoresDeEdad);

        }
    }
}
