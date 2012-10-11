using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Es un While hasta que el ciclo sea mayor al numero ingresado

// n = 5  (Numero ingresado, inicia el While)
// x = 1  (Se imprime el contenido de x)
//     2  (Se imprime el contenido de x)
//     3  (Se imprime el contenido de x)"		"
//     4  (Se imprime el contenido de x)"		"
//     5  (Se imprime el contenido de x)"		"
//     6  (Sale del while porque 6 no es menor o igual a 5)

namespace EstructuraRepetitivaWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            string linea;
            Console.Write("Ingrese el valor final:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            x = 1;
            while (x <= n)
            {
                Console.Write(x);
                Console.Write(" - ");
                x = x + 1;
            }
            Console.ReadKey();
        }
    }
}
