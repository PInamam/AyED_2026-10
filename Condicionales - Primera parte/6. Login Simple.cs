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

            Console.Write("Nombre de usuario: ");
            string usuario = Console.ReadLine();

            Console.Write("Contraseña: ");
            string contraseña = Console.ReadLine();

            if (usuario == "admin" && contraseña == "1234")
            {
                Console.WriteLine("Acceso concedido.");
            }
            else
            {
                Console.WriteLine("Error de credenciales.");
            }

        }
    }
}