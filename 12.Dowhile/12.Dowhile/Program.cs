using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cuenta = 0;
            string nombre;
            int saldo;
            bool continuar = false;
            byte contador = 0;
            int acumulador = 0;
            do
            {
                Console.WriteLine("ingrese su nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese su numero de cuenta");
                cuenta = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese su saldo");
                saldo = int.Parse(Console.ReadLine());
                if (saldo >= 3000000)
                {
                    Console.WriteLine("el usuario " + nombre + " identificado por la cuenta numero " + cuenta + " es apta para crédito gracias a su saldo de " + saldo);
                    acumulador += saldo;
                }
                else
                {
                    Console.WriteLine("el usuario " + nombre + " identificado por la cuenta numero " + cuenta + " no es apta para crédito por su saldo de " + saldo);
                    acumulador += saldo;
                }
                contador++;
                Console.WriteLine("desea continuar (true/false)");
                continuar = bool.Parse(Console.ReadLine());
            } while (continuar == true);
            Console.WriteLine("se consultaron " + contador + " cuentas con un premedio de saldo de " + (acumulador/contador));
        }
    }
}
