using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstructuraCondicionalCompuesta1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string linea;
            Console.Write("Ingrese primer valor:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese segundo valor:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            //SE REALIZA UNA COMPARACION DE LOS VALORES DE LAS VARIABLES
            //CAPTURADAS DESDE CONSOLA.
            if (num1 > num2)
            {
                //EN CASO DE QUE NUM1 SI SEA MAYOR A NUM2
                Console.Write(num1);
            }
            else
            {
                Console.Write(num2);
            }
            Console.ReadKey();
        }
    }
}
