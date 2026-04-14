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

            double peso, sobrePeso;
            Console.Write("Ingrese el peso de la carga actual: ");
            peso = Convert.ToDouble(Console.ReadLine());

            if (peso <= 5000)
            {
                Console.WriteLine("Despegue autorizado. Buen viaje, Mando");
            }
            else {
                sobrePeso = peso - 5000;
                Console.WriteLine("Alerta: Exceso de peso. Debes descargar " + sobrePeso + "kg para despegar");
            }
            

        }
    }
}
