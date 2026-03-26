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
            string pelicula;

            Console.WriteLine("Hola usuario");
            Console.Write("¿Cual es su nombre?: ");
            nombre = Console.ReadLine();
            Console.Write("¿Cual es tu pelicula favorita?: ");
            pelicula = Console.ReadLine();

            Console.WriteLine("Hola " + nombre + " .Tu pelicula preferida " + pelicula + " es una porqueria");


        }
    }
}
