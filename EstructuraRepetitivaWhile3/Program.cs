using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//En este problema, a semejanza de los anteriores, llevamos un CONTADOR llamado x que nos sirve para contar las vueltas que debe repetir el while.
//También aparece el concepto de ACUMULADOR (un acumulador es un tipo especial de variable que se incrementa o decrementa con valores variables durante la ejecución del programa)
//Hemos dado el nombre de suma a nuestro acumulador. Cada ciclo que se repita la estructura repetitiva, la variable suma se incrementa con el contenido ingresado en la variable valor.
//La prueba del diagrama se realiza dándole valores a las variables:
//valor		suma		x 	   promedio
//                 0		0
//(Antes de entrar a la estructura repetitiva estos son los valores).
// 5		 5		1
//16		21		2
// 7		28		3
//10		38		4
// 2		40		5
//20		60		6
// 5		65		7
// 5		70		8
//10		80		9
// 2		82	       10
// 8		90	       11
//                              9

//Este es un seguimiento del diagrama planteado. Los números que toma la variable valor dependerá de qué cifras cargue el operador durante la ejecución del programa.
//El promedio se calcula al salir de la estructura repetitiva (es decir primero sumamos los 10 valores ingresados y luego los dividimos por 10)
//Hay que tener en cuenta que cuando en la variable valor se carga el primer valor (en este ejemplo 5) al cargarse el segundo valor (16) el valor anterior 5 se pierde, por ello la necesidad de ir almacenando en la variable suma los valores ingresados.

namespace EstructuraRepetitivaWhile3
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, suma, valor, promedio;
            string linea;
            x = 1;
            suma = 0;
            //Se comprara X si es igual o mayor a 10 (valor fijo)
            while (x <= 10)
            {
                Console.Write("Ingrese un valor:");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                suma = suma + valor;
                x = x + 1;
            }
            // x es mayor que 10, saca el promedio
            promedio = suma / 10;
            Console.Write("La suma de los 10 valores es:");
            Console.WriteLine(suma);
            Console.Write("El promedio es:");
            Console.Write(promedio);
            Console.ReadKey();

        }
    }
}
