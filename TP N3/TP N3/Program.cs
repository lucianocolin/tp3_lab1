using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_N3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //EJERCICIO 1:  
            int[] vector = { 20, 32, -10, 54, 102 };
            int acumulador = 0;
            int sumaTotal = 0;

            Console.Clear();

            //se utiliza el acumulador para realizar la suma de cada número del vector seleccionado. A su vez el total de esta
            //suma, se le asignará a la variable sumaTotal

            for (int i = 0; i < vector.Length; i++)
            {
                acumulador += vector[i];
                sumaTotal = acumulador;
            }

            Console.WriteLine($"La suma del vector es igual a: {sumaTotal}");
            Console.WriteLine("EL PUNTO 1 FINALIZÓ");

            Console.ReadKey(); */

            /*

            //EJERCICIO 3:

            int[] notas = { 10, 6, 8, 9, 7, 10 };
            int acumulador = 0;
            double promedio = 0;

            Console.Clear();

            //en la variable acumulador se realiza la suma de todas las notas del alumno, para luego ser dividida en la
            //variable promedio, junto con la cantidad de elementos del vector notas.

            for (int i = 0; i < notas.Length; i++)
            {
                acumulador += notas[i];
                promedio = acumulador / notas.Length;
            }

            Console.WriteLine($"El promedio del alumno es: {promedio}");
            Console.WriteLine("EL PUNTO 3 FINALIZÓ");

            Console.ReadKey(); */

            //EJERCICIO 5

            string[] nombres = { "camila", "roberto", "ricardo", "karina", "rosario", "nahuel", "carlos" };
            string nombreBuscado = "";

            Console.Clear();

            Console.WriteLine("Ingresar un nombre para buscar en el vector:");
            nombreBuscado = Console.ReadLine();

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombreBuscado === nombres[i])
                {
                    Console.WriteLine("El nombre buscado está en el vector");
                }
                else
                {
                    Console.WriteLine("El nombre buscado no se encuentra en el vector");
                }
            }

            Console.ReadKey();
        }
    }
}
