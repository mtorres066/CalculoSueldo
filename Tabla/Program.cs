using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// Nombre de espacio principal
namespace Tabla
{
    class TablaMultiplicar  // Nombre de la Clase
    {
        //El método CargarValores no tiene parámetros y tiene por objetivo cargar un valor 
        //entero por teclado y llamar al método Calcular para que muestre la tabla de multiplicar 
        //del valor que le pasamos por teclado:
        public void CargarValor()
        {
            int valor;
            string linea;
            do
            {
                Console.Write("Ingrese un valor (-1 para finalizar):");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor != -1)
                {
                    Calcular(valor);
                    //Como vemos al método Calcular lo llamamos por su nombre y entre paréntesis 
                    //le pasamos el dato a enviar (debe ser un valor o variable entera)
                }
            } while (valor != -1);
        }
        
        //El método Calcular recibe un parámetro de tipo entero, luego lo utilizamos 
        //dentro del método para mostrar la tabla de multiplicar de dicho valor, para 
        //esto inicializamos la variable f con el valor que llega en el parámetro. Luego 
        //de cada ejecución del for incrementamos el contador f con el valor de v.
        public void Calcular(int v)
        {
            for (int f = v; f <= v * 10; f = f + v)
            {
                Console.Write(f + "-");
            }
            Console.WriteLine();
        }
        
        //En este problema en la Main solo llamamos al método CargarValor, ya que el método 
        //Calcular luego es llamado por el método CargarValor:
        static void Main(string[] args)
        {
            TablaMultiplicar tm = new TablaMultiplicar();
            tm.CargarValor();
        }
    }
}
