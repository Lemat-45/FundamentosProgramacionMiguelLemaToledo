using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _20.programacionmodular
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
           voaloid(pedirguord());
            
        }
        static char[] pedirguord()
        {
            Console.WriteLine("inserta tu fokin palabra sin tildes ome bobo");
            string fokinpalabra = Console.ReadLine();
            char[] charguord = fokinpalabra.ToCharArray();
            return charguord;
        }
        static void voaloid(char[] charguord)
        {
            int vocales =0;
            int consonantes = 0;
            for (int i = 0; i < charguord.Length; i++)
            {
                if (charguord[i] == 'a' || charguord[i] == 'e' || charguord[i] == 'i' || charguord[i] == 'o' || charguord[i] == 'u')
                {
                    vocales++;
                }
                else
                {
                    consonantes++;
                }
            }
            Console.WriteLine($"t-tienes {vocales} vocales en t-tu palabra y {consonantes} consonantes e-en tu palabra n-no es como que me importe hmph!");
            int sicseben = 67;
            Console.WriteLine(sicseben);
        }
    }
}
