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
            string[] calificaciones = new string[20];
            string[] calificacionesValidas = { "1", "2", "3", "4", "5" };
            int calificacionesUno = 0;
            int calificacionesDos = 0;
            int calificacionesTres = 0;
            int calificacionesCuatro = 0;
            int calificacionesCinco = 0;

            for (int i = 0; i < calificaciones.Length; i++)
            {
                bool calificacionEsValida = false;
                do
                {
                    Console.Write((i + 1) + ". Calificacion (1 al 5): ");
                    calificaciones[i] = Console.ReadLine();
                    
                    foreach (string num in calificacionesValidas)
                    {
                        if (calificaciones[i] == num)
                        {
                            calificacionEsValida = true;
                            break;
                        }
                    }
                    if (calificacionEsValida == false)
                    {
                        Console.WriteLine("Ingrese una calificacion del 1 al 5");
                    }
                } while (calificacionEsValida == false);

                switch (calificaciones[i])
                {
                    case "1":
                        calificacionesUno++;
                        break;
                    case "2":
                        calificacionesDos++;
                        break;
                    case "3":
                        calificacionesTres++;
                        break;
                    case "4":
                        calificacionesCuatro++;
                        break;
                    case "5":
                        calificacionesCinco++;
                        break;
                }
            }

            Console.WriteLine("\nReseñas de 1: " + calificacionesUno);
            Console.WriteLine("Reseñas de 2: " + calificacionesDos);
            Console.WriteLine("Reseñas de 3: " + calificacionesTres);
            Console.WriteLine("Reseñas de 4: " + calificacionesCuatro);
            Console.WriteLine("Reseñas de 5: " + calificacionesCinco);

        }
    }
}
