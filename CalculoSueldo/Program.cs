using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculoSueldo
{
    class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            float costoHora;
            float sueldo;
            //VARIABLE TIPO STRING PARA CAPTURAR LO INGRESADO POR TECLADO EN CONSOLA
            string linea;
            Console.Write("Ingrese Horas Trabajadas por el operario:");
            //PASAMOS A LA VARIABLE "linea" LO CAPTURADO EN CONSOLA
            linea = Console.ReadLine();
            //PASAMOS EL VALOR A LA VARIABLE "horasTrabajadas" PREVIO CONVERTIRLA EN "int" CON "Parse"
            horasTrabajadas = int.Parse(linea);
            Console.Write("Ingrese el pago por hora:");
            linea = Console.ReadLine();
            costoHora = float.Parse(linea);
            sueldo = horasTrabajadas*costoHora;
            Console.Write("El Sueldo Total del operario es:");
            Console.Write(sueldo);
            Console.ReadKey();

        }
    }
}
