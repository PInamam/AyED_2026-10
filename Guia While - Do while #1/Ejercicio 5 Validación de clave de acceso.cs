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
            string claveDeAcceso = "hola";
            string claveIngresada = "";

            while (claveDeAcceso != claveIngresada)
            {
                Console.Write("Ingrese una clave de acceso: ");
                claveIngresada = Console.ReadLine();

                if (claveDeAcceso != claveIngresada)
                {
                    Console.WriteLine("Clave de acceso incorrecta.");
                }
            }
            

            Console.WriteLine("Acceso permitido");

        }
    }
}
