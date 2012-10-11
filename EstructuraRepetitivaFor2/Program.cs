using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Desarrollar un programa que permita la carga de 10 valores por teclado y nos muestre posteriormente la 
//suma de los valores ingresados y su promedio. Este problema ya lo desarrollamos, lo resolveremos empleando la estructura for.

//En este caso, a la variable del for (f) sólo se la requiere para que se repita el bloque de instrucciones 10 veces.


namespace EstructuraRepetitivaFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma, f, valor, promedio;
            string linea;
            //Se le asigna valor cero a la variable arriba definida
            suma = 0;
            //Este FOR solo se ejecutará 10 veces.
            for (f = 1; f <= 10; f++)
            {
                Console.Write("Ingrese valor:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                //Se acumulan los valores capturados en consola
                suma = suma + valor;
            }
            Console.Write("La suma es:");
            Console.WriteLine(suma);
            //Se saca el promedio utilizando la variable "suma"
            promedio = suma / 10;
            Console.Write("El promedio es:");
            Console.Write(promedio);
            Console.ReadKey();
        }
    }
}
