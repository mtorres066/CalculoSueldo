using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//En caso que el contador cant tenga un valor distinto a 0 el promedio se obtiene dividiendo el 
//acumulador suma por el contador cant que tiene la cantidad de valores ingresados antes de introducir el 0.

//El contador cant DEBE inicializarse antes del ciclo, lo mismo que el acumulador suma. 
//El promedio se calcula siempre y cuando el contador cant sea distinto a 0.

//Se usa un DO-While y un IF


namespace EstructuraRepetitivaDoWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma, cant, valor, promedio;
            string linea;
            suma = 0;
            cant = 0;
           
            //Captura valor desde consola (por el usuario)
            do
            {
                Console.Write("Ingrese un valor (0 para finalizar):");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                //Revisa si el usuario capturó algun valor
                if (valor != 0)
                {
                    suma = suma + valor;
                    cant++;
                }
            } 
            //Termina si el usuario capturó cero o nada
            while (valor != 0);
            

            if (cant != 0)
            {
                promedio = suma / cant;
                Console.Write("El promedio de los valores ingresados es:");
                Console.Write(promedio);
            }
            else
                //El usuario no registró captura
            {
                Console.Write("No se ingresaron valores.");
            }
            //Muestra Resultado
            Console.ReadLine();
        }
    }
}
