using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Explicacion: DO ejecuta WHILE Hasta que...

//Escribir un programa que solicite la carga de un número entre 0 y 999, y nos muestre 
//un mensaje de cuántos dígitos tiene el mismo. Finalizar el programa cuando se cargue el valor 0.

namespace EstructuraRepetitivaDoWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            string linea;
            //Inicia el Do While
            do
            {
                Console.Write("Ingrese un valor entre 0 y 999 (0 finaliza):");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor >= 100)
                {
                    Console.WriteLine("Tiene 3 dígitos.");
                }
                else
                {
                    if (valor >= 10)
                    {
                        Console.WriteLine("Tiene 2 dígitos.");
                    }
                    else
                    {
                        Console.WriteLine("Tiene 1 dígito.");
                    }
                }
                //Si el valor capturado en consola es DIFERENTE a cero, continua.
                //Termina cuando el "valor" es igual a cero.
            } while (valor != 0);
        }
    }
}
