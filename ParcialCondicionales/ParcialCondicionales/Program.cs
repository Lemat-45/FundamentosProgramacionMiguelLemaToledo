using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int respuesta1;
            Console.WriteLine("-----------Selecciona tu signo del Zodiaco---------");
            Console.WriteLine(" 1. Aries                                    2. Tauro");
            Console.WriteLine(" 3. Géminis                                  4. Cáncer");
            Console.WriteLine(" 5. Leo                                      6. Virgo");
            Console.WriteLine(" 7. Libra                                    8. Escorpio");
            Console.WriteLine(" 9. Sagitario                               10. Capricornio");
            Console.WriteLine("11. Acuario                                 12. Piscis");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Escribre el número al lado izquierdo de tu signo zodiacal");
            respuesta1 = int.Parse(Console.ReadLine());
            switch (respuesta1)
            {
                case 1:
                    Console.WriteLine("Aries elegido");
                    break;
                case 2:
                    Console.WriteLine("Tauro elegido");
                    break;
                case 3:                    Console.WriteLine("Géminis elegido");
                    break;
                case 4:
                    Console.WriteLine("Cáncer elegido");
                    break;
                case 5:
                    Console.WriteLine("Leo elegido");
                    break;
                case 6:
                    Console.WriteLine("Virgo elegido");
                    break;
                case 7:
                    Console.WriteLine("Libra elegido");
                    break;
                case 8:                    Console.WriteLine("Escorpio elegido");
                    break;
                case 9:
                    Console.WriteLine("Sagitario elegido");
                    break;
                case 10:                    Console.WriteLine("Capricornio elegido");
                    break;
                case 11:
                    Console.WriteLine("Acuario elegido");
                    break;
                case 12:
                    Console.WriteLine("Piscis elegido");
                    break;
                default:
                    Console.WriteLine("parchaaao que aún no se inventan otros nuevos");
                    break;


            }
            Console.WriteLine("------------Selecciona tu mes de nacimiento------------");
            Console.WriteLine(" 1. Enero                                    2. Febrero");
            Console.WriteLine(" 3. Marzo                                    4. Abril");
            Console.WriteLine(" 5. Mayo                                      6. Junio");
            Console.WriteLine(" 7. Julio                                    8. Agosto");
            Console.WriteLine(" 9. Septiembre                               10. Octubre");
            Console.WriteLine("11. Noviembre                                12. Diciembre");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("Escribre el número al lado izquierdo de tu signo mes de nacimiento");
            int respuesta2;
            respuesta2 = int.Parse(Console.ReadLine());
            switch (respuesta2)
            {
                case 1:
                    Console.WriteLine("Enero elegido");
                    break;
                case 2:
                    Console.WriteLine("Febrero elegido");
                    break;
                case 3:
                    Console.WriteLine("Marzo elegido");
                    break;
                case 4:
                    Console.WriteLine("Abril elegido");
                    break;
                case 5:
                    Console.WriteLine("Mayo elegido");
                    break;
                case 6:
                    Console.WriteLine("Junio elegido");
                    break;
                case 7:
                    Console.WriteLine("Julio elegido");
                    break;
                case 8:
                    Console.WriteLine("Agosto elegido");
                    break;
                case 9:
                    Console.WriteLine("Septiembre elegido");
                    break;
                case 10:
                    Console.WriteLine("Octubre elegido");
                    break;
                case 11:
                    Console.WriteLine("Noviembre elegido");
                    break;
                case 12:
                    Console.WriteLine("Diciembre elegido");
                    break;
                default:
                    Console.WriteLine("... el año sólo tiene 12 meses");
                    break;
            }
            if (respuesta1 == 1 || respuesta1 == 9 || respuesta1 == 5)
            {
                Console.WriteLine("Tu elemento es Fuego");
            }
            if (respuesta1 == 2 || respuesta1 == 10 || respuesta1 == 6)
            {
                Console.WriteLine("tu elemento es la tierra");
            }
            if (respuesta1 ==3 || respuesta1==7 || respuesta1 == 11)
            {
                Console.WriteLine("tu elemento es el aire");
            }
            if (respuesta1 == 4|| respuesta1 == 8||respuesta1 == 12)
            {
                Console.WriteLine("tu elemento es el agua");
            }
        }
    }
}
