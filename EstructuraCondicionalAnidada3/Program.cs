using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Se ingresa por teclado un valor entero, mostrar una leyenda que 
//indique si el número es positivo, nulo o negativo.

namespace EstructuraCondicionalAnidada3
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;
            string linea;
            Console.Write("Ingrese un valor:");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            //Lo nuevo es: comparativa de variable a un numero (==)
            if (num == 0)
            {
                Console.Write("Se ingresó el cero");
            }
            else
            {
                if (num > 0)
                {
                    Console.Write("Se ingresó un valor positivo");
                }
                else
                {
                    Console.Write("Se ingresó un valor negativo");
                }
            }
            Console.ReadKey();

        }
    }
}
