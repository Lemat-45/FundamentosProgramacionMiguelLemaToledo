using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.CondicionalesAnidadosDiagramaFlujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //condicionales anidados - diagrama de flujo
            //b. diseñar un algoritmo
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("debe ingresar 3 numeros enteros diferentes");
            Console.WriteLine("ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el tercer numero");
            num3 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            { 
            if (num1>num3)
                {
                    Console.WriteLine("El primer numero es mayor");
                }
                else
                {
                    Console.WriteLine("El tercer numero es mayor");
                }
            }
            else
            {
                if (num2 > num3)
                {
                    Console.WriteLine("el segundo es el mayor");
                }
                else
                {
                    Console.WriteLine("el tercero es el mayor");

                }
            }
        }
    }
}
