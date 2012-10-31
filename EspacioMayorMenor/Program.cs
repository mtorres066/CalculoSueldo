using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Confeccionar una clase que permita ingresar tres valores por teclado. Luego mostrar el mayor y el menor
namespace EspacioMayorMenor
{
    class MayorMenor
    {

        public void cargarValores()
        {
            string linea;
            Console.Write("Ingrese primer valor:");
            linea = Console.ReadLine();
            int valor1 = int.Parse(linea);
            Console.Write("Ingrese segundo valor:");
            linea = Console.ReadLine();
            int valor2 = int.Parse(linea);
            Console.Write("Ingrese tercer valor:");
            linea = Console.ReadLine();
            int valor3 = int.Parse(linea);
            int mayor, menor;
            mayor = CalcularMayor(valor1, valor2, valor3);  //La llamada al método calcularMayor lo hacemos desde dentro del método CargarCalores
            menor = CalcularMenor(valor1, valor2, valor3);
            //Debemos asignar a una variable el valor devuelto por el método CalcularMayor. Luego el contenido de la variable mayor lo mostramos:
            Console.WriteLine("El valor mayor de los tres es:" + mayor);
            Console.WriteLine("El valor menor de los tres es:" + menor);
        }
        //Lo primero que podemos observar que el método retorna un entero y recibe tres parámetros:
        //Dentro del método verificamos cual de los tres parámetros almacena un valor mayor, a este 
        //valor lo almacenamos en una variable local llamada "m", al valor almacenado en esta variable 
        //lo retornamos al final con un return.
        public int CalcularMayor(int v1, int v2, int v3)
        {
            int m;
            if (v1 > v2 && v1 > v3)
            {
                m = v1;
            }
            else
            {
                if (v2 > v3)
                {
                    m = v2;
                }
                else
                {
                    m = v3;
                }
            }
            return m;
        }

        public int CalcularMenor(int v1, int v2, int v3)
        {
            int m;
            if (v1 < v2 && v1 < v3)
            {
                m = v1;
            }
            else
            {
                if (v2 < v3)
                {
                    m = v2;
                }
                else
                {
                    m = v3;
                }
            }
            return m;
        }

        static void Main(string[] args)
        {
            MayorMenor mm = new MayorMenor();
            mm.cargarValores();
            Console.ReadKey();
        }
    }
}
