using System;
using System.Xml;

namespace _19.programación_modular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mostrarmenu();
            RealizarOperaciones(captureoptions());
        }
        static void mostrarmenu() 
        {
            Console.WriteLine("________________________");
            Console.WriteLine("|Elegir una opción     |");
            Console.WriteLine("|1.Suma                |");
            Console.WriteLine("|2.Resta               |");
            Console.WriteLine("|3.Multiplicación      |");
            Console.WriteLine("|4.división            |");
            Console.WriteLine("|5.Salir               |");
            Console.WriteLine("------------------------");
            
        }
        static void RealizarOperaciones(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"la suma de los numeros ingresados es {suma()}");
                    mostrarmenu();
                    RealizarOperaciones(captureoptions());
                    break;
                case 2:
                    Console.WriteLine($"la resta de los numeros ingresados es {resta()}");
                    mostrarmenu();
                    RealizarOperaciones(captureoptions());
                    break;
                case 3:
                    Console.WriteLine($"la multiplicación de los numeros ingresados es {multi()}");
                    mostrarmenu();
                    RealizarOperaciones(captureoptions());
                    break;
                case 4:
                    Console.WriteLine($"la division de los numeros ingresados es {Divi()}");
                    mostrarmenu();
                    RealizarOperaciones(captureoptions());
                    break;
                case 5:
                    Console.WriteLine("gracias uwu");
                    break;



            }
        }
        static float Divi()
        {
            char respuesta = 'N';
            int division = 1;
            int number = 1;
            do
            {
                respuesta = 'N';
                Console.WriteLine("ingrese el valor a multiplicar");
                number = int.Parse(Console.ReadLine());
                division /=number;
                Console.WriteLine("desea continuar dividiendo el valor anterior? S/N");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 'S');
            return division;
        }
        static int captureoptions()
        {
            return int.Parse(Console.ReadLine());
        }
        static float suma()
        {
            float sumar = 0f;
            float number = 0f;
            char respuesta= 'N';
            do
            {
                respuesta = 'N';
                Console.WriteLine("ingrese el valor a sumar");
                number = float.Parse(Console.ReadLine());
                sumar += number;
                Console.WriteLine("desea continuar sumando al valor anterior? S/N");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 'S');
            return sumar;
        }
        static float multi()
        {
            char respuesta = 'N';
            int multiplicación=1;
            int number = 1;
            do
            {
                respuesta = 'N';
                Console.WriteLine("ingrese el valor a multiplicar");
                number = int.Parse(Console.ReadLine());
                multiplicación *= number;
                Console.WriteLine("desea continuar multiplicando al valor anterior? S/N");
                respuesta = char.Parse(Console.ReadLine());
            } while (respuesta == 'S');
            return multiplicación;
        }
        static float resta()
        {
                int restar = 0;
                int restador = 0;
                Console.WriteLine("ingrese el numero a restar");
                restar=int.Parse(Console.ReadLine()); 
                bool resp = false;
                do
                {
                    Console.WriteLine("ingrese el numero que va restar al valor actual");
                    restador = int.Parse(Console.ReadLine());
                    restar-=restar;
                    Console.WriteLine("desea continuar restando al valor anterior? True/false");
                    resp = bool.Parse(Console.ReadLine());
                } while (resp == true);
                return restar;
        }
    }
}
