using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//- La variable f  toma inicialmente el valor 1.
//- Se controla automáticamente el valor de la condición: como f vale 1 y esto es menor 
//que 50, la condición da verdadero.
//- Como la condición fue verdadera, se ejecutan la/s operación/es.
//- Al finalizar de ejecutarlas, se retorna a la instrucción f++, por lo que la 
//variable f se incrementa en uno. 
//- Se vuelve a controlar (automáticamente) si f es menor o igual a 50. 
//Como ahora su valor es 2, se ejecuta nuevamente el bloque de instrucciones e 
//incrementa nuevamente la variable del for al terminar el mismo.
//- El proceso se repetirá hasta que la variable f sea incrementada al valor 51. 
//En este momento la condición será falsa, y el ciclo se detendrá.

//Como funciona: 
//"f=1" funciona la primera vez que se ejecuta el FOR
//"f <= 50" compara f si es menor o igual al valor 50
//"f++" Es el equivalente al contador = contador + 1
//en cada ciclo, despues de iniciar, solo se ejecuta f <= 50 y f++

namespace EstructuraRepetitivaFor1
{
    class Program
    {
        static void Main(string[] args)
        {
            int f;
            //La explicacion esta arriba en el comentario
            //Lo interesante aqui, es que todo el FOR esta en una sola linea.
            for (f = 1; f <= 50; f++)
            {
                Console.Write(f);
                Console.Write("-");
            }
            Console.ReadKey();
        }
    }
}
