using System;

namespace _18.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("benvenuti a il corso di FDLP");
            Mostrarmasaje("Lema");
            MostrarMensaje("Lema", "Miguel");
            Console.ReadKey();
            Console.WriteLine($"Lema tiene {CalcularEdad()}");
            Console.WriteLine($" tiene {CalcularEdad(2026, 2009)}");
        }
        static int CalcularEdad(int HOY, int cuandomeparieron)
        {
            return HOY - cuandomeparieron;
        }
        static void Mostrarmasaje(string nomini)
        {
            Console.WriteLine($"Ciao, {nomini} benvenuti a il corso di FDLP");
        }
        static void MostrarMensaje(string nomini, string apellidos)
        {
            Console.WriteLine($"buenas, {nomini} di {apellidos} esto es FDLP");
        }
    }
}
