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

            int nota;
            do
            { 
                Console.Write("Ingrese una nota de examen: ");
                nota = Convert.ToInt32(Console.ReadLine());

                if (nota > 10 || nota < 1)
                {
                    Console.WriteLine("El valor ingresado no es valido");
                }           
            }
            while (nota > 10 || nota < 1);

            Console.WriteLine("Nota: " + nota);
            

        }
    }
}
