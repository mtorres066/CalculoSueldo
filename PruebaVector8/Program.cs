using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Se desea almacenar los sueldos de operarios. 
 * Cuando se ejecuta el programa se debe pedir la cantidad de sueldos a ingresar. 
 * Luego crear un vector con dicho tamaño.*/

namespace PruebaVector8
{
    class PruebaVector8
    {
        //La definición del vector no varía:
        private int[] sueldos;

        public void Cargar()
        {
            //Luego para la creación del mismo ingresamos una variable entera y la utilizamos 
            //como subíndice en el momento de la creación del vector:
            Console.Write("Cuantos sueldos cargará:");
            string linea;
            linea = Console.ReadLine();
            int cant = int.Parse(linea);
            sueldos = new int[cant];
            for (int f = 0; f < sueldos.Length; f++)  //Luego las estructuras repetitivas las acotamos accediendo a la propiedad Length del vector:
            {
                Console.Write("Ingrese sueldo:");
                linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < sueldos.Length; f++)
            {
                Console.WriteLine(sueldos[f]);
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaVector8 pv = new PruebaVector8();
            pv.Cargar();
            pv.Imprimir();
        }
    }
}
