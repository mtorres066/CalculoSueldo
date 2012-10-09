using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Sacar el trimestre del año

//Uso de "||" es el equivalente al OR
//Es true si se cumple cualquiera de las opciones, si alguna es true entonces es True la respuesta

namespace CondicionCompuesta2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, año;
            string linea;
            Console.Write("Ingrese nro de día:");
            linea = Console.ReadLine();
            dia = int.Parse(linea); ;
            Console.Write("Ingrese nro de mes:");
            linea = Console.ReadLine();
            mes = int.Parse(linea);
            Console.Write("Ingrese nro de año:");
            linea = Console.ReadLine();
            año = int.Parse(linea);
            //Se traduce: mes es igual a 1? Or mes es igual a 2? O mes es igual a 3?
            if (mes == 1 || mes == 2 || mes == 3)
            {
                Console.Write("Corresponde al primer trimestre");
            }
            Console.ReadLine();
        }
    }
}
