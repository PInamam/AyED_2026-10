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

            int[] rifasVendidas = new int[15];

            for (int i = 0; i < rifasVendidas.Length; i++)
            {
                bool check;
                do
                {
                    Console.Write((i + 1) + ". Numero de rifa vendida: ");
                    rifasVendidas[i] = Convert.ToInt32(Console.ReadLine());
                    check = false;
                    if (rifasVendidas[i] > 99 || rifasVendidas[i] < 1)
                    {
                        Console.WriteLine("Ingrese un numero del 0 al 99");
                    } else
                    {
                        for (int j = 0; j < rifasVendidas.Length; j++)
                        {
                            if (i != j)
                            {
                                if (rifasVendidas[i] == rifasVendidas[j])
                                {
                                    check = true;
                                    Console.WriteLine("Numero repetido");
                                }
                            }
                        }
                    }
                }
                while (rifasVendidas[i] > 99 || rifasVendidas[i] < 1 || check == true);
            }

            Console.Write("\nIngrese un numero de rifa: ");
            int rifaUsuario = Convert.ToInt32(Console.ReadLine());
            bool rifaVendida = false;
            for (int i = 0; i < rifasVendidas.Length; i++)
            {
                if (rifasVendidas[i] == rifaUsuario)
                {
                    rifaVendida = true;
                }
            }

            if (rifaVendida == true)
            {
                Console.WriteLine("El numero " + rifaUsuario + " ya fue vendido");
            } else
            {
                Console.WriteLine("El numero " + rifaUsuario + " esta disponible");
            }

        }
    }
}
