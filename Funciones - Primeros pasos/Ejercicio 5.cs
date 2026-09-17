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
            Console.Write("Ingrese la base: ");
            int baseUsuario = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el exponente: ");
            int exponenteUsuario = Convert.ToInt32(Console.ReadLine());

            int resultado = Potencia(baseUsuario, exponenteUsuario);
            Console.WriteLine(baseUsuario + " elevado a la " + exponenteUsuario + " es igual a " + resultado);

        }

        static int Potencia(int basee, int exponente)
        {
            int resultado = 1;
            for (int i = 0; i < exponente; i++)
            {
                resultado = resultado * basee;
            }

            return resultado;
        }

    }
}
