using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[15];
            int mayor = 0;
            int menor = 0;
            for (int i = 0; i < 15; i++)
            {

                Console.WriteLine("ingrese su numero deseado para la posición " + (i + 1));
                numeros[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    menor = numeros[i];
                    mayor = numeros[i];
                }

                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
                else if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
            }
            Console.WriteLine("El numero mayor es " + mayor + " y el menor es " + menor);
        }
    }
}
