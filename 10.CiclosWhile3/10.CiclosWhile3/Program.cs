using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CiclosWhile3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random NumeroPC = new Random();
            int Numero = NumeroPC.Next(1,101);
            int NumeroH = -1;
            Console.WriteLine("Adivina el numero que tengo en mi procesador :3");
            while (NumeroH != Numero)
            {
                NumeroH = int.Parse(Console.ReadLine());
                if (NumeroH > Numero)
                {
                    Console.WriteLine("muy alto! OwO");
                }
                if (NumeroH < Numero)
                {
                    Console.WriteLine("muy Bajo! UnU");
                }
                
            }
                Console.WriteLine("Ese era! :O eres mago");
        }
    }
}
