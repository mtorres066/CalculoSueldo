using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Muestra los numeros del 1 al 100
namespace EstructuraRepetitivaWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            //Uso del While (uso repetitivo si se cumple condicion, si es false, termina ciclo repetitivo)
            while (x <= 100)
            {
                //es true la condicion (x es menor o igual a 100)
                Console.Write(x);
                Console.Write(" - ");
                x = x + 1;
            }
            //x es mayor que 100
            Console.ReadKey();
        }
    }
}
