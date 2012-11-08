using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Una matriz es una estructura de datos que permite almacenar un CONJUNTO de datos del MISMO tipo.
Con un único nombre se define la matriz y por medio de DOS subíndices hacemos referencia a cada elemento de la misma (componente)
 * Crear una matriz de 3 filas por 5 columnas con elementos de tipo int, cargar sus componentes y luego imprimirlas.*/

namespace Matriz1
{
    class Matriz1
    {
        // Para definir una matriz debemos disponer una coma dentro de los corchetes:
        private int[,] mat;
        // De esta forma el compilador de C# puede diferenciar los vectores de las matrices.

        public void Cargar()
        {
            // Para crear la matriz, es decir hacer la reserva de espacio de todas sus componentes debemos utilizar el 
            //operador new y mediante dos subíndices indicamos la cantidad de filas y columnas que tendrá la matriz:
            mat = new int[3, 5];
            /* Luego debemos pasar a cargar sus 15 componentes (cada fila almacena 5 componentes y tenemos 3 filas)
            Lo más cómodo es utilizar un for anidado, el primer for que incrementa el contador f lo utilizamos para 
            recorrer las filas y el contador interno llamado c lo utilizamos para recorrer las columnas.
            Cada vez que se repite en forma completa el for interno se carga una fila completa, primero se carga la 
            fila cero en forma completa, luego la fila uno y finalmente la fila 2.
            Siempre que accedemos a una posición de la matriz debemos disponer dos subíndices que hagan referencia a la 
            fila y columna mat[f,c]):*/
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write("Ingrese componente:");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f, c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            /* Para imprimir la matriz de forma similar utilizamos dos for para acceder a cada elemento de la matriz: */
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    /* Cada vez que se ejecuta todas las vueltas del for interno tenemos en pantalla una fila completa 
                     * de la matriz, por eso pasamos a ejecutar un salto de línea (con esto logramos que en pantalla 
                     * los datos aparezcan en forma matricial): */
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Matriz1 ma = new Matriz1();
            ma.Cargar();
            ma.Imprimir();
        }
    }
}
