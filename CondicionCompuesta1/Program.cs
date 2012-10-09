using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//Saca el numero mayor, despues de capturar en consola 3 valores

//Uso de && como el equivalente al AND en uso del IF


namespace CondicionCompuesta1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se declaran 3 variables en la misma linea
            int num1, num2, num3;
            string linea;
            Console.Write("Ingrese primer valor:");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.Write("Ingrese segundo valor:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.Write("Ingrese tercer valor:");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            //Se pregunta en la misma linea: ¿Es num1 mayor que num2? Y ¿num1 es mayor que num3?
            if (num1 > num2 && num1 > num3)
            {
                //si es True, (num1 es mayor que num2 y num3)
                Console.Write(num1);
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
