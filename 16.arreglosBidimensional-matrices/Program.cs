using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.arreglosBidimensional_matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            char[,] simbolos = new char[3, 2];
            for (int i = 0; i<3; i++)
            {
                for ( int j = 0; j< 2; j++)
                {
                    Console.WriteLine($"escriba el caracter para los simbolos");
                    simbolos[i, j] = char.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < simbolos.GetLength(0); i++)
            {
            for (int j = 0; j <simbolos.GetLength(1); j++)
            {
                    Console.WriteLine($"{simbolos[i, j]}");
            }
                Console.WriteLine();
            }
            
            int[,] docientoscien = new int[10,20];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    docientoscien[i, j] = 100;
                }
            }
            for (int i = 0; i < docientoscien.GetLength(0); i++)
            {
                for (int j = 0; j < docientoscien.GetLength(1); j++)
                {
                    Console.Write($"{docientoscien[i, j]}|");
                }
                Console.WriteLine();
            */
            int[,] multipli = new int[2,3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"ingrese el valor numero {i},{j} de la primera lista");
                    multipli[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] divisori = new int[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"ingrese el valor numero {i},{j} de la segunda lista");
                    divisori[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] resultati = new int[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    //Console.WriteLine($"la suma de la posición {i},{j} de ambas listas es {divisori[i, j] + multipli[i,j]}");
                    resultati[i, j] = divisori[i, j] + multipli[i, j];
                }
            }
            for (int i = 0; i < resultati.GetLength(0); i++)
            {
                for (int j = 0; j < resultati.GetLength(1); j++)
                {
                    Console.Write($"|{resultati[i, j]}");
                }
                Console.WriteLine("|");
            }
        }
    }
    }
