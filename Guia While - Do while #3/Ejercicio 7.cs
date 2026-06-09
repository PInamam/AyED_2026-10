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
            string nombreAlumno;
            string estadoAlumno;
            string opcion = "";
            int cantPresentes = 0;
            int cantAusentes = 0;
            int totalAlumnos = 0;

            do
            {
                Console.Write("Nombre alumno: ");
                nombreAlumno = Console.ReadLine();
                do
                {
                    Console.Write("Estado (P/A): ");
                    estadoAlumno = Console.ReadLine();
                }
                while (estadoAlumno != "P" && estadoAlumno != "A");
                totalAlumnos++;

                if (estadoAlumno == "P")
                {
                    cantPresentes++;
                }
                else
                {
                    cantAusentes++;
                }

                do
                {
                    Console.Write("Desea cargar otro alumno?(S/N): ");
                    opcion = Console.ReadLine();
                }
                while (opcion != "S" && opcion != "N");
            }
            while (opcion == "S");


            double porcentajePresentismo = cantPresentes * 100 / totalAlumnos;

            Console.WriteLine("");
            Console.WriteLine("Total alumnos: " + totalAlumnos);
            Console.WriteLine("Presentes: " + cantPresentes);
            Console.WriteLine("Ausentes: " + cantAusentes);
            Console.WriteLine("Presentismo: " + porcentajePresentismo + "%");

        }
    }
}
