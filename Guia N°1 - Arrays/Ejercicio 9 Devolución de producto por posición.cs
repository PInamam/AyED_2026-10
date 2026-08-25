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

            double[] precioProdutos = new double[10];
            int indiceProductoRemovido;
            double totalAcumuladoDia = 0;
            double nuevoTotalAcumulado;

            for (int i = 0; i < precioProdutos.Length; i++)
            {
                do
                {
                    Console.Write("Precio del producto n°" + (i + 1) + ": $");
                    precioProdutos[i] = Convert.ToDouble(Console.ReadLine());
                    if (precioProdutos[i] < 0)
                    {
                        Console.WriteLine("Ingrese un numero positivo");
                    }
                    else
                    {
                        totalAcumuladoDia += precioProdutos[i];
                    }
                }
                while (precioProdutos[i] < 0);
            }

            Console.WriteLine("\nTotal acumulado del dia: $" + totalAcumuladoDia);

            do
            {
                Console.Write("\nIngrese la posicion del producto a descontar(1-10): ");
                indiceProductoRemovido = Convert.ToInt32(Console.ReadLine()) - 1;
                if (indiceProductoRemovido < 0 || indiceProductoRemovido > (precioProdutos.Length - 1))
                {
                    Console.WriteLine("Posicion no valida");
                }
            }
            while (indiceProductoRemovido < 0 || indiceProductoRemovido > (precioProdutos.Length - 1));

            nuevoTotalAcumulado = totalAcumuladoDia - precioProdutos[indiceProductoRemovido];

            Console.WriteLine("\nPrecio del producto removido: $" + precioProdutos[indiceProductoRemovido]);
            Console.WriteLine("\nNuevo total acumulado: $" + nuevoTotalAcumulado);

        }
    }
}
