using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.cicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int acumulador = 1;
            while (contador < 5)
            { 
            contador++;
            acumulador = acumulador + contador;
            }
            Console.WriteLine("la suma de los primeros 5 numeros es " + acumulador);
            */
            //crear un algoritmo para que calcule la factorial del numero dado por el usuario
            int contador = 1;
            int acumulador = 1;
            int Numero = 1;
            Console.WriteLine("inserte un numero para sacar su prima");
            Numero = int.Parse(Console.ReadLine());
            while (contador < Numero)
            {
                contador++;
                acumulador = acumulador * contador;
            }
            Console.WriteLine(Numero + " factorial es " + acumulador);
        }
    }
}
