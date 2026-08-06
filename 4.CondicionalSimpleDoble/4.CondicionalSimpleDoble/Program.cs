using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CondicionalSimpleDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. crea  un algoritmo que lea la edad de un usuario, si el usuario es mayor e 18, se debe mostrar este mensaje "
            /*  byte edad = 0;
              Console.WriteLine("Ingrese su edad");
              edad = Convert.ToByte(Console.ReadLine());
              if (edad >= 18)
              {
                  Console.WriteLine("Bienvenido a mi sitio web");
              }
              }*/
            //2. crear un algoritmo que permita ingresar el nombre y el sueldo de una persona si el sueldo supera los 3000 pesos mostrar el mensaje en pantala con el nombre de la persona indicando que debe abonar impuestos
            /*string nombre = ("ingresar su nombre");
            Console.WriteLine("ingresar su nombre");
            float sueldo = 0f;
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese su sueldo");
            sueldo = Convert.ToSingle(Console.ReadLine());
            if (sueldo > 3000)
            {
                Console.WriteLine((nombre) + " debes pagar impuestos! ni el joker se mete con el IRS, debes pagar" + sueldo * 0.19);
            }
            */
            //3. crear un algoritmo que lea la edad de un usuario si el usuario es mayor de 18 se debe  dar el mensaje "bienvenido a mi sitio web" de lo contrario "no es apto para el contenido de este sitio web"
            byte edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine("vayase culicagado");
            }
        }
    }
}
