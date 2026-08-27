using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CiclosWhile1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NUM;
            NUM = 0;
            int SUM;
            SUM = 0;
            while (NUM >= 0)
            {
                Console.WriteLine("ingrese un número positivo para sumarlo, ingrese u numero negativo para cerrar la lista");
                NUM = int.Parse(Console.ReadLine());
                SUM = SUM + NUM;
            }
            Console.WriteLine("La suma de tus numeros positivos es " + SUM);
        }
    }
}
