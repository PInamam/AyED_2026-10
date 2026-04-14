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

            int midiclorianos;
            Console.Write("ingrese la cantidad de midiclorianos detectados en el sujeto: ");
            midiclorianos = Convert.ToInt32(Console.ReadLine());

            if (midiclorianos > 15000)
            {
                Console.WriteLine("Potencial Maestro Jedi detectado. Avisar al Consejo.");
            }
            else if (midiclorianos >= 5000)
            {
                Console.WriteLine("Aceptable para entrenamiento Padawan.");
            }
            else
            {
                Console.WriteLine("No posee sensibilidad a la Fuerza.");
            }
            

        }
    }
}
