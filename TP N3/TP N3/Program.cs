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
            string nombre;

            Console.Clear();

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine($"BIENVENIDO {nombre}");

            Console.ReadKey();
        }
    }
}
