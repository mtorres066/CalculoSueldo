using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaClase1
{
    //Se crea la Clase "Persona"
    //El nombre de la clase debe hacer referencia al concepto (en este caso la hemos llamado Persona):
    class Persona
    {

        //Los atributos los definimos dentro de la clase pero fuera de la main:
        //nombre y edad;
        private string nombre;
        private int edad;
        //Veremos más adelante que un atributo es normalmente definido con la cláusula private (con esto no 
        //permitimos el acceso al atributo desde otras clases)
        //A los atributos se tiene acceso desde cualquier función o método de la clase (salvo la main)

        //Luego de definir los atributos de la clase debemos declarar los métodos o funciones de la clase. 
        //La sintaxis es parecida a la main (sin la cláusula static): "Inicializar(), Imprimir(), EsMayorEdad()"
        public void Inicializar()
        {
            Console.Write("Ingrese el nombre:");
            nombre = Console.ReadLine();
            string linea;
            Console.Write("Ingrese la edad:");
            linea = Console.ReadLine();
            edad = int.Parse(linea);
        }

        public void Imprimir()
        {
            Console.Write("Nombre:");
            Console.WriteLine(nombre);
            Console.Write("Edad:");
            Console.WriteLine(edad);
        }

        public void EsMayorEdad()
        {
            if (edad >= 18)
            {
                Console.Write("Es mayor de edad");
            }
            else
            {
                Console.Write("No es mayor de edad");
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            //Por último en la main declaramos un objeto de la clase Persona y llamamos 
            //a los métodos en un orden adecuado:

            Persona per1 = new Persona(); //Declaración y creación del objeto
            per1.Inicializar(); //Llamada de un método en el orden adecuado segun logica
            per1.Imprimir();
            per1.EsMayorEdad();
        }
    }
}
