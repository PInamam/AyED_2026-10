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

            Console.WriteLine("MENU: ");
            Console.WriteLine("(S)ándwich");
            Console.WriteLine("(P)izza");
            Console.WriteLine("(H)amburguesa");
            Console.Write("Ingrese una opcion del menu: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "P":
                    Console.WriteLine("Precio de la Pizza: $10000");
                    break;

                case "S":
                    Console.WriteLine("Precio del Sandwhich: $6000");
                    break;

                case "H":
                    Console.WriteLine("Precio de la Hamburguesa: $8000");
                    break;

                default:
                    Console.WriteLine("Producto no encontrado");
                    break;
            }


        }
    }
}
