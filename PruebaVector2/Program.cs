using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Definir un vector de 5 componentes de tipo float que representen las alturas de 5 personas.
//Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas.

namespace PruebaVector2
{
    class PruebaVector2
    {
        private float[] alturas;  //Definimos como atributo un vector donde almacenaremos las alturas:
        private float promedio;

        public void Cargar()
        {
            alturas = new float[5];  //En la carga creamos el vector indicando que reserve espacio para 5 componentes:
            for (int f = 0; f < 5; f++)  //Procedemos seguidamente a cargar todos sus elementos:
            {
                Console.Write("Ingrese la altura de la persona:");
                string linea = Console.ReadLine();
                alturas[f] = float.Parse(linea);
            }
        }
        //En otro método procedemos a sumar todas sus componentes y obtener el promedio. El promedio lo almacenamos en un 
        //atributo de la clase ya que lo necesitamos en otro método:
        public void CalcularPromedio()
        {
            float suma;
            suma = 0;
            for (int f = 0; f < 5; f++)
            {
                suma = suma + alturas[f];
            }
            promedio = suma / 5;
            Console.WriteLine("Promedio de alturas:" + promedio);
        }
        //Por último en un tercer método comparamos cada componente del vector con el atributo promedio, si el valor almacenado 
        //supera al promedio incrementamos un contador en caso que sea menor al promedio incrementamos otro contador:
        public void MayoresMenores()
        {
            int may, men;
            may = 0;
            men = 0;
            for (int f = 0; f < 5; f++)
            {
                if (alturas[f] > promedio)
                {
                    may++;
                }
                else
                {
                    if (alturas[f] < promedio)
                    {
                        men++;
                    }
                }
            }
            Console.WriteLine("Cantidad de personas mayores al promedio:" + may);
            Console.WriteLine("Cantidad de personas menores al promedio:" + men);
            Console.ReadKey();
        }

        static void Main()
        {
            PruebaVector2 pv2 = new PruebaVector2();
            pv2.Cargar();
            pv2.CalcularPromedio();
            pv2.MayoresMenores();
        }
    }
}
//Importante
/*En este problema podemos observar una ventaja de tener almacenadas todas las alturas de las personas. Si no conociéramos los 
 * vectores tenemos que cargar otra vez las alturas por teclado para compararlas con el promedio.
Mientras el programa está en ejecución tenemos el vector alturas a nuestra disposición. 
 * Es importante tener en cuenta que cuando finaliza la ejecución del programa se pierde el contenido de todas las variables (simples y vectores) */
