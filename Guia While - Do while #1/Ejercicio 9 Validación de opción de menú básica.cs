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

            bool opcionSalir = false;

            while (opcionSalir == false)
            {
                Console.WriteLine("");
                Console.WriteLine("MENU");
                Console.WriteLine("1. Saludar");
                Console.WriteLine("2. Despedir");
                Console.WriteLine("3. Salir");
                Console.Write("Elija una opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Hola");
                        break;

                    case "2":
                        Console.WriteLine("Hasta luego");
                        break;

                    case "3":
                        opcionSalir = true;
                        break;

                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            }


        }
    }
}
