using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Un postulante a un empleo, realiza un test de capacitación, se obtuvo la siguiente 
//información: cantidad total de preguntas que se le realizaron y la cantidad de 
//preguntas que contestó correctamente. Se pide confeccionar un programa que 
//ingrese los dos datos por teclado e informe el nivel del mismo según el porcentaje 
//de respuestas correctas que ha obtenido, y sabiendo que:
//	Nivel máximo:	Porcentaje>=90%.
//	Nivel medio:	Porcentaje>=75% y <90%.
//	Nivel regular:	Porcentaje>=50% y <75%.
//	Fuera de nivel:	Porcentaje<50%.

namespace EstructuraCondicionalAnidada5
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPreguntas, totalCorrectas;
            string linea;
            Console.Write("Ingrese la cantidad total de preguntas del examen:");
            linea = Console.ReadLine();
            totalPreguntas = int.Parse(linea);
            Console.Write("Ingrese la cantidad total de preguntas contestadas correctamente:");
            linea = Console.ReadLine();
            totalCorrectas = int.Parse(linea);
            //Se define variable en la misma operacion aritmetica (porcentaje)
            int porcentaje = totalCorrectas * 100 / totalPreguntas;
            if (porcentaje >= 90)
            {
                Console.Write("Nivel máximo");
            }
            else
            {
                if (porcentaje >= 75)
                {
                    Console.Write("Nivel medio");
                }
                else
                {
                    if (porcentaje >= 50)
                    {
                        Console.Write("Nivel regular");
                    }
                    else
                    {
                        Console.Write("Fuera de nivel");
                    }
                }
            }
            //Muy importante cerrar los "corchetes al mismo nivel"
            Console.ReadKey();
        }
    }
}
