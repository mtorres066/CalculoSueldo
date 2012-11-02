using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* Si tenemos dos vectores de 5 elementos cada uno. En uno se almacenan los nombres de personas en el otro las edades de dichas personas.
Decimos que el vector nombres es paralelo al vector edades si en la componente 0 de cada vector se almacena información relacionada a una persona (Juan - 12 años)
Es decir hay una relación entre cada componente de los dos vectores.
Esta relación la conoce únicamente el programador y se hace para facilitar el desarrollo de algoritmos que procesen los datos almacenados en las estructuras de datos.

 * Desarrollar un programa que permita cargar 5 nombres de personas y sus edades respectivas. Luego de realizar la carga por teclado de todos los datos imprimir los nombres de las personas mayores de edad (mayores o iguales a 18 años) */

namespace PruebaVector10
{
    class PruebaVector10
    {
        //Definimos los dos vectores:
        private string[] nombres;
        private int[] edades;

        public void Cargar()
        {
            //Creamos los dos vectores con 5 elementos cada uno:
            nombres = new string[5];
            edades = new int[5];
            //Mediante un for procedemos a la carga de los elementos de los vectores:
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese nombre:");
                nombres[f] = Console.ReadLine();
                Console.Write("Ingrese edad:");
                string linea;
                linea = Console.ReadLine();
                edades[f] = int.Parse(linea);
            }
        }
        //Para imprimir los nombres de las personas mayores de edad verificamos cada componente del 
        //vector de edades, en caso que sea igual o mayor o 18 procedemos a mostrar el elemento de la 
        //misma posición del otro vector:
        public void MayoresEdad()
        {
            Console.WriteLine("Personas mayores de edad.");
            for (int f = 0; f < nombres.Length; f++) //Podemos utilizar la propiedad Length de cualquiera de los dos vectores, ya que tienen el mismo tamaño.
            {
                if (edades[f] >= 18)
                {
                    Console.WriteLine(nombres[f]);
                }
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaVector10 pv = new PruebaVector10();
            pv.Cargar();
            pv.MayoresEdad();
        }
    }
}
