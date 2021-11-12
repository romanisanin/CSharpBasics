using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers set split by space:");
            string set = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < set.Length; i++)
            {
                string s = "";
                while(set[i].ToString() != " ")
                {
                    s += set[i].ToString();
                    if (i == set.Length-1)
                        break;
                    i++;
                }
                sum += Int32.Parse(s); 
            }
            Console.WriteLine($"The sum is {sum}");
        }
    }
}
//Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом,
//и возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат на экран.
