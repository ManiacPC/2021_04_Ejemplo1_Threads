using Ejemplo1_Threads.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejemplo1_Threads
{
    /*
     * Desarrolle una aplicación de consola C# que levante 6 hebras de ejecución.
    Definir a cada Hebra un identificador de ejecución N desde 1 a 6
    En la ejecución de cada una se debe hacer un sleep de N segundos y
    luego mostrar el texto “Hola mundo” seguido del valor de N.

     * */
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<7; i++)
            {
                Thread hilo = new Thread(new ParameterizedThreadStart(Ejecutar)); // no se le pasa el parámetro (i)
                hilo.Name = i.ToString();
                hilo.IsBackground = true;

                hilo.Start(i); // Parámetro de método ejecutar

            }

            Console.ReadKey();
        }

        static void Ejecutar(object o) // 3
        {
            Random random = new Random();
            int randomMiliseconds = random.Next(500, 2000);            

            int tiempoEnSegundos = Convert.ToInt32(o);

            Console.WriteLine(tiempoEnSegundos.ToSeconds(randomMiliseconds).ToString());

            Thread.Sleep(tiempoEnSegundos.ToSeconds(randomMiliseconds)); // Sleep trabaja con milisegundos (3s = 3000ms)
            Console.WriteLine($"Hola desde el hilo {tiempoEnSegundos}");
        }
    }
}
