using System;
namespace _13_ciclosfor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador=0;
            //ciclo ford
            for (int contador=1; contador<=5; contador++)
            {
                acumulador += contador;
            }
            Console.WriteLine("la suma de los 5 primeros numeros es " + acumulador);
        }
    }
}
