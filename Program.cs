using System;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Int32.Parse(Console.ReadLine());
            string numberType = (number % 2 == 0) ? numberType = "Odd" : numberType = "Even";
            Console.WriteLine($"Hello, you have entered {numberType} number");
        }
    }
}
//Определить, является ли введённое пользователем число чётным.

