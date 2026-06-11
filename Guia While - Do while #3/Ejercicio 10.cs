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

            int creditos = 100;
            int creditosApostados;
            int dado1;
            int dado2;
            int sumaDados;

            do
            {
                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("Creditos disponibles: " + creditos);
                    Console.Write("¿Cuantos creditos desea apostar?(0 para retirarse): ");
                    creditosApostados = Convert.ToInt32(Console.ReadLine());
                    if (creditosApostados > creditos)
                    {
                        Console.WriteLine("Creditos insuficientes");
                    }
                    else if (creditosApostados < 0)
                    {
                        Console.WriteLine("No puedes apostar creditos negativos");
                    }
                }
                while (creditosApostados > creditos || creditosApostados < 0);

                if (creditosApostados == 0)
                {
                    Console.WriteLine("Usted ha decidido retirarse");
                    break;
                }

                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("Introduzca un numero del 1 al 6");
                    Console.Write("Dado 1: ");
                    dado1 = Convert.ToInt32(Console.ReadLine());
                }
                while (dado1 < 1 || dado1 > 6);

                do
                {
                    Console.WriteLine("");
                    Console.WriteLine("Introduzca un numero del 1 al 6");
                    Console.Write("Dado 2: ");
                    dado2 = Convert.ToInt32(Console.ReadLine());
                }
                while (dado1 < 1 || dado2 > 6);

                sumaDados = dado1 + dado2;

                if (sumaDados == 7 || sumaDados == 11)
                {
                    creditos = creditos + creditosApostados;
                    Console.WriteLine("Creditos ganados: " + creditosApostados);
                }
                else
                {
                    creditos = creditos - creditosApostados;
                    Console.WriteLine("Creditos perdidos: " + creditosApostados);
                }

            }
            while (creditos > 0);

            Console.WriteLine("");
            Console.WriteLine("Saldo final: " + creditos);

        }
    }
}
