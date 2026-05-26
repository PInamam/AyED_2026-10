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

            string nombreUsuarioRegistrado = "Usuario123";
            string contraseñaRegistrada = "1234";

            string nombreUsuarioIngresado;
            string contraseñaIngresada;

            bool datosCorrectos = false;

            int intentos = 0;

            while (intentos < 3 && datosCorrectos == false)
            {
                Console.WriteLine("");
                Console.Write("Nombre de Usuario: ");
                nombreUsuarioIngresado = Console.ReadLine();
                Console.Write("Contraseña: ");
                contraseñaIngresada = Console.ReadLine();

                intentos++;

                if (nombreUsuarioIngresado == nombreUsuarioRegistrado && contraseñaIngresada == contraseñaRegistrada)
                {
                    datosCorrectos = true;
                    Console.WriteLine("Bienvenido al sistema");
                }
            }

            if (intentos >= 3)
            {
                Console.WriteLine("Cuenta bloqueada por seguridad");
            }

        }
    }
}
