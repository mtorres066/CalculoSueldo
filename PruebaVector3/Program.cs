using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*Una empresa tiene dos turnos (mañana y tarde) en los que trabajan 8 empleados (4 por la mañana y 4 por la tarde)
Confeccionar un programa que permita almacenar los sueldos de los empleados agrupados por turno.
Imprimir los gastos en sueldos de cada turno.*/

namespace PruebaVector3
{
    class PruebaVector3
    {
        //Definimos dos atributos de tipo vector donde almacenaremos los sueldos de los empleados de cada turno:
        private float[] turnoMan;
        private float[] turnoTar;

        public void Cargar()
        {
            string linea;
            //Creamos los vectores con cuatro elementos cada uno:
            turnoMan = new float[4];
            turnoTar = new float[4];
            //Mediante dos estructuras repetitivas procedemos a cargar cada vector:
            Console.WriteLine("Sueldos de empleados del turno de la mañana.");
            for (int f = 0; f < 4; f++)
            {
                Console.Write("Ingrese sueldo:");
                linea = Console.ReadLine();
                turnoMan[f] = float.Parse(linea);
            }
            Console.WriteLine("Sueldos de empleados del turno de la tarde.");
            for (int f = 0; f < 4; f++)
            {
                Console.Write("Ingrese sueldo:");
                linea = Console.ReadLine();
                turnoTar[f] = float.Parse(linea);
            }
        }
        //En otro método procedemos a sumar las componentes de cada vector y mostrar dichos acumuladores:
        public void CalcularGastos()
        {
            float man = 0;
            float tar = 0;
            for (int f = 0; f < 4; f++)
            {
                man = man + turnoMan[f];
                tar = tar + turnoTar[f];
            }
            Console.WriteLine("Total de gastos del turno de la mañana:" + man);
            Console.WriteLine("Total de gastos del turno de la tarde:" + tar);
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            PruebaVector3 pv = new PruebaVector3();
            pv.Cargar();
            pv.CalcularGastos();
        }
    }
}
