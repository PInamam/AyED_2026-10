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

            double saldo = 10000;
            string opcion = "";
            double deposito = 0;
            double retiro = 0;
            bool salir = false;



            while (salir == false)
            {
                Console.WriteLine("");
                Console.WriteLine("--- MENU ---");
                Console.WriteLine("1. Depositar dinero");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. Ver saldo actual");
                Console.WriteLine("4. Salir");
                Console.Write("Elija una opcion: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("¿Cuanto dinero desea depositar?: $");
                        deposito = Convert.ToDouble(Console.ReadLine());
                        saldo = saldo + deposito;
                        break;

                    case "2":
                        Console.Write("¿Cuanto dinero desea retirar?: $");
                        retiro = Convert.ToDouble(Console.ReadLine());
                        saldo = saldo - retiro;
                        break;

                    case "3":
                        Console.WriteLine("Saldo actual: $" + saldo);
                        break;

                    case "4":
                        salir = true;
                        Console.WriteLine("");
                        Console.WriteLine("Usted ha salido del programa");
                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            }

        }
    }
}
