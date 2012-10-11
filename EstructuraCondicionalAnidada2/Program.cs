using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos.

namespace EstructuraCondicionalAnidada2
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, num3;
            string linea;
            Console.Write("Ingrese primer valor:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese segunda valor:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingrese tercer valor:");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            //Primera Comparativa (Primer IF)
            if (num1 > num2)
            {
                //Si es afirmativo (true)
                //Segunda comparativa (Segundo IF)
                if (num1 > num3)
                {
                    Console.Write(num1);
                }
                else
                {
                    Console.Write(num3);
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.Write(num2);
                }
                else
                {
                    Console.Write(num3);
                }
            }
            Console.ReadKey();

        }
    }
}
