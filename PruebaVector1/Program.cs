using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Se desea guardar los sueldos de 5 operarios.
//Según lo conocido deberíamos definir 5 variables si queremos tener en un cierto momento los 5 sueldos almacenados en memoria.
//Empleando un vector solo se requiere definir un único nombre y accedemos a cada elemento por medio del subíndice.

namespace PruebaVector1
{
    class PruebaVector1
    {
        //Para la declaración de un vector le antecedemos al nombre los corchetes abiertos y cerrados:
        //Lo definimos como atributo de la clase ya que lo utilizaremos en los dos métodos.
        private int[] sueldos;

        //En el método de Cargar lo primero que hacemos es crear el vector (en C# los vectores son objetos 
        //por lo que es necesario proceder a su creación mediante el operador new):
        public void Cargar()
        {
            sueldos = new int[5];  //Cuando creamos el vector indicamos entre corchetes la cantidad de elementos que se pueden almacenar posteriormente en el mismo.
            for (int f = 0; f < 5; f++)  //Para cargar cada componente debemos indicar entre corchetes que elemento del vector estamos accediendo
            {
                Console.Write("Ingrese valor de la componente:");
                String linea;
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);  //Cuando f vale cero estamos accediendo a la primer componente del vector (en nuestro caso sería):
            }
        }
        //La estructura de programación que más se adapta para cargar en forma completa las componentes de un vector es un "for", ya que sabemos de antemano la cantidad de valores a cargar.
        //Lo mas común es utilizar una estructura repetitiva "for" para recorrer cada componente del vector.

        //La impresión de las componentes del vector lo hacemos en el otro método:
        public void Imprimir()
        {
            for (int f = 0; f < 5; f++)
            {
                Console.WriteLine(sueldos[f]);
            }
            Console.ReadKey();
        }
        //Por último en este programa creamos un objeto en la Main y llamamos a lo métodos de Cargar e Imprimir el vector:
        static void Main(string[] args)
        {
            PruebaVector1 pv = new PruebaVector1();
            pv.Cargar();
            pv.Imprimir();
        }
    }
}
//Comentario:
//Siempre que queremos acceder a una componente del vector debemos indicar entre corchetes la componente, dicho valor comienza a 
//numerarse en cero y continua hasta un número menos del tamaño del vector, en nuestro caso creamos el vector con 5 elementos:
//sueldos = new int[5];