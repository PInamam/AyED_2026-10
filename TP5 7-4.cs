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
            int costo_minuto, costo_hora;
            costo_minuto = 150;
            costo_hora = 6000;

            int tiempo, horas, minutos;

            Console.Write("Ingrese los minutos que su auto estuvo estacionado: ");
            tiempo = Convert.ToInt32(Console.ReadLine());
            horas = tiempo / 60;
            minutos = tiempo % 60;
            Console.WriteLine("Horas: " + horas);
            Console.WriteLine("Minutos: " + minutos);


            double total, total_a_pagar, iva;
            total = horas * costo_hora + minutos * costo_minuto;
            iva = total * 21 / 100;
            total_a_pagar = total + iva;

            Console.WriteLine("Monto: " + total);
            Console.WriteLine("Monto + IVA: " + total_a_pagar);

        }
    }
}
