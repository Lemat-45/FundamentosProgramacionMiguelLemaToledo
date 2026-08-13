using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Condicionales_multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int respuesta = 0
            Console.WriteLine("----------------------------menú---------------------------");
            Console.WriteLine("1. opción 1                                     2. opción 2");
            Console.WriteLine("3. opción 3                                     4. opción 4");
            Console.WriteLine("5. opción 5                                      ");
            respuesta = int.Parse(Console.ReadLine());
            switch (respuesta) 
            {
                case 1:
                    Console.WriteLine("eligió opción 1");
                    break;
                case 2:
                    Console.WriteLine("eligió opción 2");
                    break;
                case 3:
                    Console.WriteLine("eligió opción 3");
                    break;
                case 4:
                    Console.WriteLine("eligió opción 4");
                    break;
                case 5:
                    Console.WriteLine("eligió opción 5");
                    break;
                default:
                    Console.WriteLine("elija una opción del tablero o deje que un mayor de edad le ayude (bobo)");
                    break;
            }
        }
    }
}
