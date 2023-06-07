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
            //EJERCICIO 1:  
            int[] vector = { 20, 32, -10, 54, 102 };
            int acumulador = 0;
            int sumaTotal = 0;

            Console.Clear();
            for (int i = 0; i < vector.Length; i++)
            {
                acumulador += vector[i];
                sumaTotal = acumulador;
            }

            Console.WriteLine($"La suma del vector es igual a: {sumaTotal}");
            Console.WriteLine("EL PROGRAMA FINALIZÓ");
            Console.ReadKey();
        }
    }
}
