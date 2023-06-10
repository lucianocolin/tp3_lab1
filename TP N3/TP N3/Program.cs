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

            /*
            //EJERCICIO 7
            int[,] numeros = { { 2, 4, 6 }, { 10, 3, 9 }, { 4, 5, 1 } };
            int sumaFilas, sumaColumnas, sumaTotal;

            Console.Clear();

            sumaFilas = 0;
            sumaColumnas = 0;
            sumaTotal = 0;

            //declaro una variable que, con cada iteración del ciclo for, va sumando los elementos de las Filas
            //de mi vector. Luego otra que haga lo mismo con las Columnas, y por último una que realice la suma de ambas.

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
            Console.WriteLine("EL PROGRAMA FINALIZÓ");

            Console.ReadKey(); */

            /*
            //EJERCICIO 9
            int[,] matrizA = { 
                { 14, 42, 32 }, 
                { 22, 35, 48 }, 
                { 39, 60, 97 } };

            int[,] matrizB = { 
                { 32, 65, 19 }, 
                { 12, 48, 72 }, 
                { 23, 56, 80 } };

            int[,] sumaMatrices = new int[3, 3];

            //realizo dos ciclos for anidados, uno para las filas y otro para las columnas. En la variable sumaMatrices
            //inicializo la suma de la matriz A y la matriz B, para luego enseñarla por consola

            Console.Clear();

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    sumaMatrices[f,c] = matrizA[f, c] + matrizB[f, c];
                    Console.WriteLine(sumaMatrices[f,c]);
                }
            }

            Console.WriteLine("--------------------");
            Console.WriteLine("EL PROGRAMA FINALIZÓ");


            Console.ReadKey(); */

            //EJERCICIO 11
            string[,] Frutas = { 
                {"manzana", "pera", "uva"}, 
                {"naranja", "pera", "kiwi"}, 
                {"mango", "pera", "limon"} };
            string nombreABuscar;
            int centinela = 0;

            Console.Clear();

            Console.WriteLine("Ingrese un nombre para buscar dentro de la matriz:");
            nombreABuscar = Console.ReadLine();

            for (int f = 0; f < Frutas.GetLength(0); f++)
            {
                for (int c = 0; c < Frutas.GetLength(1); c++)
                {
                    if (Frutas[f, c] == nombreABuscar)
                    {
                        Console.WriteLine($"El nombre '{nombreABuscar}' se encuentra en la matriz");
                        centinela = 1;
                    }
                }
            }

            if (centinela == 0)
            {   
                Console.WriteLine($"El nombre '{nombreABuscar}' no se encuentra en la matriz");
            }
            
            Console.ReadKey();
        }
    }
}
