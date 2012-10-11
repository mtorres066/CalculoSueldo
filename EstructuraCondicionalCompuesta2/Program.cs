using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstructuraCondicionalCompuesta2
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
            if (num1 > num2)
            {
                //En caso de ser afirmativo o "true"
                //se agregan dos variables tipo INT dentro del "IF"
                int suma, diferencia;
                suma = num1 + num2;
                diferencia = num1 - num2;
                Console.Write("La suma de los dos valores es:");
                Console.WriteLine(suma);
                Console.Write("La diferencia de los dos valores es:");
                Console.WriteLine(diferencia);
            }
            else
            {
                //En caso de ser negativo o "false"
                //se agregan dos variables tipo INT dentro del "IF"
                int producto, division;
                producto = num1 * num2;
                division = num1 / num2;
                Console.Write("El producto de los dos valores es:");
                Console.WriteLine(producto);
                Console.Write("La división de los dos valores es:");
                Console.WriteLine(division);
            }
            Console.ReadKey();
        }
    }
}
