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

            /*
            //EJERCICIO 5

            string[] nombres = { "camila", "roberto", "ricardo", "karina", "rosario", "nahuel", "carlos" };
            string nombreBuscado = "";
            int centinela = 0;

            Console.Clear();

            Console.WriteLine("Ingresar un nombre para buscar en el vector:");
            nombreBuscado = Console.ReadLine();

            //defino una variable centinela, que al estar en 0 indica que no se encontró un nombre en el vector, mientras que
            //si el nombre se encuentra, ésta pasa a valer "1". Se hace la búsqueda mediante un ciclo for

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombres[i] == nombreBuscado)
                {
                    Console.WriteLine($"El nombre '{nombreBuscado}' está en el vector");
                    Console.WriteLine("EL PROGRAMA FINALIZÓ");
                    centinela = 1;
                }
            }

            if (centinela == 0)
            {
                Console.WriteLine($"El nombre '{nombreBuscado}' no se encuentra en el vector");
                Console.WriteLine("EL PROGRAMA FINALIZÓ");
            }

            Console.ReadKey(); */

            //EJERCICIO 7
            int[,] numeros = { { 2, 4, 6 }, { 10, 3, 9 }, { 4, 5, 1 } };
            int sumaFilas, sumaColumnas, sumaTotal;

            sumaFilas = 0;
            sumaColumnas = 0;
            sumaTotal = 0;

            for (int f = 0; f < numeros.GetLength(0); f++)
            {
                sumaFilas += numeros[f, 0];
                for (int c = 0; c < numeros.GetLength(1); c++)
                {
                    sumaColumnas += numeros[0, c];

                    sumaTotal = sumaFilas + sumaColumnas;
                }
            }

            Console.WriteLine(sumaTotal);

            Console.ReadKey();
        }
    }
}
