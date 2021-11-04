using System;
using static System.Console;


namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[4, 4];



            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = count++;
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Write($"{array[i, j]} ");
                    }
                    else
                    {
                        Write($"x ");
                    }

                }
                Console.WriteLine();
            }


        }
    }
}
//1. Написать программу, выводящую элементы двумерного массива по диагонали.
