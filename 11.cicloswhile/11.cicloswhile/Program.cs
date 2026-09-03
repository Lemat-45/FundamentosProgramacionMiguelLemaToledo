using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CicloDOwhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int contador = 1;
            int acumulador = 0;
            do
            {
                acumulador += contador;
                contador++;
            } while (contador <= 5);
            Console.WriteLine("la suma de los primeros 5 numeros es " + acumulador);
            ..........................................................................................
            bool reinicio = false;
            do
            {
                int contador = 1;
                int numero = 0;
                int multiplo = 0;
                Console.WriteLine("ingrese el numero del que quiere revisar la tabla");
                numero = int.Parse(Console.ReadLine());
                do
                {
                    multiplo = numero * contador;
                    Console.WriteLine(numero + " por " + contador + " es igual a " + multiplo);
                    contador++;
                } while (contador <= 10);
                Console.WriteLine("quiere continuar revisando tablas?, escribe true o false");
                reinicio=bool.Parse(Console.ReadLine());
            } while (reinicio == true);
            */
            int numero = 1;
            int contador2 = 1;
            int divisor = 0;
            do
            {
                do
                {
                    contador2++;
                    if (numero % contador2 == 0)
                    {
                        divisor++;
                    }
                } while (contador2 <= numero);
                contador2 = 0;
                    if (divisor == 2)
                {
                    Console.WriteLine(numero);
                }
                divisor = 0;
                numero++;
            } while (numero <= 100);

        }
    }
}
