using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.CiclosWilde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Byte CantNum;
            Byte CantM0;
            Byte Cantm0;
            Byte CantI0;
            CantM0 = 0;
            Cantm0 = 0;
            CantI0 = 0;
            int Num;
            Console.WriteLine("Ingrese la cantidad de numeros en su lista");
            CantNum = Byte.Parse(Console.ReadLine());
            while (CantNum > 0)
            {
                Console.WriteLine("Ingrese el Siguiente Numero " +  CantNum + " numeros restantes" );
                Num = int.Parse(Console.ReadLine());
                CantNum--;
                if (Num == 0)
                {
                    CantI0++;
                }
                if (Num > 0)
                {
                    CantM0++;
                }
                if (Num< 0)
                {
                    Cantm0++;
                }
            }
            Console.WriteLine("En tu lista hay " + CantI0 + " ceros " + CantM0 + " numeros mayores a cero y " + Cantm0 + " numeros negativos");
        }
    }
}
