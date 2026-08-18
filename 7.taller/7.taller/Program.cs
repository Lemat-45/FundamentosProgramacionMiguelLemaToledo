using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.taller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int Num1 = 0;
            Console.WriteLine("ingrese el primer numero");
            Num1=int.Parse(Console.ReadLine());
            int Num2 = 0;
            Console.WriteLine("ingrese el segundo numero");
            Num2=int.Parse(Console.ReadLine());
            int Num3 = 0;
            Console.WriteLine("ingrese el tercer numero");
            Num3 = int.Parse(Console.ReadLine());
            if (Num1 == Num2)
            {
                        Console.WriteLine("hay numeros ingresados son iguales, elija 3 distintos");
            }
            else
            {
                if (Num2 == Num3)
                {
                    Console.WriteLine("hay numeros ingresados son iguales, elija 3 distintos");
                }
                else
                {
                    if (Num3 == Num1)
                    {
                        Console.WriteLine("hay numeros ingresados son iguales, elija 3 distintos");
                    }
                    else
                    {
                        if (Num1 > Num2 && Num2 > Num3)
                        {
                            Console.WriteLine( $"Mayor:{Num1}, medio:{Num2}, menor:{Num3}");
                        }
                        else
                        {
                            if (Num1 > Num2 && Num2 < Num3) 
                            {
                                if (Num1>Num3)
                                {
                                 
                                    Console.WriteLine($"Mayor:{Num1}, medio:{Num3}, menor:{Num2}");
                                }
                                else
                                {
                                    Console.WriteLine($"Mayor:{Num3}, medio:{Num1}, menor:{Num2}");
                                }
                            }
                            else
                            {
                                if (Num3 > Num2 && Num2 > Num1)
                                {
                                    Console.WriteLine($"Mayor:{Num3}, medio:{Num2}, menor:{Num1}");
                                }
                                else
                                {
                                    if (Num2>Num3 && Num3 >Num1)
                                    {
                                        Console.WriteLine($"Mayor:{Num2}, medio:{Num3}, menor:{Num1}");
                                    }
                                    else
                                    {
                                        if (Num2 > Num3 && Num3 < Num1)
                                        {
                                            Console.WriteLine($"Mayor:{Num2}, medio:{Num1}, menor:{Num3}");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}