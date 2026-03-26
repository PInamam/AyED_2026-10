using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pablo_Mamani_4__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string juego;

            Console.WriteLine("Hola usuario");
            Console.Write("¿Cual es su nombre?: ");
            nombre = Console.ReadLine();
            Console.Write("¿Cual es tu juego favorito?: ");
            juego = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + " .Tu juego favorito es " + juego + " y se juega en consola");


        }
    }
}
