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

            int numeroSecreto = 42;
            int numeroIngresado;
            int intentos = 0;
            bool numeroSecretoEncontrado = false;

            do
            {
                Console.WriteLine("");
                Console.Write("Ingrese un numero: ");
                numeroIngresado = Convert.ToInt32(Console.ReadLine());
                intentos++;

                if (numeroSecreto < numeroIngresado)
                {
                    Console.WriteLine("El número es menor");
                }
                else if (numeroSecreto > numeroIngresado)
                {
                    Console.WriteLine("El número es mayor");
                }
                else
                {
                    numeroSecretoEncontrado = true;
                }
            }
            while (intentos < 5 && numeroSecretoEncontrado == false) ;

            Console.WriteLine("");
            if (numeroSecretoEncontrado == true)
            {
                Console.WriteLine("Ganaste");
            }
            else
            {
                Console.WriteLine("Perdiste");  
            }
            Console.WriteLine("El numero secreto era " + numeroSecreto);
            Console.WriteLine("Intentos utilizados: " + intentos);

        }
    }
}
